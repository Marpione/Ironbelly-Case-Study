using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class SpawnButton : MonoBehaviour
{
    public InputField inputField;


    public void SpawnObjects()
    {
        int value = int.Parse(inputField.text);

        for (int i = 0; i < value; i++)
        {
            PoolingSystem.Instance.InstantiateAPS("Cube", FindObjectOfType<NavMeshSurface>().GetRandomPositionMovementArea());
        }
    }
}
