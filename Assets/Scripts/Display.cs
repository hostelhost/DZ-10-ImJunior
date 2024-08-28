using TMPro;
using UnityEngine;

public class Display : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Counter _ñounter;

    private void OnEnable() => _ñounter.ValueChanged += Show;

    private void OnDisable() => _ñounter.ValueChanged -= Show;

    private void Start() => _text.text = "";

    private void Show(float count) => _text.text = count.ToString("");
}
