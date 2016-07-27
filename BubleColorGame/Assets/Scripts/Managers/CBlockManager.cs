using UnityEngine;
using System.Collections;

public class CBlockManager : Singleton<CBlockManager>
{
    protected CBlockManager() { }
    
    [SerializeField]
    private Transform m_spawnPoint;

    [SerializeField]
    private GameObject m_block;

    [SerializeField]
    private float deltaSpawn = 0;
    private float currentTime = 0;

    // Update is called once per frame
    void Update()
    {
        if(currentTime<deltaSpawn)
        {
            currentTime += Time.deltaTime;
        }
        else
        {
            currentTime -= deltaSpawn;
            Instantiate(m_block, m_spawnPoint.position, Quaternion.identity);
        }
    }
}
