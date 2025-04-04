using UnityEngine;

public class BunnyMovements : MonoBehaviour
{
    private Animator animator;
    public float moveSpeed = 5f;

    [Header("-- Private references --")]
    [SerializeField] private int coinsCollected = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
 //   void Update()
  //  {
  //      if (Input.GetKey(KeyCode.W)) 
  //      {
  //          animator.SetInteger("Movement",2);
  //      }
  //      else if (Input.GetKey(KeyCode.S)) 
  //      {
  //          animator.SetInteger("Movement",1);
  //      }
  //      else if (Input.GetKey(KeyCode.A)) 
  //      {
  //          animator.SetInteger("Movement",3);
  //      }
  //      else if (Input.GetKey(KeyCode.D)) 
  //      {
  //          animator.SetInteger("Movement",0);
  //      }
  // }
    
     // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 newPosition = transform.position;
            if(Input.GetKey(KeyCode.A)) {
                newPosition.x -= moveSpeed * Time.deltaTime;
                animator.SetInteger("Movement",3);
            }
            if(Input.GetKey(KeyCode.D)) {
                newPosition.x += moveSpeed * Time.deltaTime;
                animator.SetInteger("Movement",0);
            }
            if(Input.GetKey(KeyCode.W)) {
                newPosition.y += moveSpeed * Time.deltaTime;
                animator.SetInteger("Movement",2);
            }
            if(Input.GetKey(KeyCode.S)) {
                newPosition.y -= moveSpeed * Time.deltaTime;
                animator.SetInteger("Movement",1);
            }            
        transform.position = newPosition;
    }

    // OnTriggerEnter2D is called once, when two GameObjects with Collider2Ds hit each other
        // - One GameObject must have a Rigidbody2D as well
        // - One of the Collider2Ds must be a Trigger
    void OnTriggerEnter2D(Collider2D coll) {
        if(coll.gameObject.tag.Equals("Coin")) {
            coinsCollected += 1;
            Destroy(coll.gameObject);
        }
    }

}
