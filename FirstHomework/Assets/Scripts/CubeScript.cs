using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public string playerName;
    public int health;
    public float speed;
    public Vector3 location = new Vector3(0, 0, 0);

    GameObject _sphere;

    [SerializeField] 
    SphereScript sphereScript;

    void Start()
    {
       _sphere = GameObject.FindObjectOfType<SphereScript>().gameObject;
       sphereScript = _sphere.GetComponent<SphereScript>();
       
       _sphere.GetComponent<Renderer>().material.color = Color.green;

        Debug.Log($"\nPlayer name : {sphereScript.playerName} \n Speed : {sphereScript.speed}");
    }

}
