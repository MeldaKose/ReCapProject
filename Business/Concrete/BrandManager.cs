﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
            Console.WriteLine("brand has been successfully added");

        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("brand has been successfully deleted");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetById(int id)
        {
            return _brandDal.GetAll(b => b.BrandId == id);
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
            Console.WriteLine("brand has been successfully updated");
        }
    }
}
