using UnityEngine;

public class TankController
{
   private TankModel tankModel;
   private TankView tankView;  // these are empty referenes here

   private Rigidbody rb; // reference of rigid body

   // Adding constructor to the class
   // using below constructor to set up the empty references above

   // Below is class constructor TankController
   public TankController(TankModel _tankModel, TankView _tankView) {
    tankModel = _tankModel;
    tankView = GameObject.Instantiate<TankView>(_tankView); 
    rb = tankView.GetRigidBody(); 
    // the references have been assigned (not empty anymore)

    tankModel.SetTankController(this);
    tankView.SetTankController(this); // this => reference of current script (TankController)

    tankView.changeColor(tankModel.color);

   }

   public void Move(float movement, float movementSpeed)
   {
      rb.velocity = tankView.transform.forward * movement * movementSpeed;
   }

   public void Rotate(float rotate, float rotationSpeed)
   {
      Vector3 vector = new Vector3(0f, rotate * rotationSpeed, 0f);
      Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
      rb.MoveRotation(rb.rotation * deltaRotation);
   }

   public TankModel GetTankModel()
   {
      return tankModel;
   }
}
