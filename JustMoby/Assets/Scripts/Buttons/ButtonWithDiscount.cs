using TMPro;
using UnityEngine;

public class ButtonWithDiscount : ButtonBase
{
    [SerializeField] private TextMeshProUGUI _priceText;
    [SerializeField] private TextMeshProUGUI _oldPriceText;
    [SerializeField] private TextMeshProUGUI _discountText;

    public override void Initialize(ButtonData data)
    {
        _priceText.text = data.Price;
        _oldPriceText.text = data.OldPrice;
        _discountText.text = data.Discount;
    }
}
