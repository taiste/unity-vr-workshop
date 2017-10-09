using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinder : MonoBehaviour {

    public GameObject bulletPrefab;
    Vector3 startPosition;

	// Use this for initialization
	void Start () {
		this.startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = this.startPosition + new Vector3(0f, 0f, Mathf.Sin(Time.time) * 10);
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
