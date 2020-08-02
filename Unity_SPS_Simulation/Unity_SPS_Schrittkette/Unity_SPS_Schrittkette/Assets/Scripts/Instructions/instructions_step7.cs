using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class instructions_step7 : MonoBehaviour
{
    Button back_button;

    void Start()
    {
        back_button = GameObject.Find("Back_Button").GetComponent<Button>();

        back_button.onClick.AddListener(back_button_click);
    }


    void Update()
    {
        
    }

    void back_button_click(){
        SceneManager.LoadScene("Main_Menu", LoadSceneMode.Single);
    }
}
