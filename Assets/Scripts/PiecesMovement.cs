using UnityEngine;
using System.Collections;

public class PiecesMovement : MonoBehaviour {

	private Vector2 randomspot;
	public float speed;
	public float timer;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		timer = timer - Time.deltaTime;
		if (timer < 1) {
			timer = 15;
		}
		randomspot = new Vector2 (Random.Range (5, 50), Random.Range (5, 50));
		transform.position = Vector2.Lerp (transform.position, randomspot, speed);
	}
}
