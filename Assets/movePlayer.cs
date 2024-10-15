using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    
public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator = GetComponent<Animator>();
        
         float move = Input.GetAxis("Horizontal") * 15 * Time.deltaTime;

        transform.Translate(move, 0f, 0f);

        Vector3 characterScale = transform.localScale;

        if (move < 0) // Moving left
        {
            characterScale.x = Mathf.Abs(characterScale.x) * -1;
            animator.Play("walking");
            animator.speed = 1;
        }
        else if (move > 0) // Moving right
        {
            characterScale.x = Mathf.Abs(characterScale.x); 
            animator.Play("walking");
            animator.speed = 1; // Play animation at normal speed
        }
        else // No movement
        {
            animator.Play("walking", 0, 0f); // Reset to the first frame
            animator.speed = 0; // Freeze the animation
        }

    
        transform.localScale = characterScale;
    }
}
