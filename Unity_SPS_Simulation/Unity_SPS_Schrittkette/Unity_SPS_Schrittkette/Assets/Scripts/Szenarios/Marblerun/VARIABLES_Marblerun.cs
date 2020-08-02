using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VARIABLES_Marblerun
{


    public static bool plc_control;



    public static bool[] input = new bool[11];
    /*
    Input list:
    _____Maschine_____
    [0] = sensor_1
    [1] = sensor_2
    
    _____Bedienpult_____
    [2] = maschine_einschalten
    [3] = betriebsart   
    [4] = auto_start
    [5] = auto_stop
    [6] = Magazin
    [7] = Zylinder_1
    [8] = Weiche_1
    [9] = Weiche_2
    [10] = Weiche_3
    */
    public static bool[] output = new bool[5];
    /*
    Output list:
    [0] = Magazin
    [1] = Zylinder_1
    [2] = Weiche_1
    [3] = Weiche_2
    [4] = Weiche_3
    */

    public static uint[] counter = new uint[5];
    /*
    Counter list:
    [0] = Counter_1
    [1] = Counter_2
    [2] = Counter_3
    [3] = Counter_4
    [4] = Counter_5
    */


    public static string[] input_adresse = {"DB1.DBX0.0", "DB1.DBX0.1", "DB1.DBX0.2", "DB1.DBX0.3", "DB1.DBX0.4", "DB1.DBX0.5", "DB1.DBX0.6", "DB1.DBX0.7", "DB1.DBX1.0", "DB1.DBX1.1", "DB1.DBX1.2"};
    public static string[] output_adresse = {"O0.0", "O0.1", "O0.2", "O0.3", "O0.4"};
    public static string[] counter_adresse = {"DB1.DBD4.0", "DB1.DBD8.0", "DB1.DBD12.0", "DB1.DBD16.0", "DB1.DBD20.0"};
}
