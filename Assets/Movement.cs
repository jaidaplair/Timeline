using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Animator animator;
    public string animationName = "run"; // Set this in the Inspector

    public void PlayAnimation()
    {
        animator.Play(animationName);
    }


}

