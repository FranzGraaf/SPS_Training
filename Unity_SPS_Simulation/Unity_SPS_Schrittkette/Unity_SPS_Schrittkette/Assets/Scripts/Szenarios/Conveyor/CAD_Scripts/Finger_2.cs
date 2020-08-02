using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finger_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += transform.TransformDirection (Vector3.right*VARIABLES_Conveyor.gripper_speed*Time.deltaTime);
        if(!(transform.localPosition.x>40 && VARIABLES_Conveyor.gripper_speed>0) && !(transform.localPosition.x<0 && VARIABLES_Conveyor.gripper_speed<0)){
            transform.localPosition = new Vector3(transform.localPosition.x+VARIABLES_Conveyor.gripper_speed*Time.deltaTime, 0, 0);
        }
    }
}
