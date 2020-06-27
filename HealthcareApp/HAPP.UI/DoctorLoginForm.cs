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
    public partial class DoctorLoginForm : Form
    {
        ServiceUse Service { get; set; }
        public DoctorLoginForm(ServiceUse service)
        {
            Service = service;
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor()
            {
                ID = new Guid(textBox1.Text.ToString()),
                Name = textBox2.Text.Trim()
            };

            Doctor dr = Service.CAService.FindDoctor(doctor);

            if (dr != null && dr.privateKey == textBox3.Text)
            {
                MessageBox.Show("登录成功");
                UseForm2 fm = new UseForm2(Service, dr);
                fm.Show();
            }
            else
            {
                MessageBox.Show("验证失败");
            }
        }
    }
}
