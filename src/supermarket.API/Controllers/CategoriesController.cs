using Microsoft.AspNetCore.Mvc;
using supermarket.API.Domain.Models;
using supermarket.API.Domain.Services;
using System.Collections.Generic;

namespace supermarket.API.Controllers
{
    [Route("/api/[controller]")]
    public class CategoriesController : Controller
    {
        // The underscore prefix is another common convention to denote a field
        //  It is a very common practice as a way to avoid having to use the “this” keyword
        //  to distinguish class fields from local variables.
        // We’ll use this field to access the methods of our category service implementation.
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            // It means the class instance can be anything that implements the service interface.
            _categoryService = categoryService;
        }
        // The HttpGet attribute tells the ASP.NET Core pipeline to use it to handle GET requests.
        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            // returns the categories to the client
            // The framework pipeline handles the serialization of data to a JSON object.
            return categories;
        }
    }
}
