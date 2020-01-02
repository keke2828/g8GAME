using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool openDoor;
    private int score = 100;
    private void Start()
    {


        if (true)
        {
            print("測試!");
        }
    }

    private void Update()
    {
        if (openDoor)
        {
            print("開門");

        }
        else
        {
            print("關門");

        }
        if (score >= 60)
        {
            print("及格");

        }
        else
        {
            print("被當了");
        }
    }

}
