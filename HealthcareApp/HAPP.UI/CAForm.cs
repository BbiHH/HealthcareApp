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
    public partial class CAForm : Form
    {
        ServiceUse Service { get; set; }
        public CAForm(ServiceUse service)
        {
            Service = service;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="患者")
            {
                Patient people = new Patient();
                people.Name = textBox1.Text.Trim();
                string key = textBox2.Text.Trim();
                if (key != "")
                {
                    people.privateKey = key;
                }

                Service.CAService.AddPatient(people);

                textBox3.Text = people.PublicKey;
                textBox4.Text = people.privateKey;
                textBox5.Text = people.ID.ToString();
            }
            else
            {
                Doctor people = new Doctor();
                people.Name = textBox1.Text.Trim();
                string key = textBox2.Text.Trim();
                if (key != "")
                {
                    people.privateKey = key;
                }

                Service.CAService.AddDoctor(people);
                textBox3.Text = people.PublicKey;
                textBox4.Text = people.privateKey;
                textBox5.Text = people.ID.ToString();
            }

            MessageBox.Show("注册成功!");

        }
    }
}
