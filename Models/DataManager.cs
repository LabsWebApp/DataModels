using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DataProviders.DataTest;
using Models.Repositories;

namespace Models
{
    public class DataManager
    {
        public readonly IMainEntityRepository MainEntityRepository;

        public DataManager(IMainEntityRepository mainEntityRepository)
        {
            MainEntityRepository = mainEntityRepository;
        }
    }
}