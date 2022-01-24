using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capadatos;
namespace capanegocio
{
    public class NEmpleados
    {
        public static string insertarempleado(string nombre, string apellidos, string genero, DateTime fecha_nacimiento, string direcccion, string cedula, string correo, string tipo_cargo)
        {
            DEmpleados objeto = new DEmpleados();
            objeto.Nombre = nombre;
            objeto.Apellidos = apellidos;
            objeto.Genero = genero;
            objeto.Fecha_nacimiento = fecha_nacimiento;
            objeto.Direccion = direcccion;
            objeto.Cedula = cedula;
            objeto.Correo = correo;
            objeto.Tipo_cargo = tipo_cargo;

            return objeto.insertarempleado(objeto);
        }
        public static string editarempleado(int id_empleado, string nombre, string apellidos, string genero, DateTime fecha_nacimiento, string direccion, string cedula, string correo, string tipo_cargo)
        {
            DEmpleados objeto = new DEmpleados();
            objeto.Id_empleado = id_empleado;
            objeto.Nombre = nombre;
            objeto.Apellidos = apellidos;
            objeto.Genero = genero;
            objeto.Fecha_nacimiento = fecha_nacimiento;
            objeto.Direccion = direccion;
            objeto.Cedula = cedula;
            objeto.Correo = correo;
            objeto.Tipo_cargo = tipo_cargo;

            return objeto.editarempleado(objeto);
        }
        public static string eliminarempleado(int id_empleado)
        {
            DEmpleados objeto = new DEmpleados();
            objeto.Id_empleado = id_empleado;


            return objeto.eliminarempleado(objeto);
        }
        public static DataTable mostrarempleado()
        {
            DEmpleados objeto = new DEmpleados();
            return objeto.mostrarempleado();
        }
        public static DataTable buscarempleadonombre(string textobuscar)
        {
            DEmpleados objeto = new DEmpleados();
            objeto.Textobuscar = textobuscar;
            return objeto.buscarempleadonombre(objeto);
        }

        public static DataTable buscarempleadoapellidos(string textobuscar)
        {
            DEmpleados objeto = new DEmpleados();
            objeto.Textobuscar = textobuscar;
            return objeto.buscarempleadoapellidos(objeto);
        }
        public static DataTable buscarempleadocedula(string textobuscar)
        {
            DEmpleados objeto = new DEmpleados();
            objeto.Textobuscar = textobuscar;
            return objeto.buscarempleadocedula(objeto);
        }
    }
}
