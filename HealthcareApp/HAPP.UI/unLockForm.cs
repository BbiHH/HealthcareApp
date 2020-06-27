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
    public partial class unLockForm : Form
    {
        Doctor doctor;
        ServiceUse Service;
        public unLockForm(ServiceUse service, Doctor doctor)
        {
            Service = service;
            this.doctor = doctor;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EMR emr = Service.DoctorService.unLockEMR(textBox1.Text, textBox2.Text,doctor);
            if(emr!=null)
            {
                MessageBox.Show("解锁成功");
                ShowEMR showEMR = new ShowEMR(emr,Service);
                showEMR.Show();
            }
            else
            {
                MessageBox.Show("解锁失败");
            }
        }
    }
}
