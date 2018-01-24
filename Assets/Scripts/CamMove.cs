using UnityEngine;

public class CamMove : MonoBehaviour {

	public GameObject GG5;

	void Update () {
		transform.position = new Vector3 (GG5.transform.position.x, GG5.transform.position.y, -7f);
		
	}
}
