using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public Transform PlayerPos;
    public List<Transform>SlotsPos;
    public bool hit;

    public int whatSlot;

    float step = 0.0f;

	// Use this for initialization
	void Start () {
		
	}

	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            hit = true;
            whatSlot++;
        }

        if (hit)
        {
            transform.position = Vector2.Lerp(transform.position, SlotsPos[whatSlot].position, step += 0.4f * Time.deltaTime);
            StartCoroutine(HaltforHit() );
        }

        if (whatSlot >= SlotsPos.Capacity - 1)
        {
            Debug.Log("Reached the Edge!!");
        }
    }



    IEnumerator HaltforHit()
    {
        yield return new WaitForSeconds(1.0f);
        hit = false;
        step = 0.0f;
    }
}
