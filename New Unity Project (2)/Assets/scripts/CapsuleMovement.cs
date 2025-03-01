using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    [SerializeField] private float _grownSpeed = .5f;

    void Update()
    {
        transform.localScale = transform.localScale + Vector3.one * _grownSpeed * Time.deltaTime;
    }
}
