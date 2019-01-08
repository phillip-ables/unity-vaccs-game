using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public BabyScript baby;
    public NeedleScript needle;
    public int babyCount;

    public static Vector2 bottomLeft;
    public static Vector2 topRight;

    private float babyTime;

    private void Start()
    {
        //Convert screen's pivel coordinate into game's coordinate
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        babyTime = 0;

        Instantiate(baby);
        Instantiate(needle);

        needle.Init(5);
    }

    private void Update()
    {
        //Debug.Log("Entered Update");
        if (babyCount > 0)
        {
            if (babyTime > baby.waitTime)
            {
                baby.MakeBaby();
                babyTime = 0;
                Debug.Log("MadeBaby");
                babyCount--;
            }
            else
                babyTime += Time.deltaTime;
        }
            
    }
}
