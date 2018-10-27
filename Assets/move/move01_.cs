using UnityEngine;

public class move01_ : MonoBehaviour {

    void Update()  {
        if (Application.platform == RuntimePlatform.Android)
        {
            Vector3 tpos = Input.GetTouch(0).position;
            if (tpos.x >= Screen.width / 2)
            {
                transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, -1), Time.deltaTime * 210);
            }
            else if (tpos.x <= Screen.width / 2)
            {
                transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, -1), Time.deltaTime * 210);
            }
        }
    }
}