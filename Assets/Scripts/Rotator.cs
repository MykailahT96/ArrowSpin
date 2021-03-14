using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float spinSpeed = 100f;

    void Update()
    {
        transform.Rotate(0f, 0f, -(spinSpeed * Time.deltaTime));
    }

    /* public void AdjustRotationSpeed(float newRotateSpeed)
    {
        spinSpeed = newRotateSpeed;
    }
    */
}
