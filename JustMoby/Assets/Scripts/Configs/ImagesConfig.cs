using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ImagesConfig", menuName = "ScriptableObjects/ImagesConfig", order = 0)]
public class ImagesConfig : ScriptableObject
{
    [SerializeField] private List<ImageData> _images;
    public List<ImageData> Images => _images;

    public Sprite GetSpriteByName(string name)
    {
        ImageData data = _images.Find(x => x.Name.ToLower() == name.ToLower());
        if (data == null)
            return null;

        return data.Image;
    }
}
