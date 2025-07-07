using AccesoDatos;
using Entities;

namespace CapaNegocio
{
    public class NgCasa
    {
        public void AgregarCasa(Casa casa)
        {
           AdCasa Adcasa = new AdCasa();
            Adcasa.AgregarCasa(casa);
        }


        public void ActualizarCasa(Casa casa)
        {
            AdCasa Adcasa = new AdCasa();
            Adcasa.ActualizarCasa(casa);
        }


        public void EliminarCasa(int CasaId)
        {
            AdCasa Adcasa = new AdCasa();
            Adcasa.EliminarCasa(CasaId);

        }/*
        public void EliminarAsociacion(int AsociacionId)
        {
            AdCasa Adcasa = new AdCasa();
            Adcasa.EliminarAsociacion(AsociacionId);
        }
        */

        public Casa ObtenerCasa(int CasaId)
        {
            AdCasa Adcasa = new AdCasa();
             return Adcasa.ObtenerCasa(CasaId);
        }

        public List<Casa> ObtenerCasas()
        {
            AdCasa Adcasa = new AdCasa();
            return Adcasa.ObtenerCasas();
        }
    }
}