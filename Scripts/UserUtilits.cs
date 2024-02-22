using UnityEngine;

public static class UserUtilits
{
    public static void Validate(ref float currentValue, float minValue, float maxValue)
    {
        currentValue = Mathf.Clamp(currentValue, minValue, maxValue);
    }
}