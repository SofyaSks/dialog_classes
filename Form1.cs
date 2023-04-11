using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dialog_сдфыыуы
{
    public partial class Form1 : Form
    {
        //string docname;

        Color c;
        public Form1()
        {
            InitializeComponent();
            c = BackColor;
            menuStrip_ru.Visible = false;
            button_lang_russian.Text = "Russian";
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*| Text Files(*.txt)|*.txt||";
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                richTextBox1.Text = reader.ReadToEnd(); 
                reader.Close();
            }
            //docname = open.FileName;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            if (save.ShowDialog() == DialogResult.OK)
            {
               //if(docname == "") {}
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.Write(richTextBox1.Text);
                writer.Close();
            }
        }

        private void button_font_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.SelectionFont;
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void button_color_Click(object sender, EventArgs e)
        {
            
            colorDialog1.Color = richTextBox1.SelectionColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem it = (ToolStripMenuItem)sender;
            if(it.Checked == true)
            {
                BackColor = Color.Red;
            }
            else
            {
                BackColor = c;
            }
        }

        private void button_lang_russian_Click(object sender, EventArgs e)
        {
            if (button_lang_russian.Text.CompareTo("English") == 0)
            {
                button_lang_russian.Text = "Russian";
                menuStrip_eng.Visible = true;
                menuStrip_ru.Visible = false;
                MainMenuStrip = menuStrip_eng;
            }
            else
            {
                button_lang_russian.Text = "English";
                menuStrip_ru.Visible = true;
                menuStrip_eng.Visible = false;
                MainMenuStrip = menuStrip_ru;
            }
        }
    }
}
