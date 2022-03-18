using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;
using Models.Repositories;

namespace Models.DataProviders.DataTest
{
    public class TestMainRepository : IMainEntityRepository
    {
        public TestMainRepository()
        {
            Items = new MainEntity?[4]
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Petja",
                    Number = 0
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Masha",
                    Number = 99
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Kolya"
                },
                new ()
                {
                    Id = Guid.NewGuid(),
                    Name = "Olya"
                }
            };
        }

        public MainEntity?[]? Items { get; private set; }

        public MainEntity? GetItemById(Guid id)
        {
            for (int i = 0; i < Items?.Length; i++)
            {
                if (Items[i]?.Id == id) return Items[i];
            }

            return null;
        }

        public void Delete(MainEntity item)
        {
            for (int i = 0; i < Items?.Length; i++)
            {
                if (Items[i]?.Id == item.Id)
                {
                    Items[i] = null;
                    return;
                }
            }
        }

        public void Update(MainEntity item)
        {
            for (int i = 0; i < Items?.Length; i++)
            {
                if (Items[i]?.Id != item.Id) continue;

                if (Items[i]!.Name != item.Name)
                    Items[i]!.Name = item.Name;
                if (Items[i]!.Number != item.Number)
                    Items[i]!.Number = item.Number;
                return;
            }

            if (item.Id == default)
            {
                item = new MainEntity
                {
                    Id = Guid.NewGuid(), Name = item.Name, Number = item.Number
                };
            }

            var buffer = new MainEntity?[(Items?.Length ?? 0) + 1];
            for (int i = 0; i < Items?.Length; i++) buffer[i] = Items[i];
            buffer[^1] = item;
            Items = buffer;
        }
    }
}
