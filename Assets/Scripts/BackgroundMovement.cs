using UnityEngine;
using System.Collections;

public class BackgroundMovement : MonoBehaviour {

	private Vector2 mousePosition;
	private Vector2 newPosition;
	public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
		mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
		newPosition = transform.position;
		newPosition.x = newPosition.x - mousePosition.x;
		newPosition.y = newPosition.y - mousePosition.y;
		transform.position = Vector2.Lerp (transform.position, newPosition, moveSpeed);

	}
}
