using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class SelectorWithSwipe : SwipeReceiver {

	public Selectable firstSelectedButton;
	// Update is called once per frame

	private Selectable m_currentSelectable;

	private void Start()
	{
		m_currentSelectable = firstSelectedButton;

		m_currentSelectable.Select();
	}

	protected override void OnSwipeUp()
	{
		base.OnSwipeUp();

		var tmp = m_currentSelectable.FindSelectableOnUp();

		m_currentSelectable = tmp ? tmp : m_currentSelectable;

		m_currentSelectable.Select();
	}

	protected override void OnSwipeDown()
	{
		base.OnSwipeDown();

		var tmp = m_currentSelectable.FindSelectableOnDown();

		m_currentSelectable = tmp ? tmp : m_currentSelectable;

		m_currentSelectable.Select();
	}

	protected override void OnDoubleTap()
	{
		base.OnDoubleTap();

		m_currentSelectable.GetComponent<Button>().onClick.Invoke();
	}

}
