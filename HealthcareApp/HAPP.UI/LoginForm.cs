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
    public partial class LoginForm : System.Windows.Forms.Form
    {
        ServiceUse Service { get; set; }
        public LoginForm(ServiceUse service)
        {
            Service = service;
            InitializeComponent();
        }

        private void denglu1_Click(object sender, EventArgs e)
        {

            PatientForm patientForm = new PatientForm(Service);
            patientForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorLoginForm doctorLoginForm = new DoctorLoginForm(Service);
            doctorLoginForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CAForm caForm = new CAForm(Service);
            caForm.Show();
        }
    }
}
