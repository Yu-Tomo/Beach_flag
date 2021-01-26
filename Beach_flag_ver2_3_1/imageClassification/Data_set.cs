using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imageClassification
{
    class Data_set
    {
        //画像のファイル名を取得格納
        private String name;
        //画像データがどんなデータなのか
        //flg 0～10
        private int flg=0;

        //get set
        public String Name { get { return name; } set { name = value; } }
        public int Flg { get { return flg; } set { flg = value; } }
    }
}
