using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invader : MonoBehaviour {
    public GameObject explo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position += new Vector3(0, -0.01f, 0);
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="Ship"||col.tag=="Bullet")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);

            Instantiate(explo, transform.position, transform.rotation);
            if(col.tag=="Ship")
            {
                Instantiate(explo, col.gameObject.transform.position, col.gameObject.transform.rotation);

                GameFunction.instance.GameOver();
            }
            GameFunction.instance.AddScore();
        }
    }
}
