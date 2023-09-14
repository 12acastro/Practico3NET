using DataAccessLayer.IDALs;
using Microsoft.Data.SqlClient;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DALs
{
    public class DAL_Vehiculos_EF : IDAL_Vehiculos
    {
        private DBContextCore _dbContext;

        public DAL_Vehiculos_EF(DBContextCore dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(string documento)
        {
            throw new NotImplementedException();
        }

        public List<Vehiculo> Get()
        {
            return _dbContext.Vehiculos
                             .Select(v => new Vehiculo { Marca = v.Marca, Modelo = v.Modelo, Matricula = v.Matricula })
                             .ToList();
        }

        public Vehiculo Get(string matricula)
        {
            throw new NotImplementedException();
        }

        public void Insert(Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }

        public void Update(Vehiculo vehicolo)
        {
            throw new NotImplementedException();
        }
    }
}