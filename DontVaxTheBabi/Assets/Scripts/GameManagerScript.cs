using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {
    public BabyScript baby;
    public NeedleScript needle;

    public static Vector2 bottomLeft;
    public static Vector2 topRight;
    
	// Use this for initialization
	void Start () {
        // Convert screen's pixel coordinate into game's coordinate
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        Instantiate(baby);
        Instantiate(needle);

        needle.Init(5);
	}
}
