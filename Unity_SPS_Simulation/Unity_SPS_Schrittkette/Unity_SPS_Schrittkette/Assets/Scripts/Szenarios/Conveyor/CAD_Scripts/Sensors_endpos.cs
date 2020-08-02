using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensors_endpos : MonoBehaviour
{
    public int sensor_number;
    MeshRenderer mr;
    Light l;
    Material activated;
    Material deactivated;

    
    void Start()
    {
        mr = this.GetComponent<MeshRenderer>();
        l = this.GetComponent<Light>();
        activated = Resources.Load("Materials/activated", typeof(Material)) as Material;
        deactivated = Resources.Load("Materials/deactivated", typeof(Material)) as Material;
    }

    
    void Update()
    {
        if(VARIABLES_Conveyor.input[sensor_number]){
            mr.material = activated;
            l.enabled = true;
        } 
        else{
            mr.material = deactivated;
            l.enabled = false;
        }
    }
}
