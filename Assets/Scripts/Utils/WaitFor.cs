using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WaitFor : MonoBehaviour
{
    public static IEnumerator Frames(int frameCount, UnityAction callback)
    {
        frameCount = frameCount <= 0 ? 1 : frameCount;
        
        while (frameCount-- > 0)
            yield return null;

        callback();
    }
}