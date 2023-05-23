using Assets.Scripts;
using DefaultNamespace;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostAttack2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Text PlayerAttack;

    private void Update()
    {
        if (CarControl.isNormalControl)
        {
            if (Input.GetKeyDown(KeyCode.Period) && Car2.BonusCount > 0)
            {
                AttackBuff();
            }
        }

        else
        {
            if (Input.GetKeyDown(KeyCode.C) && Car2.BonusCount > 0)
            {
                AttackBuff();
            }
        }
    }
    // Start is called before the first frame update
    public void AttackBuff()
    {
        Car2.Damage += 1;
        PlayerAttack.text = (Car2.Damage).ToString();
        Car2.BonusCount -= 1;
    }
}
