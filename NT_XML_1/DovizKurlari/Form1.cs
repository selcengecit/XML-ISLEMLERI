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

namespace DovizKurlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doviz secilenDoviz = new Doviz();
            secilenDoviz = (Doviz)lstDoviz.SelectedItem;
            lblAlis.Text = secilenDoviz.AlisFiyat.ToString();
            lblSatis.Text = secilenDoviz.SatisFiyat.ToString();
            lblBirim.Text = secilenDoviz.Birim.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          
            
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            lstDoviz.Items.Clear();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("https://www.tcmb.gov.tr/kurlar/today.xml");
            XmlElement rooteleman = xmldoc.DocumentElement;
            XmlNodeList liste = rooteleman.GetElementsByTagName("Currency");
            List<Doviz> dliste = new List<Doviz>();
            foreach (var item in liste)
            {
                Doviz d = new Doviz();
                XmlElement currency = (XmlElement)item;
                string isim = currency.GetElementsByTagName("Isim").Item(0).InnerText;

                d.DovizAd = isim;

                string alisFiyat = currency.GetElementsByTagName("ForexBuying").Item(0).InnerText;
                string satisFiyat = currency.GetElementsByTagName("ForexSelling").Item(0).InnerText;
                string birim = currency.GetElementsByTagName("Unit").Item(0).InnerText;

                if(!string.IsNullOrEmpty(alisFiyat))
                {
                    d.AlisFiyat = Convert.ToDecimal(alisFiyat);
                }

                if(!string.IsNullOrEmpty(satisFiyat))
                {
                    d.SatisFiyat = Convert.ToDecimal(satisFiyat);
                }

                if (!string.IsNullOrEmpty(birim))
                {
                    d.Birim = Convert.ToInt32(birim);
                }
                lstDoviz.Items.Add(d);
                dliste.Add(d);
}
            dataGridDoviz1.DataSource = dliste;
            int i = 0;
            foreach (var item in dliste)
            {
                try
                {
                    dataGridDoviz2.Rows.Add();
                    dataGridDoviz2.Rows[i].Cells[0].Value = item.DovizAd;
                    dataGridDoviz2.Rows[i].Cells[1].Value = item.SatisFiyat;
                    i++;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }

            }




            
        }
    }
}
