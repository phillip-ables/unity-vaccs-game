using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleScript : MonoBehaviour {
    public GameObject liveNeedle;
    public GameObject deadNeedle;
    public float throwSpeed;
    public bool isFired;

    private float spriteAngleRot = 25;

    private void Update()
    {
        //Debug.Log(isFired);
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Started");
            Vector3 pos = transform.position;
            pos += Vector3.up * throwSpeed * Time.deltaTime;
            transform.position = pos;
            if (pos.y > GameManager.topRight.y)
            {
                Debug.Log("Finished");
                isFired = false;

            }
        }

        if (isFired)
        {
            Debug.Log("nothing ever works");

        }
    }
    
    public void Init(int needleCount)
    {
        float spriteWidth = liveNeedle.transform.localScale.x;
        float spriteHeight = liveNeedle.transform.localScale.y;
        for (int i = 0; i < needleCount; i++)
        {
            Vector2 pos = Vector2.zero;
            //Vector3 rot = Vector3.zero;

            if (i != needleCount -1)
            {
                //24.825 would be the slight angle tilt
                if (i % 2 == 0)
                {
                    pos = new Vector2(GameManager.topRight.x, GameManager.bottomLeft.y + spriteHeight * (i + 2) + (transform.localScale.y * 4));
                    pos -= Vector2.right * spriteWidth * 5;
                    liveNeedle.GetComponent<SpriteRenderer>().flipX = false;
                    //rot = Vector3.forward * spriteAngleRot;
                }
                else
                {
                    pos = new Vector2(GameManager.bottomLeft.x, GameManager.bottomLeft.y + spriteHeight * (i + 2) + (transform.localScale.y * 4));
                    pos += Vector2.right * spriteWidth * 5;
                    liveNeedle.GetComponent<SpriteRenderer>().flipX = true;
                    //rot = Vector3.forward * -spriteAngleRot;
                }
                liveNeedle.transform.position = pos;
                //liveNeedle.transform.Rotate(rot);
                Instantiate(liveNeedle);
            }
            else
            {
                Instantiate(gameObject);
                pos = new Vector2(0, GameManager.bottomLeft.y);
                pos += Vector2.up * transform.localScale.y * 4;  // i dont think this works
                transform.position = pos;
            }
        }
    }

    public IEnumerator FireNeedle()
    {
        Debug.Log("Fire has arrived");
        while (transform.position.y < GameManager.topRight.y )
        {
            Vector3 pos = transform.position;
            pos += Vector3.up * throwSpeed * Time.deltaTime;
            transform.position = pos;
            Debug.Log(pos.y);
            yield return new WaitForSeconds(.3f);
        }
    }

    public void Firing()
    {
        Debug.Log("Firing was called");
        isFired = true;
        Debug.Log(isFired);
    }
}
