using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class WindowView : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private TextMeshProUGUI _titleText;
    [SerializeField] private TextMeshProUGUI _descriptionText;
    [SerializeField] private Image _mainImage;
    [SerializeField] private Button _buttonWithPrice;
    [SerializeField] private Button _buttonWithDiscount;

    //[SerializeField] private ItemsPanelController _itemsPanelController;

    public UnityAction OnButtonWithPriceClick;

    private WindowScenarioConfig _config;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        _buttonWithPrice.onClick.RemoveAllListeners();
        _buttonWithPrice.onClick.AddListener(OnButtonWithPriceClick);

        _buttonWithDiscount.onClick.RemoveAllListeners();
        _buttonWithDiscount.onClick.AddListener(OnButtonWithPriceClick);
    }

    public void ShowWindow(string title, string description, Sprite mainImageSprite, bool hasDiscount, string price, string oldPrice)
    {
        _titleText.text = title;
        _descriptionText.text = description;
        _mainImage.sprite = mainImageSprite;

        _buttonWithPrice.gameObject.SetActive(!hasDiscount);
        _buttonWithDiscount.gameObject.SetActive(hasDiscount);

        /*
        if (hasDiscount)
        {
            _buttonWithPrice.gameObject.SetActive(false);
            _buttonWithDiscount.gameObject.SetActive(true);


        }
        */
    }

    public void CloseWindow()
    {

    }

    private void OnDestroy()
    {
        _buttonWithPrice.onClick.RemoveAllListeners();
        _buttonWithDiscount.onClick.RemoveAllListeners();
    }
}
