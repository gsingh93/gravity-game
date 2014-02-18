using UnityEngine;
using System.Collections;

public class GravityField : MonoBehaviour {
	public const float gravityConst = 10;
	public const float mass = 10;

	public Vector3 GetForce(Vector3 position) {
		Vector3 r = transform.position - position;
		float rMag = r.magnitude;
		Vector3 rNorm = r.normalized;
		return (gravityConst * mass/(rMag * rMag)) * rNorm;
	}
}
