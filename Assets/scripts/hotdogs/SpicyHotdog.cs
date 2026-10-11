using UnityEngine;

public class SpicyHotdog : Hotdog
{
    private readonly int _cost;
    private readonly int _weight;

    public SpicyHotdog() : base("’от-дог острый")
    {
        _cost = 250;
        _weight = 160;
    }

    public SpicyHotdog(HotdogConfig config) : base(config.displayName)
    {
        _cost = config.cost;
        _weight = config.weight;
    }

    public override int GetCost() => _cost;

    public override int GetWeight() => _weight;
}