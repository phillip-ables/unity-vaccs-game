using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyScript : MonoBehaviour {
    public float speed;
    public float fastSpeed;
 
    private float height;
    private float width;
    private bool isDew;
    private float dewMultiplier = 2;
    private bool isElectric;
    private float electricMultiplier = 4;
    private Animation mController;


	// Use this for initialization
	void Start () {
        height = transform.localScale.y;
        width = transform.localScale.x;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void WallCollision()
    {
        GetComponent<SpriteRenderer>().flipX
    }
}
