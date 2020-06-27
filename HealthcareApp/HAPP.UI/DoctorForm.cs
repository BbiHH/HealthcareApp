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
    public partial class DoctorForm : Form
    {
        ServiceUse Service { get; set; }
        public DoctorForm(ServiceUse service)
        {
            Service = service;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EMRForm eMRForm = new EMRForm();
            eMRForm.Show();
        }
    }
}
