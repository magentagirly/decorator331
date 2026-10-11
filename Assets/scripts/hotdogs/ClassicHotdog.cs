using UnityEngine;

public class ClassicHotdog : Hotdog
{
    private readonly int _cost;
    private readonly int _weight;

    public ClassicHotdog() : base("Хот-дог классический")
    {
        _cost = 210;
        _weight = 150;
    }

    public ClassicHotdog(HotdogConfig config) : base(config.displayName)
    {
        _cost = config.cost;
        _weight = config.weight;
    }

    public override int GetCost() => _cost;

    public override int GetWeight() => _weight;
}
