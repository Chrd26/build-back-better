using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    //Manager Instance
    public static Manager ManagerInstance;

    public Object workerObject1;
    public Object workerObject2;

    //Declare Gameplay Variables
    public float nutrients = 0.0f, workersGather = 0.01f, pointerGather = 1.0f;
    public int workers = 0, workersUpgrade = 0, pointerUpgrade = 0, rootsUpgrade = 0, workerNutrients = 100, pointerNeutrients = 100, rootsNeutrients = 500, getRandom = 0;

    //Declare sound effect Variables
    public AudioSource upgradeSoundWorkers, upgradeSoundPointer, upgradeSoundRoots, clickSound;

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
	clickSound.pitch = Random.Range(0.9f, 1.1f);
	clickSound.Play();


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
            nutrients -= workerNutrients;
            workersUpgrade++;
            workersGather += workersGather;
            workerNutrients += 200; 
            upgradeSoundWorkers.pitch = Random.Range(0.9f, 1.1f);
            upgradeSoundWorkers.Play();

            for (int i = 0; i < workersUpgrade * 2; i++)
            {
                getRandom = Random.Range(0, 2);
                Debug.Log(getRandom);

                if (getRandom == 0)
                {
                    Instantiate(workerObject1);
                }
                else
                {
                    Instantiate(workerObject2);
                }
            }
        }
    }

    public void PointerUpgradeLevel()
    {
        if (nutrients >= pointerNeutrients)
        {
            nutrients -= pointerNeutrients;
            pointerUpgrade++;
            pointerGather += 2.0f;
            pointerNeutrients += 200;
            upgradeSoundPointer.pitch = Random.Range(0.9f, 1.1f);
            upgradeSoundPointer.Play();
        }
    }

    public void RootsUpgradeLevel()
    {
        if (nutrients >= rootsNeutrients)
        {
            nutrients -= rootsNeutrients;
            rootsUpgrade++;
            rootsNeutrients += 500;
            upgradeSoundRoots.pitch = Random.Range(0.9f, 1.1f);
            upgradeSoundRoots.Play();
        }
    }
}
