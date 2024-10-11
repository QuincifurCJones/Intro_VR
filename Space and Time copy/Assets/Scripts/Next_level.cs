using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_level : MonoBehaviour
{
    void Start()
    {
        Debug.Log(GameObject.FindGameObjectsWithTag("Enemy").Length);
    }
    // Update is called once per frame
    void Update()
    {
        //GameObject.FindGameObjectsWithTag("Opponent").Length == 0
        //Debug.Log(GameObject.FindGameObjectsWithTag("Enemy").Length);
        if(GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            load_next_level();
        }
        
    }

    void load_next_level()
    {
        //Debug.Log("MOVE TO NEXT SCENE");
        string currentSceneName = SceneManager.GetActiveScene().name;
        //SceneManager.LoadScene(currentSceneName);
        int num = SceneManager.GetActiveScene().buildIndex;
        num++;
        SceneManager.LoadScene(num);
    }
}
