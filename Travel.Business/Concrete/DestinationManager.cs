﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Business.Abstract;
using Travel.DataAccess.Abstract;
using Travel.Entity.Concrete;

namespace Travel.Business.Concrete
{
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void TAdd(Destination TEntity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Destination TEntity)
        {
            throw new NotImplementedException();
        }

        public Destination TGetById(int id)
        {
            return _destinationDal.GetById(id);
        }

        public List<Destination> TGetList()
        {
            return _destinationDal.GetAll();
        }

        public void TUpdate(Destination TEntity)
        {
            throw new NotImplementedException();
        }
    }
}
