using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Linq;
namespace BDtoDatagridView
{
   //Codigo autogenerado por YQP PRODUCCIONES - Suscribete a mi canal para ver mas contenidos
   public class Conexion
   {
       public static SqlConnection con = null;
       public static string Ruta
       {
           get {
               return "Data Source=LAPTOP-8VVMNLRS\\SQLEXPRESS;Initial Catalog=bdproyecto01;Persist Security Info=True;User ID=user;Password=glzflores";
           }
       }
       public static string Message { get; set; }
       public static SqlConnection Open()
       {
           con = null;
           try
           {
               con = new SqlConnection(Ruta);
               con.Open();
               Message = "[Conección Establecida]";
           }
           catch (Exception ex)
           {
               Message = "Ocurrió un grave error al intentar coenctarse con la base de datos " + ex.Message;
               con = null;
           }
           return con;
       }
       public static void Close() {
           con = null;
           Message = "[Conección Cerrada]";
       }
   }
}

