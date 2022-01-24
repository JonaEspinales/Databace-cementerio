using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace capadatos
{
    public class DEmpleados
    {
        private int _id_empleado;
        private string _nombre;
        private string _apellidos;
        private string _cedula;
        private string _correo;
        private DateTime _fecha_nacimiento;
        private string _direcccion;
        private string _tipo_cargo;
        private string _genero;
        private string _textobuscar;

        public int Id_empleado { get => _id_empleado; set => _id_empleado = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public DateTime Fecha_nacimiento { get => _fecha_nacimiento; set => _fecha_nacimiento = value; }
        public string Direccion { get => _direcccion; set => _direcccion = value; }
        public string Tipo_cargo { get => _tipo_cargo; set => _tipo_cargo = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        public DEmpleados()
        {
        }

        public DEmpleados(int id_empleado, string nombre, string apellidos, string cedula, string correo, DateTime fecha_nacimiento, string direcccion, string tipo_cargo, string genero, string textobuscar)
        {
            Id_empleado = id_empleado;
            Nombre = nombre;
            Apellidos = apellidos;
            Cedula = cedula;
            Correo = correo;
            Fecha_nacimiento = fecha_nacimiento;
            Direccion = direcccion;
            Tipo_cargo = tipo_cargo;
            Genero = genero;
            Textobuscar = textobuscar;
        }

        public string insertarempleado(DEmpleados empleado)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.cn;
                sqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlCon;
                SqlCmd.CommandText = "spinsertar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_empleado = new SqlParameter();
                ParId_empleado.ParameterName = "@id_empleado";
                ParId_empleado.SqlDbType = SqlDbType.Int;
                ParId_empleado.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_empleado);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = empleado.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 80;
                ParApellidos.Value = empleado.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParGenero = new SqlParameter();
                ParGenero.ParameterName = "@genero";
                ParGenero.SqlDbType = SqlDbType.VarChar;
                ParGenero.Size = 10;
                ParGenero.Value = empleado.Genero;
                SqlCmd.Parameters.Add(ParGenero);

                SqlParameter ParFechanac = new SqlParameter();
                ParFechanac.ParameterName = "@fecha_nacimiento";
                ParFechanac.SqlDbType = SqlDbType.DateTime;
                ParFechanac.Value = empleado.Fecha_nacimiento;
                SqlCmd.Parameters.Add(ParFechanac);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direcccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 30;
                ParDireccion.Value = empleado.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParCedula = new SqlParameter();
                ParCedula.ParameterName = "@cedula";
                ParCedula.SqlDbType = SqlDbType.VarChar;
                ParCedula.Size = 10;
                ParCedula.Value = empleado.Cedula;
                SqlCmd.Parameters.Add(ParCedula);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 30;
                ParCorreo.Value = empleado.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParTipo_Cargo = new SqlParameter();
                ParTipo_Cargo.ParameterName = "@tipo_cargo";
                ParTipo_Cargo.SqlDbType = SqlDbType.VarChar;
                ParTipo_Cargo.Size = 30;
                ParTipo_Cargo.Value = empleado.Tipo_cargo;
                SqlCmd.Parameters.Add(ParTipo_Cargo);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "no se  ingreso el registro";


                return rpta;
            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }


            return rpta;
        }
        public string editarempleado(DEmpleados empleado)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.cn;
                sqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlCon;
                SqlCmd.CommandText = "speditar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_empleado = new SqlParameter();
                ParId_empleado.ParameterName = "@id_empleado";
                ParId_empleado.SqlDbType = SqlDbType.Int;
                ParId_empleado.Value = empleado.Id_empleado;
                SqlCmd.Parameters.Add(ParId_empleado);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = empleado.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 80;
                ParApellidos.Value = empleado.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParGenero = new SqlParameter();
                ParGenero.ParameterName = "@genero";
                ParGenero.SqlDbType = SqlDbType.VarChar;
                ParGenero.Size = 10;
                ParGenero.Value = empleado.Genero;
                SqlCmd.Parameters.Add(ParGenero);

                SqlParameter ParFechanac = new SqlParameter();
                ParFechanac.ParameterName = "@fecha_nacimiento";
                ParFechanac.SqlDbType = SqlDbType.DateTime;
                ParFechanac.Value =empleado.Fecha_nacimiento;
                SqlCmd.Parameters.Add(ParFechanac);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direcccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 30;
                ParDireccion.Value = empleado.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParCedula = new SqlParameter();
                ParCedula.ParameterName = "@cedula";
                ParCedula.SqlDbType = SqlDbType.VarChar;
                ParCedula.Size = 10;
                ParCedula.Value = empleado.Cedula;
                SqlCmd.Parameters.Add(ParCedula);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 10;
                ParCorreo.Value = empleado.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParTipo_Cargo = new SqlParameter();
                ParTipo_Cargo.ParameterName = "@tipo_cargo";
                ParTipo_Cargo.SqlDbType = SqlDbType.VarChar;
                ParTipo_Cargo.Size = 30;
                ParTipo_Cargo.Value = empleado.Tipo_cargo;
                SqlCmd.Parameters.Add(ParTipo_Cargo);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "no se  actualizo el registro";


                return rpta;
            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }


            return rpta;
        }

        public string eliminarempleado(DEmpleados empleado)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.cn;
                sqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlCon;
                SqlCmd.CommandText = "speliminar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_empleado = new SqlParameter();
                ParId_empleado.ParameterName = "@id_empleado";
                ParId_empleado.SqlDbType = SqlDbType.Int;
                ParId_empleado.Value = empleado.Id_empleado;
                SqlCmd.Parameters.Add(ParId_empleado);



                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "no se  elimino el registro";


                return rpta;
            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }


            return rpta;
        }

        public DataTable mostrarempleado()
        {
            DataTable dtresultado = new DataTable("EMPLEADO");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.cn;
                sqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlCon;
                SqlCmd.CommandText = "spmostrar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqladat = new SqlDataAdapter(SqlCmd);
                sqladat.Fill(dtresultado);
            }
            catch (Exception ex)
            {

                dtresultado = null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }


            return dtresultado;
        }

        public DataTable buscarempleadonombre(DEmpleados empleado)
        {
            DataTable dtresultado = new DataTable("EMPLEADO");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.cn;
                sqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlCon;
                SqlCmd.CommandText = "spbuscar_empleado_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 100;
                ParTextobuscar.Value = empleado.Textobuscar;
                SqlCmd.Parameters.Add(ParTextobuscar);

                SqlDataAdapter sqladat = new SqlDataAdapter(SqlCmd);
                sqladat.Fill(dtresultado);
            }
            catch (Exception ex)
            {

                dtresultado = null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }


            return dtresultado;
        }

        public DataTable buscarempleadoapellidos(DEmpleados empleado)
        {
            DataTable dtresultado = new DataTable("EMPLEADO");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.cn;
                sqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlCon;
                SqlCmd.CommandText = "spbuscar_empleado_apellidos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 100;
                ParTextobuscar.Value = empleado.Textobuscar;
                SqlCmd.Parameters.Add(ParTextobuscar);

                SqlDataAdapter sqladat = new SqlDataAdapter(SqlCmd);
                sqladat.Fill(dtresultado);
            }
            catch (Exception ex)
            {

                dtresultado = null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }


            return dtresultado;
        }

        public DataTable buscarempleadocedula(DEmpleados empleado)
        {
            DataTable dtresultado = new DataTable("EMPLEADO");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.cn;
                sqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlCon;
                SqlCmd.CommandText = "spbuscar_empleado_cedula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 100;
                ParTextobuscar.Value = empleado.Textobuscar;
                SqlCmd.Parameters.Add(ParTextobuscar);

                SqlDataAdapter sqladat = new SqlDataAdapter(SqlCmd);
                sqladat.Fill(dtresultado);
            }
            catch (Exception ex)
            {

                dtresultado = null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }


            return dtresultado;
        }
    }
}
