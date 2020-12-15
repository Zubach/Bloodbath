using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	Transform player;

	void Start()
	{
		this.player = GameObject.FindGameObjectWithTag("Player").transform;
	}

	

	void Update()
	{
		transform.position = new Vector3(player.position.x,player.position.y,player.position.z);
	}
}
