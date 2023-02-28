using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_cl464.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
