using UnityEngine;

public class move01 : MonoBehaviour {

    public GameObject over;
    bool reone;

	void Update () {
        if (Player.HP > 0)
        {
            reone = true;
        }
        else
        {
            if (reone == true)
            {
                Instantiate(over);
                reone = false;

            }
        }
        if (Application.platform == RuntimePlatform.Android)
        {
            Vector3 tpos = Input.GetTouch(0).position;
            if (tpos.x >= Screen.width / 2)
            {
                transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * 210);
            }
            else if (tpos.x <= Screen.width / 2)
            {
                transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * 210);
            }
        }
    }
}