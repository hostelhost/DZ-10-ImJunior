using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDetector : MonoBehaviour
{
    [SerializeField] private Button _butten;

    private bool _iSClickStats;

    public event Action<bool> Click;

    private void OnEnable() => _butten.onClick.AddListener(ButtonClick);
    
    private void OnDisable() => _butten.onClick.RemoveListener(ButtonClick);

    private void ButtonClick()
    {
        _iSClickStats = !_iSClickStats;
        Click?.Invoke(_iSClickStats);
    }
}
