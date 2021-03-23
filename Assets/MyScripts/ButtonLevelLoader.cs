using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLevelLoader : MonoBehaviour
{
    public string mLevelToLoad;

    public void LoadLevel()
    {
        //load the new level (mLevelToLoad)
        SceneManager.LoadScene(mLevelToLoad);

    }


}
