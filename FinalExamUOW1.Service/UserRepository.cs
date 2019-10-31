using FinalExamUOW1.Data.Contexts;
using FinalExamUOW1.Data.Interfaces;
using FinalExamUOW1.Data.Models;

namespace FinalExamUOW1.Service
{
    public class UserRepository:Repository<User,DataContext1>, IUserRepository
    {
        private readonly DataContext1 _dataContext1;

        public UserRepository(DataContext1 dataContext1) : base(dataContext1)
        {
            _dataContext1 = dataContext1;
        }
    }
}
