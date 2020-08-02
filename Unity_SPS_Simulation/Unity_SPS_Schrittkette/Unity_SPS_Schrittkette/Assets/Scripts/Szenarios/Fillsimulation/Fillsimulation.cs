using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using S7.Net;
using TMPro;
using System;
using System.Threading;

public class Fillsimulation : MonoBehaviour
{

    Button back;
    Button settings;
    Button start;
    Button pause;
    Button reset;
    Button handbetrieb;
    Button bedienpult;



    Thread plc_r_w;
    Plc plc;
    bool plc_enable = false;




    void Start()
    {
        plc_r_w = new Thread(plc_r_w_func);
        plc_r_w.Start();

        back = GameObject.Find("Back_Button").GetComponent<Button>();
        back.onClick.AddListener(back_click);
        settings = GameObject.Find("Settings_Button").GetComponent<Button>();
        settings.onClick.AddListener(settings_click);

        start = GameObject.Find("Sim_Start_Button").GetComponent<Button>();
        start.onClick.AddListener(start_click);
        pause = GameObject.Find("Sim_Pause_Button").GetComponent<Button>();
        pause.onClick.AddListener(pause_click);
        reset = GameObject.Find("Sim_Reset_Button").GetComponent<Button>();
        reset.onClick.AddListener(reset_click);
        handbetrieb = GameObject.Find("Sim_Hand_Button").GetComponent<Button>();
        handbetrieb.onClick.AddListener(hand_click);
        bedienpult = GameObject.Find("Sim_Bedien_Button").GetComponent<Button>();
        bedienpult.onClick.AddListener(bedien_click);


        plc = new Plc(CpuType.S71200, "127.0.0.1", 0, 1);
        plc.Open();
        plc_enable = true;
    }


    void Update()
    {

    }

    void OnDestroy()
    {
        //plc_timer.Change(Timeout.Infinite,Timeout.Infinite);
        plc_r_w.Suspend();
    }



    void back_click(){
        SceneManager.LoadScene("Main_Menu", LoadSceneMode.Single);
    }

    void settings_click(){
        SceneManager.LoadScene("Fillsimulation_Settings", LoadSceneMode.Single);
    }

        void start_click(){
        VARIABLES_Fillsimulation.plc_control = false;
    }
    void pause_click(){
        
    }
    void reset_click(){
        
    }
    void hand_click(){
        VARIABLES_Fillsimulation.plc_control = false;
    }
    void bedien_click(){
        VARIABLES_Fillsimulation.plc_control = true;
    }




        void plc_r_w_func(object state)
    {
        while(true){
            if(VARIABLES_Fillsimulation.plc_control)
            {
                if(plc_enable)
                {
                    for(int i = 0; i < VARIABLES_Fillsimulation.input_adresse.Length; i++){
                        try{
                            plc.Write(VARIABLES_Fillsimulation.input_adresse[i], VARIABLES_Fillsimulation.input[i]);
                        } catch{

                        }
                    }

                    for(int i = 0; i < VARIABLES_Fillsimulation.output_adresse.Length; i++){
                        try{
                        VARIABLES_Fillsimulation.output[i] = (bool)plc.Read(VARIABLES_Fillsimulation.output_adresse[i]);
                        } catch{

                        }
                    }
                }
            }
            //Debug.Log("Thread_running");
            Thread.Sleep(1);
        }
        //plc_r_w = new Thread(plc_r_w_func);
        //plc_r_w.Start();
    }
}
