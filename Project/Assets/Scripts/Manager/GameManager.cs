﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public MatchSettings MatchSettings;

    void Awake()
    {
        if (instance != null)
            Debug.LogError("More than one GameManager in scene");
        else
            instance = this;
    }
    #region Player Settings

    private const string PLAYER_ID_PREFIX = "Player ";

    public static Dictionary<string, Player> players = new Dictionary<string, Player>();

    public static void RegisterPlayer(string _netID, Player _player)
    {
        string _playerID = PLAYER_ID_PREFIX + _netID;
        players.Add(_playerID, _player);
        _player.transform.name = _playerID;
    }
    public static void UnRegisterPlayer(string _playerID)
    {
        players.Remove(_playerID);
    }
    public Dictionary<string, Player> GetPlayers()
    {
        return players;
    }
    public static Player GetPlayer(string _playerID)
    {
        return players[_playerID];
    }

    #endregion

    #region Match Settings

    #endregion
}
