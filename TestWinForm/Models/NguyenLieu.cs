using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWinForm.Models
{
    public class NguyenLieu
    {
        public int Id { get; set; }
        public string TenNguyenLieu { get; set; }
        public bool TinhTrang { get; set; }
        public virtual ICollection<MonAn> MonAns { get; set; }

    }
}
