using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using capadatos;

namespace capapresentacion
{
    public partial class TSevicio : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        public TSevicio()
        {
            InitializeComponent();
            cn = new SqlConnection(Conexion.cn);
            transferir();
           
        }
        public void transferir()
        {
            try
            {
                //aqui todo el llamado
                dataGridView1.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("select * from PAGO", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString()/*, dr[2].ToString()*/);
                }
                dr.Close();
                cn.Close();
                dataGridView1.ClearSelection();

            }
            catch (Exception ex)
            {

                cn.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("desea tranferir esa cantidad?", "confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand();
                    cm.Connection = cn;
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "PA_SERVICIO";
                    cm.Parameters.AddWithValue("@PIDSERVICIOPAGO", int.Parse(txtorigen.Text));
                    cm.Parameters.AddWithValue("@PIDCUENTAPAGO", int.Parse(txtdestino.Text));
                    cm.Parameters.AddWithValue("@PVALORSERVICIO", double.Parse(txtvalor.Text));
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("transaccion correctamente", "confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "NO SE PUEDE EJECUTAR LA TRANSACTIONS ESTA VIOLANDO LA RESTRICCION");
                //MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clear()
        {
            txtorigen.Clear();
            txtdestino.Clear();
            txtvalor.Clear();
            txtorigen.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("desea tranferir esa cantidad?", "confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand();
                    cm.Connection = cn;
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "PA_SERVICIO_NO";
                    cm.Parameters.AddWithValue("@PIDSERVICIOPAGO", int.Parse(txtorigen.Text));
                    cm.Parameters.AddWithValue("@PIDCUENTAPAGO", int.Parse(txtdestino.Text));
                    cm.Parameters.AddWithValue("@PVALORSERVICIO", double.Parse(txtvalor.Text));
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("transaccion correctamente", "confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "NO SE PUEDE EJECUTAR LA TRANSACTIONS ESTA VIOLANDO LA RESTRICCION");
                //MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("select * from PAGO", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString()/*, dr[2].ToString()*/);
                }
                dr.Close();
                cn.Close();
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {

                cn.Close();
                //MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("select * from SERVICIO", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView2.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                }
                dr.Close();
                cn.Close();
                dataGridView2.ClearSelection();
            }
            catch (Exception ex)
            {

                cn.Close();
                //MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView3.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("select * from TRANSFERIR", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView3.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                }
                dr.Close();
                cn.Close();
                dataGridView3.ClearSelection();
            }
            catch (Exception ex)
            {

                cn.Close();
                //MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TSevicio_Load(object sender, EventArgs e)
        {

        }
    }
}
