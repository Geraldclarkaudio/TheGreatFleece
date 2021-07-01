using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Loading : MonoBehaviour
{
    //reference to prgress bar
    public Image progressBar;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadMainScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadMainScene()
    {
        //create async op == loadscene ("Main")
        AsyncOperation operation = SceneManager.LoadSceneAsync("Main");
        //while operation isnt finished
        while (!operation.isDone)
        {
            progressBar.fillAmount = operation.progress;
            yield return new WaitForEndOfFrame();
        }

    }
}
