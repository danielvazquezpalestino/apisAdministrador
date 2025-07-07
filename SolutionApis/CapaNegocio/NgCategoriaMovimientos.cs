
using AccesoDatos;
using Entities;

namespace CapaNegocios
{
    public class NgCategoriaMovimientos
    {
        public void AgregarCategoriaMovimientos(CategoriaMovimientos categoria)
        {
            AdCategoriaMovimientos Adcategoriamovimientos = new AdCategoriaMovimientos();
            Adcategoriamovimientos.AgregarCategoriaMovimientos(categoria);
        }

        public void ActualizarCategoriaMovimientos(CategoriaMovimientos categoria)
        {
            AdCategoriaMovimientos Adcategoriamovimientos = new AdCategoriaMovimientos();
            Adcategoriamovimientos.ActualizarCategoriaMovimientos(categoria);
        }


        public void EliminarCategoriaMovimientos(int AreaComunId)
        {
            AdCategoriaMovimientos Adcategoriamovimientos = new AdCategoriaMovimientos();
            Adcategoriamovimientos.EliminarCategoriaMovimientos(AreaComunId);

        }
        public CategoriaMovimientos MostrarCategoriaMovimientos(int CategoriaMovimientoId)
        {
            AdCategoriaMovimientos Adcategoriamovimientos = new AdCategoriaMovimientos();
            return Adcategoriamovimientos.MostrarCategoriaMovimientos(CategoriaMovimientoId);
        }


    }
}
