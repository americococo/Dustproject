using UnityEngine;

public class move04_ : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < -15)
        {
            transform.position = new Vector3(Helper.DR, -1, 0);
        }
        if (transform.position.y < -15)
        {
            transform.position = new Vector3(Helper.DR, -1, 0);
        }
        if (transform.position.y > 15)
        {
            transform.position = new Vector3(Helper.DR, -1, 0);
        }
        if (transform.position.x > 15)
        {
            transform.position = new Vector3(Helper.DR, -1, 0);
        }
    }
}
