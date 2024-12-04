using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WindowView : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private TextMeshProUGUI _titleText;
    [SerializeField] private TextMeshProUGUI _descriptionText;
    //[SerializeField] private ItemsPanelController _itemsPanelController;
    [SerializeField] private Image _mainImage;
    [SerializeField] private Button _buttonWithPrice;
    [SerializeField] private Button _buttonWithDiscount;

    private WindowScenarioConfig _config;

    public void Initialize(WindowScenarioConfig config)
    {

    }

    public void ShowWindow()
    {

    }
}
