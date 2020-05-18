using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemoWebAP.Database.Repositories
{
    public abstract class BaseRepository<T> where T : class
    {
        public abstract List<T> GetAll();
        public abstract T GetItemById(int id);
        public abstract List<T> GetSomeColumnsOfAll(List<string> columns);
    }
}
