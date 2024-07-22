using System;

namespace SDL_cs;

/// <summary>
/// Valid key modifiers (possibly OR'd together).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Keymod">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_Keymod : ushort
{
	/// <summary>
	/// No modifier is applicable.
	/// </summary>
	None = 0x0000,

	/// <summary>
	/// The left Shift key is down.
	/// </summary>
	LShift = 0x0001,

	/// <summary>
	/// The left Shift key is down.
	/// </summary>
	RShift = 0x0002,

	/// <summary>
	/// The left Ctrl (Control) key is down.
	/// </summary>
	LCtrl = 0x0040,

	/// <summary>
	/// The right Ctrl (Control) key is down.
	/// </summary>
	RCtrl = 0x0080,

	/// <summary>
	/// The left Alt key is down.
	/// </summary>
	LAlt = 0x0100,

	/// <summary>
	/// The right Alt key is down.
	/// </summary>
	RAlt = 0x0200,

	/// <summary>
	/// The left GUI key (often the Windows key) is down.
	/// </summary>
	LGUI = 0x0400,

	/// <summary>
	/// The left GUI key (often the Windows key) is down.
	/// </summary>
	RGUI = 0x0800,

	/// <summary>
	/// The Num Lock key (may be located on an extended keypad) is down.
	/// </summary>
	Num = 0x1000,

	/// <summary>
	/// The Caps Lock key is down.
	/// </summary>
	Caps = 0x2000,

	/// <summary>
	/// The !AltGr key is down.
	/// </summary>
	Mode = 0x4000,

	/// <summary>
	/// The Scoll Lock key is down.
	/// </summary>
	Scroll = 0x8000,

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