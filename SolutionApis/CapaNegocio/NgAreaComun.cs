using AccesoDatos;
using Entities;

namespace CapaNegocios
{
    public class NgAreaComun
    {
        public void  AgregarAreaComun (AreaComun areaComun) 
        {
            AdAreaComun Adareacomun = new AdAreaComun();
            Adareacomun.AgregarAreaComun(areaComun);
        }

        public void ActualizarAreaComun(AreaComun areaComun)
        {
            AdAreaComun Adareacomun = new AdAreaComun();
            Adareacomun.ActualizarAreaComun(areaComun);
        }

        public void EliminarAreaComun(int AreaComunId)
        {
            AdAreaComun Adareacomun = new AdAreaComun();
            Adareacomun.EliminarAreaComun(AreaComunId);

        }
        public AreaComun ObtenerAreaComun(int AreaComunId)
        {
            AdAreaComun Adaareacomun = new AdAreaComun();
            return Adaareacomun.ObtenerAreaComun(AreaComunId);
        }
/*
        public List<AreaComun> ObtenerAreasComunes()
        {
            AdAreaComun Adareacomun = new AdAreaComun();
            return Adareacomun.ObtenerAreasComunes();
        }
        */

    }
}
