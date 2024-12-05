using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowController : MonoBehaviour
{
    [Header("MVC")]
    [SerializeField] private WindowModel _model;
    [SerializeField] private WindowView _view;

    [Header("Components")]
    [SerializeField] private Button _showWindowButton;

    private void Start()
    {
        _showWindowButton.onClick.AddListener(ShowWindow);
        _view.OnButtonWithPriceClick = CloseWindow;
    }

    private void ShowWindow()
    {
        _view.gameObject.SetActive(true);

        IconView mainImageView = _model.IconsViewConfig.GetIconByName(_model.ScenarioConfig.MainImageName);
        if (mainImageView == null)
            return;

        string price = string.Format("{0:C2}", _model.ScenarioConfig.Price - _model.ScenarioConfig.Price * _model.ScenarioConfig.Discount / 100);

        _view.ShowWindow(_model.ScenarioConfig.Title, _model.ScenarioConfig.Description, mainImageView.Icon, _model.ScenarioConfig.Discount > 0, price, string.Format("{0:C2}", _model.ScenarioConfig.Price));
    }

    private void CloseWindow()
    {
        _view.CloseWindow();
        _view.gameObject.SetActive(false);
    }
}
