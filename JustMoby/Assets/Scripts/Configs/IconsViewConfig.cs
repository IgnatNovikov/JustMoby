using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IconsViewConfig", menuName = "ScriptableObjects/IconsViewConfig", order = 0)]
public class IconsViewConfig : ScriptableObject
{
    [SerializeField] private List<IconView> _icons;
    public List<IconView> Icons => _icons;
}
