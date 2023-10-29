using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
	public int start = 22;
	public int end = 100;

	// Start is called before the first frame update
	void Start()
	{
		//The same can be accomplished with a 'For' loop. A for loop is a
		//countered controlled loop that takes things like the creation
		//of the counter and the incrementation of the counter and puts
		//them in the control line itself. The following For loop will
		//count the even numbers from 22 to 100
		for (int i = 22; i < 100; i += 2)
			print(i);
		{

		}
	}
}