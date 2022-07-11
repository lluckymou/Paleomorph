using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionAnimation : MonoBehaviour
{
    [SerializeField] Vector3[] frames;
    [SerializeField] float time = 0.3f;

    float _time;
    int position = 0;

    void Start() => _time = time;

    void Update()
    {
        if(frames.Length < 1) return;

        if(_time > 0)
        {
            _time -= Time.deltaTime;
            return;
        }

        _time = time;
        position = (position + 1) % frames.Length;

        transform.localPosition = frames[position];
    }
}
