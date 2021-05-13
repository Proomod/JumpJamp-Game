using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayUIController : MonoBehaviour
{

    public void uiNavigator()
    {
        string selectedCharacter = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        if (selectedCharacter == "Restart")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);


        }
        else if (selectedCharacter == "Home")
        {
            SceneManager.LoadScene("MainMenu");

        }

    }
    // Start is called before the first frame update

}
