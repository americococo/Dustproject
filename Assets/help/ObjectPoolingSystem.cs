using UnityEngine;
using System.Collections.Generic;

public class ObjectPoolingSystem : MonoBehaviour {

    public static ObjectPoolingSystem current;  //모든 클래스에서 직접호출 가능

    public GameObject Pool_dust;
    public GameObject Pool_rock;
    public GameObject Pool_enemy;
    public GameObject Pool_warning;

    public GameObject Play_Obj; //obj를 Play_Obj 밑으로생성

    public int PoolAmount_dust = 25;
    public int PoolAmount_rock = 5;
    public int PoolAmount_enemy = 5;
    public int PoolAmount_warning = 5;

    public List<GameObject> PoolObjs_dust;
    public List<GameObject> PoolObjs_rock;
    public List<GameObject> PoolObjs_enemy;
    public List<GameObject> PoolObjs_warning;

    void Awake() {
        //static으로 선언한 NewObjPooling current에 접근
        current = this;
    }

    void Start() {
        PoolObjs_dust = new List<GameObject>();
        PoolObjs_rock = new List<GameObject>();
        PoolObjs_enemy = new List<GameObject>();
        PoolObjs_warning = new List<GameObject>();

        for (int i = 0; i < PoolAmount_dust; i++)
        {
            GameObject obj_dust = (GameObject)Instantiate(Pool_dust);

            obj_dust.transform.parent = Play_Obj.transform; //[자식] obj_dust -> [부모] Play_Obj 밑으로 생성하기

            //PoolObj -> obj에 저장
            obj_dust.SetActive(false);
            PoolObjs_dust.Add(obj_dust);
            // Instantiate로 그려지고 비활성화된 상태의 오브젝트를 PoolObjs에 차곡차곡 넣는다.
        }
        for (int i = 0; i < PoolAmount_rock; i++)
        {
            GameObject obj_rock = (GameObject)Instantiate(Pool_rock);

            obj_rock.transform.parent = Play_Obj.transform;

            obj_rock.SetActive(false);
            PoolObjs_rock.Add(obj_rock);
        }
        for (int i = 0; i < PoolAmount_enemy; i++)
        {
            GameObject obj_enemy = (GameObject)Instantiate(Pool_enemy);

            obj_enemy.transform.parent = Play_Obj.transform;

            obj_enemy.SetActive(false);
            PoolObjs_enemy.Add(obj_enemy);
        }
        for (int i = 0; i < PoolAmount_warning; i++)
        {
            GameObject obj_warning = (GameObject)Instantiate(Pool_warning);

            obj_warning.transform.parent = Play_Obj.transform;

            obj_warning.SetActive(false);
            PoolObjs_warning.Add(obj_warning);
        }
    }

    public GameObject GetPooledObject_dust() {
        for (int i = 0; i < PoolObjs_dust.Count; i++)
        {
            //obj.SetActive 가 false면 실행 
            if (!PoolObjs_dust[i].activeInHierarchy)
            {
                //GM의 CUBE_A()에서 넘어온 obj.SetActive(true)된 Cube_A 호출
                return PoolObjs_dust[i];
            }
        }
        return null;
        // PoolObjs에 prefab이 남아있지 않으면 null을 넘겨준다.
    }
    public GameObject GetPooledObject_rock() {
        for (int i = 0; i < PoolObjs_rock.Count; i++)
        {
            if (!PoolObjs_rock[i].activeInHierarchy)
            {
                return PoolObjs_rock[i];
            }
        }
        return null;
    }
    public GameObject GetPooledObject_enemy() {
        for (int i = 0; i < PoolObjs_enemy.Count; i++)
        {
            if (!PoolObjs_enemy[i].activeInHierarchy)
            {
                return PoolObjs_enemy[i];
            }
        }
        return null;
    }
    public GameObject GetPooledObject_warning()
    {
        for (int i = 0; i < PoolObjs_warning.Count; i++)
        {
            if (!PoolObjs_warning[i].activeInHierarchy)
            {
                return PoolObjs_warning[i];
            }
        }
        return null;
    }
}
