using UnityEngine;
using System.Collections;

public class CObstaclesController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        foreach(Transform child in transform)
        {
            child.gameObject.AddComponent<BoxCollider2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
