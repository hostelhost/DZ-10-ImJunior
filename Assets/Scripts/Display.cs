using TMPro;
using UnityEngine;

public class Display : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Counter _�ounter;

    private void OnEnable() => _�ounter.ValueChanged += Show;

    private void OnDisable() => _�ounter.ValueChanged -= Show;

    private void Start() => _text.text = "";

    private void Show(float count) => _text.text = count.ToString("");
}
