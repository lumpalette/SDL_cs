namespace SDL3;

// SDL_keycode.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_keycode.h
unsafe partial class SDL
{
	/// <summary>
	/// The SDL virtual key representation.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_Keycode">here</see>.
	/// </remarks>
	public enum Keycode : uint
	{
		Unknown				= 0,
		Return				= '\r',
		Escape				= '\x1B',
		Backspace			= '\b',
		Tab					= '\t',
		Space				= ' ',
		Exclaim				= '!',
		DoubleApostrophe	= '"',
		Hash				= '#',
		Percent				= '%',
		Dollar				= '$',
		Ampersand			= '&',
		Apostrophe			= '\'',
		LParenthesis		= '(',
		RParenthesis		= ')',
		Asterisk			= '*',
		Plus				= '+',
		Comma				= ',',
		Minus				= '-',
		Period				= '.',
		Slash				= '/',
		Row0				= '0',
		Row1				= '1',
		Row2				= '2',
		Row3				= '3',
		Row4				= '4',
		Row5				= '5',
		Row6				= '6',
		Row7				= '7',
		Row8				= '8',
		Row9				= '9',
		Colon				= ':',
		Semicolon			= ';',
		Less				= '<',
		Equals				= '=',
		Greater				= '>',
		Question			= '?',
		At					= '@',
		LBracket			= '[',
		Backslash			= '\\',
		RBracket			= ']',
		Caret				= '^',
		Underscore			= '_',
		Grave				= '`',
		A					= 'a',
		B					= 'b',
		C					= 'c',
		D					= 'd',
		E					= 'e',
		F					= 'f',
		G					= 'g',
		H					= 'h',
		I					= 'i',
		J					= 'j',
		K					= 'k',
		L					= 'l',
		M					= 'm',
		N					= 'n',
		O					= 'o',
		P					= 'p',
		Q					= 'q',
		R					= 'r',
		S					= 's',
		T					= 't',
		U					= 'u',
		V					= 'v',
		W					= 'w',
		X					= 'x',
		Y					= 'y',
		Z					= 'z',
		Capslock			= Scancode.Capslock | SCANCODE_MASK,
		F1					= Scancode.F1 | SCANCODE_MASK,
		F2					= Scancode.F2 | SCANCODE_MASK,
		F3					= Scancode.F3 | SCANCODE_MASK,
		F4					= Scancode.F4 | SCANCODE_MASK,
		F5					= Scancode.F5 | SCANCODE_MASK,
		F6					= Scancode.F6 | SCANCODE_MASK,
		F7					= Scancode.F7 | SCANCODE_MASK,
		F8					= Scancode.F8 | SCANCODE_MASK,
		F9					= Scancode.F9 | SCANCODE_MASK,
		F10					= Scancode.F10 | SCANCODE_MASK,
		F11					= Scancode.F11 | SCANCODE_MASK,
		F12					= Scancode.F12 | SCANCODE_MASK,
		Printscreen			= Scancode.Printscreen | SCANCODE_MASK,
		ScrollLock			= Scancode.ScrollLock | SCANCODE_MASK,
		Pause				= Scancode.Pause | SCANCODE_MASK,
		Insert				= Scancode.Insert | SCANCODE_MASK,
		Home				= Scancode.Home | SCANCODE_MASK,
		PageUp				= Scancode.PageUp | SCANCODE_MASK,
		Delete				= Scancode.Delete | SCANCODE_MASK,
		End					= Scancode.End | SCANCODE_MASK,
		PageDown			= Scancode.PageDown | SCANCODE_MASK,
		RArrow				= Scancode.RArrow | SCANCODE_MASK,
		LArrow				= Scancode.LArrow | SCANCODE_MASK,
		DArrow				= Scancode.DArrow | SCANCODE_MASK,
		UArrow				= Scancode.UArrow | SCANCODE_MASK,
		NumlockClear		= Scancode.NumlockClear | SCANCODE_MASK,
		KpDivide			= Scancode.KpDivide | SCANCODE_MASK,
		KpMultiply			= Scancode.KpMultiply | SCANCODE_MASK,
		KpMinus				= Scancode.KpMinus | SCANCODE_MASK,
		KpPlus				= Scancode.KpPlus | SCANCODE_MASK,
		KpEnter				= Scancode.KpEnter | SCANCODE_MASK,
		Kp1					= Scancode.Kp1 | SCANCODE_MASK,
		Kp2					= Scancode.Kp2 | SCANCODE_MASK,
		Kp3					= Scancode.Kp3 | SCANCODE_MASK,
		Kp4					= Scancode.Kp4 | SCANCODE_MASK,
		Kp5					= Scancode.Kp5 | SCANCODE_MASK,
		Kp6					= Scancode.Kp6 | SCANCODE_MASK,
		Kp7					= Scancode.Kp7 | SCANCODE_MASK,
		Kp8					= Scancode.Kp8 | SCANCODE_MASK,
		Kp9					= Scancode.Kp9 | SCANCODE_MASK,
		Kp0					= Scancode.Kp0 | SCANCODE_MASK,
		KpPeriod			= Scancode.KpPeriod | SCANCODE_MASK,
		Application			= Scancode.Application | SCANCODE_MASK,
		Power				= Scancode.Power | SCANCODE_MASK,
		KpEquals			= Scancode.KpEquals | SCANCODE_MASK,
		F13					= Scancode.F13 | SCANCODE_MASK,
		F14					= Scancode.F14 | SCANCODE_MASK,
		F15					= Scancode.F15 | SCANCODE_MASK,
		F16					= Scancode.F16 | SCANCODE_MASK,
		F17					= Scancode.F17 | SCANCODE_MASK,
		F18					= Scancode.F18 | SCANCODE_MASK,
		F19					= Scancode.F19 | SCANCODE_MASK,
		F20					= Scancode.F20 | SCANCODE_MASK,
		F21					= Scancode.F21 | SCANCODE_MASK,
		F22					= Scancode.F22 | SCANCODE_MASK,
		F23					= Scancode.F23 | SCANCODE_MASK,
		F24					= Scancode.F24 | SCANCODE_MASK,
		Execute				= Scancode.Execute | SCANCODE_MASK,
		Help				= Scancode.Help | SCANCODE_MASK,
		Menu				= Scancode.Menu | SCANCODE_MASK,
		Select				= Scancode.Select | SCANCODE_MASK,
		Stop				= Scancode.Stop | SCANCODE_MASK,
		Again				= Scancode.Again | SCANCODE_MASK,
		Undo				= Scancode.Undo | SCANCODE_MASK,
		Cut					= Scancode.Cut | SCANCODE_MASK,
		Copy				= Scancode.Copy | SCANCODE_MASK,
		Paste				= Scancode.Paste | SCANCODE_MASK,
		Find				= Scancode.Find | SCANCODE_MASK,
		Mute				= Scancode.Mute | SCANCODE_MASK,
		VolumeUp			= Scancode.VolumeUp | SCANCODE_MASK,
		VolumeDown			= Scancode.VolumeDown | SCANCODE_MASK,
		KpComma				= Scancode.KpComma | SCANCODE_MASK,
		KpEqualsAS400		= Scancode.KpEqualsAS400 | SCANCODE_MASK,
		AltErase			= Scancode.AltErase | SCANCODE_MASK,
		SysReq				= Scancode.SysReq | SCANCODE_MASK,
		Cancel				= Scancode.Cancel | SCANCODE_MASK,
		Clear				= Scancode.Clear | SCANCODE_MASK,
		Prior				= Scancode.Prior | SCANCODE_MASK,
		Return2				= Scancode.Return2 | SCANCODE_MASK,
		Separator			= Scancode.Separator | SCANCODE_MASK,
		Out					= Scancode.Out | SCANCODE_MASK,
		Oper				= Scancode.Oper | SCANCODE_MASK,
		ClearAgain			= Scancode.ClearAgain | SCANCODE_MASK,
		Crsel				= Scancode.Crsel | SCANCODE_MASK,
		Exsel				= Scancode.Exsel | SCANCODE_MASK,
		Kp00				= Scancode.Kp00 | SCANCODE_MASK,
		Kp000				= Scancode.Kp000 | SCANCODE_MASK,
		ThousandSeparator	= Scancode.ThousandSeparator | SCANCODE_MASK,
		DecimalSeparator	= Scancode.DecimalSeparator | SCANCODE_MASK,
		CurrencyUnit		= Scancode.CurrencyUnit | SCANCODE_MASK,
		CurrencySubUnit		= Scancode.CurrencySubUnit | SCANCODE_MASK,
		KpLParenthesis		= Scancode.KpLParenthesis | SCANCODE_MASK,
		KpRParenthesis		= Scancode.KpRParenthesis | SCANCODE_MASK,
		KpLBrace			= Scancode.KpLBrace | SCANCODE_MASK,
		KpRBrace			= Scancode.KpRBrace | SCANCODE_MASK,
		KpTab				= Scancode.KpTab | SCANCODE_MASK,
		KpBackspace			= Scancode.KpBackspace | SCANCODE_MASK,
		KpA					= Scancode.KpA | SCANCODE_MASK,
		KpB					= Scancode.KpB | SCANCODE_MASK,
		KpC					= Scancode.KpC | SCANCODE_MASK,
		KpD					= Scancode.KpD | SCANCODE_MASK,
		KpE					= Scancode.KpE | SCANCODE_MASK,
		KpF					= Scancode.KpF | SCANCODE_MASK,
		KpXOR				= Scancode.KpXOR | SCANCODE_MASK,
		KpPower				= Scancode.KpPower | SCANCODE_MASK,
		KpPercent			= Scancode.KpPercent | SCANCODE_MASK,
		KpLess				= Scancode.KpLess | SCANCODE_MASK,
		KpGreater			= Scancode.KpGreater | SCANCODE_MASK,
		KpAmpersand			= Scancode.KpAmpersand | SCANCODE_MASK,
		KpDoubleAmpersand	= Scancode.KpDoubleAmpersand | SCANCODE_MASK,
		KpVerticalBar		= Scancode.KpVerticalBar | SCANCODE_MASK,
		KpDoubleVerticalBar	= Scancode.KpDoubleVerticalBar | SCANCODE_MASK,
		KpColon				= Scancode.KpColon | SCANCODE_MASK,
		KpHash				= Scancode.KpHash | SCANCODE_MASK,
		KpSpace				= Scancode.KpSpace | SCANCODE_MASK,
		KpAt				= Scancode.KpAt | SCANCODE_MASK,
		KpExclaim			= Scancode.KpExclaim | SCANCODE_MASK,
		KpMemStore			= Scancode.KpMemStore | SCANCODE_MASK,
		KpMemRecall			= Scancode.KpMemRecall | SCANCODE_MASK,
		KpMemClear			= Scancode.KpMemClear | SCANCODE_MASK,
		KpMemAdd			= Scancode.KpMemAdd | SCANCODE_MASK,
		KpMemSubtract		= Scancode.KpMemSubtract | SCANCODE_MASK,
		KpMemMultiply		= Scancode.KpMemMultiply | SCANCODE_MASK,
		KpMemDivide			= Scancode.KpMemDivide | SCANCODE_MASK,
		KpPlusMinus			= Scancode.KpPlusMinus | SCANCODE_MASK,
		KpClear				= Scancode.KpClear | SCANCODE_MASK,
		KpClearEntry		= Scancode.KpClearEntry | SCANCODE_MASK,
		KpBinary			= Scancode.KpBinary | SCANCODE_MASK,
		KpOctal				= Scancode.KpOctal | SCANCODE_MASK,
		KpDecimal			= Scancode.KpDecimal | SCANCODE_MASK,
		KpHexadecimal		= Scancode.KpHexadecimal | SCANCODE_MASK,
		LCtrl				= Scancode.LCtrl | SCANCODE_MASK,
		LShift				= Scancode.LShift | SCANCODE_MASK,
		LGUI				= Scancode.LGUI | SCANCODE_MASK,
		RCtrl				= Scancode.RCtrl | SCANCODE_MASK,
		RShift				= Scancode.RShift | SCANCODE_MASK,
		RGUI				= Scancode.RGUI | SCANCODE_MASK,
		Mode				= Scancode.Mode | SCANCODE_MASK,
		AudioNext			= Scancode.AudioNext | SCANCODE_MASK,
		AudioPrev			= Scancode.AudioPrev | SCANCODE_MASK,
		AudioStop			= Scancode.AudioStop | SCANCODE_MASK,
		AudioPlay			= Scancode.AudioPlay | SCANCODE_MASK,
		AudioMute			= Scancode.AudioMute | SCANCODE_MASK,
		MediaSelect			= Scancode.MediaSelect | SCANCODE_MASK,
		WWW					= Scancode.WWW | SCANCODE_MASK,
		Mail				= Scancode.Mail | SCANCODE_MASK,
		Calculator			= Scancode.Calculator | SCANCODE_MASK,
		Computer			= Scancode.Computer | SCANCODE_MASK,
		AcSearch			= Scancode.AcSearch | SCANCODE_MASK,
		AcHome				= Scancode.AcHome | SCANCODE_MASK,
		AcBack				= Scancode.AcBack | SCANCODE_MASK,
		AcForward			= Scancode.AcForward | SCANCODE_MASK,
		AcStop				= Scancode.AcStop | SCANCODE_MASK,
		AcRefresh			= Scancode.AcRefresh | SCANCODE_MASK,
		AcBookmarks			= Scancode.AcBookmarks | SCANCODE_MASK,
		BrightnessDown		= Scancode.BrightnessDown | SCANCODE_MASK,
		BrightnessUp		= Scancode.BrightnessUp | SCANCODE_MASK,
		DisplaySwitch		= Scancode.DisplaySwitch | SCANCODE_MASK,
		KbdIllumToggle		= Scancode.KbdIllumToggle | SCANCODE_MASK,
		KbdIllumDown		= Scancode.KbdIllumDown | SCANCODE_MASK,
		KbdIllumUp			= Scancode.KbdIllumUp | SCANCODE_MASK,
		Eject				= Scancode.Eject | SCANCODE_MASK,
		Sleep				= Scancode.Sleep | SCANCODE_MASK,
		App1				= Scancode.App1 | SCANCODE_MASK,
		App2				= Scancode.App2 | SCANCODE_MASK,
		AudioRewind			= Scancode.AudioRewind | SCANCODE_MASK,
		AudioFastForward	= Scancode.AudioFastForward | SCANCODE_MASK,
		LSoft				= Scancode.LSoft | SCANCODE_MASK,
		RSoft				= Scancode.RSoft | SCANCODE_MASK,
		Call				= Scancode.Call | SCANCODE_MASK,
		EndCall				= Scancode.EndCall | SCANCODE_MASK,
	}

