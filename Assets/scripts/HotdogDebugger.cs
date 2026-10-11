using UnityEngine;

using UnityEngine;

public class HotdogDebugger : MonoBehaviour
{
    [SerializeField] private HotdogConfig classicConfig;
    [SerializeField] private IngredientConfig picklesConfig;
    [SerializeField] private IngredientConfig onionConfig;

    private void Start()
    {
        Hotdog classic = new ClassicHotdog(classicConfig);

        Print(classic);
        Debug.Log("Дополнительная информация:");

        Hotdog withPickles = new PicklesDecorator(new ClassicHotdog(classicConfig), picklesConfig);
        Print(withPickles);

        Hotdog withOnion = new SweetOnionDecorator(new ClassicHotdog(classicConfig), onionConfig);
        Print(withOnion);
    }

    private void Print(Hotdog hotdog)
    {
        Debug.Log($"{hotdog.GetName()} ({hotdog.GetWeight()}г) — {hotdog.GetCost()}р.");
    }
}