﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;
using System;
public class PlayerState : State<State_Manager>
{
    private static PlayerState _instance;

    private PlayerState()
    {
        if (_instance != null)
        {
            return;
        }

        _instance = this;
    }

    public static PlayerState Instance {
        get {
            if (_instance == null)
            {
                new PlayerState();
            }
            return _instance;
        }

    }
    public override void EnterState(State_Manager _owner)
    {
        seconds = 20;
        Debug.Log("Entering Player State");
    }

    public override void ExitState(State_Manager _owner)
    {
        Debug.Log("Exiting Player State");
    }

    public override string ReturnText()
    {
        return ("Time to to take position: " + seconds);
    }
    public override void UpdateState(State_Manager _owner)
    {

    }
}