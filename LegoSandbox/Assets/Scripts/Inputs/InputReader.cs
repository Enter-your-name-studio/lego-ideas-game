using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class InputReader {
	public Action<Vector2> onMove;
	public Action onJump;
	public Action<Vector2> onLook;


	public Action onBuild;
	public Action onBroke;


	public void Init() {
		TemplateGameManager.Instance.actions.Player.Move.performed += OnMove;

		TemplateGameManager.Instance.actions.Player.LookMouse.performed += OnLookMouse;
		TemplateGameManager.Instance.actions.Player.LookGamepad.performed += OnLookGamepad;

		TemplateGameManager.Instance.actions.Player.Jump.performed += OnJump;

		TemplateGameManager.Instance.actions.Player.Build.performed += OnBuild;
		TemplateGameManager.Instance.actions.Player.Broke.performed += OnBroke;
	}

	public void UnInit() {
		TemplateGameManager.Instance.actions.Player.Move.performed -= OnMove;

		TemplateGameManager.Instance.actions.Player.LookMouse.performed -= OnLookMouse;
		TemplateGameManager.Instance.actions.Player.LookGamepad.performed -= OnLookGamepad;

		TemplateGameManager.Instance.actions.Player.Jump.performed -= OnJump;

		TemplateGameManager.Instance.actions.Player.Build.performed -= OnBuild;
		TemplateGameManager.Instance.actions.Player.Broke.performed -= OnBroke;
	}

	void OnMove(InputAction.CallbackContext context) {
		if (context.performed) {
			Vector2 value = context.ReadValue<Vector2>();
			onMove?.Invoke(value);
		}
	}

	void OnLookMouse(InputAction.CallbackContext context) {
		if (context.performed) {
			Vector2 value = context.ReadValue<Vector2>();
			onLook?.Invoke(value);
		}
	}
	
	void OnLookGamepad(InputAction.CallbackContext context) {
		if (context.performed) {
			Vector2 value = context.ReadValue<Vector2>();
			onLook?.Invoke(value);
		}
	}

	void OnJump(InputAction.CallbackContext context) {
		if (context.performed) {
			onJump?.Invoke();
		}
	}

	void OnBuild(InputAction.CallbackContext context) {
		if (context.performed) {
			onBuild?.Invoke();
		}
	}

	void OnBroke(InputAction.CallbackContext context) {
		if (context.performed) {
			onBroke?.Invoke();
		}
	}
}
