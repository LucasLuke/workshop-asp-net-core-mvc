﻿using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class SellerServices
    {
        private readonly SalesWebMVCContext _context;

        public SellerServices(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
           return _context.Seller.ToList();
        }
    }
}
