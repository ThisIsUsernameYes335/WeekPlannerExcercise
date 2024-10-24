using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeeklyPlanScript : MonoBehaviour
{
    //array for all days of the week as ints
    int[] weekArray = new int[7];
    // Start is called before the first frame update

    void weekMethod1(int weekDay){

        switch (weekDay){

            case 0:
                Debug.Log("reading on monday");
                break;
            case 1:
                Debug.Log("programming on tuesday");
                break;
            case 2:
                Debug.Log("designing on wednesday");
                break;
            case 3:
                Debug.Log("reading on thursday");
                break;
            case 4:
                Debug.Log("programming on friday");
                break;
            case 5:
                Debug.Log("writing on saturday");
                break;
            case 6:
                Debug.Log("testing on sunday");
                break;
                      
        }

    }

       void weekMethod2(int weekDay){

        if(weekDay == 0){
            Debug.Log("reading on monday");
        }

        else if(weekDay == 1){
            Debug.Log("programming on tuesday");
        }

        else if(weekDay == 2){
            Debug.Log("designing on wednesday");
        }

        else if(weekDay == 3){
            Debug.Log("reading on thursday");
        }

        else if(weekDay == 4){
            Debug.Log("programming on friday");
        }

        else if(weekDay == 5){
            Debug.Log("writing on saturday");
        }

        else if(weekDay == 6){
            Debug.Log("testing on sunday");
        }

        else {
            return;
        }

    }

    void Start()
    {
        weekMethod1(weekArray[0]);

        weekMethod2(weekArray[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}