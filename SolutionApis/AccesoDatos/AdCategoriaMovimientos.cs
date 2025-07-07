
using Entities;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class AdCategoriaMovimientos
    {
        readonly SqlConnection Connection;
        public AdCategoriaMovimientos()
        {
            Connection = new SqlConnection(Conexion.ConectionString);
        }

        public void AgregarCategoriaMovimientos(CategoriaMovimientos categoria)
        {
            string query = "INSERT INTO dbo.CategoriasMovimiento (Tipo, Nombre, Descripcion, Activo) " +
            "VALUES (@Tipo, @Nombre, @Descripcion, @Activo)";

            SqlCommand comand = Connection.CreateCommand();
            comand.Parameters.AddWithValue("@Tipo", categoria.Tipo);
            comand.Parameters.AddWithValue("@Nombre", categoria.Nombre);
            comand.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
            comand.Parameters.AddWithValue("@Activo", categoria.Activo);
            comand.CommandText = query;
            comand.CommandType = CommandType.Text;
            if (Connection.State != ConnectionState.Open)
            { Connection.Open(); }
            comand.ExecuteNonQuery();
            Connection.Close();
        }

        public void ActualizarCategoriaMovimientos(CategoriaMovimientos categoria)
        {
            string query = "UPDATE dbo.CategoriasMovimiento SET " +
            "Tipo = @Tipo, Nombre = @Nombre, Descripcion = @Descripcion, Activo = @Activo " +
            "WHERE ID = @ID";
            
            SqlCommand comand = Connection.CreateCommand();
            comand.Parameters.AddWithValue("@ID", categoria.ID);
            comand.Parameters.AddWithValue("@Tipo", categoria.Tipo);
            comand.Parameters.AddWithValue("@Nombre", categoria.Nombre);
            comand.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
            comand.Parameters.AddWithValue("@Activo", categoria.Activo);            
            comand.CommandText = query;
            comand.CommandType = CommandType.Text;            
            if (Connection.State != ConnectionState.Open)
            { Connection.Open(); }            
            comand.ExecuteNonQuery();
            Connection.Close();
        }

        public void EliminarCategoriaMovimientos(int ID)
        {
            string query = "DELETE FROM dbo.CategoriasMovimiento WHERE ID = @ID";
            SqlCommand comand = Connection.CreateCommand();
            comand.Parameters.AddWithValue("@ID",ID);
            comand.CommandText = query;
            comand.CommandType = CommandType.Text;
            if (Connection.State != ConnectionState.Open)
            { Connection.Open(); }
            comand.ExecuteNonQuery();
            Connection.Close();
        }

        public CategoriaMovimientos MostrarCategoriaMovimientos(int ID)
        {
            string query = "SELECT * FROM dbo.CategoriasMovimiento WHERE ID = @ID";
            SqlCommand comand = Connection.CreateCommand();
            CategoriaMovimientos categoria = new CategoriaMovimientos();
            if (Connection.State != ConnectionState.Open)
            { Connection.Open(); }
            comand.Parameters.AddWithValue("@ID", ID);
            comand.CommandText = query;
            comand.CommandType = CommandType.Text;
            IDataReader reader = comand.ExecuteReader();
            if (reader.Read())
            {
                categoria.ID = reader.GetInt32(reader.GetOrdinal(nameof(categoria.ID)));
                categoria.Tipo = reader.GetString(reader.GetOrdinal(nameof(categoria.Tipo)));
                categoria.Nombre = reader.GetString(reader.GetOrdinal(nameof(categoria.Nombre)));
                categoria.Descripcion = reader.GetString(reader.GetOrdinal(nameof(categoria.Descripcion)));
                categoria.Activo = reader.GetBoolean(reader.GetOrdinal(nameof(categoria.Activo)));
            }

            Connection.Close();
            return categoria;
        }
    }
}
