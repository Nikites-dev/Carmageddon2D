using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReverseMove : MonoBehaviour
{

    [SerializeField] private Text boostButton1;
    [SerializeField] private Text regenerateButton1;

    [SerializeField] private Text boostButton2;
    [SerializeField] private Text regenerateButton2;

    // Update is called once per frame
    void Update()
    {
        if (CarControl.isNormalControl)
        {
            regenerateButton2.text = "Regenerate (<)";
            boostButton2.text = "Boost attack (>)";

            regenerateButton1.text = "Regenerate (X)";
            boostButton1.text = "Boost attack (C)";
        }

        else
        {
            regenerateButton2.text =  "Regenerate (X)";
            boostButton2.text = "Boost attack (C)";

            regenerateButton1.text = "Regenerate (<)";
            boostButton1.text = "Boost attack (>)";
        }
    }
}
