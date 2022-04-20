using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    int health;
    int power;
    string name;

    public Player()
    {
        health = 1001;
        power = 801;
        name = "Warriors2";

        Debug.Log("Player's health = " + health + "/ Player's power = " + power + "/ Player's name = " + name);
    }
}
