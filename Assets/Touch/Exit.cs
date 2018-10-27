using UnityEngine;

public class Exit : MonoBehaviour {

    // Update is called once per frame
    void Update() {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
}
