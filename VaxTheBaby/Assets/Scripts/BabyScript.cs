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

    private void Update()
    {
        //transform.position += Vector3.right * speed * Time.deltaTime;
    }

    public void MakeBaby()
    {
        Vector2 initialPos = Vector2.zero;
        float randFloat = Random.Range(0.0f, 1.0f);
        Debug.Log(randFloat);
        if (false)
        {
            initialPos.x = GameManager.topRight.x;
            GetComponent<SpriteRenderer>().flipX = false;
            Debug.Log("Right baby : " + initialPos.x+ " , " + GetComponent<SpriteRenderer>().flipX);
        }
        else
        {
            initialPos.x = GameManager.bottomLeft.x;
            GetComponent<SpriteRenderer>().flipX = true;
            speed *= -1;
            Debug.Log("Right baby : " + initialPos.x + " , " + GetComponent<SpriteRenderer>().flipX);
        }

        initialPos.y = Random.Range(GameManager.bottomLeft.y, GameManager.topRight.y);
        Instantiate(gameObject);
        transform.position = initialPos;
        
    }

    public void WallCollision()
    {
        GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
        speed *= -1;
    }
}
