﻿using UnityEngine;
using System.Collections;

public class NameTakenScreen : GameScreen {

	TextFieldElement textField;

	public NameTakenScreen (GameState state, string name="Name Taken") : base (state, name) {
		Events.instance.AddListener<NameTakenEvent> (OnNameTakenEvent);
		textField = new TextFieldElement (1);
		ScreenElements.AddEnabled ("copy", new LabelElement ("", 0));
		ScreenElements.AddEnabled ("textfield", textField);
		ScreenElements.AddEnabled ("enter", CreateButton ("Enter", 2));
		ScreenElements.AddEnabled ("back", CreateBottomButton ("Back"));
	}

	public override void OnScreenStart (bool hosting, bool isDecider) {
		base.OnScreenStart (hosting, isDecider);
		Events.instance.AddListener<RegisterEvent> (OnRegisterEvent);
	}

	public override void OnScreenEnd () {
		base.OnScreenEnd ();
		Events.instance.RemoveListener<RegisterEvent> (OnRegisterEvent);
	}

	void OnRegisterEvent (RegisterEvent e) {
		GotoScreen ("Lobby");
	}

	void OnNameTakenEvent (NameTakenEvent e) {
		string nameTaken = string.Format ("There's already someone named {0} in this game. Please enter a new name:", e.name);
		ScreenElements.Get<LabelElement> ("copy").Content = nameTaken;
		ScreenElements.EnableUpdating ();
	}

	protected override void OnButtonPress (ButtonPressEvent e) {
		switch (e.id) {
			case "Enter": 
				TextFieldElement tfe = ScreenElements.Get<TextFieldElement> ("textfield");
				if (tfe.content != "") {
					Events.instance.Raise (new EnterNameEvent (tfe.content));
					MultiplayerManager2.instance.NewNameEntered ();
				}
				break;
			case "Back": 
				MultiplayerManager2.instance.Disconnect ();
				GotoScreen ("Games List"); 
				break;
		}
	}
}
