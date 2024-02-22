using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _duration;

    [SerializeField] private float _minSpeed;
    [SerializeField] private float _maxSpeed;
    [SerializeField] private float _currentSpeed;

    private void OnValidate()
    {
        _currentSpeed = Mathf.Clamp(_currentSpeed, _minSpeed, _maxSpeed);
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(_duration * _currentSpeed * Time.deltaTime, Space.Self);
    }
}