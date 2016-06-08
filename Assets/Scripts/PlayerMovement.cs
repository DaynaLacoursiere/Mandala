using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Vector2 mousePosition;
	public float moveSpeed = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
		mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
		transform.position = Vector2.Lerp (transform.position, mousePosition, moveSpeed);
	}
}
