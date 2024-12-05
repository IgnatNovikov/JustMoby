using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WindowController : MonoBehaviour
{
    [Header("MVC")]
    [SerializeField] private WindowModel _model;
    [SerializeField] private WindowView _view;
    [SerializeField] private ImagesConfig _imagesConfig;
    [SerializeField] private PanelController _panel;

    [Header("Components")]
    [SerializeField] private Button _showWindowButton;
    [SerializeField] private TMP_InputField _inputField;

    [Header("Formats")]
    [SerializeField] private string _priceFormat = "${0:0.00}";
    [SerializeField] private string _oldPriceFormat = "<s>${0}</s>";
    [SerializeField] private string _discountFormat = "-{0}%";

    private IconsViewConfig _iconsConfig;

    private void Start()
    {
        _view.OnButtonWithPriceClick = CloseWindow;
        InitializeWindow();

        _showWindowButton.onClick.AddListener(ShowWindow);
    }

    private void InitializeWindow()
    {
        Sprite mainImage = _imagesConfig.GetSpriteByName(_model.ScenarioConfig.MainImageName);
        if (mainImage == null)
            return;

        float price = _model.ScenarioConfig.Price - _model.ScenarioConfig.Price * _model.ScenarioConfig.Discount / 100;
        if (price < 0)
            price = 0;

        _view.Initialize(_model.ScenarioConfig.Title,
            _model.ScenarioConfig.Description,
            mainImage,
            string.Format(_priceFormat, price),
            string.Format(_oldPriceFormat, _model.ScenarioConfig.Price),
            _model.ScenarioConfig.Discount > 0,
            string.Format(_discountFormat, _model.ScenarioConfig.Discount > 100 ? 100 : _model.ScenarioConfig.Discount));
    }

    private void InitializePanel()
    {
        _panel.Initialize(_iconsConfig);
    }

    private void ShowWindow()
    {
        CheckInput(_inputField.text);
        InitializePanel();
        _view.ShowWindow();
    }

    private void CloseWindow()
    {
        _view.CloseWindow();
    }

    private void CheckInput(string value)
    {
        if (!int.TryParse(value, out int count))
        {
            _iconsConfig = _model.ScenarioConfig.IconsViewConfig;
            return;
        }

        if (count < 3)
            count = 3;
        if (count > 6)
            count = 6;

        _iconsConfig = _model.ScenarioConfig.AllConfigs[count - 3];
    }
}
