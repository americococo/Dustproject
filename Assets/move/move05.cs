using UnityEngine;

public class move05 : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Rock")
        {
            other.gameObject.SetActive(false);
        }
    }
}
