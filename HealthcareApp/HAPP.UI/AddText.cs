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

    public partial class AddText : Form
    {
        EMR emr;
        ServiceUse Service;

        public AddText(EMR emr, ServiceUse service)
        {
            this.emr = emr;
            Service = service;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Text = richTextBox1.Text;
            Service.DoctorService.ModifyEMR(emr, Text, new Doctor()
            {
                Name = textBox1.Text,
                PublicKey = textBox2.Text
            });

        }
    }
}
