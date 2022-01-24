using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capanegocio;

namespace capapresentacion
{
    public partial class CrudEmpleados : Form
    {
        bool esnuevo = false;
        bool eseditar = false;
        public CrudEmpleados()
        {
            InitializeComponent();
        }
        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistemas de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistemas de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void limpiar()
        {
            this.txtid.Text = string.Empty;
            this.txtnombre.Text = string.Empty;
            this.txtapellido.Text = string.Empty;
            this.cbogenero.SelectedValue = "M";
            this.txtdireccion.Text = string.Empty;
            this.txtcedula.Text = string.Empty;
            this.txtcorreo.Text = string.Empty;
            this.cbotipo.Text = string.Empty;
        }
        private void habilitar(bool valor)
        {
            this.txtid.ReadOnly = true;
            this.txtnombre.ReadOnly = !valor;
            this.txtapellido.ReadOnly = !valor;
            this.txtdireccion.ReadOnly = !valor;
            this.txtcedula.ReadOnly = !valor;
            this.txtcorreo.ReadOnly = !valor;
            this.cbogenero.Enabled = valor;
            this.dtfecha.Enabled = valor;
            this.cbotipo.Enabled = valor;

        }
        private void botones()
        {
            if (esnuevo || this.eseditar)
            {
                habilitar(true);
                btnnuevo.Enabled = false;
                this.btnguardar.Enabled = true;
                this.btneditar.Enabled = false;
                this.btncancelar.Enabled = true;

            }
            else
            {
                habilitar(false);
                btnnuevo.Enabled = true;
                this.btnguardar.Enabled = false;
                this.btneditar.Enabled = true;
                this.btncancelar.Enabled = false;


            }
        }
        private void mostrarempleados()
        {
            this.datalistado.DataSource = NEmpleados.mostrarempleado();
            this.ocultarcolumnas();
            this.lbltotal.Text = "la cantidad total de empleados es :" + Convert.ToString(datalistado.Rows.Count);
        }
        private void ocultarcolumnas()
        {
            this.datalistado.Columns[0].Visible = false;
            this.datalistado.Columns[1].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            esnuevo = true;
            botones();
            limpiar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtnombre.Text == string.Empty || this.txtapellido.Text == string.Empty ||
                    this.txtcedula.Text == string.Empty)
                {
                    mensajeerror("faltan datos por ingresar seran remarcados");
                    this.iconoerror.SetError(this.txtnombre, "ingresar nombre");
                    this.iconoerror.SetError(this.txtapellido, "ingresar apelldos");
                    this.iconoerror.SetError(this.txtcedula, "ingresar cedula");

                }
                else
                {
                    if (esnuevo)
                    {
                        rpta = NEmpleados.insertarempleado(this.txtnombre.Text.Trim().ToUpper(), this.txtapellido.Text.Trim().ToUpper(), this.cbogenero.Text, this.dtfecha.Value, this.txtdireccion.Text.Trim(),
                            this.txtcedula.Text.Trim(), this.txtcorreo.Text.Trim(), this.cbotipo.Text);
                            
                            /*(this.txtnombre.Text.Trim().ToUpper(), this.txtapellido.Text.Trim().ToUpper(), this.cbogenero.Text, this.dtfecha.Value, this.txtdireccion.Text.Trim(),
                            this.txtcedula.Text.Trim(), this.txtcorreo.Text.Trim(), this.cbotipo.Text);*/
                    }
                    else
                    {
                        rpta = NEmpleados.editarempleado(Convert.ToInt32(this.txtid.Text), this.txtnombre.Text.Trim().ToUpper(), this.txtapellido.Text.Trim().ToUpper(), this.cbogenero.Text, this.dtfecha.Value, this.txtdireccion.Text.Trim(),
                            this.txtcedula.Text.Trim(), this.txtcorreo.Text.Trim(), this.cbotipo.Text);
                    }
                    if (rpta.Equals("OK"))
                    {
                        if (esnuevo)
                        {
                            this.mensajeok("se inserto el empleado satisfactoriamente");
                        }
                        else
                        {
                            this.mensajeok("se actualizo el empleado satisfactoriamente");
                        }

                    }
                    else
                    {
                        this.mensajeerror(rpta);
                    }
                    this.esnuevo = false;
                    this.eseditar = false;
                    botones();
                    this.limpiar();
                    this.mostrarempleados();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void CrudEmpleados_Load(object sender, EventArgs e)
        {
            this.mostrarempleados();
            this.botones();
        }

        private void datalistado_DoubleClick(object sender, EventArgs e)
        {
            this.txtid.Text = Convert.ToString(datalistado.CurrentRow.Cells["id_empleado"].Value);
            this.txtnombre.Text = Convert.ToString(datalistado.CurrentRow.Cells["nombre"].Value);
            this.txtapellido.Text = Convert.ToString(datalistado.CurrentRow.Cells["apellidos"].Value);
            this.cbogenero.SelectedValue = Convert.ToString(datalistado.CurrentRow.Cells["genero"].Value);
            this.dtfecha.Text = Convert.ToString(datalistado.CurrentRow.Cells["fecha_nacimiento"].Value);
            this.txtdireccion.Text = Convert.ToString(datalistado.CurrentRow.Cells["direcccion"].Value);
            this.txtcedula.Text = Convert.ToString(datalistado.CurrentRow.Cells["cedula"].Value);
            this.txtcorreo.Text = Convert.ToString(datalistado.CurrentRow.Cells["correo"].Value);
            this.cbotipo.SelectedValue = Convert.ToString(datalistado.CurrentRow.Cells["tipo_cargo"].Value);
            this.tabControl1.SelectedIndex = 1;
        }

        private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)datalistado.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (!this.txtid.Text.Equals(""))
            {
                this.eseditar = true;
                this.botones();
                this.mostrarempleados();
            }
            else
            {
                this.mensajeerror("seleccione el registro a modificar");
            }
        }
        private void buscarempleadoxnombre(string texto)
        {
            this.datalistado.DataSource = NEmpleados.buscarempleadonombre(texto);
            this.ocultarcolumnas();
        }

        private void buscarempleadoxapellidos(string texto)
        {
            this.datalistado.DataSource = NEmpleados.buscarempleadoapellidos(texto);
            this.ocultarcolumnas();
        }
        private void buscarempleadoxcedula(string texto)
        {
            this.datalistado.DataSource = NEmpleados.buscarempleadocedula(texto);
            this.ocultarcolumnas();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (this.cbobuscar.Text.Equals("NOMBRE"))
            {
                this.buscarempleadoxnombre(this.txtbuscar.Text);
            }
            if (this.cbobuscar.Text.Equals("APELLIDOS"))
            {
                this.buscarempleadoxapellidos(this.txtbuscar.Text);
            }
            if (this.cbobuscar.Text.Equals("CEDULA"))
            {
                this.buscarempleadoxcedula(this.txtbuscar.Text);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.datalistado.Columns[0].Visible = true;
            }
            else
            {
                this.datalistado.Columns[0].Visible = false;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea eliminar las filas seleccionadas ?", " Empleados", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    string rpta = "";
                    foreach (DataGridViewRow row in datalistado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            rpta = NEmpleados.eliminarempleado(codigo);

                            if (rpta.Equals("OK"))
                            {
                                this.mensajeok("se elimino el empleado correctamente");
                            }
                            else
                            {
                                this.mensajeerror(rpta);
                            }
                        }
                    }
                    this.mostrarempleados();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
 }

