using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Start");
    }

    [SerializeField]

    private Spawner m_spawner;

    [SerializeField]

    private CloudController m_cloudController;

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("Key X pressed ");
            m_spawner.Spawn();

            if (m_spawner)
            {
                m_spawner.Spawn();
            }
            else
            {
                Debug.LogError("m_spawner == null");
            }
        }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                m_cloudController.Action();
            }

        
    }
}
