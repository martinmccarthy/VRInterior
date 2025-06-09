using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private InputActionReference m_aButton;
    [SerializeField] private InputActionReference m_leftStick;
    [SerializeField] private float moveSpeed = 1.5f;
    [SerializeField] private Transform playerPosition;
    [SerializeField] private Transform playerRotation;

    private void Update()
    {
    }
}
