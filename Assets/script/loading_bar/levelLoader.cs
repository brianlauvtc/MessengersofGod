using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour
{
	public GameObject loadingScreen;
	public Image ProcessBar;
	public Text ProcessText;

	public void LoadLevel(string sceneName){
		StartCoroutine(LoadAsynchronously(sceneName));
	}

	IEnumerator LoadAsynchronously(string sceneName){
		AsyncOperation operation = SceneManager.LoadSceneAsync (sceneName);
		loadingScreen.SetActive (true);
		loadingScreen.transform.Find("Text").GetComponent<Text>().text = "Loading Scene...";
        while (!operation.isDone) {
			float progress = Mathf.Clamp01 (operation.progress / .9f);

			ProcessText.text = ""+Mathf.RoundToInt(progress * 100) + " %";
			ProcessBar.fillAmount = progress;
			yield return null;
		}
	}
}
