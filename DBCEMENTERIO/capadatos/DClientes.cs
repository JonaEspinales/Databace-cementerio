using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace capadatos
{
    public class DClientes
    {
        private int _id_cliente;
        private string _nombre;
        private string _apellidos;
        private string _genero;
        private DateTime _fecha_nacimiento;
        private string _direccion;
        private string _cedula;
        private string _correo;
        private string _textobuscar;

        public int Id_cliente { get => _id_cliente; set => _id_cliente = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public DateTime Fecha_nacimiento { get => _fecha_nacimiento; set => _fecha_nacimiento = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        public DClientes(int id_cliente, string nombre, string apellidos, string genero, DateTime fecha_nacimiento, string direccion, string cedula, string correo, string textobuscar)
        {
            Id_cliente = id_cliente;
            Nombre = nombre;
            Apellidos = apellidos;
            Genero = genero;
            Fecha_nacimiento = fecha_nacimiento;
            Direccion = direccion;
            Cedula = cedula;
            Correo = correo;
            Textobuscar = textobuscar;
        }

        public DClientes()
        {
        }   

        public string insertarcliente(DClientes cliente)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.cn;
                sqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlCon;
                SqlCmd.CommandText = "spinsertar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_cliente = new SqlParameter();
                ParId_cliente.ParameterName = "@id_cliente";
                ParId_cliente.SqlDbType = SqlDbType.Int;
                ParId_cliente.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId_cliente);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = cliente.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 80;
                ParApellidos.Value = cliente.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParGenero = new SqlParameter();
                ParGenero.ParameterName = "@genero";
                ParGenero.SqlDbType = SqlDbType.VarChar;
                ParGenero.Size = 10;
                ParGenero.Value = cliente.Genero;
                SqlCmd.Parameters.Add(ParGenero);

                SqlParameter ParFechanac = new SqlParameter();
                ParFechanac.ParameterName = "@fecha_nacimiento";
                ParFechanac.SqlDbType = SqlDbType.DateTime;
                ParFechanac.Value = cliente.Fecha_nacimiento;
                SqlCmd.Parameters.Add(ParFechanac);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 30;
                ParDireccion.Value = cliente.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParCedula = new SqlParameter();
                ParCedula.ParameterName = "@cedula";
                ParCedula.SqlDbType = SqlDbType.VarChar;
                ParCedula.Size = 10;
                ParCedula.Value = cliente.Cedula;
                SqlCmd.Parameters.Add(ParCedula);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 30;
                ParCorreo.Value = cliente.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

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

        public string editarcliente(DClientes cliente)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.cn;
                sqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlCon;
                SqlCmd.CommandText = "speditar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_cliente = new SqlParameter();
                ParId_cliente.ParameterName = "@id_cliente";
                ParId_cliente.SqlDbType = SqlDbType.Int;
                ParId_cliente.Value = cliente.Id_cliente;
                SqlCmd.Parameters.Add(ParId_cliente);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = cliente.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 80;
                ParApellidos.Value = cliente.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParGenero = new SqlParameter();
                ParGenero.ParameterName = "@genero";
                ParGenero.SqlDbType = SqlDbType.VarChar;
                ParGenero.Size = 10;
                ParGenero.Value = cliente.Genero;
                SqlCmd.Parameters.Add(ParGenero);

                SqlParameter ParFechanac = new SqlParameter();
                ParFechanac.ParameterName = "@fecha_nacimiento";
                ParFechanac.SqlDbType = SqlDbType.DateTime;
                ParFechanac.Value = cliente.Fecha_nacimiento;
                SqlCmd.Parameters.Add(ParFechanac);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 30;
                ParDireccion.Value = cliente.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParCedula = new SqlParameter();
                ParCedula.ParameterName = "@cedula";
                ParCedula.SqlDbType = SqlDbType.VarChar;
                ParCedula.Size = 10;
                ParCedula.Value = cliente.Cedula;
                SqlCmd.Parameters.Add(ParCedula);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 10;
                ParCorreo.Value = cliente.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

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

        public string eliminarcliente(DClientes cliente)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.cn;
                sqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlCon;
                SqlCmd.CommandText = "speliminar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_cliente = new SqlParameter();
                ParId_cliente.ParameterName = "@id_cliente";
                ParId_cliente.SqlDbType = SqlDbType.Int;
                ParId_cliente.Value = cliente.Id_cliente;
                SqlCmd.Parameters.Add(ParId_cliente);



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

        public DataTable mostrarcliente()
        {
            DataTable dtresultado = new DataTable("CLIENTE");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.cn;
                sqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlCon;
                SqlCmd.CommandText = "spmostrar_cliente";
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

        public DataTable buscarclientenombre(DClientes cliente)
        {
            DataTable dtresultado = new DataTable("CLIENTE");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.cn;
                sqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlCon;
                SqlCmd.CommandText = "spbuscar_cliente_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 100;
                ParTextobuscar.Value = cliente.Textobuscar;
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

        public DataTable buscarclienteapellidos(DClientes cliente)
        {
            DataTable dtresultado = new DataTable("CLIENTE");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.cn;
                sqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlCon;
                SqlCmd.CommandText = "spbuscar_cliente_apellidos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 100;
                ParTextobuscar.Value = cliente.Textobuscar;
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

        public DataTable buscarclientecedula(DClientes cliente)
        {
            DataTable dtresultado = new DataTable("CLIENTE");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.cn;
                sqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlCon;
                SqlCmd.CommandText = "spbuscar_cliente_cedula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 100;
                ParTextobuscar.Value = cliente.Textobuscar;
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
