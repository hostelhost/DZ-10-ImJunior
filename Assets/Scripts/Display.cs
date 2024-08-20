using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Display : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Timer _timer;

    private void OnEnable() => _timer.NextNumber += DisplayReportNumber;

    private void OnDisable() => _timer.NextNumber -= DisplayReportNumber;

    private void Start()
    {
        _text.text = "";
    }

    private void DisplayReportNumber(float count) => _text.text = count.ToString("");
}
