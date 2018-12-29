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
    public partial class Insert : Form
    {
        string s_item;
        myClass obj = new myClass();
        public Insert()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            s_item = comboBox1.SelectedItem.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (s_item == "BURGER")
            {
                c = 1;
                obj.ins_updt_del("insert into tblBurgerMaster (B_name,B_cost) values('" + textBox1.Text + "','" + textBox2.Text + "');");
            }
            else if (s_item == "DOSA")
            {
                c = 1;
                obj.ins_updt_del("insert into tblDosaMaster (Do_name,Do_cost) values('" + textBox1.Text + "','" + textBox2.Text + "');");
            }
            else if (s_item == "COLD DRINKS")
            {
                c = 1;
                obj.ins_updt_del("insert into tbldrinksMaster (D_name,D_cost) values('" + textBox1.Text + "','" + textBox2.Text + "');");
            }
            else if (s_item == "ICE CREAM")
            {
                c = 1;
                obj.ins_updt_del("insert into tblIceMaster (I_name,I_cost) values('" + textBox1.Text + "','" + textBox2.Text + "');");
            }
            else if (s_item == "PIZZA")
            {
                c = 1;
                obj.ins_updt_del("insert into tblPizzaMaster (P_name,P_cost) values('" + textBox1.Text + "','" + textBox2.Text + "');");
            }
            else if (s_item == "PUNJABI")
            {
                c = 1;
                obj.ins_updt_del("insert into tblPunjabiMaster (Pu_name,Pu_cost) values('" + textBox1.Text + "','" + textBox2.Text + "');");
            }
            else if (s_item == "ROTI")
            {
                c = 1;
                obj.ins_updt_del("insert into tblRotiMaster (R_name,R_cost) values('" + textBox1.Text + "','" + textBox2.Text + "');");
            }
            else if (s_item == "SANDWICH")
            {
                c = 1;
                obj.ins_updt_del("insert into tblSandwitchMaster (S_name,S_cost) values('" + textBox1.Text + "','" + textBox2.Text + "');");
            }
            else if (s_item == "STARTER")
            {
                c = 1;
                obj.ins_updt_del("insert into tblStarterMaster (St_name,St_cost) values('" + textBox1.Text + "','" + textBox2.Text + "');");
            }

            MessageBox.Show(c.ToString());


        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void iNSERTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insert obj = new Insert();
            obj.Show();
            this.Hide();

        }

        private void eMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit obj = new Edit();
            obj.Show();
            this.Hide();

        }
    }
}
