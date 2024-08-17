using UnityEngine;

public class ButtonDetector : MonoBehaviour
{
    public bool Click { get; private set; }


    private void Start()
    {
        Click = true;    
    }

    public bool ButtonClick()
    {
        if (Click)
            Click = false;
        else
            Click = true;

        return Click;
    }
}
