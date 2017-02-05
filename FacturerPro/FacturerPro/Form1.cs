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
using System.Xml.Linq;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace FacturerPro
{
    public partial class Form1 : Form
    {

        

        
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
            // TODO: This line of code loads data into the 'pcgroundDataSet.factura_detall' table. You can move, or remove it, as needed.
            this.factura_detallTableAdapter.Fill(this.pcgroundDataSet.factura_detall);
            // TODO: This line of code loads data into the 'pcgroundDataSet.factura' table. You can move, or remove it, as needed.
            this.facturaTableAdapter.Fill(this.pcgroundDataSet.factura);
            // TODO: This line of code loads data into the 'pcgroundDataSet.productes' table. You can move, or remove it, as needed.
            this.productesTableAdapter.Fill(this.pcgroundDataSet.productes);
            // TODO: This line of code loads data into the 'pcgroundDataSet.clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.pcgroundDataSet.clients);

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Console.WriteLine("Hola");

            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    clientsBindingNavigator.BindingSource = clientsBindingSource;
                    Console.WriteLine("0");
                    break;
                case 1:
                    clientsBindingNavigator.BindingSource = productesBindingSource;
                    Console.WriteLine("1");
                    break;
                case 2:
                    clientsBindingNavigator.BindingSource = facturaBindingSource;
                    Console.WriteLine("2");
                    break;
                case 3:
                    clientsBindingNavigator.BindingSource = factura_detallBindingSource;
                    Console.WriteLine("3");
                    break;
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Exportar
        {   
            
            DataSet dataSet = this.pcgroundDataSet;
            DataTableHelper.WriteDataSetToXML(dataSet, "new.xml");
        }

        private void button2_Click(object sender, EventArgs e)//Importar
        {
            DataSet dataSet = this.pcgroundDataSet;
            DataTableHelper.ReadXmlIntoDataSet(dataSet, "old.xml");
        }
    }

    static class DataTableHelper
    {
        public static void WriteDataSetToXML(DataSet dataset, String xmlFileName)
        {
            try {
                using (FileStream fsWriterStream = new FileStream(xmlFileName, FileMode.Create))
                {
                    using (XmlTextWriter xmlWriter = new XmlTextWriter(fsWriterStream, Encoding.Unicode))
                    {
                        //dataset.WriteXml(xmlWriter);
                        dataset.WriteXml(xmlWriter, XmlWriteMode.WriteSchema);
                        Console.WriteLine("Write {0} to the File {1}.", dataset.DataSetName, xmlFileName);
                        Console.WriteLine();
                    }
                }
                MessageBox.Show("Xml correctament guardat.");
            } catch (Exception ex) {
                MessageBox.Show("Quelcom ha anat malament!");
            }
            
        }


        public static void ReadXmlIntoDataSet(DataSet newDataSet, String xmlFileName)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFileName);
            XmlElement root = doc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("/descendant-or-self::node()");
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "Database = pcground; Password = root; Port = 3307; Server = localhost; User = root";
            
            //List<string> parts = new List<string>();
            foreach (XmlNode node in nodes)
            {
                switch (node.Name) {

                    case "clients":
                        XmlNodeList childones03 = node.ChildNodes;
                        List<string> clients = new List<string>();
                        foreach (XmlNode node01 in childones03)
                        {
                            //Console.WriteLine(node01.Name + " -> " + node01.InnerText);
                            clients.Add(node01.InnerText);
                        }
                        try
                        {
                            conn = new MySql.Data.MySqlClient.MySqlConnection();
                            conn.ConnectionString = myConnectionString;
                            MySqlCommand command = conn.CreateCommand();
                            command.CommandText = "INSERT INTO clients (id_Client,Nom,Cognom1,Cognom2,Adreça,Codi_Postal,Població,Província,Telèfon,Fax,E-mail) VALUES (?id_Client,?Nom,?Cognom1,?Cognom2,?Adreça,?Codi_Postal,?Població,?Província,?Telèfon,?Fax,?E-mail)";
                            command.Parameters.AddWithValue("?id_Client", clients[0]);
                            command.Parameters.AddWithValue("?Nom", clients[1]);
                            command.Parameters.AddWithValue("?Cognom1", clients[2]);
                            command.Parameters.AddWithValue("?Cognom2", clients[3]);
                            command.Parameters.AddWithValue("?Adreça", clients[4]);
                            command.Parameters.AddWithValue("?Codi_Postal", clients[5]);
                            command.Parameters.AddWithValue("?Població", clients[6]);
                            command.Parameters.AddWithValue("?Província", clients[7]);
                            command.Parameters.AddWithValue("?Telèfon", clients[8]);
                            command.Parameters.AddWithValue("?Fax", clients[9]);
                            command.Parameters.AddWithValue("?E-mail", clients[10]);
                            conn.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (MySql.Data.MySqlClient.MySqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        Console.WriteLine();
                    break;

                    case "factura":
                        XmlNodeList childones01 = node.ChildNodes;
                        List<string> factures = new List<string>();
                        foreach (XmlNode node01 in childones01)
                        {
                            //Console.WriteLine(node01.Name + " -> " + node01.InnerText);
                            factures.Add(node01.InnerText);    
                        }
                        try
                        {
                            conn = new MySql.Data.MySqlClient.MySqlConnection();
                            conn.ConnectionString = myConnectionString;
                            MySqlCommand command = conn.CreateCommand();
                            command.CommandText = "INSERT INTO factura (n_Factura,id_Client,Data,Descompte,IVA) VALUES (?n_Factura,?id_Client,?Data,?Descompte,?IVA)";
                            command.Parameters.AddWithValue("?n_Factura", factures[0]);
                            command.Parameters.AddWithValue("?id_Client", factures[1]);
                            command.Parameters.AddWithValue("?Data", factures[2]);
                            command.Parameters.AddWithValue("?Descompte", factures[3]);
                            command.Parameters.AddWithValue("?IVA", factures[4]);
                            conn.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (MySql.Data.MySqlClient.MySqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        Console.WriteLine();
                        break;

                    case "productes":
                        XmlNodeList childones02 = node.ChildNodes;
                        List<string> productes = new List<string>();
                        foreach (XmlNode node01 in childones02)
                        {
                            //Console.WriteLine(node01.Name + " -> " + node01.InnerText);
                            productes.Add(node01.InnerText);
                        }
                        try
                        {
                            conn = new MySql.Data.MySqlClient.MySqlConnection();
                            conn.ConnectionString = myConnectionString;
                            MySqlCommand command = conn.CreateCommand();
                            command.CommandText = "INSERT INTO productes (id_Producte,Producte,Preu) VALUES (?id,?Producte,?Preu)";
                            command.Parameters.AddWithValue("?id", productes[0]);
                            command.Parameters.AddWithValue("?Producte", productes[1]);
                            command.Parameters.AddWithValue("?Preu", productes[2]);
                            conn.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (MySql.Data.MySqlClient.MySqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        Console.WriteLine();
                        break;

                    

                    case "factura_detall":
                        XmlNodeList childones04 = node.ChildNodes;
                        List<string> facturesDetall = new List<string>();
                        foreach (XmlNode node01 in childones04)
                        {
                            //Console.WriteLine(node01.Name + " -> " + node01.InnerText);
                            facturesDetall.Add(node01.InnerText);
                        }
                        try
                        {
                            conn = new MySql.Data.MySqlClient.MySqlConnection();
                            conn.ConnectionString = myConnectionString;
                            MySqlCommand command = conn.CreateCommand();
                            command.CommandText = "INSERT INTO factura_detall (n_Factura,id_Producte,Quantitat) VALUES (?n_Factura,?id_Producte,?Quantitat)";
                            command.Parameters.AddWithValue("?n_Factura", facturesDetall[0]);
                            command.Parameters.AddWithValue("?id_Producte", facturesDetall[1]);
                            command.Parameters.AddWithValue("?Quantitat", facturesDetall[2]);
                            conn.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (MySql.Data.MySqlClient.MySqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        Console.WriteLine();
                        break;
                }
            }
        }

        public static void ShowDataSet(DataSet dataset)
        {
            foreach (DataTable table in dataset.Tables)
            {
                Console.WriteLine("Table {0}:", table.TableName);
                ShowDataTable(table);
            }
        }


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


        public static void UpdateBindingNavigator() {
            SqlDataAdapter datapter;
            DataSet dset;
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "Database = pcground; Password = root; Port = 3307; Server = localhost; User = root";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            datapter = new SqlDataAdapter("SELECT * FROM clients", myConnectionString);
            dset = new DataSet();
            datapter.Fill(dset);

            //BindingSource1.DataSource = dset.Tables[0];



        }

        public static void ClearBeforeFill()
        {
            //Netajem els bindings Sources
            //txtbox1.DataBindings.Clear();
        }
    }
}
