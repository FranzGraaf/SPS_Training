using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Stepchain_Settings : MonoBehaviour
{
    Button back;
    Button save;
    TMP_InputField Ienable;
    TMP_InputField I1;
    TMP_InputField I2;
    TMP_InputField I3;
    TMP_InputField I4;
    TMP_InputField O1;
    TMP_InputField O2;
    TMP_InputField O3;
    TMP_InputField O4;
    
    void Start()
    {
        back = GameObject.Find("Back_Button").GetComponent<Button>();
        back.onClick.AddListener(back_click);
        save = GameObject.Find("Save_Button").GetComponent<Button>();
        save.onClick.AddListener(save_click);

        Ienable = GameObject.Find("InputField_Ienable").GetComponent<TMP_InputField>();
        I1 = GameObject.Find("InputField_I1").GetComponent<TMP_InputField>();
        I2 = GameObject.Find("InputField_I2").GetComponent<TMP_InputField>();
        I3 = GameObject.Find("InputField_I3").GetComponent<TMP_InputField>();
        I4 = GameObject.Find("InputField_I4").GetComponent<TMP_InputField>();
        O1 = GameObject.Find("InputField_O1").GetComponent<TMP_InputField>();
        O2 = GameObject.Find("InputField_O2").GetComponent<TMP_InputField>();
        O3 = GameObject.Find("InputField_O3").GetComponent<TMP_InputField>();
        O4 = GameObject.Find("InputField_O4").GetComponent<TMP_InputField>();

        Ienable.text = VARIABLES_Stepchain.input_adresse[0];
        I1.text = VARIABLES_Stepchain.input_adresse[1];
        I2.text = VARIABLES_Stepchain.input_adresse[2];
        I3.text = VARIABLES_Stepchain.input_adresse[3];
        I4.text = VARIABLES_Stepchain.input_adresse[4];

        O1.text = VARIABLES_Stepchain.output_adresse[0];
        O2.text = VARIABLES_Stepchain.output_adresse[1];
        O3.text = VARIABLES_Stepchain.output_adresse[2];
        O4.text = VARIABLES_Stepchain.output_adresse[3];
    }

    void back_click(){
        SceneManager.LoadScene("Stepchain", LoadSceneMode.Single);
    }
    
    void save_click(){
        VARIABLES_Stepchain.input_adresse[0] = Ienable.text;
        VARIABLES_Stepchain.input_adresse[1] = I1.text;
        VARIABLES_Stepchain.input_adresse[2] = I2.text;
        VARIABLES_Stepchain.input_adresse[3] = I3.text;
        VARIABLES_Stepchain.input_adresse[4] = I4.text;

        VARIABLES_Stepchain.output_adresse[0] = O1.text;
        VARIABLES_Stepchain.output_adresse[0] = O2.text;
        VARIABLES_Stepchain.output_adresse[0] = O3.text;
        VARIABLES_Stepchain.output_adresse[0] = O4.text;
    }



    void Update()
    {

    }
}
