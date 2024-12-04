using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WindowScenarioConfig", menuName = "ScriptableObjects/WindowScenarioConfig", order = 0)]
public class WindowScenarioConfig : ScriptableObject
{
    [SerializeField] private IconsViewConfig _iconsViewConfig;
    public IconsViewConfig IconsViewConfig => _iconsViewConfig;

    [Space]

    [SerializeField] private string _title;
    public string Title => _title;
    [SerializeField, TextArea(3, 10)] private string _description;
    public string Description => _description;
    [SerializeField] private List<ItemData> _items;
    public List<ItemData> Items => _items;
    [SerializeField] private float _price;
    public float Price => _price;
    [SerializeField] private int _discount;
    public int Discount => _discount;
    [SerializeField] private string _mainImageName;
    public string MainImageName => _mainImageName;
}
