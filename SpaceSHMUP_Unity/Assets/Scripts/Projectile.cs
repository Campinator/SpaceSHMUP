/**** 
 * Created by: Camp Steiner
 * Date Created: April 6, 2022
 * 
 * Last Edited by: Camp Steiner
 * Last Edited: April 6, 2022
 * 
 * Description: Behavior for the projectile
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private BoundsCheck bc;
    // Start is called before the first frame update
    void Awake()
    {
        bc = GetComponent<BoundsCheck>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (bc.offUp)
        {
            Destroy(gameObject);
        }
    }
}
