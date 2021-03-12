using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Session1Homework : MonoBehaviour {

	//1.Declare a int variable and set a value
	public int Month = 3;
	private int Year = 2021;

	//2.Declare a float variable and set a value
	public float iPad = 12.9f;
	private float iPhone = 5.7f;

	//3.Declare a string variable and set a value
	private string myFirstWordsInUnity = "Hello Octavian Gheorghiu";
	public string mySceondWordsInUnity = "Good afternoon";

	//4.Create a function that prints the declared variables
	private int CalculatorSub(int _FirstNumber, int _SecondNumber)
    {
		int SubResult = _FirstNumber - _SecondNumber;
		return SubResult;

	}

	//5.Declare and initialize an array
	public int[] myArray= new int[3];

	//6.Declare and initialize a list
	public List<float> myList = new List<float>();

	//7.Create and initialize a Dictionary
	public Dictionary<string, int> menu = new Dictionary<string, int>()
	{
		{"coconut", 3 },
		{"chicken", 1 },
		{"red dates", 10 },
		{"wolfberry", 50 }
	};



	void Start () {

		//4.Create a function that prints the declared variables
		int SubResult = CalculatorSub(Year, Month);
		Debug.Log("the Sub result is: " + SubResult.ToString());

		//5.Declare and initialize an array
		myArray[0] = 2;
		myArray[1] = 4;
		myArray[2] = 6;

		//6.Declare and initialize a list
		myList.Add(6.2f);
		myList.Add(8.4f);
		myList[0] = 3.1f;

		//7.Create and initialize a Dictionary
		Debug.Log("the number of coconut is: " + menu["coconut"]);
		Debug.Log("the number of chicken is: " + menu["chicken"]);
		Debug.Log("the number of red dates is: " + menu["red dates"]);
		Debug.Log("the number of wolfberry is: " + menu["wolfberry"]);


	}


	void Update () {
		
	}
}
