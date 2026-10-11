using UnityEngine;

public class CheeseHotdog : Hotdog
{
    private readonly int _cost;
    private readonly int _weight;

    public CheeseHotdog() : base("’от-дог сырный")
    {
        _cost = 260;
        _weight = 170;
    }

    public CheeseHotdog(HotdogConfig config) : base(config.displayName)
    {
        _cost = config.cost;
        _weight = config.weight;
    }

    public override int GetCost() => _cost;

    public override int GetWeight() => _weight;
}