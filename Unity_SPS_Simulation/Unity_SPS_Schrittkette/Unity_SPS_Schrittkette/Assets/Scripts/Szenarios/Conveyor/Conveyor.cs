using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using S7.Net;
using TMPro;
using System;
using System.Threading;


public class Conveyor : MonoBehaviour
{

    Button back;
    Button settings;
    Button start;
    Button pause;
    Button reset;
    Button handbetrieb;
    Button bedienpult;

    TextMeshProUGUI debug_text;

    Plc plc;
    bool plc_enable = false;

// Für die Funktion Maschinenfunktionen
    bool new_object_flag = false;
    bool paint_flag = false;

    Thread plc_r_w;
    Timer plc_timer;
    

    
    
    void Start()
    {
        //debug_text = GameObject.Find("debug_text").GetComponent<TextMeshProUGUI>();
        plc_r_w = new Thread(plc_r_w_func);
        plc_r_w.Start();
        //plc_timer = new Timer(new TimerCallback(plc_r_w_func), null, 0, 100);

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

        //StartCoroutine("PLC_Read_Write");

        plc = new Plc(CpuType.S71200, "127.0.0.1", 0, 1);
        plc.Open();
        plc_enable = true;
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
        SceneManager.LoadScene("Conveyor_Settings", LoadSceneMode.Single);
    }

    void start_click(){
        VARIABLES_Conveyor.plc_control = false;
    }
    void pause_click(){
        
    }
    void reset_click(){
        
    }
    void hand_click(){
        VARIABLES_Conveyor.plc_control = false;
    }
    void bedien_click(){
        VARIABLES_Conveyor.plc_control = true;
    }

    
    void Update()
    {
        Maschinenfunktionen();
    }


    void plc_r_w_func(object state)
    {
        while(true){
            if(VARIABLES_Conveyor.plc_control)
            {
                if(plc_enable)
                {
                    for(int i = 0; i < VARIABLES_Conveyor.input_adresse.Length; i++){
                        try{
                            //print("----------------");
                            //print(VARIABLES_Conveyor.input_adresse[0]);
                            print(VARIABLES_Conveyor.input[0]);
                            //print("----------------");
                            plc.Write(VARIABLES_Conveyor.input_adresse[i], VARIABLES_Conveyor.input[i]);
                        } catch{

                        }
                    }

                    for(int i = 0; i < VARIABLES_Conveyor.output_adresse.Length; i++){
                        try{
                        VARIABLES_Conveyor.output[i] = (bool)plc.Read(VARIABLES_Conveyor.output_adresse[i]);
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

    IEnumerator PLC_Read_Write() // Coroutine not used as the thread is used instead
    {
        if(VARIABLES_Conveyor.plc_control)
        {
            if(plc_enable)
            {
                for(int i = 0; i < VARIABLES_Conveyor.input_adresse.Length; i++){
                    try{
                        plc.Write(VARIABLES_Conveyor.input_adresse[i], VARIABLES_Conveyor.input[i]);
                    } catch{

                    }
                }

                for(int i = 0; i < VARIABLES_Conveyor.output_adresse.Length; i++){
                    try{
                    VARIABLES_Conveyor.output[i] = (bool)plc.Read(VARIABLES_Conveyor.output_adresse[i]);
                    } catch{

                    }
                }
            }
        }
    
        yield return new WaitForSeconds(0.1f);
        StartCoroutine("PLC_Read_Write");
    }




    void Maschinenfunktionen()
    {
        if(VARIABLES_Conveyor.output[0])
        {
            if(!new_object_flag)
            {
                new_can();
            }
            new_object_flag = true;
        } else {
            new_object_flag = false;
        }

        if(VARIABLES_Conveyor.output[1])
        {
            VARIABLES_Conveyor.belt_speed = 2;
        }
        if(VARIABLES_Conveyor.output[2])
        {
            VARIABLES_Conveyor.belt_speed = -2;
        }
        if(!VARIABLES_Conveyor.output[1] && !VARIABLES_Conveyor.output[2])
        {
            VARIABLES_Conveyor.belt_speed = 0;
        }

        if(VARIABLES_Conveyor.output[3])
        {
            if(!paint_flag)
            {
                VARIABLES_Conveyor.paint = true;
            } else {
                VARIABLES_Conveyor.paint = false;
            }
            paint_flag = true;
            // vllt eine Sprühanimation einfügen
        } else {
            paint_flag = false;
            VARIABLES_Conveyor.paint = false;
        }

        if(VARIABLES_Conveyor.output[4])
        {
            VARIABLES_Conveyor.stange_speed = 50;
        }
        if(VARIABLES_Conveyor.output[5])
        {
            VARIABLES_Conveyor.stange_speed = -50;
        }
        if(!VARIABLES_Conveyor.output[4] && !VARIABLES_Conveyor.output[5])
        {
            VARIABLES_Conveyor.stange_speed = 0;
        }


        if(VARIABLES_Conveyor.output[6])
        {
            VARIABLES_Conveyor.gripper_speed = -30;
        }
        if(VARIABLES_Conveyor.output[7])
        {
            VARIABLES_Conveyor.gripper_speed = 30;
        }
        if(!VARIABLES_Conveyor.output[6] && !VARIABLES_Conveyor.output[7])
        {
            VARIABLES_Conveyor.gripper_speed = 0;
        }

        if(VARIABLES_Conveyor.output[8])
        {
            VARIABLES_Conveyor.rot_speed = 50;
        }
        if(VARIABLES_Conveyor.output[9])
        {
            VARIABLES_Conveyor.rot_speed = -50;
        }
        if(!VARIABLES_Conveyor.output[8] && !VARIABLES_Conveyor.output[9])
        {
            VARIABLES_Conveyor.rot_speed = 0;
        }

        if(VARIABLES_Conveyor.output[10])
        {
            VARIABLES_Conveyor.scan = true;
            // vllt eine Scananimation einfügen
        } else {
            VARIABLES_Conveyor.scan = false;
        }

        if(VARIABLES_Conveyor.output[11])
        {
            VARIABLES_Conveyor.push_speed = 3000;
        }
        if(VARIABLES_Conveyor.output[12])
        {
            VARIABLES_Conveyor.push_speed = -500;
        }
        if(!VARIABLES_Conveyor.output[11] && !VARIABLES_Conveyor.output[12])
        {
            VARIABLES_Conveyor.push_speed = 0;
        }
    }

    void new_can()
    {
        GameObject select_item;
        GameObject clone_item;

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