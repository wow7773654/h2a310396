﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomSideFunction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update(){
    }
		void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag=="Emeny")
            {
                Destroy(col.gameObject);
            }
        }
	
}
