using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fill_Sensor : MonoBehaviour
{
    public int input_number;
    MeshRenderer mr;
    Material activated;
    Material deactivated;

    int counter = 0;
    public int treshold = 110;

    
    void Start()
    {
        mr = this.GetComponent<MeshRenderer>();
        activated = Resources.Load("Materials/activated", typeof(Material)) as Material;
        deactivated = Resources.Load("Materials/deactivated", typeof(Material)) as Material;
        mr.material = deactivated;
    }

    
    void Update()
    {
        //Debug.Log(counter);
        if(counter>treshold){
            mr.material = activated;
            VARIABLES_Fillsimulation.input[input_number] = true;
        }
        else
        {
            mr.material = deactivated;
            VARIABLES_Fillsimulation.input[input_number] = false;
        }
    }


    void OnTriggerExit(Collider other)
    {
        if(other.name == "Sphere(Clone)"){
            counter --;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Sphere(Clone)"){
            counter ++;
        }
    }

}