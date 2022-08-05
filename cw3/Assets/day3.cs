using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day3 : MonoBehaviour
{
    string heroname = "amk";
    int heroPower = 100;

    string villainName = "nmk";
    int villairPower = 100;

    float playerSpeed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        if (heroPower > villairPower)
        {
            print(heroname + "isStronger");
        }
        else if (heroPower == villairPower)
        {
            print(heroname + "eqauls" + villainName);
        }
        else
        {
            print(villainName + " is strongr");
        }
        setSpeed(2.5f);
    }   
    
        
    void setSpeed(float Newspeed)
    {
        print(playerSpeed);
        playerSpeed = Newspeed;
        print(playerSpeed);
    }
}
