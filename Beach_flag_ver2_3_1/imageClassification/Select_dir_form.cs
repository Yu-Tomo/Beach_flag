using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageClassification
{
    public partial class Select_dir_form : Form
    {
        public mainForm MainForm;
        public Select_dir_form()
        {
            InitializeComponent();
        }
        private string dirPath;
        private string saveDir;
      
        public string DirPath { get { return dirPath; } set { dirPath = value; } }
        private string dirOpen(TextBox text)
        {
            string str;
            if (text.Text == "")
            {
                FolderOpen folderOpen = new FolderOpen();
                str=folderOpen.FolderOpenDia(this) + Path.DirectorySeparatorChar;
                folderPath.Text = str;
            }
            else
            {
                str = text.Text;
            }
            return str;
        }
        private void miss_f_Click(object sender, EventArgs e)
        {
            saveDir= dirOpen(folderPath);                                   
        }

        private void end_button_Click(object sender, EventArgs e)
        {
            
            MainForm.SavePath = saveDir;
           
            if(saveDir == null)MessageBox.Show("ディレクトリを選択してください。", "エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
          
            this.Close();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void folderDragEntry(object sender, DragEventArgs e)
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
        private void folderDrop(object sender, DragEventArgs e)
        {
            string[] str;

            str = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (str.Length > 1) MessageBox.Show("複数ファイル選択には対応していません。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (File.Exists(str[0]))
            {
                MessageBox.Show("フォルダーを選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                str[0] += Path.DirectorySeparatorChar;
                folderPath.Text = str[0];
                saveDir = str[0];
            }
        }
    }
}
