using System;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDetector : MonoBehaviour
{
    [SerializeField] Button _butten;

    private bool _clickStats;

    public event Action<bool> Click;

    private void OnEnable()
    {
        _butten.onClick.AddListener(ButtonClick);
    }

    private void OnDisable() => _butten.onClick.RemoveListener(ButtonClick);

    private void ButtonClick()
    {
        _clickStats = !_clickStats;
        Click?.Invoke(_clickStats);
    }
}
