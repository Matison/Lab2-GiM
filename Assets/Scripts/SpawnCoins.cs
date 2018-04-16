﻿using UnityEngine;
using System.Collections;

public class SpawnCoins : MonoBehaviour {

	public Transform[] coinSpawns;
	public GameObject[] coin;
	// Use this for initialization
	void Start () {
		Spawn (); // Generate some coins when the script is called.
	}
	// Spawn a random coin object
	void Spawn(){
		// For however many coins we have, spawn them if a coin flips to 1.
		for (int i =0; i < coinSpawns.Length; i++) {
			int coinFlip = Random.Range(0,2); // Produce a value of 0 or 1
			int aaa = Random.Range(0,3);
			if(coinFlip > 0){
				if (aaa== 0)
				{
					Instantiate(coin[0], coinSpawns[i].position, Quaternion.identity);

				}
				if (aaa == 1)
				{
					Instantiate(coin[1], coinSpawns[i].position, Quaternion.identity);

				}
				if (aaa == 2)
				{
					Instantiate(coin[2], coinSpawns[i].position, Quaternion.identity);

				}
			}
		}
	}
}
