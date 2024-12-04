using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowController : MonoBehaviour
{
    [SerializeField] private Button _showWindowButton;

    private void Awake()
    {
        _showWindowButton.onClick.AddListener(ShowWindow);
    }

    private void ShowWindow()
    {

    }
}
