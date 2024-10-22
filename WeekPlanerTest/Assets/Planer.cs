using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planer : MonoBehaviour
{
    public string today;
    
    // Start is called before the first frame update
    void Start()
    {
        if (today == week[0])
        {
            Debug.Log("program");
        }
        else if (today == week[1])
        {
            Debug.Log("work");
        }
        else if (today == week[2])
        {
            Debug.Log("get drunk");
        }
        else if (today == week[3])
        {
            Debug.Log("get drunk");
        }
        else if (today == week[4])
        {
            Debug.Log("sleep");
        }
        else if (today == week[5])
        {
            Debug.Log("chill");
        }
        else if (today == week[6])
        {
            Debug.Log("prepare");
        }
        else 
        {
            Debug.Log("not a week day");
        }
        //Debug.Log(week[2]);


        foreach (string i in weekProgram)
        {
            Debug.Log(i);

        }


        switch (today)
        {
            case "monday":
                Debug.Log("");
                break;
            case "tuesday":
                Debug.Log("");
                break;
            case "wednesday":
                Debug.Log("");
                break;
            case "thursday":
                Debug.Log("");
                break;
            case "friday":
                Debug.Log("");
                break;
            case "saturday":
                Debug.Log("");
                break;
            case "sunday":
                Debug.Log("");
                break;
        }
    }



    string[] week = new string[7] { "monday", "tuesday", "wednesday", "thursday","friday", "saturday", "sunday"};
    string[] weekProgram = new string[7] { "monday: program", "tuesday: work", "wednesday: get drunk", "thursday: get drunk", "friday: sleep", "saturday; chill", "sunday: prepare" };
}
