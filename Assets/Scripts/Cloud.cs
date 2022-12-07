using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    [SerializeField]

    private ParticleSystem m_rain;

    public void StartRain()
    {
      m_rain.Play();
    }

    public void StoptRain()
    {
        m_rain.Stop();
    }
    

}
