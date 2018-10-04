// VR at SAIC 
// UnityScritping
// Basic scripts to get started with scripting in Unity 3D
//

using UnityEngine;

public class interpolation : MonoBehaviour {

	// animate the game object from -1 to +1 and back
	public float minimum = -1.0F;
	public float maximum =  1.0F;

	// animate the game object from -1 to +1 and back
	public float sizeMinimum = .1F;
	public float sizeMaximum =  2.0F;

	// starting value for the Lerp    
	static float t = 0.0f;

	void Update() {
		// animate the position of the game object...
		transform.position = new Vector3(Mathf.Lerp(minimum, maximum, t), 2.0f, 0);


		// .. and increate the t interpolater
		t += 0.5f * Time.deltaTime;

		// now check if the interpolator has reached 1.0
		// and swap maximum and minimum so game object moves
		// in the opposite direction.
		if (t > 1.0f){
			float temp = maximum;
			maximum = minimum;
			minimum = temp;
			t = 0.0f;
		}

		beat ();
	}

	void beat(){

		//animate the size
		transform.localScale = new Vector3 (Mathf.Lerp(sizeMinimum, sizeMaximum, t), transform.localScale.y, transform.localScale.z);
//		transform.localScale = new Vector3 (Mathf.PingPong (Time.deltaTime * t, sizeMaximum), transform.localScale.y, transform.localScale.z);
		// .. and increate the t interpolater
		t += 0.1f * Time.deltaTime;

		// now check if the interpolator has reached 1.0
		// and swap maximum and minimum so game object moves
		// in the opposite direction.
		if (t > sizeMaximum){
			float temp = sizeMaximum;
			sizeMaximum = sizeMinimum;
			sizeMinimum = temp;
			t = 0.0f;
		}
	}
}