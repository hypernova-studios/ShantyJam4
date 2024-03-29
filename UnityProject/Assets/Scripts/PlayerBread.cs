﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBread : MonoBehaviour
{
    public int HowManyBreadsHaveYouEatenInYourLife;

    public Text t;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bread")
        {
            Destroy(collision.gameObject);
            HowManyBreadsHaveYouEatenInYourLife++;
            t.text = HowManyBreadsHaveYouEatenInYourLife.ToString();
        }
    }

    public bool HasEnough()
    {
        return HowManyBreadsHaveYouEatenInYourLife >= 5;
    }

}
