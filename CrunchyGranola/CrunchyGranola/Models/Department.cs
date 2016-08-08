using System.Collections.Generic;

namespace CrunchyGranola.Models
{
    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public int Budget { get; set; }

        public virtual ICollection<Product>Products { get; set; }

    }
}