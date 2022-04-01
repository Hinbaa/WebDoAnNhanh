namespace Ictshop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        [Key]
        public int MaBL { get; set; }

        public int MaNguoiDung { get; set; }

        public string TenNguoiDung { get; set; }

        public int MaSP { get; set; }

        public string NDBinhLuan { get; set; }

        public DateTime? NgayDang { get; set; }
    }
}
