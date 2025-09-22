using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] PlayerInput input;
    [SerializeField] Agentmovet movement;
 [SerializeField] AgentAnimation agentAnimation;
    void Start()
    {
        input.OnMouseClick += movement.SetDestination;
        movement.OnSpeedChange += agentAnimation.SetSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
