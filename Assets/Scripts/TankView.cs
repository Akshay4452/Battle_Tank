using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    private float translate;
    private float rotation;
    public Rigidbody rb; // 
    // instantiate here as rigidbody is attached to the prefab and prefab is attached to TankView script

    public MeshRenderer[] childs; // array of mesh renderers

    // Start is called before the first frame update
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform); // tankview's transform will be the camera's transform
        cam.transform.position = new Vector3(0f, 3f, -4f);
    }

    public void SetTankController(TankController _tankController)
    {
        // view and controller are connected
        tankController = _tankController;
    }

    public void Movement()
    {
        // this function will get the input and rotation data as per user input
        translate = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    public Rigidbody GetRigidBody()
    {
        return rb;
    }

    public void changeColor(Material color)
    {   
        for(int i=0; i<childs.Length; i++)
        {
            childs[i].material = color;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if(translate != 0)
        {
            tankController.Move(translate, tankController.GetTankModel().translateSpeed); 
        }
            

        if(rotation != 0)
            tankController.Rotate(rotation, tankController.GetTankModel().rotationSpeed);
    }
}
