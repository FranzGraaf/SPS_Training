using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marblerun_sensor : MonoBehaviour
{
public int input_number;
    MeshRenderer mr;
    Material activated;
    Material deactivated;

    // Start is called before the first frame update
    void Start()
    {
        mr = this.GetComponent<MeshRenderer>();
        activated = Resources.Load("Materials/activated", typeof(Material)) as Material;
        deactivated = Resources.Load("Materials/deactivated", typeof(Material)) as Material;
        mr.material = deactivated;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerExit(Collider other)
    {
        if(other.name == "Murmel(Clone)"){
            mr.material = deactivated;
            VARIABLES_Marblerun.input[input_number] = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Murmel(Clone)"){
            mr.material = activated;
            VARIABLES_Marblerun.input[input_number] = true;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.name == "Murmel(Clone)"){
            mr.material = activated;
            VARIABLES_Marblerun.input[input_number] = true;
        }
    }
}