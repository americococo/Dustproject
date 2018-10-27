using UnityEngine;

public class move04 : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (transform.position.x < -15)
        {
            this.gameObject.SetActive(false);
        }
        if (transform.position.y < -15)
        {
            this.gameObject.SetActive(false);
        }
        if (transform.position.y > 15)
        {
            this.gameObject.SetActive(false);
        }
        if (transform.position.x > 15)
        {
            this.gameObject.SetActive(false);
        }
    }
}
