using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWinForm.Models
{
    public class MonAnNguyenLieu
    {
        [MaxLength(5)]
        public string Id { get; set; }
        public int SoLuong { get; set; }
        public string DonViTinh { get; set; }
        public int MonAnId { get; set; }
        public virtual MonAn MonAn {get; set;}
        public int NguyenLieuId { get; set; }
        public virtual NguyenLieu NguyenLieu { get; set; }
    }
}
