using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worker2spawn : MonoBehaviour
{
    private RectTransform setRect;
    // Start is called before the first frame update
    void Start()
    {
        setRect = GetComponent<RectTransform>();
        setRect.anchoredPosition = new Vector2(Random.Range(-430, 430), Random.Range(-200, 200));
    }

}
