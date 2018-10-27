using UnityEngine;

public class Player : MonoBehaviour {

    public static int HP = 3;
    public static int Ptime;
    float time;

    public static bool PHP;

    void Awake() {
        PHP = false;
    }

    // Update is called once per frame
    void Update() {
        if (PHP == true || shield.SD >= 4)
        {
            time -= 2 * Time.deltaTime;
            if (time < 0)
            {
                Ptime++;
                time = 1;
            }
        }
        if (PHP == true)
        {
            if (Ptime >= 6)
            {
                GetComponent<MeshRenderer>().material.color = new Color32(0, 255, 0, 255);
                PHP = false;
                Ptime = 0;
            }
            else if (Ptime % 2 == 0)
            {
                GetComponent<MeshRenderer>().material.color = new Color32(125, 0, 0, 150);
            }
            else
            {
                GetComponent<MeshRenderer>().material.color = new Color32(255, 0, 0, 50);
            }
        }
        if (shield.SD >= 4)
        {
            if (Ptime >= 34)
            {
                GetComponent<MeshRenderer>().material.color = new Color32(0, 255, 0, 255);
                shield.SD = 0;
                Ptime = 0;
                PHP = true;
            }
            else if (Ptime % 2 == 0)
            {
                GetComponent<MeshRenderer>().material.color = new Color32(0, 0, 125, 150);
            }
            else
            {
                GetComponent<MeshRenderer>().material.color = new Color32(0, 0, 255, 50);
            }
        }
    }
}