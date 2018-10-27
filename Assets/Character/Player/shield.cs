using UnityEngine;

public class shield : MonoBehaviour {

    public static int SD = 0;
	
	// Update is called once per frame
	void Update () {
        if(SD <= 0)
        {
            transform.localScale = new Vector3(0, 0, 0);
        }
        else
        {
            transform.localScale = new Vector3(2, 2, 2);
        }
    }
}
