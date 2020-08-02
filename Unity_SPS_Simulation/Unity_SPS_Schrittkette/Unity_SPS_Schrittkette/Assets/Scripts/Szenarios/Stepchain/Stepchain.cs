using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using S7.Net;

public class Stepchain : MonoBehaviour
{

    Button back;
    Button set;
    Plc plc;
    bool plc_enable = false;
    
    void Start()
    {
        back = GameObject.Find("Back_Button").GetComponent<Button>();
        back.onClick.AddListener(back_click);
        set = GameObject.Find("Settings_Button").GetComponent<Button>();
        set.onClick.AddListener(set_click);

        plc = new Plc(CpuType.S71200, "127.0.0.1", 0, 1);
        plc.Open();
        plc_enable = true;

        /*ErrorCode result = plc.Open();
        if (result != ErrorCode.NoError)
        {
            Debug.Log("Error: " + plc.LastErrorCode + "\n" + plc.LastErrorString);
        }
        else
        {
            plc_enable = true;
        }*/
        
    }



    void back_click(){
        SceneManager.LoadScene("Main_Menu", LoadSceneMode.Single);
    }

    void set_click(){
        SceneManager.LoadScene("Stepchain_Settings", LoadSceneMode.Single);
    }

    
    void Update()
    {
        if(plc_enable){
            for(int i = 0; i < VARIABLES_Stepchain.input_adresse.Length; i++){
                plc.Write(VARIABLES_Stepchain.input_adresse[i], VARIABLES_Stepchain.input[i]);
            }

            for(int i = 0; i < VARIABLES_Stepchain.output_adresse.Length; i++){
                VARIABLES_Stepchain.output[i] = (bool)plc.Read(VARIABLES_Stepchain.output_adresse[i]);
            }
        }

    }
}
