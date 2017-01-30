using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace FacturerLitePro
{
    public partial class Form1 : Form
    {
       // public MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
        

        public Form1()
        {
            
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcgroundDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "Database = pcground; Password = root; Port = 3307; Server = localhost; User = root";



            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO productes (id_Producte) VALUES (?id)";
                command.Parameters.AddWithValue("?id", 3);
                conn.Open();
                command.ExecuteNonQuery();
                // Console.WriteLine("Hola");
                // Console.ReadLine();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*this.conn_string.Server = "localhost";
            this.conn_string.UserID = "root";
            this.conn_string.Password = "root";
            this.conn_string.Database = "pcground";*/
            DataSet dataSet = this.pcgroundDataSet;
            AddARow(dataSet);
            // TODO: This line of code loads data into the 'pcgroundDataSet.factura_detall' table. You can move, or remove it, as needed.
            this.factura_detallTableAdapter.Fill(this.pcgroundDataSet.factura_detall);
           
            
            // TODO: This line of code loads data into the 'pcgroundDataSet.factura' table. You can move, or remove it, as needed.
            this.facturaTableAdapter.Fill(this.pcgroundDataSet.factura);
            // TODO: This line of code loads data into the 'pcgroundDataSet.productes' table. You can move, or remove it, as needed.
            this.productesTableAdapter.Fill(this.pcgroundDataSet.productes);
            // TODO: This line of code loads data into the 'pcgroundDataSet.clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.pcgroundDataSet.clients);
           // string connectionString = GetConnectionString();
            /*SqlCeDataAdapter da = new SqlCeDataAdapter(connectionString);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            da.SelectCommand = new SqlCommand(@"SELECT * FROM FooTable", connString);
            da.Fill(ds, "FooTable");
            dt = ds.Tables["FooTable"];

            foreach (DataRow dr in dt.Rows)
            {
                MessageBox.Show(dr["Column1"].ToString());
            }*/
           
            ShowDataSet(dataSet);
            DataTable table = this.pcgroundDataSet.factura_detall;
            Console.WriteLine(table);

            //DataTableHelper.WriteDataSetToXML(dataSet, "new.xml");
            // Add ten rows.
            DataRow row;
            Console.WriteLine(dataSet.GetXml());
            //DataTableHelper.ReadXmlIntoDataSet(dataSet, "new.xml");
            this.productesTableAdapter.Fill(this.pcgroundDataSet.productes);

            /*for (int i = 0; i < 10; i++)
            {
                row = table.NewRow();
                row["n_Factura"] = i;
                row["id_Producte"] = i;
                row["Quantitat"] =  i+5;
                table.Rows.Add(row);
            }*/
        }
        private void AddARow(DataSet dataSet)
        {
            Console.WriteLine("ey nai");
            DataTable table;
            table = dataSet.Tables["productes"];
            // Use the NewRow method to create a DataRow with 
            // the table's schema.
            DataRow newRow = table.NewRow();
            // Set values in the columns:
            newRow["id_Producte"] = 3;
            newRow["Producte"] = "Producte Nou";
            newRow["Preu"] = 14;
            // Add the row to the rows collection.
            table.Rows.Add(newRow);
            //AdapterUpdate(this.conn_string.ToString());
            //this.productesTableAdapter.Fill(this.pcgroundDataSet.productes);
            //sqlDataAdapter1.Fill(dataset1.Tables["Customers"]);
        }

        private void productesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clientsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Gang");

            

        }

      

        public static void ShowDataSet(DataSet dataset)
        {
            foreach (DataTable table in dataset.Tables)
            {
                Console.WriteLine("Table {0}:", table.TableName);
                ShowDataTable(table);
            }
        }

        // Display the columns and value of DataTable.
        private static void ShowDataTable(DataTable table)
        {
            foreach (DataColumn col in table.Columns)
            {
                Console.Write("{0,-14}", col.ColumnName);
            }
            Console.WriteLine("{0,-14}", "");

            foreach (DataRow row in table.Rows)
            {
                if (row.RowState == DataRowState.Deleted)
                {
                    foreach (DataColumn col in table.Columns)
                    {
                        if (col.DataType.Equals(typeof(DateTime)))
                        {
                            Console.Write("{0,-14:d}", row[col, DataRowVersion.Original]);
                        }
                        else if (col.DataType.Equals(typeof(Decimal)))
                        {
                            Console.Write("{0,-14:C}", row[col, DataRowVersion.Original]);
                        }
                        else
                        {
                            Console.Write("{0,-14}", row[col, DataRowVersion.Original]);
                        }
                    }
                }
                else
                {
                    foreach (DataColumn col in table.Columns)
                    {
                        if (col.DataType.Equals(typeof(DateTime)))
                        {
                            Console.Write("{0,-14:d}", row[col]);
                        }
                        else if (col.DataType.Equals(typeof(Decimal)))
                        {
                            Console.Write("{0,-14:C}", row[col]);
                        }
                        else
                        {
                            Console.Write("{0,-14}", row[col]);
                        }
                    }
                }
                Console.WriteLine("{0,-14}", "");
            }
        }

        static class DataTableHelper
        {
            public static void WriteDataSetToXML(DataSet dataset, String xmlFileName)
            {
                using (FileStream fsWriterStream = new FileStream(xmlFileName, FileMode.Create))
                {
                    using (XmlTextWriter xmlWriter = new XmlTextWriter(fsWriterStream, Encoding.Unicode))
                    {
                        dataset.WriteXml(xmlWriter, XmlWriteMode.WriteSchema);
                        Console.WriteLine("Write {0} to the File {1}.", dataset.DataSetName, xmlFileName);
                        Console.WriteLine();
                    }
                }
            }


            public static void ReadXmlIntoDataSet(DataSet newDataSet, String xmlFileName)
            {
                using (FileStream fsReaderStream = new FileStream(xmlFileName, FileMode.Open))
                {
                    using (XmlTextReader xmlReader = new XmlTextReader(fsReaderStream))
                    {
                        newDataSet.ReadXml(xmlReader, XmlReadMode.ReadSchema);
                    }
                }
            }
        }

        private static void AdapterUpdate(string connectionString)
        {
            using (SqlConnection connection =
                       new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdpater = new SqlDataAdapter(
                  "SELECT * FROM productes",
                  connection);

                dataAdpater.UpdateCommand = new SqlCommand(
                   "UPDATE productes SET preu = 1000 " +
                   "WHERE id_Producte = 1", connection);

               /* dataAdpater.UpdateCommand.Parameters.Add(
                   "@CategoryName", SqlDbType.NVarChar, 15, "CategoryName");

                SqlParameter parameter = dataAdpater.UpdateCommand.Parameters.Add(
                  "@CategoryID", SqlDbType.Int);
                parameter.SourceColumn = "CategoryID";
                parameter.SourceVersion = DataRowVersion.Original;*/

                DataTable categoryTable = new DataTable();
                dataAdpater.Fill(categoryTable);

                DataRow categoryRow = categoryTable.Rows[0];
                categoryRow["CategoryName"] = "New Beverages";

                dataAdpater.Update(categoryTable);

                Console.WriteLine("Rows after update.");
                foreach (DataRow row in categoryTable.Rows)
                {
                    {
                        Console.WriteLine("{0}: {1}", row[0], row[1]);
                    }
                }
            }
        }

        

        /*
// btnTest is object of button. This is how you add event for button
btnTest.Click += new System.EventHandler(this.btnButton_Click);

// its event handler

void btnButton_Click(object sender, EventArgs e)
{
   // your code goes here
}*/
    }
}
