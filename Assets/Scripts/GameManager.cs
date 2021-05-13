using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject player;
    public static GameManager instance;
    private string _playerName;

    public string playerName
    {

        get { return _playerName; }

        set { _playerName = value; }

    }



    private void Awake()
    {
        //when we are awake we must check if the gameobject exists and do as we wish 

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }

    }
    private void OnEnable()
    {
        SceneManager.sceneLoaded += onLevelFinishedLoading;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= onLevelFinishedLoading;
    }
    void onLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "gameplay")
        {
            Instantiate(player);
        }


    }

}
