﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class GameSwitch_Manager : NetworkBehaviour {
    [SyncVar]
    public int test = 0;

    public State_Manager SM;
    public AudioSource testsound;


    public Text UItext;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
        UItext.text = "" + SM.stateMachine.currentState.ReturnText() + SM.stateMachine.currentState.seconds;
    }
}
