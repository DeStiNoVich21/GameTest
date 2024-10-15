using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public abstract class Pl : MonoBehaviour
{
    public abstract void MoveUp();
    public abstract void MoveDown();
    
    public abstract void MoveLeft();

    public abstract void MoveRight();

    public abstract void Kick();


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            switch (Input.inputString)
            {
                case "w":
                    MoveUp();
                    break;
                case "s":
                    MoveDown();
                    break;
                case "d":
                    MoveRight();
                    break;
                case "a":
                    MoveLeft();
                    break;
                case "f":
                    Kick();
                    break;
            }
        }
    }


}
