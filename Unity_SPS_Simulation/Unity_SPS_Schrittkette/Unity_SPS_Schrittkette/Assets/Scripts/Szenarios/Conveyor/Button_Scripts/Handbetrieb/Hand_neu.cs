using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Hand_neu : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    GameObject select_item;
    GameObject clone_item;
    // Start is called before the first frame update
    void Start()
    {
        //this.GetComponent<Button>().onClick.AddListener(new_can);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        VARIABLES_Conveyor.output[0] = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        VARIABLES_Conveyor.output[0] = false;
    }

    void new_can()
    {
        select_item = GameObject.Find("Dose");
        clone_item = Instantiate(select_item, new Vector3(0,0,0), new Quaternion(0, 0, 0, 0));
        clone_item.transform.parent = GameObject.Find("Conveyor_CAD").transform;
        //clone_item.GetComponent<Rigidbody>().useGravity = true;
        clone_item.GetComponent<MeshRenderer>().enabled = true;
        clone_item.GetComponent<MeshCollider>().enabled = true;
        clone_item.GetComponent<ConstantForce>().enabled = true;
        clone_item.transform.localScale = new Vector3(1, 1, 1);
        clone_item.transform.localRotation = Quaternion.Euler(0, 0, 0);
        clone_item.transform.localPosition = new Vector3(906, -95.2f, 578.2f);
    }

    
}
