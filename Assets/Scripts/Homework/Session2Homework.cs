using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BallTeam;

public class Session2Homework : MonoBehaviour
{
    //1.
    bool evidence1 = false;
    bool evidence2 = true;
    bool evidence3 = false;

    //2.
    string[] fridge = { "beef", "egg", "lamb", "lobster" };
    
    //3.
    dog Shepherd, Poodle, Huskie;


    void Start()
    {
        //1.Write a function that uses a condition
        if(evidence1 == true  && evidence2 == true)
        {
            Debug.Log("the murderer is A");
        }
        if (evidence2 == false  || evidence3 == false )
        {
            Debug.Log("the murderer is B");
        }


        //2.Write a for loop
        foreach (string food in fridge)
        {
            Debug.Log("We gonna eat " + food);
        }



        //3.Write a dog class and initialize an instance of the class
        Shepherd = new dog("Shep", "Frontline", 90);
        Poodle = new dog("Pood", "midfielder", 95);
        Huskie = new dog("Husk", "defenders ", 85);


    }


    void Update()
    {
        //Debug.Log(Shepherd.Getpower());
        Shepherd.Running();
        Shepherd.Shooting();
    }
}
