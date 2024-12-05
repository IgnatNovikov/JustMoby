using UnityEngine;

public class WindowModel : MonoBehaviour
{
    [SerializeField] private WindowScenarioConfig _scenarioConfig;
    public WindowScenarioConfig ScenarioConfig => _scenarioConfig;
}
