using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VARIABLES_Conveyor
{

    public static bool plc_control = true;

    public static float belt_speed = 0;
    public static float stange_speed = 0;
    public static float rot_speed = 0;
    public static float gripper_speed = 0;
    public static float push_speed = 0;
    public static bool paint = false;
    public static bool scan = false;

    


    public static bool sensor1 = false;
    public static bool sensor2 = false;
    public static bool sensor3 = false;
    public static bool sensor_top = false;
    public static bool sensor_bottom = false;
    public static bool sensor_open = false;
    public static bool sensor_closed = false;
    public static bool sensor_360 = false;
    public static bool sensor_out = false;
    public static bool sensor_in = false;


    public static bool[] input = new bool[28];
    //public static bool[] input = {false, false, false, false, false, false, false, false, false, false, false};
    /*
    Input list:
    _____Maschine_____
    [0] = sensor1
    [1] = sensor2
    [2] = sensor3
    [3] = sensor_360
    [4] = sensor_top
    [5] = sensor_bottom
    [6] = sensor_open
    [7] = sensor_closed
    [8] = sensor_scan   
    [9] = sensor_out
    [10] = sensor_in
    _____Bedienpult_____
    [11] = neues_objekt
    [12] = band_vor
    [13] = band_zurück
    [14] = lackieren
    [15] = drehgreifer_hoch
    [16] = drehgreifer_runter
    [17] = drehgreifer_auf
    [18] = drehgreifer_zu
    [19] = drehen_rechts
    [20] = drehen_links
    [21] = scannen
    [22] = auswerfer_vor
    [23] = auswerfer_zurück
    [24] = maschine_einschalten
    [25] = betriebsart
    [26] = automatik_start
    [27] = automatik_stopp
    */
    public static bool[] output = new bool[13];
    /*
    Output list:
    [0] = neues_objekt
    [1] = band_vor
    [2] = band_zurück
    [3] = lackieren
    [4] = drehgreifer_hoch
    [5] = drehgreifer_runter
    [6] = drehgreifer_auf
    [7] = drehgreifer_zu
    [8] = drehen_rechts   
    [9] = drehen_links
    [10] = scannen
    [11] = auswerfer_vor
    [12] = auswerfer_zurück
    */


    public static string[] input_adresse = {"DB1.DBX0.0", "DB1.DBX0.1", "DB1.DBX0.2", "DB1.DBX0.3", "DB1.DBX0.4", "DB1.DBX0.5", "DB1.DBX0.6", "DB1.DBX0.7", "DB1.DBX1.0", "DB1.DBX1.1", "DB1.DBX1.2", "DB1.DBX1.3", "DB1.DBX1.4", "DB1.DBX1.5", "DB1.DBX1.6", "DB1.DBX1.7", "DB1.DBX2.0", "DB1.DBX2.1", "DB1.DBX2.2", "DB1.DBX2.3", "DB1.DBX2.4", "DB1.DBX2.5", "DB1.DBX2.6", "DB1.DBX2.7", "DB1.DBX3.0", "DB1.DBX3.1", "DB1.DBX3.2", "DB1.DBX3.3"};
    public static string[] output_adresse = {"O0.0", "O0.1", "O0.2", "O0.3", "O0.4", "O0.5", "O0.6", "O0.7", "O1.0", "O1.1", "O1.2", "O1.3", "O1.4"};

}
