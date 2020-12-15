using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	

	void Start()
	{
		
	}

	

	void Update()
	{
		this.gameObject.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
	}
}
