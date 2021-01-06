using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
	// point implies screen space, position implies world space;
	private Vector3 screenPoint, offset, cursorPoint, cursorPosition;
	private Vector3 mousePosition => Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	
	// OnMouseDown is called when the user has pressed the mouse button while over the GUIElement or Collider.
	protected void OnMouseDown()
	{
		screenPoint = Camera.main.WorldToScreenPoint(transform.position);
		//mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		offset = transform.position - mousePosition;
	}

	// OnMouseDrag is called when the user has clicked on a GUIElement or Collider and is still holding down the mouse.
	protected void OnMouseDrag()
	{
		cursorPoint = transform.position = mousePosition + offset;
	}
}
