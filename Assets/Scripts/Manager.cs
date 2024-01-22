using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public static Manager Instance;
    public static event Action DisableSphere;
    public static event Action EnableSphere;

    private void Awake()
    {
        Instance = this;
        OnDisableSphere();
    }

    public void OnDisableSphere()
    {
        DisableSphere?.Invoke();
    }

    public void OnEnableSphere()
    {
        EnableSphere?.Invoke();
    }

    public void LateUpdate()
    {
        if (Distance.distanceBetweenObjects<2f)
        {
            OnEnableSphere();
            if(Distance.distanceBetweenObjects < 1f)
            {
                SceneManager.LoadScene("SecondScene");
            }
        }
        else
        {
            OnDisableSphere();
        }
    }




}
