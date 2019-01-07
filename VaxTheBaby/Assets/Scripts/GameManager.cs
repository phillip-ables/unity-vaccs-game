using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public BabyScript baby;
    public NeedleScript needle;

    public static Vector2 bottomLeft;
    public static Vector2 topRight;

    private void Start()
    {
        //Convert screen's pivel coordinate into game's coordinate
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        Instantiate(baby);
        Instantiate(needle);

        needle.Init(5);
    }
}
