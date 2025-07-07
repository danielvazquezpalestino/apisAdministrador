using Entities;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class AdAreaComun
    {
        readonly SqlConnection Connection;
        public AdAreaComun()
        {
            Connection = new SqlConnection(Conexion.ConectionString);
        }


        public void AgregarAreaComun(AreaComun areacomun)
        {
            string query = "INSERT INTO dbo.Areas (Nombre ,Estatus, HrInicioActividades, HrFinActividades, Anticipacion, MaxHrsReservacion, RequiereAutorizacion) " +
            "VALUES  (@Nombre ,@Estatus, @HrInicioActividades, @HrFinActividades, @Anticipacion, @MaxHrsReservacion, @RequiereAutorizacion )";
            SqlCommand comand = Connection.CreateCommand();
            comand.Parameters.AddWithValue("@Nombre", areacomun.Nombre);
            comand.Parameters.AddWithValue("@Estatus", areacomun.Estatus);
            comand.Parameters.AddWithValue("@HrInicioActividades", areacomun.HrInicioActividades);
            comand.Parameters.AddWithValue("@HrFinActividades", areacomun.HrFinActividades);
            comand.Parameters.AddWithValue("@Anticipacion", areacomun.Anticipacion);
            comand.Parameters.AddWithValue("@MaxHrsReservacion", areacomun.MaxHrsReservacion);
            comand.Parameters.AddWithValue("@RequiereAutorizacion", areacomun.RequiereAutorizacion);
            comand.CommandText = query;
            comand.CommandType = CommandType.Text;
            if (Connection.State != ConnectionState.Open)
            { Connection.Open(); }
            comand.ExecuteNonQuery();
            Connection.Close();

        }

        public void ActualizarAreaComun(AreaComun areacomun)
        {
            string query = "UPDATE dbo.Areas SET " +
                "Nombre = @Nombre, Estatus = @Estatus, " +
                "HrInicioActividades = @HrInicioActividades, " +
                "HrFinActividades = @HrFinActividades, " +
                "Anticipacion = @Anticipacion, " +
                "MaxHrsReservacion = @MaxHrsReservacion, " +
                "RequiereAutorizacion = @RequiereAutorizacion " +
                "WHERE ID_area = @ID_area";
            
            SqlCommand comand = Connection.CreateCommand();
            comand.Parameters.AddWithValue("@ID_area", areacomun.ID_area);
            comand.Parameters.AddWithValue("@Nombre", areacomun.Nombre);
            comand.Parameters.AddWithValue("@Estatus", areacomun.Estatus);
            comand.Parameters.AddWithValue("@HrInicioActividades", areacomun.HrInicioActividades);
            comand.Parameters.AddWithValue("@HrFinActividades", areacomun.HrFinActividades);
            comand.Parameters.AddWithValue("@Anticipacion", areacomun.Anticipacion);
            comand.Parameters.AddWithValue("@MaxHrsReservacion", areacomun.MaxHrsReservacion);
            comand.Parameters.AddWithValue("@RequiereAutorizacion", areacomun.RequiereAutorizacion);
            
            comand.CommandText = query;
            comand.CommandType = CommandType.Text;
            
            if (Connection.State != ConnectionState.Open)
            { Connection.Open(); }
            
            comand.ExecuteNonQuery();
            Connection.Close();
        }

        public AreaComun ObtenerAreaComun(int Id)
        {
           
            string query = "SELECT * FROM dbo.Areas  WHERE ID_area =  @ID_area ";
            SqlCommand comand = Connection.CreateCommand();
            AreaComun areacomun = new AreaComun();
            if (Connection.State != ConnectionState.Open)
            { Connection.Open(); }
            comand.Parameters.AddWithValue("@ID_area", Id);
            comand.CommandText = query;
            comand.CommandType = CommandType.Text;
            IDataReader reader = comand.ExecuteReader();
            if (reader.Read()) 
            {
                areacomun.ID_area = reader.GetInt32(reader.GetOrdinal("ID_area"));
                areacomun.Nombre = reader.GetString(reader.GetOrdinal(nameof(areacomun.Nombre)));
                areacomun.Estatus = reader.GetString(reader.GetOrdinal(nameof(areacomun.Estatus)));
                areacomun.HrInicioActividades = reader.GetByte(reader.GetOrdinal(nameof(areacomun.HrInicioActividades)));
                areacomun.HrFinActividades = reader.GetByte(reader.GetOrdinal(nameof( areacomun.HrFinActividades)));
                areacomun.Anticipacion = reader.GetInt32(reader.GetOrdinal(nameof(areacomun.Anticipacion)));
                areacomun.MaxHrsReservacion = reader.GetInt32(reader.GetOrdinal(nameof(areacomun.MaxHrsReservacion)));
                areacomun.RequiereAutorizacion = reader.GetBoolean(reader.GetOrdinal(nameof(areacomun.RequiereAutorizacion)));

            }
            Connection.Close();
            return areacomun;
        }

        public void EliminarAreaComun(int Id) 
        {
            string query = "DELETE  FROM dbo.Areas WHERE ID_area = @ID_area";
            SqlCommand comand = Connection.CreateCommand();
            if (Connection.State != ConnectionState.Open)
            { Connection.Open(); }
            comand.Parameters.AddWithValue("@ID_area", Id);
            comand.CommandText = query;
            comand.CommandType = CommandType.Text;
            comand.ExecuteNonQuery();
            Connection.Close();

        }

    }
}
