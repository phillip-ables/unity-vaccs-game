using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}

    public void Init(int neddleCount)
    {
        Vector2 pos = Vector2.zero;

        if(neddleCount > 0)
        {

        }
        else
        {
            //this should but right at the active position
            pos = new Vector2(GameManagerScript.topRight.x / 2, GameManagerScript.bottomLeft.y);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
