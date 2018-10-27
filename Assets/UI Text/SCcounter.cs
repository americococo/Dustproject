using UnityEngine;
using UnityEngine.UI;

public class SCcounter : MonoBehaviour {

    private int score;

    Text text;

    void Awake() {
        text = GetComponent<Text>();
    }

	// Update is called once per frame
	void Update () {
        score = Dust.PW + (move05_.LC * move05_.LC);
        if (score <= 0)
        {
            score = 0;
        }
        text.text = "점수" + score.ToString();
    }
}
