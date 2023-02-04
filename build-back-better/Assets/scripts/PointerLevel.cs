using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointerLevel : MonoBehaviour
{
    private TMP_Text setText;

    private void Awake()
    {
        setText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        setText.text = Manager.ManagerInstance.pointerUpgrade.ToString();
    }
}

