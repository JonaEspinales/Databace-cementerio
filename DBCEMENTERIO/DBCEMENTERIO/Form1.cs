using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using capapresentacion;

namespace DBCEMENTERIO
{
    public partial class Form1 : Form
    {
        
        

        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form crudcliente = new CrudCliente();
            crudcliente.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form crudempleado = new CrudEmpleados();
            crudempleado.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form tservicio = new TSevicio();
            tservicio.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form tfallecido = new TFallecido();
            tfallecido.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
