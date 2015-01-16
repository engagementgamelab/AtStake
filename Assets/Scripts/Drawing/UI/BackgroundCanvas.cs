﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BackgroundCanvas : MonoBehaviour {

	public Image topBar;
	public Image bottomBar;
	public Image background;

	void Awake () {
		SetTheme (new MultiplayerTheme ());
		Events.instance.AddListener<ChangeScreenEvent> (OnChangeScreenEvent);
	}

	public void SetTheme (BackgroundCanvasTheme theme) {
		topBar.color = theme.TopBar;
		bottomBar.color = theme.BottomBar;
		background.color = theme.Background;
	}

	void OnChangeScreenEvent (ChangeScreenEvent e) {
		string name = e.screen.name;
		if (name == "Lobby") {
			SetTheme (new LobbyTheme ());
		}
		if (name == "Start" || name == "Host or Join") {
			SetTheme (new MultiplayerTheme ());
		}
		if (name == "Role") {
			SetTheme (new RoleTheme ());
		}
	}
}

public abstract class BackgroundCanvasTheme {
	public abstract Color TopBar { get; }
	public abstract Color BottomBar { get; }
	public abstract Color Background { get; }
}

public class DefaultTheme : BackgroundCanvasTheme {

	public override Color TopBar {
		get { return Palette.White; }
	}

	public override Color BottomBar {
		get { return Palette.White; }
	}

	public override Color Background {
		get { return Palette.White; }
	}
}

public class MultiplayerTheme : BackgroundCanvasTheme {

	public override Color TopBar {
		get { return Palette.Orange; }
	}

	public override Color BottomBar {
		get { return Palette.Orange; }
	}

	public override Color Background {
		get { return Palette.White; }
	}
}

public class IntroductionTheme : BackgroundCanvasTheme {

	public override Color TopBar {
		get { return Palette.Blue; }
	}

	public override Color BottomBar {
		get { return Palette.Blue; }
	}

	public override Color Background {
		get { return Palette.LtBlue; }
	}
}

public class WinTheme : BackgroundCanvasTheme {

	public override Color TopBar {
		get { return Palette.Teal; }
	}

	public override Color BottomBar {
		get { return Palette.Teal; }
	}

	public override Color Background {
		get { return Palette.LtTeal; }
	}
}

public class PitchTheme : BackgroundCanvasTheme {

	public override Color TopBar {
		get { return Palette.LtOrange; }
	}

	public override Color BottomBar {
		get { return Palette.LtPink; }
	}

	public override Color Background {
		get { return Palette.White; }
	}
}

public class DecideTheme : BackgroundCanvasTheme {

	public override Color TopBar {
		get { return Palette.LtPink; }
	}

	public override Color BottomBar {
		get { return Palette.White; }
	}

	public override Color Background {
		get { return Palette.White; }
	}
}

public class ScoreboardTheme : BackgroundCanvasTheme {

	public override Color TopBar {
		get { return Palette.Blue; }
	}

	public override Color BottomBar {
		get { return Palette.Blue; }
	}

	public override Color Background {
		get { return Palette.White; }
	}
}

public class RoleTheme : BackgroundCanvasTheme {

	public override Color TopBar {
		get { return Palette.Teal; }
	}

	public override Color BottomBar {
		get { return Palette.Teal; }
	}

	public override Color Background {
		get { return Palette.White; }
	}
}

public class LobbyTheme : BackgroundCanvasTheme {

	public override Color TopBar {
		get { return Palette.Blue; }
	}

	public override Color BottomBar {
		get { return Palette.Blue; }
	}

	public override Color Background {
		get { return Palette.LtBlue; }
	}
}