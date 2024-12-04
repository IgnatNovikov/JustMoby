using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IconsViewConfig", menuName = "ScriptableObjects/IconsViewConfig", order = 0)]
public class IconsViewConfig : ScriptableObject
{
    [SerializeField] private List<IconView> _icons;
    public List<IconView> Icons => _icons;

    public IconView GetIconByName(string name)
    {
        IconView icon = _icons.Find(x => x.Name.ToLower() == name.ToLower());
        if (icon == null)
            return null;

        return icon;
    }
}
