using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        DataTable dTable = new DataTable();
        String GroupColums = "";
        String conStr = null;
        String text = "SELECT * FROM Sales ";

        private void setDataSourse(String text)
        {
            OleDbConnection connection = new OleDbConnection(conStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter(text, connection);
            BindingSource bSource = new BindingSource();
            dTable.Clear();
            adapter.Fill(dTable);
            bSource.DataSource = dTable;
            
            dataGridView.DataSource = bSource;
            
            adapter.Update(dTable);

        }

        public Form1()
        {
            InitializeComponent();

            IniFile iniFile = new IniFile();

            string sql_base = iniFile.ReadINI("SQL_Config", "Base");
            string sql_server = iniFile.ReadINI("SQL_Config", "Server");
            if (sql_base == "" | sql_server == "") {
                Form2 form = new Form2();
                form.ShowDialog();
                sql_base = iniFile.ReadINI("SQL_Config", "Base");
                sql_server = iniFile.ReadINI("SQL_Config", "Server");
            }
            conStr = "Provider=SQLNCLI11;Data Source=" + sql_server + ";Integrated Security=SSPI;Initial Catalog=" + sql_base;

            setDataSourse(text);

            foreach ( DataColumn tableColumn in dTable.Columns) {
                if (tableColumn.DataType == typeof(string) | tableColumn.DataType == typeof(DateTime))
                {
                    listColums.Items.Add(tableColumn.ColumnName);
                }
                else {
                    if (GroupColums != string.Empty ) {GroupColums += ", ";}
                    GroupColums += "sum(" + tableColumn.ColumnName + ") as " + tableColumn.ColumnName;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.dataSet1.Sales);
            

        }

 

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listColums_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ListView.CheckedListViewItemCollection items = listColums.CheckedItems;
            String where = "";

            for (int ind = 0; ind < items.Count; ind++)
            {
                 if (where != String.Empty){ where += " ,"; }
                where += items[ind].Text; 
            }

            if (where == String.Empty)
            {
                setDataSourse(text);
            }
            else {
                String textGr = "Select " + where + ", " + GroupColums + " from Sales group by " + where;
                setDataSourse(textGr);

            }
        }
    }
}
