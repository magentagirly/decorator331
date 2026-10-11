using UnityEngine;

public class SweetOnionDecorator : HotdogDecorator
{
    private readonly string _ingredientName;
    private readonly int _extraCost;
    private readonly int _extraWeight;

    public SweetOnionDecorator(Hotdog hotdog) : base(hotdog)
    {
        _ingredientName = "сладким луком";
        _extraCost = 30;
        _extraWeight = 10;
    }

    public SweetOnionDecorator(Hotdog hotdog, IngredientConfig config) : base(hotdog)
    {
        _ingredientName = config.displayName;
        _extraCost = config.cost;
        _extraWeight = config.weight;
    }

    public override string GetName() => $"{_hotdog.GetName()} с {_ingredientName}";

    public override int GetCost() => _hotdog.GetCost() + _extraCost;

    public override int GetWeight() => _hotdog.GetWeight() + _extraWeight;
}