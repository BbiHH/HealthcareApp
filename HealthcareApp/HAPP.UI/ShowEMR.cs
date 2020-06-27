using HApp.Domain;
using HApp.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HAPP.UI
{
    public partial class ShowEMR : Form
    {
        public EMR emr;
        public ServiceUse Service;
        public ShowEMR(EMR emr , ServiceUse service)
        {
            this.Service = service;
            this.emr = emr;
            InitializeComponent();
        }

        private void ShowEMR_Load(object sender, EventArgs e)
        {
            textBox1.Text = emr.ID.ToString();
            richTextBox1.Text = emr.Ehistory;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddText addText = new AddText(emr, Service);
            addText.Show();
        }
    }
}
