using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ventil_marblerun : MonoBehaviour
{
public int output_number;
    public int direction; // either 1 or -1

    void Start()
    {
        if(direction>=0){direction = 1;}else{direction = -1;}
    }

    void Update()
    {
        if(VARIABLES_Marblerun.output[output_number] && Mathf.Abs(transform.localPosition.x)<50)
        {
            transform.localPosition = transform.localPosition+new Vector3(3,0,0)*direction;
        }
        else if(!VARIABLES_Marblerun.output[output_number] && Mathf.Abs(transform.localPosition.x)>0)
        {
            transform.localPosition = transform.localPosition-new Vector3(3,0,0)*direction;
        }
    }
}