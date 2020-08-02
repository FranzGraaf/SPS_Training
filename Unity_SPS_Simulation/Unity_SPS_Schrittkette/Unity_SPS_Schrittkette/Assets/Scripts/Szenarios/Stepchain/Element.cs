using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Element : MonoBehaviour
{
    public int index;
    MeshRenderer mr;
    Material activated;
    Material deactivated;

    // Start is called before the first frame update
    void Start()
    {
        mr = this.GetComponent<MeshRenderer>();
        activated = Resources.Load("Materials/activated", typeof(Material)) as Material;
        deactivated = Resources.Load("Materials/deactivated", typeof(Material)) as Material;
    }

    // Update is called once per frame
    void Update()
    {
        if(VARIABLES_Stepchain.output[index]){
            mr.material = activated;
        }
        else {
            mr.material = deactivated;
        }
    }
}
