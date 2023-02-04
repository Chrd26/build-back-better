using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RootsLevel : MonoBehaviour
{
    private TMP_Text setText;
    // Start is called before the first frame update
    void Start()
    {
        setText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        setText.text = Manager.ManagerInstance.rootsUpgrade.ToString();
    }
}
