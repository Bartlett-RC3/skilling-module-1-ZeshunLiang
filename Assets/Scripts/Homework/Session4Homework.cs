using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4Homework : MonoBehaviour
{
    //2.Write a change colour coroutine
    IEnumerator changeCubeColor;
    [SerializeField] private Renderer cube;


    void Start()
    {
        changeCubeColor = Colorize();
        //Calling (using) a coroutine
        StartCoroutine(changeCubeColor);
    }

    
    void Update()
    {
        Debug.Log(Time.time);
        if (Time.time > 10)
        {
            //Stop a specify coroitine
            StopCoroutine(changeCubeColor);
            //Stop all coroutines
            StopAllCoroutines();
        }
    }


    IEnumerator Colorize()
    {
        while (true)
        {
            Color changedColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            cube.GetComponent<MeshRenderer>().material.color = changedColor;
            yield return new WaitForSeconds(1);
        }
    }
}
