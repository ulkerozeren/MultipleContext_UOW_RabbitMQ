using FinalExamUOW1.Data.Contexts;
using FinalExamUOW1.Data.Interfaces;
using FinalExamUOW1.Data.Models;

namespace FinalExamUOW1.Service
{
    public class ProductRepository : Repository<Product,DataContext2>, IProductRepository
    {
        private readonly DataContext2 _dataContext2;

        public ProductRepository(DataContext2 dataContext2) : base(dataContext2)
        {
            _dataContext2 = dataContext2;
        }
    }
}
