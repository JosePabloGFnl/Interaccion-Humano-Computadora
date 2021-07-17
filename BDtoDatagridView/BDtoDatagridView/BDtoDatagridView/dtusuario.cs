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
   public class dtusuario
     {
        // using System.Data;
        // using System.Data.SqlClient;
        public static MessageBoxIcon MessageBoxIcon { get; set; }
        public static DataTable Fill() {DataTable dt = new DataTable();if ( Conexion.Open() != null){ SqlDataAdapter da = new SqlDataAdapter("Select * from dbo.Base_Med" , Conexion.Open()); da.Fill(dt); Conexion.Close(); }  else { dt = null; } return dt; }
        public static DataTable SelectXID_Med( string ID_Med) { string Query = "SELECT * FROM dbo.Base_Med WHERE ID_Med = '" + ID_Med + "'"; DataTable dt = new DataTable();if (Conexion.Open() != null){ SqlDataAdapter da = new SqlDataAdapter(Query ,Conexion.Open()); da.Fill(dt); Conexion.Close(); }  else { dt = null; } return dt; }

        public static string Actualizar(  string ID_Med, string Nombre, string Descripción, string Indicaciones, string ViayDosis, string Generalidades, string ID_Riesgo_Embarazo, string EfectosAdversos, string Contradicciones, string Precauciones, string Interacciones, string ID_Grupo) 
         { 
            string result = "";
             try
            {
                SqlCommand cmd = new SqlCommand("UPDATE dbo.Base_Med SET ID_Med=@ID_Med, Nombre=@Nombre, Descripción=@Descripción, Indicaciones=@Indicaciones, ViayDosis=@ViayDosis, Generalidades=@Generalidades, ID_Riesgo_Embarazo=@ID_Riesgo_Embarazo, EfectosAdversos=@EfectosAdversos, Contradicciones=@Contradicciones, Precauciones=@Precauciones, Interacciones=@Interacciones, ID_Grupo=@ID_Grupo WHERE ID_Med = @ID_Med",Conexion.Open());
                cmd.Parameters.AddWithValue("@ID_Med", ID_Med);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Descripción", Descripción);
                cmd.Parameters.AddWithValue("@Indicaciones", Indicaciones);
                cmd.Parameters.AddWithValue("@ViayDosis", ViayDosis);
                cmd.Parameters.AddWithValue("@Generalidades", Generalidades);
                cmd.Parameters.AddWithValue("@ID_Riesgo_Embarazo", ID_Riesgo_Embarazo);
                cmd.Parameters.AddWithValue("@EfectosAdversos", EfectosAdversos);
                cmd.Parameters.AddWithValue("@Contradicciones", Contradicciones);
                cmd.Parameters.AddWithValue("@Precauciones", Precauciones);
                cmd.Parameters.AddWithValue("@Interacciones", Interacciones);
                cmd.Parameters.AddWithValue("@ID_Grupo", ID_Grupo);
                cmd.ExecuteNonQuery(); 
                Conexion.Close(); 
                result = "Los datos actualizados correctamente en la base de datos. "; 
                ;
            }
            catch (Exception ex) { result = "Ocurrió un error al actualizar: " + ex.Message;}
            return result;
        }

        public static string Insertar(  string ID_Med, string Nombre, string Descripción, string Indicaciones, string ViayDosis, string Generalidades, string ID_Riesgo_Embarazo, string EfectosAdversos, string Contradicciones, string Precauciones, string Interacciones, string ID_Grupo) 
         { 
            string result = "";
             try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Base_Med (ID_Med,Nombre,Descripción,Indicaciones,ViayDosis,Generalidades,ID_Riesgo_Embarazo,EfectosAdversos,Contradicciones,Precauciones,Interacciones,ID_Grupo) VALUES (@ID_Med,@Nombre,@Descripción,@Indicaciones,@ViayDosis,@Generalidades,@ID_Riesgo_Embarazo,@EfectosAdversos,@Contradicciones,@Precauciones,@Interacciones,@ID_Grupo)",Conexion.Open());
                cmd.Parameters.AddWithValue("@ID_Med", ID_Med);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Descripción", Descripción);
                cmd.Parameters.AddWithValue("@Indicaciones", Indicaciones);
                cmd.Parameters.AddWithValue("@ViayDosis", ViayDosis);
                cmd.Parameters.AddWithValue("@Generalidades", Generalidades);
                cmd.Parameters.AddWithValue("@ID_Riesgo_Embarazo", ID_Riesgo_Embarazo);
                cmd.Parameters.AddWithValue("@EfectosAdversos", EfectosAdversos);
                cmd.Parameters.AddWithValue("@Contradicciones", Contradicciones);
                cmd.Parameters.AddWithValue("@Precauciones", Precauciones);
                cmd.Parameters.AddWithValue("@Interacciones", Interacciones);
                cmd.Parameters.AddWithValue("@ID_Grupo", ID_Grupo);
                cmd.ExecuteNonQuery(); 
                Conexion.Close(); 
                result = "Los datos insertados correctamente en la base de datos. "; 
                ;
            }
            catch (Exception ex) { result = "Ocurrió un error al insertar: " + ex.Message; }
            return result;
        }

        public static string Eliminar(string ID_Med) {
           string r = "";
           if (Conexion.Open() != null)
           {
               try
               {
                   SqlCommand cmd = new SqlCommand("Delete from dbo.Base_Med where ID_Med = '" + ID_Med + "'", Conexion.Open());
                   cmd.ExecuteNonQuery();
                   Conexion.Close();
                   r = "Se eliminó correctamente del sistema";
               }
               catch (Exception ex)
               {
                   r = "Ocurrió un error al intentar eliminar el dato solicitado " + ex.Message;
               }
            }
            return r;
         }

        public static bool ExisteID_Med(string ID_Med)
        {
            bool result = false;
            if (SelectXID_Med(ID_Med).Rows.Count > 0) { result = true; } else { result = false; }
            return result;
        }
    }
}

