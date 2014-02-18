using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public GameObject spherePrefab;

	private GameObject planet;

	private const float deltaTime = 0.02f;

	void Start() {
		planet = GameObject.Find("Planet");

		CalculatePath();
	}
	
	void CalculatePath() {
		GravityField gf = planet.GetComponent<GravityField>();
		Vector3 velocity = Vector3.left * 10;
		Vector3 position = transform.position;
		for (int i = 0; i < 100; i++) {
			Vector3 f = gf.GetForce(position);

			velocity += deltaTime * f;
			position += deltaTime * velocity;

			GameObject sphere = Instantiate(spherePrefab) as GameObject;
			sphere.transform.position = position;
		}
	}
}
