using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Switch : VisualCounter
{
    [SerializeField]
    bool selecting = false, switchUp = false;
    [SerializeField]
    Animator animator;
    [SerializeField]
    Spinner spinner;
    [SerializeField]
    RectTransform lever;
    [SerializeField]
    int downAngle, upAngle;

    Vector2 dragStartPosition;

    void Update()
    {
        if (!switchUp)
        {
            if (selecting && Input.GetMouseButtonUp(0))
            {
                selecting = false;
                if (Input.mousePosition.y > dragStartPosition.y)
                {
                    animator.SetTrigger("Flip");
                    Counter++;
                    Game.Instance.TotalRegisteredInput++;
                    spinner.ToggleClockwise();
                }
            }
            else if (Input.GetMouseButtonDown(0))
            {
                // Convert mouse position to local position in the RectTransform
                Vector2 localMousePos;
                RectTransformUtility.ScreenPointToLocalPointInRectangle(lever, Input.mousePosition, null, out localMousePos);

                // Check if the local position is inside the RectTransform
                if (lever.rect.Contains(localMousePos))
                {
                    selecting = true;
                    dragStartPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                }
            }
        }
    }
}