using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    GameObject carPrefab;
    public GameObject[] carPrefabs = new GameObject[3];

    void Start()
    {
        SaveManager.instance.carSelected = carPrefabs[1];
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void RedSelect()
    {
        carPrefab = carPrefabs[0];
        SaveManager.instance.carSelected = carPrefab;
        Debug.Log("Red car was selected");
    }

    public void BlueSelect()
    {
        carPrefab = carPrefabs[1];
        SaveManager.instance.carSelected = carPrefab;
        Debug.Log("Blue car was selected");
    }

    public void GreenSelect()
    {
        carPrefab = carPrefabs[2];
        SaveManager.instance.carSelected = carPrefab;
        Debug.Log("Green truck was selected");
    }
    
}
