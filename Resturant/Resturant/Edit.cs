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
    public partial class Edit : Form
    {
        int id;

        myClass obj = new myClass();
        public Edit()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int s_id;
            string s_item = comboBox1.SelectedItem.ToString();
            DataTable dt = new DataTable();

            if (s_item == "BURGER")
            {
                richTextBox2.Clear();
                dt = obj.sel("select * from tblBurgerMaster");

                foreach (DataRow row in dt.Rows)
                {
                    richTextBox2.AppendText(" " + row["B_id"] + "  " + row["B_name"] + "\n");
                }

            }
            else if (s_item == "DOSA")
            {
                richTextBox2.Clear();
                dt = obj.sel("select * from tblDosaMaster");

                foreach (DataRow row in dt.Rows)
                {
                    richTextBox2.AppendText(" " + row["Do_id"] + " " + row["Do_name"] + "\n");
                }

            }
            else if (s_item == "COLD DRINKS")
            {
                richTextBox2.Clear();
                dt = obj.sel("select * from tbldrinksMaster");

                foreach (DataRow row in dt.Rows)
                {
                    richTextBox2.AppendText(" " + row["D_id"] + " " + row["D_name"] + "\n");
                }

            }


            else if (s_item == "ICE CREAM")
            {
                richTextBox2.Clear();
                dt = obj.sel("select * from tblIceMaster");

                foreach (DataRow row in dt.Rows)
                {
                    richTextBox2.AppendText(" " + row["I_id"] + " " + row["I_name"] + "\n");
                }

            }

            else if (s_item == "PIZZA")
            {
                richTextBox2.Clear();
                dt = obj.sel("select * from tblPizzaMaster");

                foreach (DataRow row in dt.Rows)
                {
                    richTextBox2.AppendText(" " + row["P_id"] + " " + row["P_name"] + "\n");
                }

            }

            else if (s_item == "PUNJABI")
            {
                richTextBox2.Clear();
                dt = obj.sel("select * from tblPunjabiMaster");

                foreach (DataRow row in dt.Rows)
                {
                    richTextBox2.AppendText(" " + row["Pu_id"] + " " + row["Pu_name"] + "\n");
                }

            }

            else if (s_item == "ROTI")
            {
                richTextBox2.Clear();
                dt = obj.sel("select * from tblRotiMaster");

                foreach (DataRow row in dt.Rows)
                {
                    richTextBox2.AppendText(" " + row["R_id"] + " " + row["R_name"] + "\n");
                }

            }

            else if (s_item == "SANDWICH")
            {
                richTextBox2.Clear();
                dt = obj.sel("select * from tblSandwitchMaster");

                foreach (DataRow row in dt.Rows)
                {
                    richTextBox2.AppendText(" " + row["S_id"] + " " + row["S_name"] + "\n");
                }

            }

            else if (s_item == "STARTER")
            {
                richTextBox2.Clear();
                dt = obj.sel("select * from tblStarterMaster");

                foreach (DataRow row in dt.Rows)
                {
                    richTextBox2.AppendText(" " + row["St_id"] + " " + row["St_name"] + "\n");
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            int cost;
            string item;
            id = Convert.ToInt16(textBox1.Text.ToString());
            cost = Convert.ToInt16(textBox2.Text.ToString());
            int c =0;
            item = comboBox1.Text; 

            if(item=="BURGER")
            {
                c = 1;

                obj.ins_updt_del("update tblBurgerMaster set B_cost='" + cost.ToString() + "' where B_id='"+id+"'");
            }
            else if (item == "DOSA")
            {
                c = 1;

                obj.ins_updt_del("update tblDosaMaster set Do_cost='" + cost.ToString() + "' where Do_id='" + id + "'");
            }
            else if (item == "COLD DRINKS")
            {
                c = 1;

                obj.ins_updt_del("update tbldrinksMaster set D_cost='" + cost.ToString() + "' where D_id='" + id + "'");
            }
            else if (item == "ICE CREAM")
            {
                c = 1;

                obj.ins_updt_del("update tblIceMaster set I_cost='" + cost.ToString() + "' where I_id='" + id + "'");
            }
            else if (item == "PIZZA")
            {
                c = 1;

                obj.ins_updt_del("update tblPizzaMaster set P_cost='" + cost.ToString() + "' where P_id='" + id + "'");
            }
            else if (item == "PUNJABI")
            {
                c = 1;

                obj.ins_updt_del("update tblPunjabiMaster set Pu_cost='" + cost.ToString() + "' where Pu_id='" + id + "'");
            }
            else if (item == "ROTI")
            {
                c = 1;

                obj.ins_updt_del("update tblRotiMaster set R_cost='" + cost.ToString() + "' where R_id='" + id + "'");
            }
            else if (item == "SANDWITCH")
            {
                c = 1;

                obj.ins_updt_del("update tblSandwitchMaster set S_cost='" + cost.ToString() + "' where S_id='" + id + "'");
            }
            else if (item == "STARTER")
            {
                c= 1;
                obj.ins_updt_del("update tblStarterMaster set St_cost='" + cost.ToString() + "' where St_id='" + id + "'");
            }

            if (c == 1)
            {
                button1.Hide();
                button2.Hide();
                label6.Text = "Edit Successdully";
                label6.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            int id;
            id = Convert.ToInt16(textBox1.Text.ToString());
            string item = comboBox1.SelectedItem.ToString();
            int c = 0;
            if (item == "BURGER")
            {
                c = 1;
                obj.ins_updt_del("delete from tblBurgerMaster where B_id="+id+"");
            }
            else if (item == "DOSA")
            {
                c = 1;
                obj.ins_updt_del("delete from tblDosaMaster  where Do_id="+id+"");
            }
            else if (item == "COLD DRINKS")
            {
                c = 1;
                obj.ins_updt_del("delete from tbldrinksMaster  where D_id=" + id + "");
            }
            else if (item == "ICE CREAM")
            {
                c = 1;
                obj.ins_updt_del("delete from tblIceMaster  where I_id=" + id +"");
            }
            else if (item == "PIZZA")
            {
                c = 1;
                obj.ins_updt_del("delete from tblPizzaMaster  where P_id=" + id + "");
            }
            else if (item == "PUNJABI")
            {
                c = 1;
                obj.ins_updt_del("delete from tblPunjabiMaster  where Pu_id=" + id + "");
            }
            else if (item == "ROTI")
            {
                c = 1;
                obj.ins_updt_del("delete from tblRotiMaster  where R_id=" + id + "");
            }
            else if (item == "SANDWICH")
            {
                c = 1;
                obj.ins_updt_del("delete from tblSandwitchMaster  where S_id=" + id + "");
            }
            else if (item =="STARTER")
            {
                c = 1;
                obj.ins_updt_del("delete from tblStarterMaster  where St_id=" + id + "");
            }

            if(c==1)
            {
                button1.Hide();
                button2.Hide();
                label6.Text = "Delete Successdully";
                label6.Visible = true;
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
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
