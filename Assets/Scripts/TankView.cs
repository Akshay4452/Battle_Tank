using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    private float movement;
    private float rotation;

    public Rigidbody rb; // 
    // instantiate here as rigidbody is attached to the prefab and prefab is attached to TankView script

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetTankController(TankController _tankController)
    {
        // view and controller are connected
        tankController = _tankController;
    }

    private void Movement()
    {
        float movement = Input.GetAxis("Vertical");
        float rotation = Input.GetAxis("Horizontal");
    }

    public Rigidbody GetRigidBody()
    {
        return rb;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if(movement != 0)
        {
            tankController.Move(movement, 30); // Hardcoding movement speed as of now
        }

    }
}
