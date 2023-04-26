using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.WinForm.Utils
{
    public abstract class ExceptionManager
    {
        public static string GetMessage(Exception exception)
        {
            System.Data.SqlClient.SqlException sqlEx = exception as System.Data.SqlClient.SqlException;           

            if (sqlEx != null && sqlEx.Number == 2627)
            {
                string value = sqlEx.Message.Split('(', ')')[1];
                return "Registro duplicado, pruebe con otro.\nEl valor duplicado es:\n    ■ " + value;
            }
            else
            {
                return "Se ha producido un error.\nDetalles:\n" + exception.Message;
            }
        }
    }
}
