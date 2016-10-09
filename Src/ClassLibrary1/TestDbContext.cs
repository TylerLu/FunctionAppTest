using AutoMapper;
using System.Data.Entity;

namespace ClassLibrary1
{
    public class TestDbContext: DbContext
    {
        public IMapper Mapper { get; set; }
    }
}
