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
        CreateTank();
    }

    private void CreateTank()
    {
        // By default Green Tank will come
        TankModel tankModel = new TankModel(tankList[0].translateSpeed, tankList[0].rotationSpeed, tankList[0].tankType, tankList[0].color);
        TankController tankController = new TankController(tankModel, tankView);
        // created object of TankController

    }

    
}
