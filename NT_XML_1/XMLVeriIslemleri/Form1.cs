using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLVeriIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dosyaYolu = Application.StartupPath + "\\Calisanlar.xml";
        const string veritabanıNorthwind = @"Data Source=WISSEN\MSSQLSRV;Initial Catalog=Northwind;User ID=sa;Password=12345srv";


        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(dosyaYolu);
        }

        private void btnXMLVeriOku_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(dosyaYolu);
            dataGridView1.DataSource = ds.Tables[0];
            webBrowser1.Url = new Uri(dosyaYolu);
        }

        private void btnXMLVeriBul_Click(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(dosyaYolu);
            XmlNode secilenNode = xmldoc.ChildNodes[1];
            bool bulundu = false;
            foreach (XmlNode item in secilenNode)
            {
                if (item.ChildNodes[0].InnerText == "Can" || item.Attributes["TCNo"].Value== "12345678901")
                {
                    MessageBox.Show("Aranan kişi bulundu : \n\n" + item.ChildNodes[0].InnerText + " " + item.ChildNodes[1].InnerText + "\n" + item.ChildNodes[2].InnerText + "\n" + "TCNo : " + item.Attributes["TCNo"].Value);
                    bulundu = true;
                    break;
                }
            }

            if(!bulundu)
            {
                MessageBox.Show("Aranan kişi 'Can' bulunamadı.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            webBrowser1.Url = new Uri(dosyaYolu);
        }
    }
}
