using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Belt : MonoBehaviour
{

    public GameObject belt;
    public Transform endpoint;
    


    void OnTriggerStay(Collider other)
    {
        other.transform.position = /*new Vector3(*/Vector3.MoveTowards(other.transform.position, endpoint.position, VARIABLES_Conveyor.belt_speed*Time.deltaTime);//.x, other.transform.position.y, other.transform.position.z);
    }
}
