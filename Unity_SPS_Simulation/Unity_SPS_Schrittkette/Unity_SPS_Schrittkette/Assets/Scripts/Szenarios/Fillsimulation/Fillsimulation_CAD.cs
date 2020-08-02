using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fillsimulation_CAD : MonoBehaviour
{
    public Transform customPivot;
    float rotation_speed = 100;
    float pan_speed = 10;
    float scroll_speed = 150;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //Debug.Log("Pressed left click.");
            this.transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), -Input.GetAxis("Mouse X"), 0) * Time.deltaTime * rotation_speed, Space.World); // Rotation by mouse when clicked in world space
        }

        if (Input.GetMouseButton(1))
        {
            //Debug.Log("Pressed right click.");
        }

        if (Input.GetMouseButton(2))
        {
            //Debug.Log("Pressed middle click.");
            this.transform.localPosition = new Vector3(this.transform.localPosition.x+Input.GetAxis("Mouse X")*pan_speed, this.transform.localPosition.y+Input.GetAxis("Mouse Y")*pan_speed, this.transform.localPosition.z);
        }   

        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            //Debug.Log("Mouse Wheel.");
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y, this.transform.localPosition.z-Input.GetAxis("Mouse ScrollWheel")*scroll_speed);
        }
    }
}

