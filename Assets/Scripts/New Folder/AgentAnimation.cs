using JetBrains.Annotations;
using UnityEngine;

public class AgentAnimation : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] string movementSpeed = "MovementSpeed";
    // Start is called once before the first execution of" Update after the MonoBehaviour is created

      public void  SetSpeed(float speed) 
      {
        animator.SetFloat(movementSpeed, speed);
      }
    


}
