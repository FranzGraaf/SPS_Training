using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class counter_script : MonoBehaviour
{
    public int counter_number;
    TextMeshProUGUI tmp;

    // Start is called before the first frame update
    void Start()
    {
        tmp = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = VARIABLES_Marblerun.counter[counter_number].ToString();
    }
}
