using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public float moveSpeed;
	private Vector3 input;
	private Vector3 spawn;
	public GameObject deathParticals;

	public AudioClip[] audioClip;

	// Use this for initialization
	void Start ()
	{
		spawn = transform.position;
	}

	// Update is called once per frame
	void Update ()
	{
		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		GetComponent<Rigidbody>().AddForce(input * moveSpeed); 


		if (transform.position.y < -2) 
		{
			PlaySound (1);
			Die ();
		}


	}

	void OnCollisionEnter(Collision other)
	{
		if (other.transform.tag == "Enemy") 
		{
			PlaySound (1);
			Die ();
		}
	}

	void Die()
	{
		
		Instantiate (deathParticals, transform.position, Quaternion.identity);
		transform.position = spawn;

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Goal")
		{
			PlaySound (0);
			Application.LoadLevel ("End");
		}

		if (other.transform.tag == "Coin")
		{
			PlaySound (2);

		}
	}


	void PlaySound(int clip)
	{
		AudioSource audio = GetComponent<AudioSource> ();
		audio.clip = audioClip [clip];
		audio.Play ();
	}



	 

}﻿