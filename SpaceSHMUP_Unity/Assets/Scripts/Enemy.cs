/**** 
 * Created by: Akram Taghavi-Burris
 * Date Created: March 16, 2022
 * 
 * Last Edited by: Camp Steiner
 * Last Edited: March 30, 2022
 * 
 * Description: Enemy controler
****/

/** Using Namespaces **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SelectionBase] //forces selection of parent object
public class Enemy : MonoBehaviour
{
    /*** VARIABLES ***/

    [Header("Enemy Settings")]
    public float speed = 10f;
    public float fireRate = 0.3f;
    public float health = 10;
    public int score = 100;

    private BoundsCheck bndCheck; //reference to bounds check component
    
    //method that acts as a field (property)
    public Vector3 pos
    {
        get { return (this.transform.position); }
        set { this.transform.position = value; }
    }

    /*** MEHTODS ***/

    //Awake is called when the game loads (before Start).  Awake only once during the lifetime of the script instance.
    void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();
    }//end Awake()


    // Update is called once per frame
    void Update()
    {
       Move();

        //Check if bounds check exists and the object is off the bottom of the screne
        if(bndCheck != null && bndCheck.offDown)
        {
              Destroy(gameObject); //destory the object

        }//end if(bndCheck != null && !bndCheck.offDown)


    }//end Update()

    //Virtual methods can be overiden by child instances
    public virtual void Move()
    {
        Vector3 tmpPos = pos;
        tmpPos.y -= speed * Time.deltaTime; //move down
        pos = tmpPos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject o = collision.gameObject;
        if(o.tag == "ProjectileHero") //if a bullet touches the enemy
        {
            Hero.SHIP.AddToScore(score); //increase score
            o.SetActive(false); //deactive the bullet
            Destroy(gameObject); //destroy the enemy
        }
    }
}
