using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuController : MonoBehaviour
{
    public void loadGameplay()
    {
        string selectedCharacter = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(selectedCharacter);
        GameManager.instance.playerName = selectedCharacter;

        SceneManager.LoadScene("gameplay");

    }
}
