using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour {

    public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.tag == "Bullet")
        {
            InstantiateBullets();
        }
    }

    void InstantiateBullets()
    {
        for(int i = 0; i < 100; i++)
        {
            Instantiate(bulletPrefab, new Vector3(-1, 2, -8), Quaternion.identity);
        }
    }
}
