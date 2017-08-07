using System;
using UnityEngine;

public abstract class SwipeReceiver: MonoBehaviour
{
	//override this
	protected virtual void OnSwipeLeft()
	{
		Debug.Log("Swipe Left");
	}

	//override this
	protected virtual void OnSwipeRight()
	{
		Debug.Log("Swipe Right");
	}

	//override this
	protected virtual void OnSwipeUp()
	{
		Debug.Log("Swipe Up");
	}

	//override this
	protected virtual void OnSwipeDown()
	{
		Debug.Log("Swipe Down");
	}

	protected virtual void OnDoubleTap()
	{
		Debug.Log("Double Tap");
	}

	protected virtual void Update()
	{
		if (SwipeManager.Instance.IsSwiping(SwipeManager.SwipeDirection.Right))
		{
			
			OnSwipeRight();
		}

		if (SwipeManager.Instance.IsSwiping(SwipeManager.SwipeDirection.Left))
		{
			OnSwipeLeft();
		}

		if (SwipeManager.Instance.IsSwiping(SwipeManager.SwipeDirection.Up))
		{
			OnSwipeUp();
		}

		if (SwipeManager.Instance.IsSwiping(SwipeManager.SwipeDirection.Down))
		{
			OnSwipeDown();
		}

		if (SwipeManager.Instance.IsDoubleTap())
		{
			OnDoubleTap();
		}
	}




}

