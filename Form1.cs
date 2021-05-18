using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perevod
{
    public partial class Form1 : Form
    {
  
        static Dictionary<char, string> dic = new Dictionary<char, string>();

        public Form1()
        {
            InitializeComponent();
            dic.Add('а', "a");
            dic.Add('б', "b");
            dic.Add('в', "v");
            dic.Add('г', "g");
            dic.Add('д', "d");
            dic.Add('е', "e");
            dic.Add('ё', "yo");
            dic.Add('ж', "zh");
            dic.Add('з', "z");
            dic.Add('и', "i");
            dic.Add('й', "j");
            dic.Add('к', "k");
            dic.Add('л', "l");
            dic.Add('м', "m");
            dic.Add('н', "n");
            dic.Add('о', "o");
            dic.Add('п', "p");
            dic.Add('р', "r");
            dic.Add('с', "s");
            dic.Add('т', "t");
            dic.Add('у', "u");
            dic.Add('ф', "f");
            dic.Add('х', "x");
            dic.Add('ц', "c");
            dic.Add('ч', "ch");
            dic.Add('ш', "sh");
            dic.Add('щ', "shh");
            dic.Add('ъ', "");
            dic.Add('ы', "y");
            dic.Add('ь', "");
            dic.Add('э', "e");
            dic.Add('ю', "yu");
            dic.Add('я', "ya");


        }


     
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            foreach (char ch in textBox1.Text)
            {
                try
                {
                    textBox2.Text += dic[ch];
                }
                catch (KeyNotFoundException ex)
                {
                    textBox2.Text += ch;
                }
            }
        }
    }
}