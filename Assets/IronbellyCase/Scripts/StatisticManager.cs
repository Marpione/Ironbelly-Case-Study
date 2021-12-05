using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class StatisticManager : MonoBehaviour
{
    private int ShootsFired;
    private int ShootsMissed;
    private int ShootsHit;

    public Text ShootsFiredText, ShootsMissedText, ShootsHitText;


    private void OnEnable()
    {
        EventManager.OnShootFired.AddListener(UpdateStats);
    }

    private void OnDisable()
    {
        EventManager.OnShootFired.RemoveListener(UpdateStats);
    }

    private void UpdateStats(bool arg0)
    {
        ShootsFired++;
        if (arg0)
            ShootsHit++;
        else
            ShootsMissed++;

        //Update UI

        ShootsFiredText.text = ShootsFired.ToString();
        ShootsMissedText.text = ShootsMissed.ToString();
        ShootsHitText.text = ShootsHit.ToString();
    }
}
