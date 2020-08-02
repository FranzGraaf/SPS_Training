using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(VARIABLES_Fillsimulation.output[9]){
            this.transform.Rotate(new Vector3(0,0,1), 5);
        }
    }
}
