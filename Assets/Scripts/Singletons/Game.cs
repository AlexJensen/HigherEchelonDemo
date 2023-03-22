using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : Singleton<Game>
{
    [SerializeField]
    int registeredInputMax;
    private int totalRegisteredInput = 0;

    public int TotalRegisteredInput
    {
        get => totalRegisteredInput; 
        set
        {
            totalRegisteredInput = value;
            if (totalRegisteredInput >= registeredInputMax)
            {

            }
        }
    }
}
