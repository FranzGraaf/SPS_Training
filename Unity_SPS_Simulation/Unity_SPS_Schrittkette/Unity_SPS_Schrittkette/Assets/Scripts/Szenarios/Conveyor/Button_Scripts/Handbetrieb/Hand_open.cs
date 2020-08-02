using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hand_open : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public void OnPointerDown(PointerEventData eventData)
    {
        //VARIABLES_Conveyor.gripper_speed = -30;
        VARIABLES_Conveyor.output[6] = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //VARIABLES_Conveyor.gripper_speed = 0;
        VARIABLES_Conveyor.output[6] = false;
    }
}