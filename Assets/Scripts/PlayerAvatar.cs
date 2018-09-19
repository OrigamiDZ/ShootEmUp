using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvatar : BaseAvatar {


    public override void decreaseHealth()
    {
        health = health - 1;
    }


    // Use this for initialization
    void Start () {
        
    
    }

    // Update is called once per frame
    void Update () {
		
	}
}
