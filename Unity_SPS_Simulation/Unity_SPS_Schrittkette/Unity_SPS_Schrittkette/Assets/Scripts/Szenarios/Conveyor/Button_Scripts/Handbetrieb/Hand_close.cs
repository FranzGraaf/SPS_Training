using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hand_close : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    
    public void OnPointerDown(PointerEventData eventData)
    {
        //VARIABLES_Conveyor.gripper_speed = 30;
        VARIABLES_Conveyor.output[7] = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //VARIABLES_Conveyor.gripper_speed = 0;
        VARIABLES_Conveyor.output[7] = false;
    }
}