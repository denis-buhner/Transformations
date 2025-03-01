using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _grownSpeed = .5f;

    void Update()
    {
        transform.localScale = transform.localScale + Vector3.one * _grownSpeed * Time.deltaTime;
    }
}
