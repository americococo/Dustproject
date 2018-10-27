using UnityEngine;
using UnityEngine.SceneManagement;

public class overgame : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            replay.regamset();
        }
    }
}
