using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dose : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localPosition.z<-5000)
        {
            Destroy(this.gameObject);
        }

        if(this.GetComponent<ConstantForce>().enabled)
        {
            this.GetComponent<Rigidbody>().AddForce(this.transform.parent.TransformDirection(new Vector3(0,0,-9.81f)), ForceMode.Force);
        }
        
        //Debug.DrawLine(this.transform.position, this.transform.position + this.transform.parent.TransformDirection(new Vector3(0,0,-100)), new Color(0, 0, 255, 100));
    }
}
