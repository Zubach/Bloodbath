using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    

    private Animator anim;

    bool isFacingRight = true;
    void Start()
    {
        this.anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) {

            if (!isFacingRight)
            {
                Flip();
            }
            anim.Play("Run");
            this.gameObject.transform.localPosition = 
                new Vector3(this.gameObject.transform.localPosition.x + 0.2f, this.gameObject.transform.localPosition.y, this.gameObject.transform.localPosition.z);       
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (isFacingRight)
            {
                Flip();
            }
            anim.Play("Run");
            this.gameObject.transform.localPosition =
                new Vector3(this.gameObject.transform.localPosition.x - 0.2f, this.gameObject.transform.localPosition.y, this.gameObject.transform.localPosition.z);
        }
        else if (Input.GetKey(KeyCode.B))
        {
           
                anim.Play("Attack");
                       
                this.gameObject.transform.localPosition =
                new Vector3(this.gameObject.transform.localPosition.x + ((isFacingRight) ? 0.2f : -0.2f), this.gameObject.transform.localPosition.y, this.gameObject.transform.localPosition.z);
            
        }
        else
        {
            
            anim.Play("Rest");
        }
        
    }

    private void Flip()
    {
       
        isFacingRight = !isFacingRight;
        
        Vector3 theScale = transform.localScale;
        
        theScale.x *= -1;
        
        transform.localScale = theScale;
    }
}
