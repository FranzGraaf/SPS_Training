using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marble_marblerun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody>().AddForce(this.transform.parent.TransformDirection(new Vector3(0,0,-500f)), ForceMode.Force);
        if(this.transform.localPosition.z < -350){Destroy(this.gameObject);}
    }
}
