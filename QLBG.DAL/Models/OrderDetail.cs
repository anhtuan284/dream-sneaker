﻿using System;
using System.Collections.Generic;

#nullable disable

namespace QLBG.DAL.Models
{
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            ShoeDetails = new HashSet<ShoeDetail>();
        }

        public int Id { get; set; }
        public int ShoeDetailId { get; set; }
        public int OrderId { get; set; }

        public virtual Comment IdNavigation { get; set; }
        public virtual Order Order { get; set; }
        public virtual ICollection<ShoeDetail> ShoeDetails { get; set; }
    }
}
