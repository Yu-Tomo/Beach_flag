using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace imageClassification
{
    class TextView                  //表示用クラス
    {
        public void text_disp(Label text, string str)
        {
            text.Text = str;
            text.Refresh();
        }
        public void text_disp(TextBox text, string str)
        {
            if (text.Multiline == true)
            {
                str += Environment.NewLine;
                text.AppendText(str);
            }
            else
            {
                text.Text = str;
            }
           
            text.Refresh();
        }
    }
}
