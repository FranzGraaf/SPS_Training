using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lackierpistole : MonoBehaviour
{
    MeshRenderer mr;
    Material can_blue;
    Material can_red;
    // Start is called before the first frame update
    void Start()
    {
        can_blue = Resources.Load("Materials/can_blue", typeof(Material)) as Material;
        can_red = Resources.Load("Materials/can_red", typeof(Material)) as Material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if(VARIABLES_Conveyor.paint)
        {
            VARIABLES_Conveyor.paint = false;
            if(Random.Range(0.0f, 1.0f)>0.5f)
            {
                other.GetComponent<MeshRenderer>().material = can_blue;
            } else{
                other.GetComponent<MeshRenderer>().material = can_red;
            }
        }
    }
}
