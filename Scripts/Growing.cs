using UnityEngine;

public class Growing : MonoBehaviour
{
    [SerializeField] private float _minGrowingSpeed;
    [SerializeField] private float _maxGrowingSpeed;

    [SerializeField] private float _currentGrowingSpeed;

    private void OnValidate()
    {
        _currentGrowingSpeed = Mathf.Clamp(_currentGrowingSpeed, _minGrowingSpeed, _maxGrowingSpeed);
    }

    private void Update()
    {
        Grow();
    }

    private void Grow()
    {
        transform.localScale += new Vector3(_currentGrowingSpeed, _currentGrowingSpeed, _currentGrowingSpeed) * Time.deltaTime;
    }
}