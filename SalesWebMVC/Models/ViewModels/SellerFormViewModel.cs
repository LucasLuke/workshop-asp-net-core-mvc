using System;
using System.Collections.Generic;


namespace SalesWebMVC.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }

     /*   public SellerFormViewModel(ICollection<Department> Departments)
        {
            this.Departments = Departments;
        }

      /*  public SellerFormViewModel()
        {
        }*/
    }
}
