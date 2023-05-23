using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegenerateHP1 : MonoBehaviour
{
    [SerializeField] private Text PlayerHealth;

    private void Update()
    {
        if (CarControl.isNormalControl) 
        {
            if (Input.GetKeyDown(KeyCode.X) && Car1.BonusCount > 0)
            {
                RegenerateBuff();
            }
        }
        
        else 
        {
            if (Input.GetKeyDown(KeyCode.Comma) && Car1.BonusCount > 0)
            {
                RegenerateBuff();
            }
        }
    }
    public void RegenerateBuff()
    {
        Car1.Health += 5;
        PlayerHealth.text = (Car1.Health).ToString();
        Car1.BonusCount -= 1;
    }
}
