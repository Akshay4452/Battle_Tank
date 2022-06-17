using UnityEngine;

public class TankModel
{
    public float translateSpeed;
    public float rotationSpeed;
    public TankTypes tankType;
    public Material color;
    private TankController tankController;

    public TankModel(float _translate, float _rotation, TankTypes tank, Material _color)
    {
        translateSpeed = _translate;
        rotationSpeed = _rotation;
        tankType = tank;
        color = _color;
    }

    public void SetTankController(TankController _tankController)
    {
        // model and controller are connected
        tankController = _tankController;
    }
}

