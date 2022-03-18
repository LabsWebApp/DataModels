using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class MainEntity : EntityBase
    {
        public string Name { get; set; } = null!;
        public int? Number { get; set; }

        public override string ToString() => $"Name = {Name}; Number = {Number} ({Id})";
    }
}
