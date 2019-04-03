using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DövizKurlarıDataSource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet doviz = new DataSet();
                doviz.ReadXml(@"https://www.tcmb.gov.tr/kurlar/today.xml");
                dataGridDoviz.DataSource = doviz.Tables[1];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
