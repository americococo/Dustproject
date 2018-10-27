using UnityEngine;

public class Dust : MonoBehaviour {

    public GameObject range;
    public static int PW;
    private int power = 3;
    float blacktime;

    void OnTriggerEnter(Collider other)
    {
        Helper.NumLimit--;
        if (other.gameObject.tag == "Player")
        {
            range.gameObject.SetActive(false);
            PW += power;
            move05_.PWC++;
        }
        else
        {
            range.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update() {
        blacktime += Time.deltaTime;
        if (blacktime > 1)
        {
            GetComponent<MeshRenderer>().material.color = new Color32(0, 0, 0, 255);
            power = 2;
        }
        if (blacktime > 2)
        {
            Helper.NumLimit--;
            GetComponent<MeshRenderer>().material.color = new Color32(255, 255, 0, 255);
            blacktime = 0;
            range.gameObject.SetActive(false);
        }
    }
}
