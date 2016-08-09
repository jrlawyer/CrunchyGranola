using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrunchyGranola.Models
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public int Budget { get; set; }

        public virtual ICollection<Purchase>Purchase { get; set; }

    }
}