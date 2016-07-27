using UnityEngine;
using System.Collections;

public class CBlockController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position.Set(transform.position.x, transform.position.y, transform.position.z-.5f);
    }
}
