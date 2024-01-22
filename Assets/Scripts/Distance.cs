using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class Distance : MonoBehaviour
{
    public Text distance;
    public GameObject target1;
    public GameObject target2;

    public static float distanceBetweenObjects;



    private void Update()
    {
        distanceBetweenObjects = Vector3.Distance(target1.transform.position, target2.transform.position);
        distanceBetweenObjects -= 1;
        distance.text = distanceBetweenObjects.ToString();
    }



}