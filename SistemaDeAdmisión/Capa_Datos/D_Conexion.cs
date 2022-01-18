using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;
namespace Capa_Datos
{
    public class D_Conexion
    {
        private SqlConnection Conexion = new SqlConnection();
        //  Abre la conexion a la base de datos
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        //Cierra la conexion a la base de datos
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
