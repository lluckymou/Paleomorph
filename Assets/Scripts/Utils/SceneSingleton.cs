using UnityEngine;

public abstract class SceneSingleton<T> : MonoBehaviour where T:UnityEngine.Object
{
    static T _instance;
    public static T instance
    {
        get
        {
            if (_instance == null)
            {
                // Debug.Log($"Found new instance for class {typeof(T).Name}");
                _instance = FindObjectOfType<T>();
            }
            return _instance;
        }
    }
}