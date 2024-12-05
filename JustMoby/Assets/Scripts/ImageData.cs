using System;
using UnityEngine;

[Serializable]
public class ImageData
{
    [SerializeField] private Sprite _image;
    public Sprite Image => _image;
    [SerializeField] private string _name;
    public string Name => _name;
}
