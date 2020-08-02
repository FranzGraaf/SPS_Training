using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heater : MonoBehaviour
{
    public int output_number;

    MeshRenderer mr;
    Material activated;
    Material deactivated;
    
    void Start()
    {
        mr = this.GetComponent<MeshRenderer>();
        activated = Resources.Load("Materials/heater_on", typeof(Material)) as Material;
        deactivated = Resources.Load("Materials/deactivated", typeof(Material)) as Material;
        mr.material = deactivated;
    }

    
    void Update()
    {
        if(VARIABLES_Fillsimulation.output[output_number])
        {
            mr.material = activated;
        }
        else{
            mr.material = deactivated;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(VARIABLES_Fillsimulation.output[output_number])
        {
            if(other.name == "Sphere(Clone)"){
                other.GetComponent<Renderer>().material.SetColor("_Color", other.GetComponent<Renderer>().material.GetColor("_Color") + new Color(0.1f*Time.deltaTime,0,0,0));
                //Debug.Log(other.GetComponent<Renderer>().material.GetColor("_Color")+new Color(0.1f,0.1f,0.1f,0.1f));
            }
        }
    }
}
