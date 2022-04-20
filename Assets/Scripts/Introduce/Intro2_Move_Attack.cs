using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro2_Move_Attack : MonoBehaviour
{
    new string name = "player";
    int power = 80;
    int speed = 30;

    public Intro2_Move_Attack(string name, int power, int speed)
    {
        this.name = name;
        this.power = power;
        this.speed = speed;
    }

    public Intro2_Move_Attack()
    {
    }

    void PlayerInfo()
    {
        Debug.Log("Player: " + name + "/ Power: " + power + "/ Speed: " + speed);
    }


    // Start is called before the first frame update
    void Start()
    {
        //Intro2_Move_Attack intro2 = new Intro2_Move_Attack();
        //intro2.Move();
        //intro2.Attack();

        Intro2_Move_Attack intro2 = new Intro2_Move_Attack("Player 2", 100, 200);
        intro2.PlayerInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Move()
    {
        Debug.Log("The player is moving");
    }
    void Attack()
    {
        Debug.Log("The player is attacking");
    }
}
