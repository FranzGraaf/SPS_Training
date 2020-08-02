using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hand_paint : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //VARIABLES_Conveyor.paint = true;
        VARIABLES_Conveyor.output[3] = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //VARIABLES_Conveyor.paint = false;
        VARIABLES_Conveyor.output[3] = false;
    }
}
