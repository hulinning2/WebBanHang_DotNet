using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ServiceReference1.ServiceClient sv = new ServiceReference1.ServiceClient();
            this.dataGridView1.DataSource = sv.getTable("SELECT * FROM DanhMucSanPham").Tables[0];
        }
    }
}
