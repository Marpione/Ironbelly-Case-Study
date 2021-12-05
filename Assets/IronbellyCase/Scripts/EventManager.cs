using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager
{
    public static StatisticEvent OnShootFired = new StatisticEvent();
}

public class StatisticEvent : UnityEvent<bool> { }


