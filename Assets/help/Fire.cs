using UnityEngine;

public class Fire : MonoBehaviour {

    public Transform[] pos;
    public Transform[] warpos;
    public int[] Ran;

    bool RNum;
    bool ENum;
    
    void Start() {
        RNum = false;
        ENum = false;

        InvokeRepeating("Ranrock", 5, 4);
        InvokeRepeating("Ranenemy", 11, 5);
    }
    
    void Update() {
        if (RNum == true)
        {
            Invoke("Rtime", 0.7f);
            RNum = false;
        }
        if (ENum == true)
        {
            Invoke("Etime", 0.4f);
            ENum = false;
        }
    }

    void Ranrock()
    {
        Ran[0] = Random.Range(0, 8);
        Ran[1] = Random.Range(0, 8);
        RNum = true;
    }

    void Obj_warning(int num)
    {
        GameObject obj_warning = ObjectPoolingSystem.current.GetPooledObject_warning();

        if (obj_warning == null) return;

        obj_warning.transform.position = warpos[Ran[num]].position;
        obj_warning.transform.rotation = pos[Ran[num]].rotation;
        obj_warning.SetActive(true);
    }

    void Ranenemy()
    {
        Ran[2] = Random.Range(0, 8);
        Ran[3] = Random.Range(0, 8);
        Ran[4] = Random.Range(0, 8);
        Obj_warning(2);
        if (TMcounter.Ctime >= 120)
        {
            Obj_warning(3);
        }
        if (TMcounter.Ctime >= 150)
        {
            Obj_warning(4);
        }
        ENum = true;
    }

    void Obj_rock(int num)
    {
        GameObject obj_rock = ObjectPoolingSystem.current.GetPooledObject_rock();

        if (obj_rock == null) return;

        obj_rock.transform.position = pos[Ran[num]].position;
        obj_rock.transform.rotation = pos[Ran[num]].rotation;
        obj_rock.SetActive(true);
    }

    void Rtime()
    {
        Obj_rock(0);
        if (TMcounter.Ctime >= 60)
        {
            Obj_rock(1);
            move03.Rspeed = 13;
        }
    }

    void Obj_enemy(int num)
    {
        GameObject obj_enemy = ObjectPoolingSystem.current.GetPooledObject_enemy();

        if (obj_enemy == null) return;

        obj_enemy.transform.position = pos[Ran[num]].position;
        obj_enemy.transform.rotation = pos[Ran[num]].rotation;
        obj_enemy.SetActive(true);
    }

    void Etime()
    {
        Obj_enemy(2);
        if(TMcounter.Ctime >= 120)
        {
            Obj_rock(3);
            move03_.Espeed = 13;
        }
        if (TMcounter.Ctime >= 150)
        {
            Obj_rock(3);
            move03_.Espeed = 17;
        }
    }
}
