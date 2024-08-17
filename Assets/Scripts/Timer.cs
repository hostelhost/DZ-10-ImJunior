using System.Collections;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private TimeKeeper _timeKeeper;

    private float _delay = 0.5f;

    private void Start()
    {
        _text.text = "";
        StartCoroutine(ReportNumber(_delay, _timeKeeper.GiveNumber));
    }

    private IEnumerator ReportNumber(float delay, float number)
    {
        WaitForSecondsRealtime wait = new WaitForSecondsRealtime(delay);

        while (true)
        {
            number++;
            _timeKeeper.GetNumber(number);
            DisplayReportNumber(number);
            yield return wait;
        }
    }

    private void DisplayReportNumber(float count)
    {
        _text.text = count.ToString("");
    }

    private void OnDisable()
    {
        StopCoroutine(ReportNumber(_delay,_timeKeeper.GiveNumber));
    }
}
