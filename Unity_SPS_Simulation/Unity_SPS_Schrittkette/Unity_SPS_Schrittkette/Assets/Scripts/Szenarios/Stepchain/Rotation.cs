using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    int speed = 1000;
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
            this.transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), -Input.GetAxis("Mouse X"), 0) * Time.deltaTime * speed, Space.World); // Rotation by mouse when clicked in world space
        }

        if (Input.GetMouseButton(1))
        {
            //Debug.Log("Pressed right click.");
        }

        if (Input.GetMouseButton(2))
        {
            //Debug.Log("Pressed middle click.");
        }
    }

}
