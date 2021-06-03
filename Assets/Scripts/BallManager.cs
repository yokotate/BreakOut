using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class BallManager : MonoBehaviour
    public float firstSpeed = 300.0f; //初速
    private Rigidbody rb; //物理エンジン
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        rb.AddForce(this.gameObject.transform.forward * firstSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
