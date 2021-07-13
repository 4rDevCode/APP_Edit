//*******************************************************************************************************************************************
//*                                                                                                                                         *
//*                                                        Jefrinsson J F Calderon                                                          *
//*                                               doblejota4r@gmail.com | jefrinssonjfcalderon@gmail.com                                    *
//*                                                                                                                                         *
//*******************************************************************************************************************************************

//:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
//              IMPORTACIONES USADAS
//:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
using System;
using System.Data;
using System.Data.SqlClient;

namespace AppEdit
{
    public class Clase
    {
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //              VARIABLES
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        public static Conexion CNX = new Conexion();
        private static string o4R_SERVER = "."; //
        private static string o4R_DATABASE = "RSCONCAR";
        private static string o4R_USER = "sa";
        private static string o4R_PASSWORD = "yoleisy2018@"; //
        private static string o4R_PORT = "1433";
        public static void Inicializar()
        {
            C = "Data Source = " + o4R_SERVER + "," + o4R_PORT + "; Initial Catalog = " + o4R_DATABASE + "; " +
                        "Persist Security Info = False; Integrated Security = FALSE; UID = " + o4R_USER + "; " +
                        "PWD = " + o4R_PASSWORD + "; Connect Timeout = 2";
        }
        public static string C;

        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //              CONSTRUCTOR
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        public Clase() { }

        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //              FUNCIONES
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        public Boolean TextConnection()
        {
            try
            {
                String cadena = "Data Source = " + o4R_SERVER + "," + o4R_PORT + "; Initial Catalog = " + o4R_DATABASE + "; " +
                            "Persist Security Info = False; Integrated Security = FALSE; UID = " + o4R_USER + "; " +
                            "PWD = " + o4R_PASSWORD + "; Connect Timeout = 2";
                SqlConnection CON = new SqlConnection(cadena);
                CON.Open(); return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DataTable ObtenerZVERS(String Emp, String Año)
        {
            DataTable DT = new DataTable();
            try
            {
                CNX.Conectar();
                string SQL = "SELECT ZVERS FROM CT00"+Emp +"CONT"+Año;
                SqlDataAdapter DA = new SqlDataAdapter(SQL, CNX.CON);
                DA.Fill(DT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            CNX.Desconectar();
            return DT;
        }
        public DataTable SetZVERS(String Emp, String Año)
        {
            DataTable DT = new DataTable();
            try
            {
                CNX.Conectar();
                string SQL = "UPDATE CT00" + Emp + "CONT" + Año + " SET ZVERS = '13.32' SELECT 'OK'";
                SqlDataAdapter DA = new SqlDataAdapter(SQL, CNX.CON);
                DA.Fill(DT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            CNX.Desconectar();
            return DT;
        }

    }
}
