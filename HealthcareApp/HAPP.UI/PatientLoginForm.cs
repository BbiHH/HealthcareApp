using HApp.Domain;
using HApp.Service;
using HAPP.UI;
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
    public partial class PatientLoginForm : Form
    {
        ServiceUse Service { get; set; }
        public PatientLoginForm(ServiceUse service)
        {
            Service = service;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient() { ID = new Guid(textBox1.Text.ToString()),
            Name = textBox2.Text.Trim()};

            Patient pt = Service.CAService.FindPatient(patient);

            if(pt!=null&&pt.privateKey==textBox3.Text)
            {
                MessageBox.Show("登录成功");
                UseForm1 fm = new UseForm1(Service, pt);
                fm.Show();
            }
            else
            {
                MessageBox.Show("验证失败");
            }
        }
    }
}
