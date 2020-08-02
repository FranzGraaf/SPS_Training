using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class taster : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public int input_number;
    public void OnPointerDown(PointerEventData eventData)
    {
        VARIABLES_Conveyor.input[input_number] = true;
        this.GetComponent<Image>().color = new Color(0, 255, 0, 100);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        VARIABLES_Conveyor.input[input_number] = false;
        this.GetComponent<Image>().color = new Color(255, 255, 255, 100);
    }
}
