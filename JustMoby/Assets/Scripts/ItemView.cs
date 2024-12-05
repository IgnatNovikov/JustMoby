using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemView : MonoBehaviour
{
    [SerializeField] private Image _icon;
    [SerializeField] private TextMeshProUGUI _countText;

    public void Initialize(Sprite sprite, string count)
    {
        _icon.sprite = sprite;
        _countText.text = count;
    }
}
