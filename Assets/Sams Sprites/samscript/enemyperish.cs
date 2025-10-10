
using UnityEngine;

public class enemyperish : MonoBehaviour
{
    private Animator animator;



    void Start()
    {
        animator = GetComponent<Animator>();

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player Bullet"))
        {
            animator.SetTrigger("perish");

            Destroy(gameObject, 1);
        }
    }

} // end of class
