using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField][Range(2, 4)] private float _speed = 2;

    private void Update()
    {
        Vector3 target = transform.position + transform.forward * _speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, _speed * Time.deltaTime);
    }
}
