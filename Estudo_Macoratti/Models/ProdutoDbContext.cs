﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
namespace Mvc_Imagem.Models
{
    public class ProdutoDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}