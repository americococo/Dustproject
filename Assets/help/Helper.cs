using UnityEngine;

public class Helper : MonoBehaviour {

    public GameObject dust;
    public GameObject Player;
    public GameObject UI;
    public static int NumLimit;
    public static float DR;

    bool Limit;

    void Awake()
    {
        Limit = true;
        Instantiate(Player, new Vector3(0, -1, 0), Quaternion.identity);
        Instantiate(UI);
    }
    
    void Update() {
        if (NumLimit < 20)
        {
            Limit = true;
            if (Limit)
            {
                Invoke("PNext", 4);
            }
        }
    }

    void Obj_dust()
    {
        GameObject obj_dust = ObjectPoolingSystem.current.GetPooledObject_dust();

        if (obj_dust == null) return;

        obj_dust.transform.position = new Vector3(Random.Range(-1.4f + DR, 1.4f + DR), Random.Range(-1.4f, 1.4f), 0.0f);
        obj_dust.SetActive(true);
    }

    void PNext() {
        if (NumLimit < 20)
        {
            NumLimit++;
            Obj_dust();
        }
        else
        {
            Limit = false;
        }
    }
}
