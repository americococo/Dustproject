using UnityEngine;

public class move03 : MonoBehaviour {

    public static int Rspeed = 5;
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * Rspeed);
        transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
}
