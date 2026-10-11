using UnityEngine;

[CreateAssetMenu(fileName = "IngredientConfig", menuName = "Hotdogs/Ingredient Config")]
public class IngredientConfig : ScriptableObject
{
    public string displayName;
    public int cost;
    public int weight;
}