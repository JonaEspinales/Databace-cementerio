using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using capadatos;
namespace capanegocio
{
   public class NClientes
    {
        public static string insertarcliente(string nombre, string apellidos, string genero, DateTime fecha_nacimiento, string direccion, string cedula, string correo)
        {
            DClientes objeto = new DClientes();
            objeto.Nombre = nombre;
            objeto.Apellidos = apellidos;
            objeto.Genero = genero;
            objeto.Fecha_nacimiento = fecha_nacimiento;
            objeto.Direccion = direccion;
            objeto.Cedula = cedula;
            objeto.Correo = correo;

            return objeto.insertarcliente(objeto);
        }
        public static string editarcliente(int id_cliente, string nombre, string apellidos, string genero, DateTime fecha_nacimiento, string direccion, string cedula, string correo)
        {
            DClientes objeto = new DClientes();
            objeto.Id_cliente = id_cliente;
            objeto.Nombre = nombre;
            objeto.Apellidos = apellidos;
            objeto.Genero = genero;
            objeto.Fecha_nacimiento = fecha_nacimiento;
            objeto.Direccion = direccion;
            objeto.Cedula = cedula;
            objeto.Correo = correo;

            return objeto.editarcliente(objeto);
        }

        public static string eliminarcliente(int id_cliente)
        {
            DClientes objeto = new DClientes();
            objeto.Id_cliente = id_cliente;


            return objeto.eliminarcliente(objeto);
        }

        public static DataTable mostrarcliente()
        {
            DClientes objeto = new DClientes();
            return objeto.mostrarcliente();
        }
        public static DataTable buscarclientenombre(string textobuscar)
        {
            DClientes objeto = new DClientes();
            objeto.Textobuscar = textobuscar;
            return objeto.buscarclientenombre(objeto);
        }

        public static DataTable buscarclienteapellidos(string textobuscar)
        {
            DClientes objeto = new DClientes();
            objeto.Textobuscar = textobuscar;
            return objeto.buscarclienteapellidos(objeto);
        }

        public static DataTable buscarclientecedula(string textobuscar)
        {
            DClientes objeto = new DClientes();
            objeto.Textobuscar = textobuscar;
            return objeto.buscarclientecedula(objeto);
        }

    }
}
