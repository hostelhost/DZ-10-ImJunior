using UnityEngine;

public class TimeKeeper : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    private float _number;

    public float GiveNumber => _number;

    private void OnEnable() => _timer.NextNumber += GetNumber;

    private void OnDisable() => _timer.NextNumber -= GetNumber;

    private void Start()
    {
        _number = 0f;
    }

    private void GetNumber (float number) 
    {
        _number = number;
    }
}
