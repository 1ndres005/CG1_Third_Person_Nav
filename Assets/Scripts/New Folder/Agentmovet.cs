using UnityEngine;
using UnityEngine.AI;
using System;
using Unity.VisualScripting;
public class Agentmovet : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    public event Action<float> OnSpeedChange;
    void Update()
    {
        OnSpeedChange?.Invoke(Mathf.Clamp01(agent.velocity.magnitude / agent.speed));
    }
    public void SetDestination(Vector3 destination)

    { 
        agent.SetDestination (destination);
    }
}
