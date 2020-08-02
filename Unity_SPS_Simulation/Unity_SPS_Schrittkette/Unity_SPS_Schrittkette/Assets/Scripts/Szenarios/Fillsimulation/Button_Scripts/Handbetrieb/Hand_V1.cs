using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hand_V1 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public int output_number;
    public void OnPointerDown(PointerEventData eventData)
    {
        VARIABLES_Fillsimulation.output[output_number] = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        VARIABLES_Fillsimulation.output[output_number] = false;
    }
}
