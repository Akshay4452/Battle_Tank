using UnityEngine;

public class TankModel
{
    public float translateSpeed;
    public float rotationSpeed;
    private TankController tankController;

    public TankModel(float _translate, float _rotation)
    {
        translateSpeed = _translate;
        rotationSpeed = _rotation;
    }

    public void SetTankController(TankController _tankController)
    {
        // model and controller are connected
        tankController = _tankController;
    }
}

