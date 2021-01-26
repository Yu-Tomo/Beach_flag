using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageClassification
{
    class FolderOpen
    { 
        public string FolderOpenDia(Form form)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //上部に表示する説明テキストを指定する
            fbd.Description = "操作したい写真フォルダを指定してください。";
            //ルートフォルダを指定する
            //デフォルトでDesktop
            fbd.RootFolder = Environment.SpecialFolder.Desktop;

            //デフォルトでTrue
            fbd.ShowNewFolderButton = true;

            //ダイアログを表示する
            if (fbd.ShowDialog(form) == DialogResult.OK)
            {
               return fbd.SelectedPath;
            }
            else
            {
                return null;
            }
        }
        public long Check_fileNum(string path, string str)                     //ファイルの数を取得
        {
            long num = 0;

            try
            {
                DirectoryInfo dirinfo = new DirectoryInfo(path);
                num = dirinfo.GetFileSystemInfos(str).Length;               //directory下のファイルの数を取得します。
            }
            catch(ArgumentNullException)
            {
               
                num = -1;
            }

            return num;
        }
    }
}
