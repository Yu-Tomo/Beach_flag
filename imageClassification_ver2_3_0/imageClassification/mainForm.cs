using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageClassification
{
    public partial class mainForm : Form
    {
        Select_dir_form sdf;                                            //画像保存用フォーム
                                                                        //ファイルオープン用クラス
        public mainForm()
        {
            InitializeComponent();
            sdf = new Select_dir_form();
            sdf.MainForm = this;
            formInit();
        }
        //
        private string absolute_path;                                   //directoryの絶対パス格納変数
        private long AllimgFileNum = 0;                                 //画像が何枚あるかを格納する変数
        private imgCont imgcont;                                        //画像コントロールオブジェクト
        private bool MouseFlg = false;                                  //マウスホイールイベントがスタックしないようにするフラグ
        private bool classContinueFlg = false;                         //分類中かどうか確認するフラグ
        //
        private bool made_mouse_event_flg = false;                      //マウスホイールイベントを設置したか確かめるフラグ
        //
        private string savePath;                                        //未検知保存先パス
        bool imgInputFlg = false;                                         //画像を入力したフラグ
                                                                          //
        private string[] childFolderNames = new string[10];             //フラグの名前を入れておくバッファ


        private string[] all_extension = { "*.jpg", "*.png", "*.bmp","*.jpeg" };                         //扱う拡張子

        private string nowText;
        //get set
        public string SavePath { get { return savePath; } set { savePath = value; } }
        public string[] ChildFolderNames { get { return childFolderNames; } set { childFolderNames = value; } }
        //

        private void formInit()                                         //デザインに関係する初期値を設定
        {
            classContinueFlg = false;
            pause_b.Enabled = false;
            class_b.Enabled = true;
            flgGroupBox.Enabled = false;
            save_b.Enabled = false;
        }



        //開くボタンを押したとき
        private void fileBottun_Click(object sender, EventArgs e)
        {
            FolderOpen folderOpen= new FolderOpen();
            Folder_func(folderOpen.FolderOpenDia(this));
        }
        private void file_DragDrop(object sender, DragEventArgs e)
        {
            string[] str;

            str = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (str.Length > 1) MessageBox.Show("複数フォルダー選択には対応していません。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Folder_func(str[0]);

        }
        private void Folder_func(string getPath)                                              //開くとドラッグアンドドロップの同じ処理を別関数にする
        {
            absolute_path = getPath;                                                        //開きたいディレクトリのpathを受け取る
            if (File.Exists(getPath))
            {
                MessageBox.Show("フォルダーを選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                absolute_path = null;
            }
            if (absolute_path != null)
            {
                //ファイルを選ばず終えたときここで終了

                absolute_path += Path.DirectorySeparatorChar;                                   //環境によって異なるパス区切りを入れる directry + \
                this.filename.Text = absolute_path;


                flgGroupBox.Enabled = true;
                save_b.Enabled = true;

                imgInputFlg = input_img_data_func();                                               //画像がないときfalse

                if (imgInputFlg == true)
                {

                    radio_button_check(imgcont.Img_set[imgcont.NowFileNum].Flg);                     //ラジオボタンに表示する


                    TextView textView = new TextView();
                    textView.text_disp(disp_file_name, imgcont.Img_set[imgcont.NowFileNum].Name);       //選択したファイルのパスをテキストボックスに入れる

                    //マウスホイールのイベントを発生できるようにする
                    if (made_mouse_event_flg == false)                                              //重複しないように一度生成のみ生成
                    {
                        this.MouseWheel                                                              //ピクチャーボックスのマウスホイールイベント
                       += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseWheel);
                        made_mouse_event_flg = true;
                    }
                }
            }
        }
        private bool input_img_data_func()
        {
           FolderOpen folderOpen = new FolderOpen();
            AllimgFileNum = 0;

            foreach (string str in all_extension)
            {
                AllimgFileNum += folderOpen.Check_fileNum(absolute_path, str);            //ファイルの数を確認する
            }
            if (AllimgFileNum == 0)
            {
                MessageBox.Show("このフォルダーには画像がありません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

                close_func();
                return false;
            }
            else if (AllimgFileNum < 0) 
            {
                MessageBox.Show("分類元ファイルが指定されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                close_func();
                return false;
            }
            imgcont = new imgCont(absolute_path, AllimgFileNum);     //画像ファイル用のデータ領域を生成する
            imgcont.input_name(absolute_path, AllimgFileNum, all_extension);        //画像ファイルの名前をデータに入れる
            imgcont.disp_img(imgBox, absolute_path);
            return true;
        }


        private void radio_button_get(int flg)                                              //ラジオボタンの情報を抜き取る
        {
            foreach (RadioButton rb in flgGroupBox.Controls.OfType<RadioButton>())            //グループボッスの中からラジオボタンだけ抜き出す
            {
                if (rb.Checked)                                                             //フラグとラジオボタンのtextが等しいとき
                {
                    imgcont.Img_set[imgcont.NowFileNum].Flg = int.Parse(rb.Text);            //ラジオボタンにチェックをつける
                }
            }
        }
        private void radio_button_check(int flg)                                           //グループボッスの中からラジオボタンだけ抜き出す
        {
           foreach(RadioButton rb in flgGroupBox.Controls.OfType<RadioButton>())
            {
                if (rb.Text.Equals(flg.ToString()))                                        //フラグとラジオボタンのtextが等しいとき(ラジオボタンのテキストを見えないように配置している)
                {
                    rb.Checked = true;                                                      //ラジオボタンにチェックをつける
                }
            }
        }
        private void continuity_radio(long diff, long after)
        {
            if (diff > 0)                                                                  //画像を進めたときに分類を引きずる
            {
                long before = after - diff;
                for (long i = 0; i < diff; i++)
                {
                    if ((before > AllimgFileNum)) return; 
                    imgcont.Img_set[before + 1].Flg = imgcont.Img_set[before].Flg;
                    before++;
                }
            }
            /*
             else　                                                                       //画像を戻したときに分類をひきずる
             {
                 diff *= (-1);
                 long before = after + diff;
                 for(long i = 0;i<diff;i++)
                 {
                     imgcont.Img_set[before - (i+1)].Flg = imgcont.Img_set[before].Flg;
                 }
             }
            */
        }
        //フォームResizeイベントハンドラ
        private void mainForm_Resize(object sender, EventArgs e)
        {
            if (imgInputFlg == false) return;
            imgcont.disp_img(imgBox, absolute_path);
        }
        //マウスホイールイベントハンドラ
        private void pictureBox_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (imgInputFlg == false) return;
            if (MouseFlg == true)
            {
                return;
            }
            else
            {
                MouseFlg = true;                                                //マウスホイールイベント処理中

                long ang = (e.Delta * -1) / 120;

                if (e.Delta < 0)                                                //上スクロールの時                                     
                {
                    if (imgcont.NowFileNum < AllimgFileNum - 1)
                    {

                        if ((imgcont.NowFileNum + ang) < AllimgFileNum - 1)       //画像を前に戻す
                        {
                            imgcont.NowFileNum += ang;
                        }
                        else
                        {
                            imgcont.NowFileNum++;
                            ang = +1;
                        }

                    }
                }
                else                                                            //下スクロールの時
                {
                    if (imgcont.NowFileNum > 0)
                    {

                        if ((imgcont.NowFileNum + ang) > 0)                //画像を次に進む
                        {
                            imgcont.NowFileNum += ang;
                        }
                        else
                        {
                            imgcont.NowFileNum--;
                            ang = -1;
                        }
                    }

                }
                //前回のラジオボタンの値を引きずるモード
                if (classContinueFlg == true)
                {
                    continuity_radio(ang, imgcont.NowFileNum);
                }
                //
                imgcont.disp_img(imgBox, absolute_path);

                TextView textView = new TextView();
                textView.text_disp(disp_file_name, imgcont.Img_set[imgcont.NowFileNum].Name);   //ファイル名を描画する
                radio_button_check(imgcont.Img_set[imgcont.NowFileNum].Flg);                    //ラジオボタンのチェックを描画する

                MouseFlg = false;                                                               //次のマウスホイールイベントを許可する
            }

        }
        private void pause_b_Click(object sender, EventArgs e)                      //個別に分類を選択できるモード
        {
            mode_Individual();
        }
        private void mode_Individual()                                              //個別分類モード処理部
        {
            classContinueFlg = false;                                               //モードフラグ
            pause_b.Enabled = false;
            class_b.Enabled = true;

            TextView text = new TextView();
            text.text_disp(statusInfo, "--個別分類モード動作中--");
            text.text_disp(statusInfo, "画像を一枚一枚個別に分類できるモードです！");
        }
        private void class_b_Click(object sender, EventArgs e)                      //前回のボタンの結果を次に引きずるモード
        {
            mode_Multiple();
        }
        private void mode_Multiple()                                              //個別分類モード処理部
        {
            classContinueFlg = true;
            pause_b.Enabled = true;
            class_b.Enabled = false;

            TextView text = new TextView();
            text.text_disp(statusInfo, "--連続分類モード動作中--");
            text.text_disp(statusInfo, "スクロールすると次の画像も同じ分類になります！");
        }
        private void save_b_Click(object sender, EventArgs e)                       //保存用windowを表示する
        {
            foreach (TextBox tx in flgGroupBox.Controls.OfType<TextBox>())
            {
                string name = tx.Name;
                int flg = int.Parse(Regex.Replace(name, @"[^0-9]", ""));            //textBox(0～9)の数字を抜き出す
                childFolderNames[flg] = tx.Text+ Path.DirectorySeparatorChar; 
            }

            sdf.DirPath = absolute_path;                                            //select_dir_formに画像を選ぶときに使ったパスを送る
            sdf.ShowDialog();                                                       //select_dir_formを開く(保存先のパスを受け取る)

            TextView text = new TextView();
            text.text_disp(statusInfo, "--保存先--");
            text.text_disp(statusInfo, savePath);
            

            img_Save img_save = new img_Save();


            for (long i = 0; i < AllimgFileNum; i++)
            {
                if (imgcont.Img_set[i].Flg != 0)                                                                //分類しないを除去
                { 
                    img_save.making_folder(savePath, childFolderNames[imgcont.Img_set[i].Flg]);                     //ディレクトリがないとき作成する
                    img_save.imgSave(imgcont.Img_set[i], absolute_path, savePath, childFolderNames[imgcont.Img_set[i].Flg]);
                    img_save.write_text(imgcont.Img_set[i], savePath, childFolderNames[imgcont.Img_set[i].Flg]);
                }
            }
             
            text.text_disp(statusInfo, "--保存完了！--");

            input_img_data_func();
        }
        private void cancel_b_Click(object sender, EventArgs e)
        {
            close_func();
        }
        private void close_func()
        {
            imgBox.Image = null;                                                    //表示画像を削除
            TextView text = new TextView();
            text.text_disp(filename, null);                                         //ファイル名削除
            text.text_disp(disp_file_name, "-------------------------------");                                         //ファイル名削除
            flgGroupBox.Enabled = false;                                              //ラジオボタン禁止
            statusInfo.Text = null;
            imgcont = null;
            imgInputFlg = false;
            save_b.Enabled = false;

        }

        private void img_reset_Click(object sender, EventArgs e)                    //画像の更新
        {
            if (imgInputFlg == false) return;
            input_img_data_func();
        }

        private void file_DragEnter(object sender, DragEventArgs e)                 //ドラッグを許可
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void textEmpty_check(TextBox text,string str)
        {
            if(text.Text == "")
            {
                MessageBox.Show("文字を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text.Text = str;
            }
          
        }
       
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            textEmpty_check(tx, nowText);
        }

        private void textBoxEnter(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            nowText = tx.Text;
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            //ラジオボタンのチェックを確認する
            radio_button_get(imgcont.Img_set[imgcont.NowFileNum].Flg);
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0)
            {
                radioButton0.Checked = true;
                imgcont.Img_set[imgcont.NowFileNum].Flg = 0;
            }
            else if (e.KeyCode == Keys.D1)
            {
                radioButton1.Checked = true;
                imgcont.Img_set[imgcont.NowFileNum].Flg = 1;
            }
            else if (e.KeyCode == Keys.D2)
            {
                radioButton2.Checked = true;
                imgcont.Img_set[imgcont.NowFileNum].Flg = 2;
            }
            else if (e.KeyCode == Keys.D3)
            {
                radioButton3.Checked = true;
                imgcont.Img_set[imgcont.NowFileNum].Flg = 3;
            }
            else if (e.KeyCode == Keys.D4)
            {
                radioButton4.Checked = true;
                imgcont.Img_set[imgcont.NowFileNum].Flg = 4;
            }
            else if (e.KeyCode == Keys.D5)
            {
                radioButton5.Checked = true;
                imgcont.Img_set[imgcont.NowFileNum].Flg = 5;
            }
            else if (e.KeyCode == Keys.D6)
            {
                radioButton6.Checked = true;
                imgcont.Img_set[imgcont.NowFileNum].Flg = 6;
            }
            else if (e.KeyCode == Keys.D7)
            {
                radioButton7.Checked = true;
                imgcont.Img_set[imgcont.NowFileNum].Flg = 7;
            }
            else if (e.KeyCode == Keys.D8)
            {
                radioButton8.Checked = true;
                imgcont.Img_set[imgcont.NowFileNum].Flg = 8;
            }
            else if (e.KeyCode == Keys.D9)
            {
                radioButton9.Checked = true;
                imgcont.Img_set[imgcont.NowFileNum].Flg = 9;
            }
            else if (e.KeyCode == Keys.L)                           //画像を次に進める
            {
                if (imgcont.NowFileNum < AllimgFileNum - 1)
                {
                    imgcont.NowFileNum++;
                    //前回のラジオボタンの値を引きずるモード
                    if (classContinueFlg == true)
                    {
                        continuity_radio(imgcont.NowFileNum - 1, imgcont.NowFileNum);
                    }
                    //
                    imgcont.disp_img(imgBox, absolute_path);
                }
                TextView textView = new TextView();
                textView.text_disp(disp_file_name, imgcont.Img_set[imgcont.NowFileNum].Name);   //ファイル名を描画する
                radio_button_check(imgcont.Img_set[imgcont.NowFileNum].Flg);                    //ラジオボタンのチェックを描画する
            }
            else if (e.KeyCode == Keys.K)                           //画像を戻す
            {
                if (imgcont.NowFileNum > 0)
                {
                    imgcont.NowFileNum--;
                }
                TextView textView = new TextView();
                textView.text_disp(disp_file_name, imgcont.Img_set[imgcont.NowFileNum].Name);   //ファイル名を描画する
                radio_button_check(imgcont.Img_set[imgcont.NowFileNum].Flg);                    //ラジオボタンのチェックを描画する
            }
            else if (e.KeyCode == Keys.C)                           //モードチェンジをキーボードでできるようにする
            {
                if (classContinueFlg == true)
                {
                    mode_Individual();
                }
                else
                {
                    mode_Multiple();
                }
            }
        }
        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
