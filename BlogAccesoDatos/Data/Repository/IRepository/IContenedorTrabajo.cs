using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.AccesoDatos.Data.Repository.IRepository
{
    public interface IContenedorTrabajo : IDisposable
    {
        ICategoriaRepository Categoria { get; }
        //Aquí se deben ir agregando los diferentes repositorios
        IArticuloRepository Articulo { get; }

        void Save();

    }
}
