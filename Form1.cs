using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(input1.Text);
            var num2 = Convert.ToInt32(input2.Text);

            var num3 = num1 + num2;

            result.Text = num3.ToString();
        }

        /// <summary>
        /// Subtract
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(input1.Text);
            var num2 = Convert.ToInt32(input2.Text);

            var num3 = num1 - num2;

            result.Text = num3.ToString();
        }

        /// <summary>
        /// Multiply
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(input1.Text);
            var num2 = Convert.ToInt32(input2.Text);

            var num3 = num1 * num2;

            result.Text = num3.ToString();
        }

        /// <summary>
        /// Divide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(input1.Text);
            var num2 = Convert.ToInt32(input2.Text);

            var num3 = num1 / num2;

            result.Text = num3.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select top 10 FirstName, LastName from person.person", Properties.Settings.Default.connection);
            DataSet ds = new DataSet();
            da.Fill(ds);

            //dataGridView1.Columns[0].Width = 100;
            //dataGridView1.Columns[1].Width = 100;

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            input1.Text = "";
            input2.Text = "";
            result.Text = "";

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }
    }
}
