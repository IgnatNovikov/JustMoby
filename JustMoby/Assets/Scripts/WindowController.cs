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

    [Header("Formats")]
    [SerializeField] private string _priceFormat = "${0:0.00}";
    [SerializeField] private string _oldPriceFormat = "<s>${0}</s>";
    [SerializeField] private string _discountFormat = "-{0}%";

    private void Start()
    {
        _view.OnButtonWithPriceClick = CloseWindow;
        InitializeWindow();
        InitializePanel();

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
        _panel.Initialize(_model.ScenarioConfig.IconsViewConfig);
    }

    private void ShowWindow()
    {
        _view.ShowWindow();
    }

    private void CloseWindow()
    {
        _view.CloseWindow();
    }
}
