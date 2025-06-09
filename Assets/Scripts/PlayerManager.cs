using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private InputActionReference m_aButton;
    [SerializeField] private GameObject m_cube;

    private int m_index = 0;
    private void Update()
    {
        if(m_aButton.action.triggered)
        {
            GameObject cube = Instantiate(m_cube);
            cube.transform.position = new(0, m_index, 0);
            m_index++;
        }
    }
}
