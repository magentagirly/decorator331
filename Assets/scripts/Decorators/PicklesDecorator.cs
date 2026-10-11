using UnityEngine;

public class PicklesDecorator : HotdogDecorator
{
    private readonly string _ingredientName;
    private readonly int _extraCost;
    private readonly int _extraWeight;

    public PicklesDecorator(Hotdog hotdog) : base(hotdog)
    {
        _ingredientName = "маринованными огурцами";
        _extraCost = 50;
        _extraWeight = 20;
    }

    public PicklesDecorator(Hotdog hotdog, IngredientConfig config) : base(hotdog)
    {
        _ingredientName = config.displayName;
        _extraCost = config.cost;
        _extraWeight = config.weight;
    }

    public override string GetName() => $"{_hotdog.GetName()} с {_ingredientName}";

    public override int GetCost() => _hotdog.GetCost() + _extraCost;

    public override int GetWeight() => _hotdog.GetWeight() + _extraWeight;
}