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
    public partial class UseForm2 : Form
    {
        ServiceUse Service;
        Doctor doctor;
        public UseForm2(ServiceUse service, Doctor doctor)
        {
            Service = service;
            this.doctor = doctor;
            InitializeComponent();
        }

        private void UseForm2_Load(object sender, EventArgs e)
        {
            label1.Text = doctor.Name;
            textBox1.Text = doctor.PublicKey;
            IList<Querise> querise = Service.DoctorService.ShowEMR(doctor);
            dataGridView1.DataSource = querise;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EMR emr = Service.DoctorService.FindEMRbyID(new Guid(textBox2.Text.Trim()));
            ShowEMR showEMR = new ShowEMR(emr,Service);
            showEMR.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            unLockForm fm = new unLockForm(Service, doctor);
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IList<Querise> querise = Service.DoctorService.ShowEMR(doctor);
            dataGridView1.DataSource = querise;
        }
    }
}
