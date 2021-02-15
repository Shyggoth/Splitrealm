using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour
{
	public Action<Vector3Int> OnMouseClick, OnMouseHold;
	public Action OnMouseUp;
	public LayerMask groundMask;
	Vector2 _cameraMovementVector;
	[SerializeField]
	Camera _mainCamera;

	public Vector2 CameraMovementVector
	{
		get { return _cameraMovementVector; }
	}

	void Update()
	{
		CheckClickDownEvent();
		CheckClickUpEvent();
		CheckClickHoldEvent();
		CheckArrowInput();
	}

	Vector3Int? RaycastGround()
	{
		RaycastHit hit;
		Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);

		if(Physics.Raycast(ray, out hit, Mathf.Infinity, groundMask))
		{
			Vector3Int positionInt = Vector3Int.RoundToInt(hit.point);
			return positionInt;
		}

		return null;
	}

	void CheckArrowInput()
	{
		_cameraMovementVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
	}

	void CheckClickHoldEvent()
	{
		if(Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject())
		{
			var position = RaycastGround();

			if(position != null)
				OnMouseHold?.Invoke(position.Value);
		}
	}

	void CheckClickDownEvent()
	{
		if(Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
		{
			var position = RaycastGround();

			if(position != null)
				OnMouseClick?.Invoke(position.Value);
		}
	}

	void CheckClickUpEvent()
	{
		if(Input.GetMouseButtonUp(0) && !EventSystem.current.IsPointerOverGameObject())
			OnMouseUp?.Invoke();
	}
}
