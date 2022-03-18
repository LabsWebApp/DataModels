using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.Repositories
{
    public interface IMainEntityRepository
    {
        MainEntity?[]? Items { get; }
        MainEntity? GetItemById(Guid id);
        void Delete(MainEntity item);
        void Update(MainEntity item);
    }
}
