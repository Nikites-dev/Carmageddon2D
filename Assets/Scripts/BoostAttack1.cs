using Assets.Scripts;
using DefaultNamespace;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostAttack1 : MonoBehaviour
{
    [SerializeField] private Text PlayerAttack;

    private void Update()
    {

        if (CarControl.isNormalControl)
        {
            if (Input.GetKeyDown(KeyCode.C) && Car1.BonusCount > 0)
            {
                AttackBuff();
            }
        }

        else
        {
            if (Input.GetKeyDown(KeyCode.Period) && Car1.BonusCount > 0)
            {
                AttackBuff();
            }
        }
    }
    public void AttackBuff() 
    {
        Car1.Damage += 1;
        PlayerAttack.text = (Car1.Damage).ToString();
        Car1.BonusCount -= 1;
    }
}
