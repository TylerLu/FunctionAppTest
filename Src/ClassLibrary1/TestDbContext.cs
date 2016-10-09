using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TestDbContext: DbContext
    {
        public IMapper Mapper { get; set; }
    }
}
