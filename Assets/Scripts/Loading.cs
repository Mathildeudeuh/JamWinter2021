using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Loading : MonoBehaviour
{
    [SerializeField] private string SceneName;
    [SerializeField] private GameObject sceneToLoad;
    //[SerializeField] private GameObject CanvasMenu;

    public void LoadSceneAsync()
    {
        StartCoroutine(LoadScreenCoroutine());
    }

    IEnumerator LoadScreenCoroutine()
    {
        var ecran = Instantiate(sceneToLoad);
        //CanvasMenu.SetActive(false);
        DontDestroyOnLoad(ecran);

        var chargement = SceneManager.LoadSceneAsync(SceneName);
        chargement.allowSceneActivation = false;

        while (chargement.isDone == false)
        {
            if (chargement.progress >= 0.9f)
            {
                chargement.allowSceneActivation = true;
                //ecran.GetComponent<Animator>().SetTrigger("Disparition");
                Destroy(ecran, 0.1f);
            }

            yield return new WaitForSeconds(4);

        }

    }
}
