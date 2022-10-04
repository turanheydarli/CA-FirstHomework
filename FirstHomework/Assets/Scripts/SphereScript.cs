using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    public string playerName;
    [SerializeField]
    private int health;
    public float speed;
    public Vector3 location = new Vector3(0, 0, 0);

    private GameObject _cube;
    public CubeScript cubeScript;
    
    // Start is called before the first frame update
    void Start()
    {
        _cube = GameObject.FindObjectOfType<CubeScript>().gameObject;
        cubeScript = _cube.GetComponent<CubeScript>();
        
        _cube.GetComponent<Renderer>().material.color = Color.blue;
        
        Debug.Log($"\nPlayer name : {cubeScript.playerName} \n Speed : {cubeScript.speed}");
    }

}
