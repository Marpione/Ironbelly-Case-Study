using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ObjectManager : Singleton<ObjectManager>
{
    public List<FindNearstGameobject> NearstGameobjects = new List<FindNearstGameobject>();
    public int startingObjectCount;

    private void Start()
    {
        for (int i = 0; i < startingObjectCount; i++)
        {
            PoolingSystem.Instance.InstantiateAPS("Cube", FindObjectOfType<NavMeshSurface>().GetRandomPositionMovementArea());

        }
    }

    public void AddNewObject(FindNearstGameobject arg0)
    {
        if (!NearstGameobjects.Contains(arg0))
        {
            NearstGameobjects.Add(arg0);
        }
    }


    public void RemoveObject(FindNearstGameobject arg0)
    {
        if (NearstGameobjects.Contains(arg0))
        {
            NearstGameobjects.Remove(arg0);
        }
    }
}
