using System;
using FinalExamUOW1.Data.Interfaces;
using FinalExamUOW1.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalExamUOW1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var result = _unitOfWork.ProductRepository.List();
            return new JsonResult(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return new JsonResult(_unitOfWork.ProductRepository.Find(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post(int id, [FromBody]  Product product)
        {
            _unitOfWork.ProductRepository.Insert(product);
            _unitOfWork.Complete();
            return new JsonResult(product);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Product product)
        {
            if (id != product.Id) return BadRequest();
            _unitOfWork.ProductRepository.Update(product);
            _unitOfWork.Complete();
            return new JsonResult(product);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return new JsonResult(new Tuple<bool, int>(_unitOfWork.ProductRepository.Delete(id), _unitOfWork.Complete()));
        }
    }
}
