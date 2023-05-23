using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegenerateHP2 : MonoBehaviour
{
    [SerializeField] private Text PlayerHealth;

    private void Update()
    {
        if (CarControl.isNormalControl)
        {
            if (Input.GetKeyDown(KeyCode.Comma) && Car2.BonusCount > 0)
            {
                RegenerateBuff();
            }
        }

        else
        {
            if (Input.GetKeyDown(KeyCode.X) && Car2.BonusCount > 0)
            {
                RegenerateBuff();
            }
        }
    }
    public void RegenerateBuff()
    {
        Car2.Health += 5;
        PlayerHealth.text = (Car2.Health).ToString();
        Car2.BonusCount -= 1;
    }
}
