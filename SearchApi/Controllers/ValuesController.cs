using SearchApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using AutoMapper;

namespace SearchApi.Controllers
{

    public class ValuesController : ApiController
    {
        erfDBEntities dbContext = null;

        // Constructor   
        public ValuesController()
        {
            // create instance of an object  
            dbContext = new erfDBEntities();
        }
        // GET api/values
        [HttpGet]
        [Route("api/Values/Index")]
        public IEnumerable<Result> Index()
        {
            var getData = new List<tblProduct>();
            getData = dbContext.tblProducts.ToList();
            var result = new List<Result>();
            foreach (var item in getData)
            {
                var value = new Result();
                value.name = item.name;
                value.manufacturer = item.manufacturer;
                value.description = item.description;
                value.category = item.category;
                value.quantity_in_stock = item.quantity_in_stock;
                value.min_quantity_to_order = item.min_quantity_to_order;

                foreach (var data in item.tblPricings)
                {
                    value.Slab_range = data.Slab_range;
                    value.Slab_range_price_per_unit = data.Slab_range_price_per_unit;
                }

                result.Add(value);
            }
            return result;
        }


        // POST api/values
        [HttpPost]
        [Route("api/values/search")]
        public IEnumerable<Result> Post(searchtext searchtext)
        {
            var getData = new List<tblProduct>();

            getData = dbContext.tblProducts.ToList();

            var result = new List<Result>();
            foreach (var item in getData)
            {
                var value = new Result();
                value.name = item.name;
                value.manufacturer = item.manufacturer;
                value.description = item.description;
                value.category = item.category;
                value.quantity_in_stock = item.quantity_in_stock;
                value.min_quantity_to_order = item.min_quantity_to_order;

                foreach (var data in item.tblPricings)
                {
                    value.Slab_range = data.Slab_range;
                    value.Slab_range_price_per_unit = data.Slab_range_price_per_unit;
                }

                result.Add(value);
            }

            if (searchtext.Text != null)
            {
                result = result.Where(x => x.name == searchtext.Text || x.manufacturer == searchtext.Text).ToList();
            }
            else if (searchtext.Price != 0)
            {
                result = result.Where(x => x.Slab_range_price_per_unit == searchtext.Price).ToList();
            }
            return result;
        }



        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
