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

            string conStr = "Provider=SQLNCLI11;Data Source="+ sql_server + ";Integrated Security=SSPI;Initial Catalog="+ sql_base;
            OleDbConnection connection = new OleDbConnection(conStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Sales", connection);

            BindingSource bSource = new BindingSource();
            DataTable dTable = new DataTable();

            adapter.Fill(dTable);
            bSource.DataSource = dTable;
            dataGridView.DataSource = bSource;

            adapter.Update(dTable);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.dataSet1.Sales);
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand(
               "UPDATE Sales SET DateDoc = @DateDoc, Firm = @Firm, City = @City, Contry = @Contry, Manager = @Manager," +
               " Counts = @Count, Sums =  @Sum WHERE (ID = @ID)");
            
            

            //Параметр ID
            OleDbParameter parametr = new OleDbParameter("@ID", SqlDbType.Int);
            parametr.SourceColumn = "ID";
            command.Parameters.Add(parametr);

            OleDbParameter Firm = new OleDbParameter("@Firm", DbType.Single);
            parametr.SourceColumn = "Firm";
            command.Parameters.Add(Firm);

            OleDbParameter City = new OleDbParameter("@City", SqlDbType.NChar);
            parametr.SourceColumn = "City";
            command.Parameters.Add(City);

            OleDbParameter Contry = new OleDbParameter("@Contry", SqlDbType.NChar);
            parametr.SourceColumn = "Contry";
            command.Parameters.Add(Contry);

            OleDbParameter Manager = new OleDbParameter("@Manager", SqlDbType.NChar);
            parametr.SourceColumn = "Manager";
            command.Parameters.Add(Manager);

            OleDbParameter Count = new OleDbParameter("@Count", SqlDbType.NChar);
            parametr.SourceColumn = "Counts";
            command.Parameters.Add(Count);

            OleDbParameter Sum = new OleDbParameter("@Sum", SqlDbType.Float);
            parametr.SourceColumn = "Sums";
            command.Parameters.Add(Sum);

            OleDbParameter DateDoc = new OleDbParameter("@DateDoc", SqlDbType.Date);
            parametr.SourceColumn = "DateDoc";
            command.Parameters.Add(DateDoc);

            command.Connection = salesTableAdapter.Connection;
            salesTableAdapter.Adapter.UpdateCommand = command;

            salesTableAdapter.Update(dataSet1.Sales);

            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            dataGridView.Refresh();
        }
    }
}
