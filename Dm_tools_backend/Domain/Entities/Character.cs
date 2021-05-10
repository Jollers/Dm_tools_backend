using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dm_tools_backend.Domain.Entities
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
    }
}
