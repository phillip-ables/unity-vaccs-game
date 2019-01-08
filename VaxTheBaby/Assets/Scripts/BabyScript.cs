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
	}

    public void Init(int babyCount)
    {
        Vector2 initialPos = new Vector2(
                                    GameManager.bottomLeft.x +( width / 2),
                                    Random.Range(GameManager.bottomLeft.y, GameManager.topRight.y));
        Instantiate(gameObject);
        transform.position = initialPos;

        timeToNextBaby = waitTime;

        while (babyCount != 0)
        {
            timeToNextBaby -= Time.deltaTime;
            if (timeToNextBaby < 0)
            {
                if (Random.Range(0, 1) <= .5)
                    initialPos.x = GameManager.topRight.x;
                else
                    initialPos.x = GameManager.bottomLeft.x;

                initialPos.y = Random.Range(GameManager.bottomLeft.y, GameManager.topRight.y);
                Instantiate(gameObject);
                transform.position = initialPos;

                timeToNextBaby = waitTime;
                babyCount--;
            }
        }
    }

    public void WallCollision()
    {
        GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
    }
}
