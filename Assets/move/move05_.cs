using UnityEngine;

public class move05_ : MonoBehaviour {

    public static int LC;
    public static int SLC;
    public static int SL;
    public static int AKD;
    public static int PWC;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Rock")
        {
            LC++;
            SLC++;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Enemy")
        {
            if (Player.Ptime == 0)
            {
                if (shield.SD <= 0)
                {
                    Player.Ptime = 1;
                    Player.HP--;
                    Player.PHP = true;
                    other.gameObject.SetActive(false);
                }
                else
                {
                    Player.Ptime = 1;
                    if(shield.SD <= 4)
                    {
                        shield.SD--;
                        Player.PHP = true;
                    }
                    else
                    {
                        LC += 2;
                        SLC += 3;
                    }
                    other.gameObject.SetActive(false);
                }
            }
            if (Player.HP <= 0)
            {
                Player.HP = 0;
                Destroy(gameObject);
            }
        }
        if (Player.HP <= 0)
        {
            Player.HP = 0;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
	void Update () {
        if(PWC > 140)
        {
            LC++;
            SLC++;
            PWC = 0;
        }
        SL = SLC / 4;
        if (SL >= 4)
        {
            SLC -= 16;
            shield.SD++;
        }
    }
}
