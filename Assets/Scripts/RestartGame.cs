using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        Car1.Health = 100;
        Car1.Damage = 1;
        Car1.BonusCount = 0;

        Car2.Health = 100;
        Car2.Damage = 5;
        Car2.BonusCount = 0;
        
        CarControl.isNormalControl = true;

        Time.timeScale = 1.0f;
    }
}
