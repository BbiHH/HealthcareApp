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

namespace HApp.UI
{
    public partial class PatientForm : System.Windows.Forms.Form
    {
        ServiceUse Service { get; set; }
        public PatientForm(ServiceUse service)
        {
            Service = service;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此EMR电子病历由***会话秘钥加密");
            EMRForm eMRForm = new EMRForm();
            eMRForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorForm doctorForm = new DoctorForm(Service);
            doctorForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EMRForm eMRForm = new EMRForm();
            eMRForm.Show();
        }
    }
}
