using UnityEngine;

public class warning : MonoBehaviour {

    private float Timer = 1;
	
	// Update is called once per frame
	void Update () {
        Timer -= Time.deltaTime;
        if (Timer < 0)
        {
            this.gameObject.SetActive(false);
            Timer = 1;
        }
    }
}
