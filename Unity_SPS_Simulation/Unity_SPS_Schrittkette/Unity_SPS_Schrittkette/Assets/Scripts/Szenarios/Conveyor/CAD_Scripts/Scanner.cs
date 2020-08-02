using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanner : MonoBehaviour
{
    bool part_there = false;
    Collider part;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(VARIABLES_Conveyor.scan){
            if(part_there)
            {
                VARIABLES_Conveyor.paint = false;
                //Debug.Log(part.GetComponent<MeshRenderer>().material.name);
                if(part.GetComponent<MeshRenderer>().material.name == "can_blue (Instance)"){
                    VARIABLES_Conveyor.input[8] = true;
                } else{
                    VARIABLES_Conveyor.input[8] = false;
                }
            } else{
                VARIABLES_Conveyor.input[8] = false;
            }
        }

    }


    void OnTriggerEnter(Collider other)
    {
        part_there = true;
        part = other;
    }

    void OnTriggerExit(Collider other)
    {
        part_there = false;
    }
}
