using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField][Range(-50, 50)] private float _rotationSpeed = 2;

    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, _rotationSpeed * Time.deltaTime);
    }
}
