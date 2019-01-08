using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public BabyScript baby;
    public NeedleScript needle;
    public int babyCount;
    public int needleCount;

    public static Vector2 bottomLeft;
    public static Vector2 topRight;

    private float babyTime;

    private void Start()
    {
        //Convert screen's pivel coordinate into game's coordinate
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        babyTime = baby.waitTime;
        //Instantiate(needle);

        needle.Init(needleCount);
    }

    private void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            //Debug.Log("Fire");
            //StartCoroutine(needle.FireNeedle());
            needle.isFired = true;
            //Debug.Log(needle.isFired);
            needle.Firing();
            needleCount--;
        }

        //Init Babies
        if (babyCount > 0)
        {
            if (babyTime > baby.waitTime)
            {
                baby.MakeBaby();
                babyTime = 0;
                //Debug.Log("MadeBaby");
                babyCount--;
            }
            else
                babyTime += Time.deltaTime;
        }
            
    }
}
