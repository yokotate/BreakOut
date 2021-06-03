using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class BallManager : MonoBehaviour
{
    public GameManager gameManager;
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

    public void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("GameOver")){
            gameManager.GameOver();
        }
    }
}
