using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Category
    {
        private string name;

        public Category(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
    }
}
