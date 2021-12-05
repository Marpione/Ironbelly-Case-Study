using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInputController : MonoBehaviour
{
    CharacterMotor characterMotor;
    CharacterMotor CharacterMotor { get { return (characterMotor == null) ? characterMotor = GetComponent<CharacterMotor>() : characterMotor; } }

    // Update is called once per frame
    void Update()
    {
        CharacterMotor.Move(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
    }
}
