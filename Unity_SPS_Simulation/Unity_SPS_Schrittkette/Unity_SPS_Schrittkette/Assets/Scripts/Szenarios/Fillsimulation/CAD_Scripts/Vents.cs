using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vents : MonoBehaviour
{
    public int output_number;
    public int direction; // either 1 or -1

    void Start()
    {
        if(direction>=0){direction = 1;}else{direction = -1;}
    }

    void Update()
    {
        if(VARIABLES_Fillsimulation.output[output_number] && Mathf.Abs(transform.localPosition.x)<250)
        {
            transform.localPosition = transform.localPosition+new Vector3(10,0,0)*direction;
        }
        else if(!VARIABLES_Fillsimulation.output[output_number] && Mathf.Abs(transform.localPosition.x)>0)
        {
            transform.localPosition = transform.localPosition-new Vector3(10,0,0)*direction;
        }
    }
}
