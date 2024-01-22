using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
    private void Awake()
    {
        Manager.DisableSphere += HideSphere;
        Manager.EnableSphere += ShowSphere;
    }
    public void ShowSphere()
    {
        gameObject.SetActive(true);
    }

    private void HideSphere()
    {
        gameObject.SetActive(false);
    }
}
