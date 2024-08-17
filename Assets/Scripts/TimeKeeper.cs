using UnityEngine;

public class TimeKeeper : MonoBehaviour
{
    private float _number;

    public float GiveNumber => _number;

    private void Start()
    {
        _number = 0f;
    }

    public void GetNumber (float number) 
    {
        _number = number;
    }
}
