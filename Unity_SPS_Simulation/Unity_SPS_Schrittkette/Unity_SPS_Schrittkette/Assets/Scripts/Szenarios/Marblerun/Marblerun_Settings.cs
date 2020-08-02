using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Marblerun_Settings : MonoBehaviour
{
    Button back;
    Button save;

    string[] IN_names = {"I1", "I2", "I3", "I4", "I5", "I6", "I7", "I8", "I9", "I10", "I11"};
    string[] OUT_names = {"O1", "O2", "O3", "O4", "O5"};
    string[] COUNTER_names = {"C1", "C2", "C3", "C4", "C5"};

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

    TMP_InputField O1;
    TMP_InputField O2;
    TMP_InputField O3;
    TMP_InputField O4;
    TMP_InputField O5;

    TMP_InputField C1;
    TMP_InputField C2;
    TMP_InputField C3;
    TMP_InputField C4;
    TMP_InputField C5;

    TMP_InputField[] IN = new TMP_InputField[11];
    TMP_InputField[] OUT = new TMP_InputField[5];
    TMP_InputField[] COUNTER = new TMP_InputField[5];


    // Start is called before the first frame update
    void Start()
    {
        TMP_InputField[] IN2 = {I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11};
        TMP_InputField[] OUT2 = {O1, O2, O3, O4, O5};
        TMP_InputField[] COUNTER2 = {C1, C2, C3, C4, C5};

        IN = IN2;
        OUT = OUT2;
        COUNTER = COUNTER2;


        back = GameObject.Find("Back_Button").GetComponent<Button>();
        back.onClick.AddListener(back_click);  
        save = GameObject.Find("Save_Button").GetComponent<Button>();
        save.onClick.AddListener(save_click);     

        for(int i = 0; i<IN.Length; i++){
            IN[i] = GameObject.Find(IN_names[i]).GetComponent<TMP_InputField>();
            IN[i].text = VARIABLES_Marblerun.input_adresse[i];
        }
        
        for(int i = 0; i<OUT.Length; i++){
            OUT[i] = GameObject.Find(OUT_names[i]).GetComponent<TMP_InputField>();
            OUT[i].text = VARIABLES_Marblerun.output_adresse[i];
        }

        for(int i = 0; i<COUNTER.Length; i++){
            COUNTER[i] = GameObject.Find(COUNTER_names[i]).GetComponent<TMP_InputField>();
            COUNTER[i].text = VARIABLES_Marblerun.counter_adresse[i];
        }


    }



    void back_click(){
        SceneManager.LoadScene("Marblerun", LoadSceneMode.Single);
    }


    void save_click(){
        for(int i = 0; i<IN.Length; i++){
            VARIABLES_Marblerun.input_adresse[i] = IN[i].text;
        }

        for(int i = 0; i<OUT.Length; i++){
            VARIABLES_Marblerun.output_adresse[i] = OUT[i].text;
        }

        for(int i = 0; i<COUNTER.Length; i++){
            VARIABLES_Marblerun.counter_adresse[i] = COUNTER[i].text;
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
