using UnityEngine;
using System.Collections.Generic;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable] // to see in Inspector
    public class Tank
    {
        public float translateSpeed;
        public float rotationSpeed;
        public TankTypes tankType;
        public Material color;

    }

    public List<Tank> tankList; // List of Tank Class
    public TankView tankView;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CreateTank(TankTypes tankType)
    {
        if(tankType == TankTypes.GreenTank)
        {
            TankModel tankModel = new TankModel(tankList[0].translateSpeed, tankList[0].rotationSpeed, tankList[0].tankType, tankList[0].color);
            TankController tankController = new TankController(tankModel, tankView);
        }
        else if(tankType == TankTypes.BlueTank)
        {
            TankModel tankModel = new TankModel(tankList[1].translateSpeed, tankList[1].rotationSpeed, tankList[1].tankType, tankList[1].color);
            TankController tankController = new TankController(tankModel, tankView);
        }
        else if(tankType == TankTypes.RedTank)
        {
            TankModel tankModel = new TankModel(tankList[2].translateSpeed, tankList[2].rotationSpeed, tankList[2].tankType, tankList[2].color);
            TankController tankController = new TankController(tankModel, tankView);
        }
        

    }

    
}
