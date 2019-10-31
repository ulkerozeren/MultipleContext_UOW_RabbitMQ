using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamUOW1.Data.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        int Complete();
        IUserRepository UserRepository { get; set; }
        IProductRepository ProductRepository { get; set; }
    }
}
