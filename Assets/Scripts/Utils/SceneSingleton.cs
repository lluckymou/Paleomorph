using UnityEngine;

public abstract class SceneSingleton<T> : MonoBehaviour where T:UnityEngine.Object
{
    static T _instance;
    public static T instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<T>();
            return _instance;
        }
    }
}