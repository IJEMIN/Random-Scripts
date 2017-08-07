using UnityEngine;
using UnityEngine.UI;

using System.Collections;
using UnityEngine.SceneManagement;
public class LoadingScene : MonoBehaviour {


	public Slider loadingSlider;

	private AsyncOperation loadingOperation;

	// Use this for initialization
	void Start () {
		loadingOperation = SceneManager.LoadSceneAsync(SceneManagerWrapper.OnLoadingSceneName);
	}

	void Update()
	{
		if (loadingOperation == null || loadingOperation.isDone)
		{
			loadingSlider.value = 100;
			return;
		}
		else
		{
			loadingSlider.value = loadingOperation.progress * 100;
		}
	}
	
}
