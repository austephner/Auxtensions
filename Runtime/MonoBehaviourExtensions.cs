using System;
using System.Collections;
using UnityEngine;

namespace Auxtensions
{
    public static class MonoBehaviourExtensions
    {
        public static void InvokeWhenTrue<T>(this T monoBehaviour, Func<bool> condition, Action action) where T : MonoBehaviour
        {
            monoBehaviour.StartCoroutine(InvokeWhenTrue(condition, action));
        }

        private static IEnumerator InvokeWhenTrue(Func<bool> condition, Action action)
        {
            while (condition?.Invoke() == true) yield return new WaitForEndOfFrame();
            action?.Invoke();
        }

        public static void InvokeNextFrame<T>(this T monoBehaviour, Action action) where T : MonoBehaviour
        {
            monoBehaviour.StartCoroutine(InvokeNextFrame(action));
        }

        private static IEnumerator InvokeNextFrame(Action action)
        {
            yield return new WaitForEndOfFrame();
            action?.Invoke();
        }
    }
}