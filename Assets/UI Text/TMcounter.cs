using UnityEngine;
using UnityEngine.UI;

public class TMcounter : MonoBehaviour {

    public static float time;
    public static int Ctime;

    Text text;

    void Awake() {
        text = GetComponent<Text>();
        time = 1;
    }
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        if(time < 0)
        {
            Ctime++;
            time = 1;
        }
        text.text = Ctime + "초".ToString();
    }
}
