using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_1
{
    internal class Articulo : Marca, Categoria, Imagen
    {
        string idArticulo;
        string nombre;
        string descripcionArticulo;
        Marca idMarca;
        Categoria idCategoria;
        Imagen idImagen;
        float precio;

    }
}
