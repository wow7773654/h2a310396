using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position += new Vector3(0, 0.1f, 0);
        if (transform.position.y > 4 || transform.position.y < -4)
        {
            //如果物件的Y值大於20或小於20 就將物件移除
            Destroy(gameObject);
        }
    }
}
