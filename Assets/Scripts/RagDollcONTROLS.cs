using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagDollcONTROLS : MonoBehaviour
{
    [SerializeField] Collider mycollider;

    Rigidbody[] rigidbodies;

    bool isRagdoll = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodies = GetComponentsInChildren<Rigidbody>();
        ToggleRagdoll(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ToggleRagdoll(bool ragDollActive)
    {
        isRagdoll = !ragDollActive;

        mycollider.enabled = isRagdoll;

        foreach (Rigidbody ragdollBone in rigidbodies)
      
        {
        ragdollBone.isKinematic = isRagdoll;
        }

        }
   }