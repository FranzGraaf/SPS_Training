using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hand_left : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    
    public void OnPointerDown(PointerEventData eventData)
    {
        //VARIABLES_Conveyor.belt_speed = -2;
        VARIABLES_Conveyor.output[2] = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //VARIABLES_Conveyor.belt_speed = 0;
        VARIABLES_Conveyor.output[2] = false;
    }
}