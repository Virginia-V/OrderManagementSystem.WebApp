﻿namespace OMS.Domain
{
    public class OrderType : BaseEntity
    {
        public string Type { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
