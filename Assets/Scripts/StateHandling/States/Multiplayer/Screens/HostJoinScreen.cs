﻿using UnityEngine;
using System.Collections;

public class HostJoinScreen : GameScreen {

	LabelElement label;
	string defaultText = "Select host or join";

	public HostJoinScreen (string name = "Host or Join") : base (name) {
		label = new LabelElement (defaultText);
		SetStaticElements (new ScreenElement[] {
			label,
			new ButtonElement ("Host", "Host"),
			new ButtonElement ("Join", "Join"),
			new ButtonElement ("Back-Host-Join", "Back")
		});

		Events.instance.AddListener<JoinTimeoutEvent> (OnJoinTimeoutEvent);
		Events.instance.AddListener<FoundGamesEvent> (OnFoundGamesEvent);
	}

	public override void OnButtonPressEvent (ButtonPressEvent e) {
		switch (e.id) {
			case "Host": 
				MultiplayerManager.instance.HostGame (); 
				GotoScreen ("Lobby");
				break;
			case "Join": 
				MultiplayerManager.instance.JoinGame (); 
				label.content = "searching for games...";
				break;
			case "Back-Host-Join": 
				GotoScreen ("Enter Name"); 
				break;
		}
	}

	void OnJoinTimeoutEvent (JoinTimeoutEvent e) {
		label.content = "no games found :(";
	}

	void OnFoundGamesEvent (FoundGamesEvent e) {
		label.content = "";
		GotoScreen ("Games List");
	}

	public override void OnScreenStart () {
		label.content = defaultText;
	}
}