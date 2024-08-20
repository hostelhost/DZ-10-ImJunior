using System;
using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TimeKeeper _timeKeeper;
    [SerializeField] private ButtonDetector _buttonDetector;

    public event Action<float> NextNumber;

    private Coroutine _coroutine;
    private float _delay = 0.5f;

    private void OnEnable() => _buttonDetector.Click += OnClick;

    private void OnDisable() => _buttonDetector.Click -= OnClick;

    private void OnClick(bool state)
    {
        if (state)
            _coroutine = StartCoroutine(ReportNumber(_delay, _timeKeeper.GiveNumber));
        else
            StopCoroutine(_coroutine);
    }

    private IEnumerator ReportNumber(float delay, float number)
    {
        WaitForSecondsRealtime wait = new WaitForSecondsRealtime(delay);

        while (true)
        {
            number++;
            NextNumber?.Invoke(number);
            yield return wait;
        }
    }
}
