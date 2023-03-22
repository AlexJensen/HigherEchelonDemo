using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField]
    GameObject spinner;

    [SerializeField]
    int spinVelocity;

    bool clockwise = true;
    bool spinning = false;

    private void Update()
    {
        if (spinning)
        {
            spinner.transform.Rotate(new Vector3(0, 0, clockwise? -spinVelocity: spinVelocity));
        }
    }

    public void ToggleSpin()
    {
        spinning = !spinning;
    }
    public void ToggleClockwise()
    {
        clockwise = !clockwise;
    }
}
