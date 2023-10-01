using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
	int TakeDamage()
    {
		int playerHeath = 100;
		return playerHeath - 5;

    }

	int TakeDamage(int damage)
    {
		int playerHeath = 100;
		return playerHeath - damage;

    }
	int TakeDamage(int playerHeath, int damage)
	{
		return playerHeath - damage;

	}
	// start is called before the first frame update
	void Start()
	{
		int x = TakeDamage();
		print("player health is: " + x);

		int y = TakeDamage(25);
		print("Second Method player health is: " + y);

		int z = TakeDamage(100, 40);
		print("Third Method player health is: " + z);
	}

	// Update is called once per frame
	void Update()

	{

	}
}
