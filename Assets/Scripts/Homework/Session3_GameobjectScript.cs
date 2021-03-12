using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3_GameobjectScript : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        //3.Add a script to a game object
        transform.Translate(1 * Time.deltaTime, 0, 0);
    }
}
