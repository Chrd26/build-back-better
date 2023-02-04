using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TreeManager : MonoBehaviour
{
    public Sprite[] treeSprites;
    private Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (Manager.ManagerInstance.rootsUpgrade)
        {
            case 0:
                image.sprite = treeSprites[0];
                break;

            case 1:
                image.sprite = treeSprites[1];
                break;

            case 2:
                image.sprite = treeSprites[2];
                break;

            case 3:
                image.sprite = treeSprites[3];
                break;

            case 4:
                image.sprite = treeSprites[4];
                break;

            case 5:
                image.sprite = treeSprites[5];
                break;

            case 6:
                image.sprite = treeSprites[6];
                break;

            case 7:
                image.sprite = treeSprites[7];
                break;

            case 8:
                image.sprite = treeSprites[8];
                break;

            case 9:
                image.sprite = treeSprites[9];
                break;

            case 10:
                image.sprite = treeSprites[10];
                break;
        }
    }
}
