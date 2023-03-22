using TMPro;
using UnityEngine;

public class VisualCounter : MonoBehaviour
{
    [SerializeField]
    TMP_Text counterText;

    int counter = 0;

    public int Counter
    {
        get => counter;
        set
        {
            counter = value;
            counterText.text = value.ToString();
        }
    }
}
