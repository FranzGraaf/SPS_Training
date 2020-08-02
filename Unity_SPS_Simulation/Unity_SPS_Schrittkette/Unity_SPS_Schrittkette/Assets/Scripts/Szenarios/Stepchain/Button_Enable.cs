using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine;

public class Button_Enable : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public int index;
    public void OnPointerDown(PointerEventData eventData)
    {
        VARIABLES_Stepchain.input[index] = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        VARIABLES_Stepchain.input[index] = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
