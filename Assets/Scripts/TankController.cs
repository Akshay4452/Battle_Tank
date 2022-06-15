using UnityEngine;

public class TankController
{
   private TankModel tankModel;
   private TankView tankView;

   // Adding constructor to the class
   // using below constructor to set up the empty references above
   public TankController(TankModel _tankModel, TankView _tankView) {
    tankModel = _tankModel;
    tankView = _tankView;
    tankModel.SetTankController(this);
    tankView.SetTankController(this); // this => reference of current script (TankController)

    GameObject.Instantiate(tankView);
   }
}
