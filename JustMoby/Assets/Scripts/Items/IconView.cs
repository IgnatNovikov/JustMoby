using System;
using UnityEngine;

[Serializable]
public class IconView
{
    [SerializeField] private string _name;
    public string Name => _name;
    [SerializeField] private int _count;
    public int Count => _count;

}
