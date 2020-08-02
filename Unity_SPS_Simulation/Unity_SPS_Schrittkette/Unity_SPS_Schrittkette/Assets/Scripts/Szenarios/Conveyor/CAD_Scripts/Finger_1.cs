using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finger_1 : MonoBehaviour
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

        if(transform.localPosition.x>40-5){
            VARIABLES_Conveyor.input[7] = true;
        }else{
            VARIABLES_Conveyor.input[7] = false;
        }
        if(transform.localPosition.x<0+5){
            VARIABLES_Conveyor.input[6] = true;
        }else{
            VARIABLES_Conveyor.input[6] = false;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.name == "Dose(Clone)"){
            other.transform.localRotation = Quaternion.Euler(other.transform.localRotation.eulerAngles.x, other.transform.localRotation.eulerAngles.y, other.transform.localRotation.eulerAngles.z+VARIABLES_Conveyor.rot_speed*Time.deltaTime);
            if(!(VARIABLES_Conveyor.input[4] || VARIABLES_Conveyor.input[5])){
                other.transform.localPosition = new Vector3(other.transform.localPosition.x, other.transform.localPosition.y, other.transform.localPosition.z+VARIABLES_Conveyor.stange_speed*Time.deltaTime); // nur bis Endlage erreicht ist
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.name == "Dose(Clone)"){
            //other.GetComponent<Rigidbody>().useGravity = true;
            other.GetComponent<ConstantForce>().enabled = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Dose(Clone)"){
            //other.GetComponent<Rigidbody>().useGravity = false;
            other.GetComponent<ConstantForce>().enabled = false;
        }
    }

}
