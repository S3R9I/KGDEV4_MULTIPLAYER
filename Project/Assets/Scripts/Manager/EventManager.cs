﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using StateMachine;

public class EventManager : NetworkBehaviour {
    public delegate void CheckWeapon();

    public static event CheckWeapon WeaponCheck;

    //Event to check weapons which is static
    public static void Weapon_Check()
    {
        WeaponCheck();
    }
}