	/// <summary>
	/// Valid key modifiers (possibly OR'd together).
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_Keymod">here</see>.
	/// </remarks>
	[Flags]
	public enum Keymod : uint
	{
		/// <summary>
		/// No modifier is applicable.
		/// </summary>
		None = 0x0000u,

		/// <summary>
		/// The left Shift key is down.
		/// </summary>
		LShift = 0x0001u,

		/// <summary>
		/// The left Shift key is down.
		/// </summary>
		RShift = 0x0002u,

		/// <summary>
		/// The left Ctrl (Control) key is down.
		/// </summary>
		LCtrl = 0x0040u,

		/// <summary>
		/// The right Ctrl (Control) key is down.
		/// </summary>
		RCtrl = 0x0080u,

		/// <summary>
		/// The left Alt key is down.
		/// </summary>
		LAlt = 0x0100u,

		/// <summary>
		/// The right Alt key is down.
		/// </summary>
		RAlt = 0x0200u,

		/// <summary>
		/// The left GUI key (often the Windows key) is down.
		/// </summary>
		LGUI = 0x0400u,

		/// <summary>
		/// The left GUI key (often the Windows key) is down.
		/// </summary>
		RGUI = 0x0800u,

		/// <summary>
		/// The Num Lock key (may be located on an extended keypad) is down.
		/// </summary>
		Num = 0x1000u,

		/// <summary>
		/// The Caps Lock key is down.
		/// </summary>
		Caps = 0x2000u,

		/// <summary>
		/// The AltGr key is down.
		/// </summary>
		Mode = 0x4000u,

		/// <summary>
		/// The Scoll Lock key is down.
		/// </summary>
		Scroll = 0x8000u,

		/// <summary>
		/// Any Ctrl key is down.
		/// </summary>
		Ctrl = LCtrl | RCtrl,

		/// <summary>
		/// Any Shift key is down.
		/// </summary>
		Shift = LShift | RShift,

		/// <summary>
		/// Any Alt key is down.
		/// </summary>
		Alt = LAlt | RAlt,

		/// <summary>
		/// Any GUI key is down.
		/// </summary>
		GUI = LGUI | RGUI,
	}

	[Macro]
	public static Keycode ScancodeToKeycode(Scancode scancode)
	{
		return (Keycode)((uint)scancode | SCANCODE_MASK);
	}

	/// <summary>
	/// A mask used to map scancodes to keycodes.
	/// </summary>
	public const uint SCANCODE_MASK = 1u << 30;
}