using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private ButtonDetector _buttonDetector;

    private Coroutine _coroutine;
    private float _delay = 0.5f;
    private float _number = 0f;

    public event Action<float> ValueChanged;

    private void OnEnable() => _buttonDetector.Click += OnClick;

    private void OnDisable() => _buttonDetector.Click -= OnClick;

    private void OnClick(bool isClickStats)
    {
        if (isClickStats)
            _coroutine = StartCoroutine(StartIncreasingNumber(_delay, _number));
        else
            if (_coroutine != null)
              StopCoroutine(_coroutine);
    }

    private IEnumerator StartIncreasingNumber(float delay, float number)
    {
        WaitForSecondsRealtime wait = new WaitForSecondsRealtime(delay);

        while (true)
        {
            number++;
            ValueChanged?.Invoke(number);
            _number = number;
            yield return wait;
        }
    }
}
