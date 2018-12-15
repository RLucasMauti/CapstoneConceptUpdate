using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpHeight;
    public Rigidbody player;
    private bool playerRot;
    public EnemyHealthManager enemyHM;
    

	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody>();
        playerRot = false;
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKey(KeyCode.A)) {
            player.velocity = new Vector3(-moveSpeed, GetComponentInParent<Rigidbody>().velocity.y, GetComponentInParent<Rigidbody>().velocity.z);
            //Debug.Log("Tried to move left");
            if (!playerRot)
            {
                CharFlip();
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            player.velocity = new Vector3(moveSpeed, GetComponentInParent<Rigidbody>().velocity.y, GetComponentInParent<Rigidbody>().velocity.z);
           // Debug.Log("Tried to move right");
            if (playerRot)
            {
                CharFlip();
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            player.velocity = new Vector3(GetComponentInParent<Rigidbody>().velocity.x , GetComponentInParent<Rigidbody>().velocity.y, moveSpeed);
           // Debug.Log("Tried to move back");
        }

        if (Input.GetKey(KeyCode.S))
        {
            player.velocity = new Vector3(GetComponentInParent<Rigidbody>().velocity.x, GetComponentInParent<Rigidbody>().velocity.y, -moveSpeed);
           // Debug.Log("Tried to move forward");
            
        }



        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            
        }
    }

    void CharFlip() {
        playerRot = !playerRot;

        transform.Rotate(0f, 0f, 180f);
    }
}
