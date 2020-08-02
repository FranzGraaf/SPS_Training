using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_Menu : MonoBehaviour
{

    Button stepchain;
    Button conveyor;
    Button fillsimulation;
    Button ins_Step7;
    Button ins_TIA;

    Ray ray;
    RaycastHit hit;

    Rigidbody Stepchain_CAD;
    Rigidbody Foerderband_V1_CAD;
    Rigidbody Fuellsimulation_V1_CAD;
    Rigidbody Murmelbahn_V1;



    void Start()
    {
        /*stepchain = GameObject.Find("Select_Stepchain_Button").GetComponent<Button>();
        conveyor = GameObject.Find("Select_Conveyor_Button").GetComponent<Button>();
        fillsimulation = GameObject.Find("Select_Fillsimulation_Button").GetComponent<Button>();*/

        ins_Step7 = GameObject.Find("instruction_Step7_Button").GetComponent<Button>();
        ins_TIA = GameObject.Find("instruction_TIA_Button").GetComponent<Button>();

        Stepchain_CAD = GameObject.Find("Stepchain_CAD").GetComponent<Rigidbody>();
        Foerderband_V1_CAD = GameObject.Find("Foerderband_V1_CAD").GetComponent<Rigidbody>();
        Fuellsimulation_V1_CAD = GameObject.Find("Fuellsimulation_V1_CAD").GetComponent<Rigidbody>();
        Murmelbahn_V1 = GameObject.Find("Murmelbahn_V1").GetComponent<Rigidbody>();

        /*stepchain.onClick.AddListener(stepchain_click);
        conveyor.onClick.AddListener(conveyor_click);
        fillsimulation.onClick.AddListener(fillsimulation_click);*/
        ins_Step7.onClick.AddListener(ins_Step7_click);
        ins_TIA.onClick.AddListener(ins_TIA_click);
    }


    /*void stepchain_click(){
        SceneManager.LoadScene("Stepchain", LoadSceneMode.Single);
    }

    void conveyor_click(){
        SceneManager.LoadScene("Conveyor", LoadSceneMode.Single);
    }

    void fillsimulation_click(){
        SceneManager.LoadScene("Fillsimulation", LoadSceneMode.Single);
    }*/

    void ins_Step7_click(){
        SceneManager.LoadScene("Instructions_Step7", LoadSceneMode.Single);
    }

    void ins_TIA_click(){
        SceneManager.LoadScene("Instructions_TIA", LoadSceneMode.Single);
    }


    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit))
        {
            //print (hit.collider.name);
            if(hit.collider.name == "Stepchain_CAD"){
                //Debug.Log("drehen");
                Stepchain_CAD.angularVelocity = new Vector3(0, 1, 0);
            } else {
                Stepchain_CAD.angularVelocity = new Vector3(0, 0, 0);
                Stepchain_CAD.transform.eulerAngles = new Vector3(0, 0, 0);
            }

            if(hit.collider.name == "Foerderband_V1_CAD"){
                //Debug.Log("drehen");
                Foerderband_V1_CAD.angularVelocity = new Vector3(0, 1, 0);
            } else {
                Foerderband_V1_CAD.angularVelocity = new Vector3(0, 0, 0);
                Foerderband_V1_CAD.transform.eulerAngles = new Vector3(-117.17f, 0, 180);
            }

            if(hit.collider.name == "Fuellsimulation_V1_CAD"){
                //Debug.Log("drehen");
                Fuellsimulation_V1_CAD.angularVelocity = new Vector3(0, 1, 0);
            } else {
                Fuellsimulation_V1_CAD.angularVelocity = new Vector3(0, 0, 0);
                Fuellsimulation_V1_CAD.transform.eulerAngles = new Vector3(-90, 0, 180);
                Fuellsimulation_V1_CAD.transform.localPosition = new Vector3(196, 73, -134);
            }

            if(hit.collider.name == "Murmelbahn_V1"){
                //Debug.Log("drehen");
                Murmelbahn_V1.angularVelocity = new Vector3(0, 1, 0);
            } else {
                Murmelbahn_V1.angularVelocity = new Vector3(0, 0, 0);
                Murmelbahn_V1.transform.eulerAngles = new Vector3(-90, 180, 0);
            }
        } else{
            Stepchain_CAD.angularVelocity = new Vector3(0, 0, 0);
            Stepchain_CAD.transform.eulerAngles = new Vector3(0, 0, 0);

            Foerderband_V1_CAD.angularVelocity = new Vector3(0, 0, 0);
            Foerderband_V1_CAD.transform.eulerAngles = new Vector3(-117.17f, 0, 180);

            Fuellsimulation_V1_CAD.angularVelocity = new Vector3(0, 0, 0);
            Fuellsimulation_V1_CAD.transform.eulerAngles = new Vector3(-90, 0, 180);
            Fuellsimulation_V1_CAD.transform.localPosition = new Vector3(196, 73, -134);

            Murmelbahn_V1.angularVelocity = new Vector3(0, 0, 0);
            Murmelbahn_V1.transform.eulerAngles = new Vector3(-90, 180, 0);
        }
    }
}


