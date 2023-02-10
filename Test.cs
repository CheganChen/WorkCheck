using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        StartCoroutine(Move(gameObject, transform.position, transform.position + Vector3.one, 2.0f, true));
    }
    private IEnumerator Move(GameObject gameObject, Vector3 begin, Vector3 end, float time, bool pingpong)
    {
        float currentTime = 0;
        bool isRight = true;
        while (true)
        {
            currentTime += Time.deltaTime;
            float t = currentTime / time;
            if (isRight) LerpMove(begin, end, t);
            else LerpMove(end, begin, t);
            if (t >= 1)
            {
                isRight = !isRight;
                currentTime = 0;
                if (!pingpong)
                {
                    break;
                }
            }
            yield return 666;
        }
    }

    private void LerpMove(Vector3 begin, Vector3 end, float percentation)
    {
        gameObject.transform.position = Vector3.Lerp(begin, end, percentation);
    }
}