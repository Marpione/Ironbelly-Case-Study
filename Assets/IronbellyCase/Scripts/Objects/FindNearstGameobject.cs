using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindNearstGameobject : MonoBehaviour
{
    public float VisionRange;

    private void OnEnable()
    {
        if (ObjectManager.Instance != null)
            ObjectManager.Instance.AddNewObject(this);
    }

    private void OnDisable()
    {
        if(ObjectManager.Instance != null)
            ObjectManager.Instance.RemoveObject(this);
    }

    private void OnDrawGizmos()
    {
        foreach (var item in ObjectManager.Instance.NearstGameobjects)
        {
            if (Vector3.Distance(transform.position, item.transform.position) < VisionRange)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawLine(transform.position, item.transform.position);
            }

        }
    }
}
