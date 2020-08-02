using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hand_rotl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    
    public void OnPointerDown(PointerEventData eventData)
    {
        //VARIABLES_Conveyor.rot_speed = -50;
        VARIABLES_Conveyor.output[9] = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //VARIABLES_Conveyor.rot_speed = 0;
        VARIABLES_Conveyor.output[9] = false;
    }
}