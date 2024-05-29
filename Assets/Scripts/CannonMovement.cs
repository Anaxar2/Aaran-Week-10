using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CannonMovement : MonoBehaviour
{
    private CinemachineDollyCart cart;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        cart = GetComponent<CinemachineDollyCart>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementX = Input.GetAxis("Horizontal");
        cart.m_Position += movementX * speed * Time.deltaTime;
    }
}
