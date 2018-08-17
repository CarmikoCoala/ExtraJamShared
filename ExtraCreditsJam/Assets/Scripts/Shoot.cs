using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject BulletShootRight, BulletShootLeft;
    public bool isPlayerOne;

    Vector2 BulletPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.A) && isPlayerOne )
        {
            Fire(isPlayerOne);
        }
        else if(Input.GetKeyDown(KeyCode.L) && !isPlayerOne)
        {
            Fire(isPlayerOne);
        }
	}

    void Fire(bool isOne)
    {
        if (isOne)
         {
            BulletPosition = new Vector2(transform.position.x+1,transform.position.y);
            Instantiate(BulletShootRight, BulletPosition, Quaternion.identity);
        }
        else {
            BulletPosition = new Vector2(transform.position.x - 1, transform.position.y);
            Instantiate(BulletShootLeft, BulletPosition, Quaternion.identity);
        }
        
    }
}
