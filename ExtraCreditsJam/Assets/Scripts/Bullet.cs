using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    Move moveScript;

    public float VelocityX;
    public float VelocityY = 0.0f;
    Rigidbody2D rigid;

	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
        moveScript = FindObjectOfType<Move>(); 
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Hit Someone!");
            moveScript.hit = true;
            moveScript.whatSlot++;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate () {

        rigid.velocity = new Vector2(VelocityX, VelocityY);
        Destroy(gameObject,3.0f);
	}
}
