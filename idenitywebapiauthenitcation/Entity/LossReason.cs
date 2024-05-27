﻿namespace EccomerceApi.Entity
{
    public class LossReason
    {
        public int Id { get; set; }
        public string Reason { get; set; }

        public virtual ICollection<LostDetail> LostDetails { get; set; } = new List<LostDetail>();

    }
}
