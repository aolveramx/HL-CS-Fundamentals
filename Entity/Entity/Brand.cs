using System;
using System.Collections.Generic;

namespace Entity
{
    public partial class Brand
    {
        public Brand()
        {
            Beers = new HashSet<Beer>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Beer> Beers { get; set; }
    }
}
