﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public abstract class TextStyle {
	public abstract int Size { get; }
	public abstract TextAnchor Anchor { get; }
	public abstract Color Color { get; }
	public virtual FontStyle FontStyle { 
		get { return FontStyle.Normal; }
	}
}

public class DefaultTextStyle : TextStyle {
	public override int Size {
		get { return 36; }
	}
	public override TextAnchor Anchor {
		get { return TextAnchor.UpperLeft; }
	}
	public override Color Color {
		get { return Palette.Grey; }
	}
}

public class DefaultCenterTextStyle : TextStyle {
	public override int Size {
		get { return 36; }
	}
	public override TextAnchor Anchor {
		get { return TextAnchor.UpperCenter; }
	}
	public override Color Color {
		get { return Palette.Grey; }
	}
}

public class AgendaItemTextStyle : TextStyle {
	public override int Size {
		get { return 32; }
	}
	public override TextAnchor Anchor {
		get { return TextAnchor.UpperCenter; }
	}
	public override Color Color {
		get { return Palette.Grey; }
	}
}

public class BonusTextStyle : TextStyle {
	public override int Size {
		get { return 28; }
	}
	public override TextAnchor Anchor {
		get { return TextAnchor.UpperCenter; }
	}
	public override Color Color {
		get { return Palette.Blue; }
	}
}

public class HeaderTextStyle : TextStyle {
	public override int Size {
		get { return 75; }
	}	
	public override TextAnchor Anchor {
		get { return TextAnchor.UpperLeft; }
	}
	public override Color Color {
		get { return Palette.Grey; }
	}
}

public class WhiteTextStyle : TextStyle {
	public override int Size {
		get { return 36; }
	}
	public override TextAnchor Anchor {
		get { return TextAnchor.UpperCenter; }
	}
	public override Color Color {
		get { return Palette.White; }
	}
}

public class WhiteTextLeftStyle : TextStyle {
	public override int Size {
		get { return 36; }
	}
	public override TextAnchor Anchor {
		get { return TextAnchor.UpperLeft; }
	}
	public override Color Color {
		get { return Palette.White; }
	}
}

public class DeciderInstructionsStyle : TextStyle {
	public override int Size {
		get { return 32; }
	}
	public override TextAnchor Anchor {
		get { return TextAnchor.UpperLeft; }
	}
	public override Color Color {
		get { return Palette.Grey; }
	}
	public override FontStyle FontStyle {
		get { return FontStyle.Italic; }
	}
}

public class CenteredWhiteItalicsStyle : TextStyle {
	public override int Size {
		get { return 32; }
	}
	public override TextAnchor Anchor {
		get { return TextAnchor.UpperCenter; }
	}
	public override Color Color {
		get { return Palette.White; }
	}
	public override FontStyle FontStyle {
		get { return FontStyle.Italic; }
	}
}

public class AboutHeaderTextStyle : TextStyle {
	public override int Size {
		get { return 75; }
	}	
	public override TextAnchor Anchor {
		get { return TextAnchor.UpperLeft; }
	}
	public override Color Color {
		get { return Palette.Blue; }
	}
}