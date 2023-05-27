using System.Collections;
using UnityEngine;

namespace ItemGenerator.System
{
    public interface ICoroutineRunner
    {
        Coroutine StartCoroutine(IEnumerator coroutine);
    }
}

