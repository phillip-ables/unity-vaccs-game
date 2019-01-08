using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyScript : MonoBehaviour {
    public float speed;
    public float fastSpeed;
    public float waitTime;
 
    private float height;
    private float width;
    private bool isDew;
    private float dewMultiplier = 2;
    private bool isElectric;
    private float electricMultiplier = 4;
    private Animation mController;
    private float timeToNextBaby;
    
	void Start () {
        height = transform.localScale.y;
        width = transform.localScale.x;
        timeToNextBaby = waitTime;
	}

    public void Init(int babyCount)
    {
        while(babyCount != 0)
        {
            timeToNextBaby -= Time.deltaTime;
            if (timeToNextBaby < 0)
            {
                timeToNextBaby = waitTime;
            }
        }
    }

    public void WallCollision()
    {
        GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
    }
}
