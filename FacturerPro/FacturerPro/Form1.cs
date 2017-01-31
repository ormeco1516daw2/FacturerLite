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
            using (FileStream fsReaderStream = new FileStream(xmlFileName, FileMode.Open))
            {
                using (XmlTextReader xmlReader = new XmlTextReader(fsReaderStream))
                {
                    newDataSet.ReadXml(xmlReader, XmlReadMode.ReadSchema);
                }
            }
        }
    }
}
