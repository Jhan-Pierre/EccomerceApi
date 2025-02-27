﻿namespace Data.Entity;
public partial class LostDetail
{
    public int Id { get; set; }
    public decimal? UnitCost { get; set; }
    public required int Amount { get; set; }
    public string? Description { get; set; } = string.Empty;
    public int? LossId { get; set; }
    public virtual Loss? Loss { get; set; }

    public int? ProductId { get; set; }
    public virtual Product? Product { get; set; }

    public int? LossReasonId { get; set; }
    public virtual LossReason LossReason { get; set; }
}
