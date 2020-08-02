using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magazin_marblerun : MonoBehaviour
{
    public int output_number;
    
    bool button_flag = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(VARIABLES_Marblerun.output[output_number] && button_flag){
            button_flag = false;

            GameObject select_item;
            GameObject clone_item;

            select_item = GameObject.Find("Murmel");
            clone_item = Instantiate(select_item, new Vector3(0,0,0), new Quaternion(0, 0, 0, 0));
            clone_item.transform.parent = GameObject.Find("Murmelbahn_V1").transform;
            clone_item.GetComponent<MeshRenderer>().enabled = true;
            clone_item.GetComponent<SphereCollider>().enabled = true;
            clone_item.AddComponent<marble_marblerun>();
            //clone_item.GetComponent<ConstantForce>().enabled = true;
            //clone_item.GetComponent<MeshRenderer>().enabled = true;
            //clone_item.GetComponent<MeshCollider>().enabled = true;
            //clone_item.GetComponent<ConstantForce>().enabled = true;
            clone_item.transform.localScale = new Vector3(10, 10, 10);
            clone_item.transform.localPosition = new Vector3(235f, -30f, 426f);
        }
        if(!VARIABLES_Marblerun.output[output_number]){
            button_flag = true;
        }
    }
}
