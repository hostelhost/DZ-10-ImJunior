using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private TimeKeeper _timeKeeper;
    [SerializeField] private ButtonDetector _buttonDetector;

    private Coroutine _coroutine;

    private float _delay = 0.5f;
    private bool _detectorReportNumber = false;

    private void Start()
    {
        _text.text = "";
    //    StartCoroutine(ReportNumber(_delay, _timeKeeper.GiveNumber));
    }

    private void Update()
    {
        if (_detectorReportNumber == false)
            if (_buttonDetector.Click)
            {
                _coroutine = StartCoroutine(ReportNumber(_delay, _timeKeeper.GiveNumber));
                _detectorReportNumber = true;
            }
        else
            if (_buttonDetector.Click == false)
            { 
                StopCoroutine(_coroutine);
                _detectorReportNumber = false;
            }
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
  //      StopCoroutine(ReportNumber(_delay,_timeKeeper.GiveNumber));
    }
}
