using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_mormal : MonoBehaviour {

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            SceneManager.LoadScene(1);
        }
    }
}