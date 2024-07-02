using System;

namespace SDL_cs;

/// <summary>
/// Valid key modifiers (possibly OR'd together).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Keymod">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_Keymod : uint
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
	/// The !AltGr key is down.
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