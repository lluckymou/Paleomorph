using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T:UnityEngine.Object
{
    private static T _instance;
    public static T instance
    {
        get => _instance;
    }

    void Awake()
    {
        if (_instance) Destroy(gameObject);
        else
        {
            _instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
    }
}