using UnityEngine;
using System.Collections;

public class LeafMovement : MonoBehaviour {

	private Vector2 randomspot;
	public float speed;
	public float timer;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		randomspot = new Vector2 (Random.Range (5, 50), Random.Range (5, 50));
		transform.position = Vector2.MoveTowards (transform.position, randomspot, speed);
	}
}
