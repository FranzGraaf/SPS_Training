using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weiche_marblerun : MonoBehaviour
{
    float local_angle_z = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localEulerAngles.z > 180){
            local_angle_z = transform.localEulerAngles.z-360f;
        } else{
            local_angle_z = transform.localEulerAngles.z;
        }

        // links von oben drauf geschaut
        if(VARIABLES_Marblerun.output[2]){ 
            if(local_angle_z > 39){
                transform.Rotate(0,0,-0.5f, Space.Self);
            }
            if(local_angle_z < 37){
                transform.Rotate(0,0,0.5f, Space.Self);
            }
        }

        // mitte von oben drauf geschaut
        if(VARIABLES_Marblerun.output[3]){ 
            if(local_angle_z > 1){
                transform.Rotate(0,0,-0.5f, Space.Self);
            }
            if(local_angle_z < -1){
                transform.Rotate(0,0,0.5f, Space.Self);
            }
        }

        // rechts von oben drauf geschaut
        if(VARIABLES_Marblerun.output[4]){
            if(local_angle_z > -37){
                transform.Rotate(0,0,-0.5f, Space.Self);
            }
            if(local_angle_z < -39){
                transform.Rotate(0,0,0.5f, Space.Self);
            }
        }
    }
}
