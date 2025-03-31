using UnityEngine;

public class BunnyMovements : MonoBehaviour
{
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            animator.SetInteger("Movement",2);
        }
        else if (Input.GetKey(KeyCode.S)) 
        {
            animator.SetInteger("Movement",1);
        }
        else if (Input.GetKey(KeyCode.A)) 
        {
            animator.SetInteger("Movement",3);
        }
        else if (Input.GetKey(KeyCode.D)) 
        {
            animator.SetInteger("Movement",0);
        }
    }
}
