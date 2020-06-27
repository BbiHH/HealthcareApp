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
    public partial class UseForm1 : Form
    {
        ServiceUse Service;
        Patient patient;
        public UseForm1(ServiceUse Service, Patient patient)
        {
            this.Service = Service;
            this.patient = patient;
            InitializeComponent();
        }

        private void UseForm1_Load(object sender, EventArgs e)
        {
            label1.Text = patient.Name;
            textBox1.Text = patient.PublicKey;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EMR emr =  Service.PatientService.CreatEMR(patient);
            MessageBox.Show("创建成功");
            richTextBox1.Text = richTextBox1.Text + "\r\n" + DateTime.Now.ToString()
                + "创建病例 ID:" + emr.ID;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EMR emr = Service.PatientService.FindEMR(patient.PublicKey);
            ShowEMR showEMR = new ShowEMR(emr,Service);
            showEMR.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string SessionKey = Service.PatientService.CreatSessionKey(patient);
            MessageBox.Show("创建成功");
            richTextBox1.Text = richTextBox1.Text + "\r\n" + DateTime.Now.ToString()
            + "创建会话密钥 :" + SessionKey;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            IList<Session>  sessions =  Service.PatientService.ShowSession(patient);
            dataGridView1.DataSource = sessions;
        }
    }
}
