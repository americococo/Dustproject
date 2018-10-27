using UnityEngine;
using UnityEngine.UI;

public class skillcounter : MonoBehaviour {

    Text text;
    string skill;

    void Awake()
    {
        text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        skill = "□□□□";
        for (int i = 0; i < shield.SD; i++)
        {
            if (i >= 3)
            {
                skill = "■■■■";
            }
            else if(i >= 2)
            {
                skill = "■■■□";
            }
            else if (i >= 1)
            {
                skill = "■■□□";
            }
            else if (i >= 0)
            {
                skill = "■□□□";
            }
        }
        text.text = skill.ToString();
    }
}
