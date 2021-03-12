using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4Homework_RayCasting : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        //3.Create a cube array and change destroy them in play mode using ray casting

        //Move object 
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.gameObject.transform.Translate(Vector3.up * 0.2f);
        }      
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.gameObject.transform.Translate(Vector3.down * 0.2f);
        }


        // Check if an obj is seeing another obj using Ray Casting

        // First let's get the position form where we are casting the ray
        Vector3 rayCastingPosition = this.gameObject.transform.position;

        //Then create a ray in the direction we want to cast
        Vector3 rayCastDirection = this.gameObject.transform.TransformDirection(Vector3.left);

        // Create a variable that stores the information about what we are hitting
        RaycastHit objectSeenByRay;

        // Cast the ray
        if (Physics.Raycast(rayCastingPosition, rayCastDirection, out objectSeenByRay))
        {
            Debug.Log("obj seen: " + objectSeenByRay.transform.name);
            Debug.Log("obj position: " + objectSeenByRay.transform.ToString());
            Debug.Log("Point where ray is hitting the object: " + objectSeenByRay.point);
            Destroy(objectSeenByRay.transform.gameObject);
        }





    }
}
