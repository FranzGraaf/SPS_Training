using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stempel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!(this.transform.localPosition.y>-204.2-100 && VARIABLES_Conveyor.push_speed>0) && !(this.transform.localPosition.y<-647.5 && VARIABLES_Conveyor.push_speed<0)){
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y+VARIABLES_Conveyor.push_speed*Time.deltaTime, this.transform.localPosition.z);
        }

        if(transform.localPosition.y>-204.2-150){
            VARIABLES_Conveyor.input[9] = true;
        }else{
            VARIABLES_Conveyor.input[9] = false;
        }
        if(transform.localPosition.y<-647.5+5){
            VARIABLES_Conveyor.input[10] = true;
        }else{
            VARIABLES_Conveyor.input[10] = false;
        }
    }
}