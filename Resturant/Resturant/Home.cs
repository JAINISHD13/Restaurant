using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Resturant
{
    public partial class Home : Form
    {
        int s_cost;
        string s_name;
        int sum = 0;
        float tax = 0;
        float total = 0;
        int s_total;
        int n;
        Boolean b;
        int remove = 0;

        myClass obj = new myClass();
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tax = 0;
            string s_item = comboBox1.SelectedItem.ToString();
            int s_code = Convert.ToInt16(textBox1.Text);
            int s_qty = Convert.ToInt16(textBox2.Text);

            DataTable dt = new DataTable();

            if (s_item == "BURGER")
            {
                dt = obj.sel("select B_name,B_cost from tblBurgerMaster where B_id = " + s_code + "");
            }
            else if (s_item == "DOSA")
            {
                dt = obj.sel("select Do_name,Do_cost from tblDosaMaster where Do_id = " + s_code + "");
            }
            else if (s_item == "COLD DRINKS")
            {
                dt = obj.sel("select D_name,D_cost from tbldrinksMaster where D_id = " + s_code + "");
            }
            else if (s_item == "ICE CREAM")
            {
                dt = obj.sel("select I_name,I_cost from tblIceMaster where I_id = " + s_code + "");
            }
            else if (s_item == "PIZZA")
            {
                dt = obj.sel("select P_name,P_cost from tblPizzaMaster where P_id = " + s_code + "");
            }
            else if (s_item == "PUNJABI")
            {
                dt = obj.sel("select Pu_name,Pu_cost from tblPunjabiMaster where Pu_id = " + s_code + "");
            }
            else if (s_item == "ROTI")
            {
                dt = obj.sel("select R_name,R_cost from tblRotiMaster where R_id = " + s_code + "");
            }
            else if (s_item == "SANDWICH")
            {
                dt = obj.sel("select S_name,S_cost from tblSandwitchMaster where S_id = " + s_code + "");
            }
            else if (s_item == "STARTER")
            {
                dt = obj.sel("select St_name,St_cost from tblStarterMaster where St_id = " + s_code + "");
            }

            s_cost = int.Parse(dt.Rows[0][1].ToString());
            s_name = dt.Rows[0][0].ToString();
            s_total = s_qty * s_cost;
            listBox1.Items.Add(s_name + "-" + s_qty + " * " + s_cost + "=" + s_total);



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
                    richTextBox2.AppendText(" " + row["D_id"] + "  " + row["D_name"] + "\n");
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

        private void button2_Click(object sender, EventArgs e)
        {
            remove = 1;
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sum = 0;
            total = 0;
            //tax = 0;

            
            if(listBox1.Items.Count==0)
            {
                textBox3.Text = sum.ToString();
                textBox4.Text = tax.ToString();
                textBox5.Text = total.ToString();
            }
            else
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    String s = listBox1.Items[i].ToString();
                    string[] str = s.Split('=');
                    int cost = int.Parse(str[1]);
                    sum = sum + cost;
                    tax = (sum * 6) / 100;
                    total = sum + tax;
                    textBox3.Text = sum.ToString();
                    textBox4.Text = tax.ToString();
                    textBox5.Text = total.ToString();
                }
                remove = 0;

            }
        }
        
        private void Home_Load(object sender, EventArgs e)
        {

            if (remove == 1)
            {
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                //richTextBox1.Clear();
            }


            radioButton2.Checked = true;
            

            if (tabControl2.SelectedTab.Text.Equals("ORDER"))
            {
                button2.Visible = true;
                button5.Visible = false;
            }
            else
            {
                button2.Visible = false;
                button5.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            if (radioButton1.Checked == true)
            {
                b = true;
                label5.Visible = true;
                label5.Text = "Additional cost is 30 Rs. ";
              
            }
            else if (radioButton2.Checked == true)
            {
                b = false;
                label5.Visible = false;
            }

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedTab.Text.Equals("ORDER"))
            {
                button2.Visible = true;
                button5.Visible = false;
            }
            else
            {
                button2.Visible = false;
                button5.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            richTextBox1.Clear();
             for (int i = 1111; i < 9999; i++)
            {
                n = new Random().Next(1111,9999);
            }

            if (tax != 0)
            {
                


                richTextBox1.AppendText("-------------INVOICE--------------");
                richTextBox1.AppendText("\nOrderNumber:" + n.ToString());
                   
                richTextBox1.AppendText("\nitems:::::::::Qty:::::::::Price\n");

                for (int i = 0; i < listBox1.Items.Count; i++)
                 {

                   String s = listBox1.Items[i].ToString();
                    //MessageBox.Show(s);
                    String[] str = s.Split('-', '=');
                   
                    richTextBox1.AppendText("\n" + str[0] + "   ----" + str[1] + "   ----" + str[2]);

                }
                richTextBox1.AppendText("\n----------------------------------");

                if (b)
                {
                    richTextBox1.AppendText("\n--------------Home Delivery:30");
                }
                    richTextBox1.AppendText("\n--------------Tax Amount:" + tax.ToString());
                    richTextBox1.AppendText("\n--------------Total Amount:" + total.ToString());
               

            }
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
