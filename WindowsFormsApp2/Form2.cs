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
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace WindowsFormsApp2
{

    public partial class Form2 : Form
    {
        IniFile file = new IniFile();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            if (file.KeyExists("Server"))
            {
                te_Server.Text  = file.ReadINI("SQL_Config", "Server");
            }

            if (file.KeyExists("Base"))
            {
                te_Base.Text = file.ReadINI("SQL_Config", "Base");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            file.Write("SQL_Config", "Server", te_Server.Text);
            file.Write("SQL_Config", "Base", te_Base.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
