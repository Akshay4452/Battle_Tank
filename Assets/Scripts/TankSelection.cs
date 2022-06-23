using UnityEngine;
using System.Collections.Generic;

public class TankSelection : MonoBehaviour
{
    public TankSpawner tankSpawner; // creating object for tank spawner
    public void BlueTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.BlueTank);
        this.gameObject.SetActive(false);
    }

    public void GreenTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.GreenTank);
        this.gameObject.SetActive(false);
    }

    public void RedTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.RedTank);
        this.gameObject.SetActive(false);
    }
}
