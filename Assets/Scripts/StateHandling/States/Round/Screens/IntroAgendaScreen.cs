﻿using UnityEngine;
using System.Collections;

public class IntroAgendaScreen : IntroductionScreen {

	public IntroAgendaScreen (GameState state, string name = "Agenda") : base (state, name) {
		//description = "Have everyone silently review their secret agenda, then press next.";
		ScreenElements.AddDisabled ("description", new LabelElement ("Have everyone silently review their secret agenda, then press next.", 0));
	}

	protected override void OnScreenStartDecider () {
		ScreenElements.SuspendUpdating ();
		ScreenElements.DisableAll ();
		ScreenElements.Enable ("description");
		ScreenElements.Enable ("next");
		ScreenElements.EnableUpdating ();
	}

	void CreateAgenda () {
		ScreenElements.DisableAll ();
		Player player = Player.instance;
		Role playerRole = player.MyRole;
		//AppendVariableElements (RoleAgendaItems (playerRole.MyAgenda.items));
		CreateAgenda (playerRole.MyAgenda.items);
	}

	protected override void OnUpdateRoleEvent (UpdateRoleEvent e) {
		if (!Player.instance.IsDecider) {
			//ClearScreen ();
			CreateAgenda ();
			/*AppendVariableElements (new ScreenElement[] {
				new BeanPotElement (),
				new BeanPoolElement ()
			});*/
			
		}
	}
}
