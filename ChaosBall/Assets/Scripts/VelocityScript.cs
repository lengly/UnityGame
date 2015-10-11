using UnityEngine;
using System.Collections;

public class VelocityScript : MonoBehaviour {
	public float max = 50;
	// Use this for initialization
	void Start () {
		rigidbody.velocity = new Vector3 (Random.Range (0, max), 0, Random.Range (0, max));
		rigidbody.position = new Vector3 (Random.Range (0, 50), 2, Random.Range (0, 50));
		transform.Rotate(Random.Range (0, 360), Random.Range (0, 360), Random.Range (0, 360));

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
