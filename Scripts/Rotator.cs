using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _minSpeedRotation;
    [SerializeField] private float _maxSpeedRotation;

    [SerializeField] private float _currentSpeedRotating;

    private void OnValidate()
    {
        UserUtilits.Validate(ref _currentSpeedRotating, _minSpeedRotation, _maxSpeedRotation);
    }

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.RotateAround(transform.position, transform.up, _currentSpeedRotating * Time.deltaTime);
    }
}