using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float health = 2.0f;
    [SerializeField] private Animator animator;
    private Score score;
    
    void Start() 
    {
        animator = this.GetComponent<Animator>();
        score = GameObject.Find("Score").GetComponent<Score>();
    }

    void OnTriggerEnter2D(Collider2D projectile)
    {
        if ( projectile.tag == "projectile" )
        {
            Destroy(projectile.gameObject, 0.0f); 
            animator.SetBool("isHit", true);
            Invoke("hitCooldown", 0.25f); // 0.25 sec cooldown between getting hit

            health--;
            if (health <= 0) {
                Destroy(gameObject);
                score.addScore(1); // add 1 to score
            }
        }

    }

    // put hit on cooldown
    private void hitCooldown() {
        animator.SetBool("isHit", false);
    }

}
