using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3Homework : MonoBehaviour
{
    public GameObject gameobject;
    public int numberOfobjects = 6;
    public float spacing = 0.5f;
    private List<GameObject> objectCopies = new List<GameObject>();
    private int frameCount = 0;



    void Start()
    {
        for (int i = 0; i < numberOfobjects; i++)
        {
            Vector3 objectCopyPosition = new Vector3(i * spacing, 1, 1);
            Quaternion objectCopyRotation = Quaternion.identity;
            GameObject objectCopy = Instantiate(gameobject, objectCopyPosition, objectCopyRotation);
            
            objectCopies.Add(objectCopy);
        }
    }


    void Update()
    {
        foreach (GameObject objectCopy in objectCopies)
        {           
            Color objectCopyColor = new Color(Random.Range(0.8f, 1.0f), Random.Range(0.8f, 1.0f), Random.Range(0.8f, 1.0f));
            objectCopy.GetComponent<MeshRenderer>().material.color = objectCopyColor;
        }
       





        foreach (GameObject cubeCopy in objectCopies)
        {
            //1.Create a cube and move it across the screen           
            cubeCopy.GetComponent<Transform>().Translate(0.5f * Time.deltaTime,0,0);



            //2.Create a cube and change its colour when key is pressed or mouse is pressed
            if (Input.GetKey(KeyCode.Space))
            {
                foreach (GameObject objectCopy in objectCopies)
                {
                    Color greenColor = new Color(0, 1, 0);
                    objectCopy.GetComponent<MeshRenderer>().material.color = greenColor;
                }
            }

            if (Input.GetMouseButton(0))
            {
                foreach (GameObject objectCopy in objectCopies)
                {
                    Color blueColor = new Color(0, 0, 1);
                    objectCopy.GetComponent<MeshRenderer>().material.color = blueColor;
                }
            }

        }
        


    }
}
