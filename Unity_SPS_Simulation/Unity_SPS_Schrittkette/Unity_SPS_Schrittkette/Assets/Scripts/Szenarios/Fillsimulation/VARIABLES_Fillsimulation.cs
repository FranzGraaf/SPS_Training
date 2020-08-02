using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VARIABLES_Fillsimulation
{


    public static bool plc_control;









    public static bool[] input = new bool[21];
    /*
    Input list:
    _____Maschine_____
    [0] = T1_leer
    [1] = T1_voll
    [2] = T2_leer
    [3] = T2_voll
    [4] = T3_leer
    [5] = T3_mitte
    [6] = T3_voll
    
    _____Bedienpult_____
    [7] = maschine_einschalten
    [8] = betriebsart   
    [9] = auto_start
    [10] = auto_stop
    [11] = Hahn_1
    [12] = Hahn_2
    [13] = Heizung_1
    [14] = Heizung_2
    [15] = V1 (T1 leeren)
    [16] = V2 (T1 zu T3)
    [17] = V3 (T2 leeren)
    [18] = V4 (T2 zu T3)
    [19] = V5 (T3 leeren)
    [20] = Motor
    */
    public static bool[] output = new bool[10];
    /*
    Output list:
    [0] = Hahn_1
    [1] = Hahn_2
    [2] = Heizung_1
    [3] = Heizung_2
    [4] = V1 (T1 leeren)
    [5] = V2 (T1 zu T3)
    [6] = V3 (T2 leeren)
    [7] = V4 (T2 zu T3)
    [8] = V5 (T3 leeren)   
    [9] = Motor
    */


    public static string[] input_adresse = {"DB1.DBX0.0", "DB1.DBX0.1", "DB1.DBX0.2", "DB1.DBX0.3", "DB1.DBX0.4", "DB1.DBX0.5", "DB1.DBX0.6", "DB1.DBX0.7", "DB1.DBX1.0", "DB1.DBX1.1", "DB1.DBX1.2", "DB1.DBX1.3", "DB1.DBX1.4", "DB1.DBX1.5", "DB1.DBX1.6", "DB1.DBX1.7", "DB1.DBX2.0", "DB1.DBX2.1", "DB1.DBX2.2", "DB1.DBX2.3", "DB1.DBX2.4"};
    public static string[] output_adresse = {"O0.0", "O0.1", "O0.2", "O0.3", "O0.4", "O0.5", "O0.6", "O0.7", "O1.0", "O1.1"};
}
