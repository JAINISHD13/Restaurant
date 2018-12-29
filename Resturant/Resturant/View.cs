using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class View : Form
    {
        myClass obj = new myClass();
        DataTable dt = new DataTable();
        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            dt = obj.sel("select * from tblPizzaMaster;");
            dataGridView1.DataSource = dt;

        }
    }
}
