﻿using Livraria.Dominio.Entidades;
using System.Collections.Generic;

namespace Livraria.Dominio.Interfaces.Repositorios
{
    public interface ILivroRepositorio : IRepositorioBase<Livro>
    {
        bool ExisteComCategoria(long categoriaId);
        bool ExisteComEditora(long editoraId);
        IEnumerable<Livro> ObterPorTitulo(string titulo);
        IEnumerable<Livro> ObterTodosOrdenadosPorTitulo();
    }
}