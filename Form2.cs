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
    public partial class Form2 : Form
    {
        MenuStrip m;
        public Form2()
        {
            InitializeComponent();
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            m = new MenuStrip();
            ToolStripMenuItem file = (ToolStripMenuItem)m.Items.Add("File");
            ToolStripMenuItem edit = (ToolStripMenuItem)m.Items.Add("Edit");
            ToolStripMenuItem style = (ToolStripMenuItem)m.Items.Add("Style");

            MainMenuStrip = m;
            Controls.Add(m);

            edit.DropDownItems.Add("copy");
            edit.DropDownItems.Add("cut");
            edit.DropDownItems.Add(new ToolStripSeparator());
            edit.DropDownItems.Add("paste");

            ToolStripMenuItem close = (ToolStripMenuItem)file.DropDownItems.Add("Close");
            close.ShortcutKeys = Keys.Control | Keys.S;
            close.ShowShortcutKeys = true;
            close.Click += new EventHandler(close_Click);

        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
