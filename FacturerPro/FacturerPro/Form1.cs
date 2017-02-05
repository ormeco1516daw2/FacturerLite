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
            Console.WriteLine("Hola");

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
            DataTableHelper.ReadXmlIntoDataSet(dataSet, "new.xml");
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
            foreach (XmlNode node in nodes)
            {
                switch (node.Name) {

                    case "factura":
                        XmlNodeList childones01 = node.ChildNodes;

                        foreach (XmlNode node01 in childones01)
                        {
                            Console.WriteLine(node01.Name + " -> " + node01.InnerText);
                        }
                        Console.WriteLine();
                        break;

                    case "productes":
                        XmlNodeList childones02 = node.ChildNodes;

                        foreach (XmlNode node01 in childones02)
                        {
                            Console.WriteLine(node01.Name + " -> " + node01.InnerText);
                        }
                        Console.WriteLine();
                        break;

                    case "clients":
                        XmlNodeList childones03 = node.ChildNodes;

                        foreach (XmlNode node01 in childones03)
                        {
                            Console.WriteLine(node01.Name + " -> " + node01.InnerText);
                        }
                        Console.WriteLine();
                        break;

                    case "factura_detall":
                        XmlNodeList childones04 = node.ChildNodes;

                        foreach (XmlNode node01 in childones04)
                        {
                            Console.WriteLine(node01.Name + " -> " + node01.InnerText);
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
    }
}
