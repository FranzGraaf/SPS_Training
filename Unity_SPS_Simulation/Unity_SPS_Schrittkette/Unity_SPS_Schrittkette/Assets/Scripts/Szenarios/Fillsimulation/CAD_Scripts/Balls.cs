using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody>().AddForce(this.transform.parent.TransformDirection(new Vector3(0,0,-2000f)), ForceMode.Force);
        if(this.transform.localPosition.z < -2000){Destroy(this.gameObject);}
    }
}
