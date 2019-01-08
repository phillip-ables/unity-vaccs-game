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
        for(int i = 0; i < babyCount; i++)
        {
            Instantiate(gameObject);
            Debug.Log("Active? " + gameObject.activeInHierarchy);
            //StartCoroutine(MakeBaby());
        }


        /*
        Vector2 initialPos = new Vector2(
                                    GameManager.bottomLeft.x +( width / 2),
                                    Random.Range(GameManager.bottomLeft.y, GameManager.topRight.y));
        Instantiate(gameObject);
        transform.position = initialPos;
        babyCount--;

        timeToNextBaby = waitTime;

        while (babyCount != 0)
        {
            timeToNextBaby -= Time.deltaTime;
            if (timeToNextBaby <= 0)
            {
                if (Random.Range(0, 1) <= .5)
                {
                    initialPos.x = GameManager.topRight.x;
                    GetComponent<SpriteRenderer>().flipX = true;
                }
                else
                {
                    initialPos.x = GameManager.bottomLeft.x;
                    GetComponent<SpriteRenderer>().flipX = false;
                }

                initialPos.y = Random.Range(GameManager.bottomLeft.y, GameManager.topRight.y);
                Instantiate(gameObject);
                transform.position = initialPos;

                timeToNextBaby = waitTime;
                babyCount--;
            }
        }
        */
    }

    public void MakeBaby()
    {
        Vector2 initialPos = Vector2.zero;
        if (Random.Range(0, 1) <= .5)
        {
            initialPos.x = GameManager.topRight.x;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            initialPos.x = GameManager.bottomLeft.x;
            GetComponent<SpriteRenderer>().flipX = false;
        }

        initialPos.y = Random.Range(GameManager.bottomLeft.y, GameManager.topRight.y);
        Instantiate(gameObject);
        transform.position = initialPos;

        Debug.Log("Finished Making Baby");
        //yield return new WaitForSeconds((waitTime));
    }

    public void WallCollision()
    {
        GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
    }
}
