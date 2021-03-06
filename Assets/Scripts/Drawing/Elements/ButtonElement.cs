﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonElement : ScreenElement {

	public readonly string id = "";
	public readonly GameScreen screen;
	
	protected string content = "";
	public virtual string Content {
		get { return content.ToLower (); }
		set { 
			content = value.ToLower (); 
			if (middleButton != null) 
				middleButton.text.text = content;
		}
	}

	string color = "";
	public string Color {
		get { return color; }
		set { 
			color = value;
			if (middleButton != null)
				middleButton.SetColor (color);
		}
	}

	protected MiddleButton middleButton;
	public MiddleButton MiddleButton {
		get { return middleButton; }
		set {
			middleButton = value;
			middleButton.text.text = Content;
			middleButton.SetColor (color);
			middleButton.button.interactable = interactable;
		}
	}

	bool interactable = true;
	public bool Interactable {
		get { return interactable; }
		set {
			interactable = value;
			if (middleButton != null)
				MiddleButton.button.interactable = value;
		}
	}

	public ButtonElement (GameScreen screen, string id, string content, int position, string color="blue") {
		this.screen = screen;
		this.id = id;
		this.content = content;
		this.Position = position;
		this.color = color;
		interactable = true;
	}

	void StyleText () {
		/*text.fontSize = style.Size;
		text.alignment = style.Anchor;
		text.color = style.Color;*/
	}
}
