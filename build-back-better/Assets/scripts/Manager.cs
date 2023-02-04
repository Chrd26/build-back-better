using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    //Manager Instance
    public static Manager ManagerInstance;

    //Declare Gameplay Variables
    public float nutrients = 0.0f, workersGather = 0.01f, pointerGather = 1.0f;
    public int workers = 0, workersUpgrade = 0, pointerUpgrade = 0, rootsUpgrade = 0, workerNutrients = 100, pointerNeutrients = 100, rootsNeutrients = 1000;

    //Declare sound effect Variables
    public AudioSource upgradeSoundWorkers, upgradeSoundPointer, upgradeSoundRoots, clickSound;

    //Music
    public AudioSource music;

    // Start is called before the first frame update
    void Start()
    {
        if (ManagerInstance == null)
        {
            ManagerInstance = this;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        WorkerNutrientsManager();

        if (rootsUpgrade == 10)
        {
            SceneManager.LoadScene("End Screen", LoadSceneMode.Single);
        }
    }

    public void WorkerNutrientsManager()
    {
        if (workersUpgrade > 0)
        {
            nutrients += workersGather + workers;
        }
        else
        {
            nutrients += workersGather;
        }

    }

    //Game Manager Functions

    public void PointerNutrientsManager()
    {
        if (pointerUpgrade > 0)
        {
            nutrients += pointerGather + pointerUpgrade;
        }
        else
        {
            nutrients += pointerGather;
        }

    }

    public void WorkerUpgradeLevel()
    {
        if (nutrients >= workerNutrients)
        {
            workersUpgrade++;
            workersGather += workersGather;
            workerNutrients *= 2;
            nutrients = 0.0f;
        }
    }

    public void PointerUpgradeLevel()
    {
        if (nutrients >= pointerNeutrients)
        {
            pointerUpgrade++;
            pointerGather += 0.1f;
            pointerNeutrients *= 2;
            nutrients = 0.0f;
        }
    }

    public void RootsUpgradeLevel()
    {
        if (nutrients >= rootsNeutrients)
        {
            rootsUpgrade++;
            rootsNeutrients *= 2;
            nutrients = 0.0f;
        }
    }
}
