using UnityEngine;

public class CubeDynamicMovement : MonoBehaviour
{
    [SerializeField][Range(-1000, 1000)] private float _rotationSpeed = 2;
    [SerializeField][Range(2, 4)] private float _speed = 2;
    [SerializeField] private float _grownSpeed = .5f;

    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, _rotationSpeed * Time.deltaTime);

        Vector3 target = transform.position + transform.forward *_speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, _speed * Time.deltaTime);

        transform.localScale = transform.localScale + Vector3.one * _grownSpeed * Time.deltaTime;
    }
}
