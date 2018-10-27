using UnityEngine;
using UnityEngine.UI;

public class HPcounter : MonoBehaviour {

    Text text;
    string health;

    void Awake() {
        text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        health = "";
        for (int i = 0; i < Player.HP; i++)
        {
            health += "♥ ";
        }
        text.text = health.ToString();
    }
}
