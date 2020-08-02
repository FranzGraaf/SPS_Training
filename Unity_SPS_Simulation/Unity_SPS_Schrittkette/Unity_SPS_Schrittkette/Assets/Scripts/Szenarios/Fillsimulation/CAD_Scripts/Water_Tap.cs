using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Tap : MonoBehaviour
{
    public int tap_number;
    float timerup;
    Material ball1_material;
    Material ball2_material;

    
    void Start()
    {
        ball1_material = Resources.Load("Materials/ball1_material", typeof(Material)) as Material;
        ball2_material = Resources.Load("Materials/ball2_material", typeof(Material)) as Material;
    }

    
    void Update()
    {
        timerup += Time.deltaTime;

        if(timerup > 0.1 && ((tap_number == 1 && VARIABLES_Fillsimulation.output[0])||(tap_number == 2 && VARIABLES_Fillsimulation.output[1]))){
            timerup = 0;
            for(int i = 0; i < 25; i++){
                GameObject select_item;
                GameObject clone_item;

                select_item = GameObject.Find("Sphere");
                clone_item = Instantiate(select_item, new Vector3(0,0,0), new Quaternion(0, 0, 0, 0));
                clone_item.transform.parent = GameObject.Find("Fuellsimulation_V1").transform;
                //clone_item.GetComponent<Rigidbody>().useGravity = true;
                clone_item.GetComponent<MeshRenderer>().enabled = true;
                clone_item.GetComponent<SphereCollider>().enabled = true;
                clone_item.AddComponent<Balls>();
                //clone_item.GetComponent<ConstantForce>().enabled = true;
                //clone_item.GetComponent<MeshRenderer>().enabled = true;
                //clone_item.GetComponent<MeshCollider>().enabled = true;
                //clone_item.GetComponent<ConstantForce>().enabled = true;
                //clone_item.transform.localScale = new Vector3(1, 1, 1);
                //clone_item.transform.localRotation = Quaternion.Euler(0, 0, 0);
                //clone_item.transform.localPosition = new Vector3(-8.16f, 7.75f, 30.24f);
                if(tap_number == 1){
                    clone_item.GetComponent<Renderer>().material = ball1_material;
                    clone_item.transform.localPosition = new Vector3(760, -113f, 1129f);
                }else{
                    clone_item.GetComponent<Renderer>().material = ball2_material;
                    clone_item.transform.localPosition = new Vector3(-716, -113f, 1129f);
                }
                
            }
        }
    }
}
