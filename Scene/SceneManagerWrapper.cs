using UnityEngine.SceneManagement;
using System.Collections;
using System;

public static class SceneManagerWrapper {

	public static string LoadingSceneName = Keywords.LodingSceneName;
	public static string MainSceneName = Keywords.MainMenuSceneName;

	private static string m_OnLoadingSceneName;

    public static string OnLoadingSceneName
    {
        get { return m_OnLoadingSceneName; }
    }

    public static void LoadWithLoadingScene(string sceneName)
    {
		m_OnLoadingSceneName = sceneName;
        SceneManager.LoadSceneAsync(LoadingSceneName);
    }

    public static void LoadMainMenu()
    {
        SceneManager.LoadScene(MainSceneName);
    }

}
