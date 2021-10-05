using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public SpriteRenderer Bg;

    public void StartBlackout()
    {
        StartCoroutine(Blackout());
    }

    IEnumerator Blackout()
    {

        for (int i = 0; i < 10; i++)
        {
            Bg.color = new Color(Bg.color.r - 0.1f, Bg.color.g - 0.1f, Bg.color.b - 0.1f);
            yield return new WaitForSeconds(0.05f);
        }

        for (int i = 0; i < 10; i++)
        {
            Bg.color = new Color(Bg.color.r + 0.1f, Bg.color.g + 0.1f, Bg.color.b + 0.1f);
            yield return new WaitForSeconds(0.05f);
        }
    }
}
