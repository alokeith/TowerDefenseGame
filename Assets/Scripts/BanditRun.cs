using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditRun : MonoBehaviour
{
	private Rigidbody2D rb;
	private void Awake() {
		rb = GetComponent<Rigidbody2D>();
	
	}
	private void FixedUpdate() {
		rb.velocity = new Vector2 (-0.5f, 0f);
	}
}
