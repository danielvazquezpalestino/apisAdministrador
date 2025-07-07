using Entities;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class AdCasa
    {
        readonly SqlConnection Connection;
        public AdCasa()
        {
            Connection = new SqlConnection(Conexion.ConectionString);
        }

        public void AgregarCasa(Casa casa)
        {

            string query = "Insert into Casas(DomicilioCalle, NumeroInterior, NumeroExterior, Telefono, Statusdomicilio) " +
                "values('" + casa.DomicilioCalle + "'," + casa.NumeroInterior + ", '" + casa.NumeroExterior + "' , '"
                + casa.Telefono + "', '" + casa.Statusdomicilio + "')";
            SqlCommand comand = new SqlCommand(query, Connection);
            if (Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }
            comand.ExecuteNonQuery();
            Connection.Close();
            Console.WriteLine($"La Casa {casa.IdCasa} Agregada con exito.");
        }

        public void ActualizarCasa(Casa casa)
        {
            string query = "update Casas set DomicilioCalle = '" + casa.DomicilioCalle + "', NumeroInterior = " +
            "'" + casa.NumeroInterior + "',NumeroExterior = '" + casa.NumeroExterior + "', Telefono = '" + casa.Telefono + "'" +
            ", Statusdomicilio = '" + casa.Statusdomicilio + "' where IdCasa  = '" + casa.IdCasa + "'";
            SqlCommand comand = new SqlCommand(query, Connection);
            Connection.Open();
            comand.ExecuteNonQuery();
            Connection.Close();

            Console.WriteLine($"Casa   {casa.IdCasa} Actualizado con exito.");
        }


        public void EliminarCasa(int CasaId)
        {
            string query = "DELETE FROM dbo.Casas WHERE IdCasa = '" + CasaId + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }




        public Casa ObtenerCasa(int CasaId)

        {
            string query = "Select * from dbo.Casas  where IdCasa  = '" + CasaId + "'";
            SqlCommand comand = new SqlCommand(query, Connection);
            Casa casa = new Casa();
            Connection.Open();
            IDataReader reader = comand.ExecuteReader();
            if (reader.Read())
            {
                casa.IdCasa = reader.GetInt32(reader.GetOrdinal(nameof(casa.IdCasa)));
                casa.DomicilioCalle = reader.GetInt32(reader.GetOrdinal(nameof(casa.DomicilioCalle)));
                casa.NumeroInterior = reader.GetInt32(reader.GetOrdinal(nameof(casa.NumeroInterior)));
                casa.NumeroExterior = reader.GetInt32(reader.GetOrdinal(nameof(casa.NumeroExterior)));
                casa.Telefono = reader.GetInt32(reader.GetOrdinal(nameof(casa.Telefono)));
                casa.Statusdomicilio = reader.GetInt32(reader.GetOrdinal(nameof(casa.Statusdomicilio)));
            }
            Connection.Close();

            Console.WriteLine($"Casa {casa.IdCasa} Obtenida con exito.");
            return casa;
        }




        public List<Casa> ObtenerCasas()
        {
            string query = "Select * from dbo.Casas  ";
            SqlCommand comand = new SqlCommand(query, Connection);
            List<Casa> casas = new List<Casa>();
            Connection.Open();
            IDataReader reader = comand.ExecuteReader();
            while (reader.Read())
            {
                Casa casa = new Casa();
                casa.IdCasa = reader.GetInt32(reader.GetOrdinal(nameof(casa.IdCasa)));
                casa.DomicilioCalle = reader.GetInt32(reader.GetOrdinal(nameof(casa.DomicilioCalle)));
                casa.NumeroInterior = reader.GetInt32(reader.GetOrdinal(nameof(casa.NumeroInterior)));
                casa.NumeroExterior = reader.GetInt32(reader.GetOrdinal(nameof(casa.NumeroExterior)));
                casa.Telefono = reader.GetInt32(reader.GetOrdinal(nameof(casa.Telefono)));
                casa.Statusdomicilio = reader.GetInt32(reader.GetOrdinal(nameof(casa.Statusdomicilio)));
            }
            Connection.Close();
            Console.WriteLine($"Csasas Obtenidas con exito.");
            return casas;

        }


    }



}
