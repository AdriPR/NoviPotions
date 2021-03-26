using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : StateMachineBehaviour
{

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("mezcla", false);
        animator.SetBool("goodPotion", false);
        animator.SetBool("botones", true);
        animator.SetBool("desactivarBotones", false);
        animator.SetBool("nuevaPeticion", true);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("botones", false);

    }

}
