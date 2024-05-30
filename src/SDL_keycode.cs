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
		Capslock			= Scancode.Capslock | ScancodeMask,
		F1					= Scancode.F1 | ScancodeMask,
		F2					= Scancode.F2 | ScancodeMask,
		F3					= Scancode.F3 | ScancodeMask,
		F4					= Scancode.F4 | ScancodeMask,
		F5					= Scancode.F5 | ScancodeMask,
		F6					= Scancode.F6 | ScancodeMask,
		F7					= Scancode.F7 | ScancodeMask,
		F8					= Scancode.F8 | ScancodeMask,
		F9					= Scancode.F9 | ScancodeMask,
		F10					= Scancode.F10 | ScancodeMask,
		F11					= Scancode.F11 | ScancodeMask,
		F12					= Scancode.F12 | ScancodeMask,
		Printscreen			= Scancode.Printscreen | ScancodeMask,
		ScrollLock			= Scancode.ScrollLock | ScancodeMask,
		Pause				= Scancode.Pause | ScancodeMask,
		Insert				= Scancode.Insert | ScancodeMask,
		Home				= Scancode.Home | ScancodeMask,
		PageUp				= Scancode.PageUp | ScancodeMask,
		Delete				= Scancode.Delete | ScancodeMask,
		End					= Scancode.End | ScancodeMask,
		PageDown			= Scancode.PageDown | ScancodeMask,
		RArrow				= Scancode.RArrow | ScancodeMask,
		LArrow				= Scancode.LArrow | ScancodeMask,
		DArrow				= Scancode.DArrow | ScancodeMask,
		UArrow				= Scancode.UArrow | ScancodeMask,
		NumlockClear		= Scancode.NumlockClear | ScancodeMask,
		KpDivide			= Scancode.KpDivide | ScancodeMask,
		KpMultiply			= Scancode.KpMultiply | ScancodeMask,
		KpMinus				= Scancode.KpMinus | ScancodeMask,
		KpPlus				= Scancode.KpPlus | ScancodeMask,
		KpEnter				= Scancode.KpEnter | ScancodeMask,
		Kp1					= Scancode.Kp1 | ScancodeMask,
		Kp2					= Scancode.Kp2 | ScancodeMask,
		Kp3					= Scancode.Kp3 | ScancodeMask,
		Kp4					= Scancode.Kp4 | ScancodeMask,
		Kp5					= Scancode.Kp5 | ScancodeMask,
		Kp6					= Scancode.Kp6 | ScancodeMask,
		Kp7					= Scancode.Kp7 | ScancodeMask,
		Kp8					= Scancode.Kp8 | ScancodeMask,
		Kp9					= Scancode.Kp9 | ScancodeMask,
		Kp0					= Scancode.Kp0 | ScancodeMask,
		KpPeriod			= Scancode.KpPeriod | ScancodeMask,
		Application			= Scancode.Application | ScancodeMask,
		Power				= Scancode.Power | ScancodeMask,
		KpEquals			= Scancode.KpEquals | ScancodeMask,
		F13					= Scancode.F13 | ScancodeMask,
		F14					= Scancode.F14 | ScancodeMask,
		F15					= Scancode.F15 | ScancodeMask,
		F16					= Scancode.F16 | ScancodeMask,
		F17					= Scancode.F17 | ScancodeMask,
		F18					= Scancode.F18 | ScancodeMask,
		F19					= Scancode.F19 | ScancodeMask,
		F20					= Scancode.F20 | ScancodeMask,
		F21					= Scancode.F21 | ScancodeMask,
		F22					= Scancode.F22 | ScancodeMask,
		F23					= Scancode.F23 | ScancodeMask,
		F24					= Scancode.F24 | ScancodeMask,
		Execute				= Scancode.Execute | ScancodeMask,
		Help				= Scancode.Help | ScancodeMask,
		Menu				= Scancode.Menu | ScancodeMask,
		Select				= Scancode.Select | ScancodeMask,
		Stop				= Scancode.Stop | ScancodeMask,
		Again				= Scancode.Again | ScancodeMask,
		Undo				= Scancode.Undo | ScancodeMask,
		Cut					= Scancode.Cut | ScancodeMask,
		Copy				= Scancode.Copy | ScancodeMask,
		Paste				= Scancode.Paste | ScancodeMask,
		Find				= Scancode.Find | ScancodeMask,
		Mute				= Scancode.Mute | ScancodeMask,
		VolumeUp			= Scancode.VolumeUp | ScancodeMask,
		VolumeDown			= Scancode.VolumeDown | ScancodeMask,
		KpComma				= Scancode.KpComma | ScancodeMask,
		KpEqualsAS400		= Scancode.KpEqualsAS400 | ScancodeMask,
		AltErase			= Scancode.AltErase | ScancodeMask,
		SysReq				= Scancode.SysReq | ScancodeMask,
		Cancel				= Scancode.Cancel | ScancodeMask,
		Clear				= Scancode.Clear | ScancodeMask,
		Prior				= Scancode.Prior | ScancodeMask,
		Return2				= Scancode.Return2 | ScancodeMask,
		Separator			= Scancode.Separator | ScancodeMask,
		Out					= Scancode.Out | ScancodeMask,
		Oper				= Scancode.Oper | ScancodeMask,
		ClearAgain			= Scancode.ClearAgain | ScancodeMask,
		Crsel				= Scancode.Crsel | ScancodeMask,
		Exsel				= Scancode.Exsel | ScancodeMask,
		Kp00				= Scancode.Kp00 | ScancodeMask,
		Kp000				= Scancode.Kp000 | ScancodeMask,
		ThousandSeparator	= Scancode.ThousandSeparator | ScancodeMask,
		DecimalSeparator	= Scancode.DecimalSeparator | ScancodeMask,
		CurrencyUnit		= Scancode.CurrencyUnit | ScancodeMask,
		CurrencySubUnit		= Scancode.CurrencySubUnit | ScancodeMask,
		KpLParenthesis		= Scancode.KpLParenthesis | ScancodeMask,
		KpRParenthesis		= Scancode.KpRParenthesis | ScancodeMask,
		KpLBrace			= Scancode.KpLBrace | ScancodeMask,
		KpRBrace			= Scancode.KpRBrace | ScancodeMask,
		KpTab				= Scancode.KpTab | ScancodeMask,
		KpBackspace			= Scancode.KpBackspace | ScancodeMask,
		KpA					= Scancode.KpA | ScancodeMask,
		KpB					= Scancode.KpB | ScancodeMask,
		KpC					= Scancode.KpC | ScancodeMask,
		KpD					= Scancode.KpD | ScancodeMask,
		KpE					= Scancode.KpE | ScancodeMask,
		KpF					= Scancode.KpF | ScancodeMask,
		KpXOR				= Scancode.KpXOR | ScancodeMask,
		KpPower				= Scancode.KpPower | ScancodeMask,
		KpPercent			= Scancode.KpPercent | ScancodeMask,
		KpLess				= Scancode.KpLess | ScancodeMask,
		KpGreater			= Scancode.KpGreater | ScancodeMask,
		KpAmpersand			= Scancode.KpAmpersand | ScancodeMask,
		KpDoubleAmpersand	= Scancode.KpDoubleAmpersand | ScancodeMask,
		KpVerticalBar		= Scancode.KpVerticalBar | ScancodeMask,
		KpDoubleVerticalBar	= Scancode.KpDoubleVerticalBar | ScancodeMask,
		KpColon				= Scancode.KpColon | ScancodeMask,
		KpHash				= Scancode.KpHash | ScancodeMask,
		KpSpace				= Scancode.KpSpace | ScancodeMask,
		KpAt				= Scancode.KpAt | ScancodeMask,
		KpExclaim			= Scancode.KpExclaim | ScancodeMask,
		KpMemStore			= Scancode.KpMemStore | ScancodeMask,
		KpMemRecall			= Scancode.KpMemRecall | ScancodeMask,
		KpMemClear			= Scancode.KpMemClear | ScancodeMask,
		KpMemAdd			= Scancode.KpMemAdd | ScancodeMask,
		KpMemSubtract		= Scancode.KpMemSubtract | ScancodeMask,
		KpMemMultiply		= Scancode.KpMemMultiply | ScancodeMask,
		KpMemDivide			= Scancode.KpMemDivide | ScancodeMask,
		KpPlusMinus			= Scancode.KpPlusMinus | ScancodeMask,
		KpClear				= Scancode.KpClear | ScancodeMask,
		KpClearEntry		= Scancode.KpClearEntry | ScancodeMask,
		KpBinary			= Scancode.KpBinary | ScancodeMask,
		KpOctal				= Scancode.KpOctal | ScancodeMask,
		KpDecimal			= Scancode.KpDecimal | ScancodeMask,
		KpHexadecimal		= Scancode.KpHexadecimal | ScancodeMask,
		LCtrl				= Scancode.LCtrl | ScancodeMask,
		LShift				= Scancode.LShift | ScancodeMask,
		LGUI				= Scancode.LGUI | ScancodeMask,
		RCtrl				= Scancode.RCtrl | ScancodeMask,
		RShift				= Scancode.RShift | ScancodeMask,
		RGUI				= Scancode.RGUI | ScancodeMask,
		Mode				= Scancode.Mode | ScancodeMask,
		AudioNext			= Scancode.AudioNext | ScancodeMask,
		AudioPrev			= Scancode.AudioPrev | ScancodeMask,
		AudioStop			= Scancode.AudioStop | ScancodeMask,
		AudioPlay			= Scancode.AudioPlay | ScancodeMask,
		AudioMute			= Scancode.AudioMute | ScancodeMask,
		MediaSelect			= Scancode.MediaSelect | ScancodeMask,
		WWW					= Scancode.WWW | ScancodeMask,
		Mail				= Scancode.Mail | ScancodeMask,
		Calculator			= Scancode.Calculator | ScancodeMask,
		Computer			= Scancode.Computer | ScancodeMask,
		AcSearch			= Scancode.AcSearch | ScancodeMask,
		AcHome				= Scancode.AcHome | ScancodeMask,
		AcBack				= Scancode.AcBack | ScancodeMask,
		AcForward			= Scancode.AcForward | ScancodeMask,
		AcStop				= Scancode.AcStop | ScancodeMask,
		AcRefresh			= Scancode.AcRefresh | ScancodeMask,
		AcBookmarks			= Scancode.AcBookmarks | ScancodeMask,
		BrightnessDown		= Scancode.BrightnessDown | ScancodeMask,
		BrightnessUp		= Scancode.BrightnessUp | ScancodeMask,
		DisplaySwitch		= Scancode.DisplaySwitch | ScancodeMask,
		KbdIllumToggle		= Scancode.KbdIllumToggle | ScancodeMask,
		KbdIllumDown		= Scancode.KbdIllumDown | ScancodeMask,
		KbdIllumUp			= Scancode.KbdIllumUp | ScancodeMask,
		Eject				= Scancode.Eject | ScancodeMask,
		Sleep				= Scancode.Sleep | ScancodeMask,
		App1				= Scancode.App1 | ScancodeMask,
		App2				= Scancode.App2 | ScancodeMask,
		AudioRewind			= Scancode.AudioRewind | ScancodeMask,
		AudioFastForward	= Scancode.AudioFastForward | ScancodeMask,
		LSoft				= Scancode.LSoft | ScancodeMask,
		RSoft				= Scancode.RSoft | ScancodeMask,
		Call				= Scancode.Call | ScancodeMask,
		EndCall				= Scancode.EndCall | ScancodeMask,
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
		return (Keycode)((uint)scancode | ScancodeMask);
	}

	/// <summary>
	/// A mask used to map scancodes to keycodes.
	/// </summary>
	public const uint ScancodeMask = 1u << 30;
}