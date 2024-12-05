using UnityEngine;
using UnityEngine.UI;

public class ButtonBase : MonoBehaviour
{
    [SerializeField] private Button _button;
    public Button Button => _button;

    public virtual void Initialize(ButtonData data)
    {

    }
}

public class ButtonData
{
    public string Price;
    public string OldPrice;
    public string Discount;
}
