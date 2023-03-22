using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Circle : VisualCounter
{
    public void ButtonPressed()
    {
        Counter++;
        Game.Instance.TotalRegisteredInput++;
    }
}
