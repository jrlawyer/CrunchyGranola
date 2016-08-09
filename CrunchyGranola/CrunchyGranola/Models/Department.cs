using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrunchyGranola.Models
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public int Budget { get; set; }

        public virtual ICollection<Product>Product { get; set; }

    }
}