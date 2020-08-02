using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drehring : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localRotation = Quaternion.Euler(0, 0, this.transform.localRotation.eulerAngles.z+VARIABLES_Conveyor.rot_speed*Time.deltaTime);

        if(transform.localRotation.eulerAngles.z>15 && transform.localRotation.eulerAngles.z<20){
            VARIABLES_Conveyor.input[3] = true;
        }else{
            VARIABLES_Conveyor.input[3] = false;
        }
    }
}
