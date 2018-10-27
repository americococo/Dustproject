using UnityEngine;

public class Dust_help : MonoBehaviour {

    private Transform Player;
    private Transform Enemy;
    public static int dustspeed = 7;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Enemy = GameObject.FindWithTag("Enemy").transform;
            Vector3 EVec = (Enemy.transform.position - transform.position).normalized;
            transform.position += EVec * Time.deltaTime * (move03_.Espeed + 2);
        }
        else if(shield.SD >= 4)
        {
            Player = GameObject.FindWithTag("Player").transform;
            Vector3 Vec = (Player.transform.position - transform.position).normalized;
            transform.position += Vec * Time.deltaTime * (dustspeed * dustspeed);
        }
        else if (other.gameObject.tag == "Player")
        {
            Player = GameObject.FindWithTag("Player").transform;
            Vector3 Vec = (Player.transform.position - transform.position).normalized;
            transform.position += Vec * Time.deltaTime * dustspeed;
        }
    }
}
