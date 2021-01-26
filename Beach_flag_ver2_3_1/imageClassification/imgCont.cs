using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageClassification
{
    class imgCont
    {
        private Data_set[] img_set;
        private long nowfileNum = 0;

        public Data_set[] Img_set { get { return img_set; } set { img_set = value; } }
        public long NowFileNum { get { return nowfileNum; } set { nowfileNum = value; } }
        
        public imgCont(String path,long fileNum)                //コンストラクタ
        {
            Data_set[] work = new Data_set[fileNum];        /*ファイルの数だけ配列を用意する*/
            img_set = work;

        }
        public void input_name(String path,long num,string[] extension)            //取得したファイルの名前を入力する
        {
            
            long filenum = 0;
            foreach (string str in extension)                                       //検索したい拡張子の分だけループ
            {
                string[] names = Directory.GetFiles(path, str);                    //pathを取得する
                for (long i = 0; i < names.Length; i++)
                {
                    Img_set[i+filenum] = new Data_set();
                    Img_set[i + filenum].Name = Path.GetFileName(names[i]);        //pathから画像のファイル名を取得する
                   
                }
                filenum += names.Length;                                            //namesの後ろに追加していく
            }
        }
        //画像を表示する
       public void disp_img(PictureBox imgBox,String path)
        {
            imgBox.Image = null;

            // System.Drawing.Image imgfile = System.Drawing.Image.FromFile(path+img_set[nowfileNum].Name);   //イメージオブジェクトを作成
            FileStream fs = new FileStream(path + img_set[nowfileNum].Name, FileMode.Open, FileAccess.Read);
            imgBox.Image = Image.FromStream(fs);

            if ((imgBox.Width > 0) && (imgBox.Height > 0))                                            //PictureBoxのサイズが1以上のとき
            {
                img_resize(imgBox, Image.FromStream(fs));
            }
            fs.Close();
            imgBox.Refresh();
        }
        private PictureBox img_resize(PictureBox pictureBox,System.Drawing.Image img)         //画像をリサイズ
        {
            
            Bitmap canvas = new Bitmap(pictureBox.Width, pictureBox.Height);
            Bitmap bimg = (Bitmap)img;
            Graphics g = Graphics.FromImage(canvas);

            g.InterpolationMode =System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic; //よくわからないけど補正してくれるやつ

            //計算用変数
            float resizeScale;
            float resizeScale2;
            float pW = pictureBox.Width;
            float iW = bimg.Width;
            float pH = pictureBox.Height;
            float iH = bimg.Height;
            //

            resizeScale = pW / iW;
            resizeScale2 = pH / iH;
           
            if (resizeScale > resizeScale2)
                resizeScale = resizeScale2;
          //  }
            g.DrawImage(bimg, 0, 0, iW*resizeScale,iH*resizeScale);     //座標(0,0)に指定サイズで描画

            g.Dispose();

            pictureBox.Image = canvas;
           
            return pictureBox;
        }


    }
}
