using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WindowScenarioConfig", menuName = "ScriptableObjects/WindowScenarioConfig", order = 0)]
public class WindowScenarioConfig : ScriptableObject
{
    [SerializeField] private IconsViewConfig _iconsViewConfig;
    public IconsViewConfig IconsViewConfig => _iconsViewConfig;
    [SerializeField] private List<IconsViewConfig> _allConfigs;
    public List<IconsViewConfig> AllConfigs => _allConfigs;

    [Space]

    [SerializeField] private string _title;
    public string Title => _title;
    [SerializeField, TextArea(3, 10)] private string _description;
    public string Description => _description;
    [SerializeField] private float _price;
    public float Price => _price;
    [SerializeField] private int _discount;
    public int Discount => _discount;
    [SerializeField] private string _mainImageName;
    public string MainImageName => _mainImageName;
}
