using UnityEngine;
using UnityEngine.UI;

public class ButtonDetector : MonoBehaviour
{
    [SerializeField] Button _butten;

    public bool Click { get; private set; }

    private void OnEnable()
    {
        _butten.onClick.AddListener(ButtonClick);
    }

    private void Start()
    {
        Click = true;    
    }

    private void ButtonClick()
    {
        if (Click)
            Click = false;
        else
            Click = true;
    }

    private void OnDisable()
    {
        _butten.onClick.RemoveListener(ButtonClick);
    }
}
