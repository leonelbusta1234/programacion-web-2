﻿using ProyectoWeb.AccesoDatos.Data.IRepository.IRepository;
using ProyectoWeb.AccesoDatos.Data.Repository.IRepository;
using ProyectoWeb.Data;
using ProyectoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.AccesoDatos.Data.Repository
{
    public class ProductoRepository: Repository<Producto>, IProductoRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Producto producto)
        {
            var objDesdeDb = _db.Producto.FirstOrDefault(s => s.Id == producto.Id);
            objDesdeDb.NombreProducto = producto.NombreProducto;
            objDesdeDb.CantidadMinima = producto.CantidadMinima;
            //_db.SaveChanges();
        }
    }
}
