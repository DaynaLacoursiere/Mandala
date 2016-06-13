using UnityEngine;
using System.Collections;

public class PiecesMovement : MonoBehaviour {

	public float speed = 0.001f;
	public float counter = 10;
	private float counter2 = 10;
	public Vector2 endpoint;
	private int numberOfLoops = 1;

	// Use this for initialization
	void Start () {
		RandomPostion ();
	}

	// Update is called once per frame
	void Update () {
		counter2 -= Time.deltaTime;
		if (counter2 < 0 && numberOfLoops > 0) {
			RandomPostion ();
			numberOfLoops--;
			counter2 = counter;
		}

		transform.position = Vector2.Lerp (transform.position, endpoint, speed);
	}

	void RandomPostion () {
		float x = Random.Range (-50f, 50f);
		float y = Random.Range (-100f, 100f);
		endpoint = new Vector2 (x, y);
	}
}
