using UnityEngine;
using UnityEngine.SceneManagement;

public class replay : MonoBehaviour {

    // Use this for initialization
    void Start() {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update() {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (Time.timeScale == 0)
                {
                    regamset();
                    SceneManager.LoadScene(0);
                }
            }
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Time.timeScale = 1;
            restop.stop = false;
            Destroy(gameObject);
        }
    }

    public static void regamset()
    {
        SceneManager.LoadScene(0);
        Player.Ptime = 0;
        Time.timeScale = 1;
        Helper.NumLimit = 0;
        Player.HP = 3;
        Dust.PW = 0;
        move03.Rspeed = 5;
        move03_.Espeed = 11;
        move05_.LC = 0;
        move05_.SLC = 0;
        shield.SD = 0;
        TMcounter.Ctime = 0;
        Helper.DR = 0;
    }
}
