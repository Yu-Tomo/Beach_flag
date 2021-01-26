using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace imageClassification
{
    class img_Save
    {
        public void imgSave(Data_set data_Set,string absoPath,string savePath,string childFolderName)
        {
            move_file(absoPath+data_Set.Name,savePath+childFolderName+data_Set.Name);
         
        }
        private void move_file(string path,string movePath)
        {
            System.IO.File.Move(path, movePath);
        }
        public void making_folder(string savePath,string childFolderName)
        {
            if (Directory.Exists(savePath + childFolderName))
            {
                    //ディレクトリが存在するとき何もしない
            }
            else
            {
                    Directory.CreateDirectory(savePath + childFolderName);      //ないときは作る
            }
        }
        public void EmptyFolderCheack(string path,string folderName)
        {
            if (System.IO.Directory.EnumerateFileSystemEntries(path + folderName).Any())
            {
                //フォルダーがからではないとき何もしない
            }
            else
            {
                Directory.Delete(path+folderName);      //空なら消す
            }
           
        }
        public void write_text(Data_set date_Set, string savePath, string childFolderName)
        {
            File.AppendAllText(savePath + childFolderName + "list.txt", date_Set.Name + "\n");
        }
    }
}
