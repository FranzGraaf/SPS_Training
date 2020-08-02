using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Fillsimulation_Settings : MonoBehaviour
{
    Button back;
    Button save;

    string[] IN_names = {"I1", "I2", "I3", "I4", "I5", "I6", "I7", "I8", "I9", "I10", "I11", "I12", "I13", "I14", "I15", "I16", "I17", "I18", "I19", "I20", "I21"};
    string[] OUT_names = {"O1", "O2", "O3", "O4", "O5", "O6", "O7", "O8", "O9", "O10"};

    TMP_InputField I1;
    TMP_InputField I2;
    TMP_InputField I3;
    TMP_InputField I4;
    TMP_InputField I5;
    TMP_InputField I6;
    TMP_InputField I7;
    TMP_InputField I8;
    TMP_InputField I9;
    TMP_InputField I10;
    TMP_InputField I11;
    TMP_InputField I12;
    TMP_InputField I13;
    TMP_InputField I14;
    TMP_InputField I15;
    TMP_InputField I16;
    TMP_InputField I17;
    TMP_InputField I18;
    TMP_InputField I19;
    TMP_InputField I20;
    TMP_InputField I21;

    TMP_InputField O1;
    TMP_InputField O2;
    TMP_InputField O3;
    TMP_InputField O4;
    TMP_InputField O5;
    TMP_InputField O6;
    TMP_InputField O7;
    TMP_InputField O8;
    TMP_InputField O9;
    TMP_InputField O10;

    TMP_InputField[] IN = new TMP_InputField[21];
    TMP_InputField[] OUT = new TMP_InputField[10];



    // Start is called before the first frame update
    void Start()
    {
        TMP_InputField[] IN2 = {I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, I13, I14, I15, I16, I17, I18, I19, I20, I21};
        TMP_InputField[] OUT2 = {O1, O2, O3, O4, O5, O6, O7, O8, O9, O10};

        IN = IN2;
        OUT = OUT2;


        back = GameObject.Find("Back_Button").GetComponent<Button>();
        back.onClick.AddListener(back_click);  
        save = GameObject.Find("Save_Button").GetComponent<Button>();
        save.onClick.AddListener(save_click);     


        for(int i = 0; i<IN.Length; i++){
            IN[i] = GameObject.Find(IN_names[i]).GetComponent<TMP_InputField>();
            IN[i].text = VARIABLES_Fillsimulation.input_adresse[i];
        }

        for(int i = 0; i<OUT.Length; i++){
            OUT[i] = GameObject.Find(OUT_names[i]).GetComponent<TMP_InputField>();
            OUT[i].text = VARIABLES_Fillsimulation.output_adresse[i];
        }
    }



    void back_click(){
        SceneManager.LoadScene("Fillsimulation", LoadSceneMode.Single);
    }


    void save_click(){
        for(int i = 0; i<IN.Length; i++){
            VARIABLES_Fillsimulation.input_adresse[i] = IN[i].text;
        }

        for(int i = 0; i<OUT.Length; i++){
            VARIABLES_Fillsimulation.output_adresse[i] = OUT[i].text;
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
