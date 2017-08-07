using UnityEngine;
using System.Collections;
using System;


/*
    UI window control themself.

	Use subclass sandbox pattern

*/
public abstract class UI_Screen : MonoBehaviour {


	protected LevelInfo m_levelInfo;


	public bool hideOnStart;

	public RectTransform uiFrameRoot;

	protected virtual void Awake()
	{
		if (uiFrameRoot.gameObject == this.gameObject)
		{
			DestroyImmediate(this);
			throw new Exception("Please, Fuxxing please don't asign self to \"Frame\" Root!!!");
		}


		m_levelInfo = LevelInfo.GetCurrentSceneInstance();

		if (hideOnStart && uiFrameRoot.gameObject.activeSelf)
		{
			uiFrameRoot.gameObject.SetActive(false);
		}

	}

	protected virtual void Start()
	{

	}


	public virtual void ActiveScreen()
	{
		uiFrameRoot.gameObject.SetActive(true);
        OnScreenActive();
	}

	public virtual void DeactiveScreen()
	{
		uiFrameRoot.gameObject.SetActive(false);
		OnScreenDeactive();
	}

	/// <summary>
	/// This should be overriden
	/// </param>
	protected virtual void OnScreenActive()
	{

	}

	/// <summary>
	/// This should be overriden
	/// </param>
	protected virtual void OnScreenDeactive()
	{

	}

	public virtual void LoadMainMenu()
	{
		SceneManagerWrapper.LoadMainMenu();
	}

}
