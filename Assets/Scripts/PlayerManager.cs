using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float playerSpeed;
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey("right") && pos.z < 3.5f)
        {
            pos = new Vector3(pos.x, pos.y, pos.z + playerSpeed);
        }
        if (Input.GetKey("left") && pos.z > -3.5f)
        {
            pos = new Vector3(pos.x, pos.y, pos.z - playerSpeed);
        }
        transform.position = pos;
    }
}
