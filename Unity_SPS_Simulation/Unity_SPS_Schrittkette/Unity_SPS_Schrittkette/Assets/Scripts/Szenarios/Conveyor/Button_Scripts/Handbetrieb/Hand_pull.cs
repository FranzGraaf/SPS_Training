using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hand_pull : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    
    public void OnPointerDown(PointerEventData eventData)
    {
        //VARIABLES_Conveyor.push_speed = -500;
        VARIABLES_Conveyor.output[12] = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //VARIABLES_Conveyor.push_speed = 0;
        VARIABLES_Conveyor.output[12] = false;
    }
}