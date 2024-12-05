using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonWithPrice : ButtonBase
{
    [SerializeField] private TextMeshProUGUI _priceText;

    public override void Initialize(float price)
    {
        
    }
}
