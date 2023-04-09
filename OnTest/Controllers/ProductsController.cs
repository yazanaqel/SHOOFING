using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnTest.Models;
using OnTest.Data.Services;
using Microsoft.AspNetCore.Hosting;
using OnTest.Code;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace OnTest.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IDataHelper<Product> _serviceProduct;
        public ProductsController(IDataHelper<Product> serviceProduct)
        {
            _serviceProduct = serviceProduct;

        }

        // GET: Products
        public IActionResult Index(int page = 1)
        {

            var products = _serviceProduct.GetAllData();


            //footer nav pages
            const int pageSize = 6;
            if (page < 1)
                page = 1;

            int recsCount = products.Count();

            var pager = new Pager(recsCount, page, pageSize);

            int recSkip = (page - 1) * pageSize;

            var data = products.Skip(recSkip).Take(pager.PageSize).ToList();

            this.ViewBag.Pager = pager;


            return View(data);
        }

        // GET: Products/Details/5
        public IActionResult Details(int id)
        {

            var companiesDetails = _serviceProduct.Find(id);
            if (companiesDetails == null) return View("NotFound");
            return View(companiesDetails);

        }

		public IActionResult Search(string item)
		{

			var result = _serviceProduct.Search(item);
			return View("Index", result);
		}

        

    }

}
