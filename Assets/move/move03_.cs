using UnityEngine;

public class move03_ : MonoBehaviour {

    public static int Espeed = 11;
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * Espeed);
        transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
    }
}
