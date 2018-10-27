using UnityEngine;

public class restop : MonoBehaviour {

    public GameObject Stop;

    public static bool stop;

    // Use this for initialization
    void Start() {
        stop = false;
    }

    // Update is called once per frame
    void Update () {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (Player.HP > 0)
                {
                    if (stop == false)
                    {
                        Instantiate(Stop);
                        stop = true;
                    }
                }
            }
        }
    }
}
