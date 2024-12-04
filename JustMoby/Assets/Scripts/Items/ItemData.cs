using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ItemData
{
    [SerializeField] private string _name;
    public string Name => _name;
    [SerializeField] private int _count;
    public int Count => _count;
}
