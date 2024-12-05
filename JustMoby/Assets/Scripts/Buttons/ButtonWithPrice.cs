using TMPro;
using UnityEngine;

public class ButtonWithPrice : ButtonBase
{
    [SerializeField] private TextMeshProUGUI _priceText;

    public override void Initialize(ButtonData data)
    {
        _priceText.text = data.Price;
    }
}
