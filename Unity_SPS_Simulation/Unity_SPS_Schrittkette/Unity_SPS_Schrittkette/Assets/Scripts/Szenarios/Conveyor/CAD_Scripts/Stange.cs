using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!(this.transform.localPosition.z>0 && VARIABLES_Conveyor.stange_speed>0) && !(this.transform.localPosition.z<-42.9 && VARIABLES_Conveyor.stange_speed<0)){
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y, this.transform.localPosition.z+VARIABLES_Conveyor.stange_speed*Time.deltaTime);
        }

        if(transform.localPosition.z>0-5){
            VARIABLES_Conveyor.input[4] = true;
        }else{
            VARIABLES_Conveyor.input[4] = false;
        }
        if(transform.localPosition.z<-42.9+5){
            VARIABLES_Conveyor.input[5] = true;
        }else{
            VARIABLES_Conveyor.input[5] = false;
        }
    }
}
