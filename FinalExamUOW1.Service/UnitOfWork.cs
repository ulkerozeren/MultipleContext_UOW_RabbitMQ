using FinalExamUOW1.Data.Contexts;
using FinalExamUOW1.Data.Interfaces;

namespace FinalExamUOW1.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext1 _dataContext1;
        private readonly DataContext2 _dataContext2;
        public UnitOfWork(DataContext1 dataContext1, DataContext2 dataContext2)
        {
            _dataContext1 = dataContext1;
            _dataContext2 = dataContext2;
            UserRepository = new UserRepository(dataContext1);
            ProductRepository = new ProductRepository(dataContext2);
        }

        public IUserRepository UserRepository { get; set; }
        public IProductRepository ProductRepository { get; set; }

        public int Complete()
        {
            return _dataContext1.SaveChanges();
        }

        public void Dispose()
        {
            _dataContext1.Dispose();
            _dataContext2.Dispose();
        }
    }
}
