using UnityEngine;

[CreateAssetMenu(fileName = "HotdogConfig", menuName = "Hotdogs/Hotdog Config")]
public class HotdogConfig : ScriptableObject
{
    public string displayName;
    public int cost;
    public int weight;
}

