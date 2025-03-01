using System.Collections;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    [SerializeField][Range(2, 4)] private float _speed = 2;

    void Update()
    {
        float offset = transform.position.x + _speed * Time.deltaTime;
        transform.position = new Vector3(offset, 0, 0);
    }
}
