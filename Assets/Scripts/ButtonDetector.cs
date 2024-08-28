using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDetector : MonoBehaviour
{
    [SerializeField] private Button _butten;

    private bool _isClickStats;

    public event Action<bool> Click;

    private void OnEnable() => _butten.onClick.AddListener(OnButtonClick);
    
    private void OnDisable() => _butten.onClick.RemoveListener(OnButtonClick);

    private void OnButtonClick()
    {
        _isClickStats = !_isClickStats;
        Click?.Invoke(_isClickStats);
    }
}
