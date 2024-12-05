using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowModel : MonoBehaviour
{
    [SerializeField] private WindowScenarioConfig _scenarioConfig;
    public WindowScenarioConfig ScenarioConfig => _scenarioConfig;
    [SerializeField] private IconsViewConfig _iconsViewConfig;
    public IconsViewConfig IconsViewConfig => _iconsViewConfig;


}
