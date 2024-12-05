using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class WindowView : MonoBehaviour
{
    [SerializeField] private WindowAnimator _animator;
    [SerializeField] private TextMeshProUGUI _titleText;
    [SerializeField] private TextMeshProUGUI _descriptionText;
    [SerializeField] private Image _mainImage;
    [SerializeField] private ButtonBase _buttonWithPrice;
    [SerializeField] private ButtonBase _buttonWithDiscount;

    public UnityAction OnButtonWithPriceClick;

    public void Initialize(string title, string description, Sprite mainImageSprite, string price, string oldPrice, string discount)
    {
        _buttonWithPrice.Button.onClick.RemoveAllListeners();
        _buttonWithPrice.Button.onClick.AddListener(OnButtonWithPriceClick);

        _buttonWithDiscount.Button.onClick.RemoveAllListeners();
        _buttonWithDiscount.Button.onClick.AddListener(OnButtonWithPriceClick);

        _titleText.text = title;
        _descriptionText.text = description;
        _mainImage.sprite = mainImageSprite;

        bool hasDiscount = !string.IsNullOrEmpty(discount);

        _buttonWithPrice.gameObject.SetActive(!hasDiscount);
        _buttonWithDiscount.gameObject.SetActive(hasDiscount);

        ButtonData buttonData = new ButtonData();
        buttonData.Price = price;
        buttonData.OldPrice = oldPrice;
        buttonData.Discount = discount;

        _buttonWithPrice.Initialize(buttonData);
        _buttonWithDiscount.Initialize(buttonData);
    }

    public void ShowWindow()
    {
        _animator.Show();
    }

    public void CloseWindow()
    {
        _animator.Hide();
    }

    private void OnDestroy()
    {
        _buttonWithPrice.Button.onClick.RemoveAllListeners();
        _buttonWithDiscount.Button.onClick.RemoveAllListeners();
    }
}
