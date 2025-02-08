using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public Rigidbody2D rig;

	public Vector2 velocity;

	public float speed;

	private void Update()
	{
		if (Input.GetKey(KeyCode.RightArrow))
		{
			//rig.MovePosition(rig.position + velocity * Time.deltaTime);
			rig.velocity = new Vector2(speed, rig.velocity.y);
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			//rig.MovePosition(rig.position - velocity * Time.deltaTime);
			rig.velocity = new Vector2(-speed, rig.velocity.y);
		}
	}




}
