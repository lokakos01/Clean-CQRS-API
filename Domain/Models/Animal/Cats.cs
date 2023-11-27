using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Animal
{
    public class Cat
    {

        public bool LikesToPlay { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
