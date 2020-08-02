using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class schalter_fill : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public int input_number;
    bool flag = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        if(flag){
            VARIABLES_Fillsimulation.input[input_number] = false;
            flag = false;
            this.GetComponent<Image>().color = new Color(255, 255, 255, 100);
        } else {
            VARIABLES_Fillsimulation.input[input_number] = true;
            flag = true;
            this.GetComponent<Image>().color = new Color(0, 255, 0, 100);
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {

    }
}
