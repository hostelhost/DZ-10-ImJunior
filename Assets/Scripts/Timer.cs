using System;
using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private ButtonDetector _buttonDetector;

    public event Action<float> GotNumber;

    private Coroutine _coroutine;
    private float _delay = 0.5f;
    private float _number = 0f;

    private void OnEnable() => _buttonDetector.Click += OnClick;

    private void OnDisable() => _buttonDetector.Click -= OnClick;

    private void OnClick(bool state)
    {
        if (state)
            _coroutine = StartCoroutine(StartReporting(_delay, _number));
        else
            StopCoroutine(_coroutine);
    }

    private IEnumerator StartReporting(float delay, float number)
    {
        WaitForSecondsRealtime wait = new WaitForSecondsRealtime(delay);

        while (true)
        {
            number++;
            GotNumber?.Invoke(number);
            GetNumber(number);
            yield return wait;
        }
    }

    private void GetNumber(float number)
    {
        _number = number;
    }
}
