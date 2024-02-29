using UnityEngine;

public class TurbineRotater : MonoBehaviour
{
    public Vector3 RotationVector;

    void Update()
    {
        transform.Rotate(RotationVector * Time.deltaTime);
    }
}
