using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoAcierto : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        var aSources = animator.GetComponents<AudioSource>();
        AudioSource success = aSources[0];
        success.Play();
    }

}
