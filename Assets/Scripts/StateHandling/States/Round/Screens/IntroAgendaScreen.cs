﻿using UnityEngine;
using System.Collections;

public class IntroAgendaScreen : IntroductionScreen {

	public IntroAgendaScreen (GameState state, string name = "Agenda") : base (state, name) {
		ScreenElements.AddEnabled ("background", new BackgroundElement ("review", Color.black));
		ScreenElements.AddDisabled ("description", new LabelElement (Copy.IntroAgenda, 0, new DefaultCenterTextStyle ()));
	}

	protected override void OnScreenStartDecider () {
		ScreenElements.SuspendUpdating ();
		ScreenElements.DisableAll ();
		ScreenElements.Enable ("background");
		ScreenElements.Enable ("description");
		ScreenElements.Enable ("next");
		ScreenElements.EnableUpdating ();
	}

	protected override void SetBackEnabled () {}

	void CreateAgenda () {
		ScreenElements.DisableAll ();
		Player player = Player.instance;
		Role playerRole = player.MyRole;
		CreateAgenda (playerRole.MyAgenda.items);
		ScreenElements.Enable ("next");
	}

	protected override void OnUpdateRoleEvent (UpdateRoleEvent e) {
		if (!Player.instance.IsDecider) {
			CreateAgenda ();
		}
	}
}
