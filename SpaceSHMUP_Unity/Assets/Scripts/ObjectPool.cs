/**** 
 * Created by: Camp Steiner
 * Date Created: April 6, 2022
 * 
 * Last Edited by: Camp Steiner
 * Last Edited: April 6, 2022
 * 
 * Description: Create a pool of objects for reuse
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool POOL;
    #region POOL SINGLETON
    void CheckPool()
    {
        if (POOL == null) POOL = this;
        else Debug.LogError("Too many pools");
    }
    #endregion

    private Queue<GameObject> projectiles = new Queue<GameObject>(); //hold the projectiles
    [Header("Pool Settings")]
    public GameObject projectilePrefab;
    public int poolStartSize = 5;

    private void Awake()
    {
        CheckPool();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
