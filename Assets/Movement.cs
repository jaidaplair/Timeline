using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    //public string animationName = "run"; // Set this in the Inspector

    public void PlayAnimation()
    {
        animator.SetBool("run", true);
            //Play(animationName);
    }


}

