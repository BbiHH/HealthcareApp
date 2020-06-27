using HApp.Domain;
using HApp.Repository;
using HApp.Repository.Interface;
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
    public partial class ShowEMR : Form
    {
        public EMR emr;
        public ServiceUse Service;
        public ShowEMR(EMR emr , ServiceUse service)
        {
            this.Service = service;
            this.emr = emr;
            InitializeComponent();
        }

        private void ShowEMR_Load(object sender, EventArgs e)
        {
            textBox1.Text = emr.ID.ToString();
            richTextBox1.Text = emr.Ehistory;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddText addText = new AddText(emr, Service);
            addText.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EMR emr = Service.DoctorService.FindEMRbyID(new Guid(textBox1.Text));
            IEMRRepository eMRRepository = new EMRRepository(Service.dbcontext);
            eMRRepository.Remove(emr);
            Service.dbcontext.SaveChanges();
            MessageBox.Show("删除成功");
        }
    }
}
