using UnityEngine;
using UnityEngine.SceneManagement;

public class regame : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            SceneManager.LoadScene(0);
        }
    }
}
