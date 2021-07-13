//*******************************************************************************************************************************************
//*                                                                                                                                         *
//*                                                        Jefrinsson J F Calderon                                                          *
//*                                               doblejota4r@gmail.com | jefrinssonjfcalderon@gmail.com                                    *
//*                                                                                                                                         *
//*******************************************************************************************************************************************

//:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
//              IMPORTACIONES USADAS
//:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

using System.Data;
using System.Data.SqlClient;

namespace AppEdit
{
    public class Conexion
    {
        public SqlConnection CON;

        public void Conectar()
        {
            Clase.Inicializar();
            CON = new SqlConnection(Clase.C);
            if (CON.State == ConnectionState.Closed) { CON.Open(); }
        }
        public void Desconectar()
        {
            Clase.Inicializar();
            CON = new SqlConnection(Clase.C);
            if (CON.State == ConnectionState.Open) { CON.Close(); }
        }
    }
}
