﻿// SDL_keycode.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_keycode.h
using System;

namespace SDL3;

/// <summary>
/// The SDL virtual key representation.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Keycode">documentation</see> for more details.
/// </remarks>
public enum SDL_Keycode : uint
{
	Unknown = 0x00000000u,
	Return = 0x0000000du,
	Escape = 0x0000001bu,
	Backspace = 0x00000008u,
	Tab = 0x00000009u,
	Space = 0x00000020u,
	Exclaim = 0x00000021u,
	DoubleApostrophe = 0x00000022u,
	Hash = 0x00000023u,
	Dollar = 0x00000024u,
	Percent = 0x00000025u,
	Ampersand = 0x00000026u,
	Apostrophe = 0x00000027u,
	LeftParenthesis = 0x00000028u,
	RightParenthesis = 0x00000029u,
	Asterisk = 0x0000002au,
	Plus = 0x0000002bu,
	Comma = 0x0000002cu,
	Minus = 0x0000002du,
	Period = 0x0000002eu,
	Slash = 0x0000002fu,
	D0 = 0x00000030u,
	D1 = 0x00000031u,
	D2 = 0x00000032u,
	D3 = 0x00000033u,
	D4 = 0x00000034u,
	D5 = 0x00000035u,
	D6 = 0x00000036u,
	D7 = 0x00000037u,
	D8 = 0x00000038u,
	D9 = 0x00000039u,
	Colon = 0x0000003au,
	Semicolon = 0x0000003bu,
	Less = 0x0000003cu,
	Equals = 0x0000003du,
	Greater = 0x0000003eu,
	Question = 0x0000003fu,
	At = 0x00000040u,
	LeftBracket = 0x0000005bu,
	Backslash = 0x0000005cu,
	RightBracket = 0x0000005du,
	Caret = 0x0000005eu,
	Underscore = 0x0000005fu,
	Grave = 0x00000060u,
	A = 0x00000061u,
	B = 0x00000062u,
	C = 0x00000063u,
	D = 0x00000064u,
	E = 0x00000065u,
	F = 0x00000066u,
	G = 0x00000067u,
	H = 0x00000068u,
	I = 0x00000069u,
	J = 0x0000006au,
	K = 0x0000006bu,
	L = 0x0000006cu,
	M = 0x0000006du,
	N = 0x0000006eu,
	O = 0x0000006fu,
	P = 0x00000070u,
	Q = 0x00000071u,
	R = 0x00000072u,
	S = 0x00000073u,
	T = 0x00000074u,
	U = 0x00000075u,
	V = 0x00000076u,
	W = 0x00000077u,
	X = 0x00000078u,
	Y = 0x00000079u,
	Z = 0x0000007au,
	LeftBrace = 0x0000007bu,
	Pipe = 0x0000007cu,
	RightBrace = 0x0000007du,
	Tilde = 0x0000007eu,
	Delete = 0x0000007fu,
	PlusMinus = 0x000000b1u,
	CapsLock = 0x40000039u,
	F1 = 0x4000003au,
	F2 = 0x4000003bu,
	F3 = 0x4000003cu,
	F4 = 0x4000003du,
	F5 = 0x4000003eu,
	F6 = 0x4000003fu,
	F7 = 0x40000040u,
	F8 = 0x40000041u,
	F9 = 0x40000042u,
	F10 = 0x40000043u,
	F11 = 0x40000044u,
	F12 = 0x40000045u,
	PrintScreen = 0x40000046u,
	ScrollLock = 0x40000047u,
	Pause = 0x40000048u,
	Insert = 0x40000049u,
	Home = 0x4000004au,
	PageUp = 0x4000004bu,
	End = 0x4000004du,
	PageDown = 0x4000004eu,
	Right = 0x4000004fu,
	Left = 0x40000050u,
	Down = 0x40000051u,
	Up = 0x40000052u,
	NumLockClear = 0x40000053u,
	KpDivide = 0x40000054u,
	KpMultiply = 0x40000055u,
	KpMinus = 0x40000056u,
	KpPlus = 0x40000057u,
	KpEnter = 0x40000058u,
	Kp1 = 0x40000059u,
	Kp2 = 0x4000005au,
	Kp3 = 0x4000005bu,
	Kp4 = 0x4000005cu,
	Kp5 = 0x4000005du,
	Kp6 = 0x4000005eu,
	Kp7 = 0x4000005fu,
	Kp8 = 0x40000060u,
	Kp9 = 0x40000061u,
	Kp0 = 0x40000062,
	KpPeriod = 0x40000063,
	Application = 0x40000065u,
	Power = 0x40000066u,
	KpEquals = 0x40000067u,
	F13 = 0x40000068u,
	F14 = 0x40000069u,
	F15 = 0x4000006au,
	F16 = 0x4000006bu,
	F17 = 0x4000006cu,
	F18 = 0x4000006du,
	F19 = 0x4000006eu,
	F20 = 0x4000006fu,
	F21 = 0x40000070u,
	F22 = 0x40000071u,
	F23 = 0x40000072u,
	F24 = 0x40000073u,
	Execute = 0x40000074u,
	Help = 0x40000075u,
	Menu = 0x40000076u,
	Select = 0x40000077u,
	Stop = 0x40000078u,
	Again = 0x40000079u,
	Undo = 0x4000007au,
	Cut = 0x4000007bu,
	Copy = 0x4000007cu,
	Paste = 0x4000007du,
	Find = 0x4000007eu,
	Mute = 0x4000007fu,
	VolumeUp = 0x40000080u,
	VolumeDown = 0x40000081u,
	KpComma = 0x40000085u,
	KpEqualsAS400 = 0x40000086u,
	AltErase = 0x40000099u,
	SysReq = 0x4000009au,
	Cancel = 0x4000009bu,
	Clear = 0x4000009cu,
	Prior = 0x4000009du,
	Return2 = 0x4000009eu,
	Separator = 0x4000009fu,
	Out = 0x400000a0u,
	Oper = 0x400000a1u,
	ClearAgain = 0x400000a2u,
	Crsel = 0x400000a3u,
	Exsel = 0x400000a4u,
	Kp00 = 0x400000b0u,
	Kp000 = 0x400000b1u,
	ThousandsSeparator = 0x400000b2u,
	DecimalSeparator = 0x400000b3u,
	CurrencyUnit = 0x400000b4u,
	CurrencySubunit = 0x400000b5u,
	KpLeftParenthesis = 0x400000b6u,
	KpRightParenthesis = 0x400000b7u,
	KpLeftBrace = 0x400000b8u,
	KpRightBrace = 0x400000b9u,
	KpTab = 0x400000bau,
	KpBackspace = 0x400000bbu,
	KpA = 0x400000bcu,
	KpB = 0x400000bdu,
	KpC = 0x400000beu,
	KpD = 0x400000bfu,
	KpE = 0x400000c0u,
	KpF = 0x400000c1u,
	KpXor = 0x400000c2u,
	KpPower = 0x400000c3u,
	KpPercent = 0x400000c4u,
	KpLess = 0x400000c5u,
	KpGreater = 0x400000c6u,
	KpAmpersand = 0x400000c7u,
	KpDoubleAmpersand = 0x400000c8u,
	KpVerticalBar = 0x400000c9u,
	KpDoubleVerticalBar = 0x400000cau,
	KpColon = 0x400000cbu,
	KpHash = 0x400000ccu,
	KpSpace = 0x400000cdu,
	KpAt = 0x400000ceu,
	KpExclaim = 0x400000cfu,
	KpMemStore = 0x400000d0u,
	KpMemRecall = 0x400000d1u,
	KpMemClear = 0x400000d2u,
	KpMemAdd = 0x400000d3u,
	KpMemSubtract = 0x400000d4u,
	KpMemMultiply = 0x400000d5u,
	KpMemDivide = 0x400000d6u,
	KpClear = 0x400000d8u,
	KpClearEntry = 0x400000d9u,
	KpBinary = 0x400000dau,
	KpOctal = 0x400000dbu,
	KpDecimal = 0x400000dcu,
	KpHexadecimal = 0x400000ddu,
	LCtrl = 0x400000e0u,
	LShift = 0x400000e1u,
	LAlt = 0x400000e2u,
	LGUI = 0x400000e3u,
	RCtrl = 0x400000e4u,
	RShift = 0x400000e5u,
	RAlt = 0x400000e6u,
	RGUI = 0x400000e7u,
	Mode = 0x40000101u,
	Sleep = 0x40000102u,
	Wake = 0x40000103u,
	ChannelIncrement = 0x40000104u,
	ChannelDecrement = 0x40000105u,
	MediaPlay = 0x40000106u,
	MediaPause = 0x40000107u,
	MediaRecord = 0x40000108u,
	MediaFastForward = 0x40000109u,
	MediaRewind = 0x4000010au,
	MediaNextTrack = 0x4000010bu,
	MediaPreviousTrack = 0x4000010cu,
	MediaStop = 0x4000010du,
	MediaEject = 0x4000010eu,
	MediaPlayPause = 0x4000010fu,
	MediaSelect = 0x40000110u,
	ACNew = 0x40000111u,
	ACOpen = 0x40000112u,
	ACClose = 0x40000113u,
	ACExit = 0x40000114u,
	ACSave = 0x40000115u,
	ACPrint = 0x40000116u,
	ACProperties = 0x40000117u,
	ACSearch = 0x40000118u,
	ACHome = 0x40000119u,
	ACBack = 0x4000011au,
	ACForward = 0x4000011bu,
	ACStop = 0x4000011cu,
	ACRefresh = 0x4000011du,
	ACBookmarks = 0x4000011eu,
	SoftLeft = 0x4000011fu,
	SoftRight = 0x40000120u,
	Call = 0x40000121u,
	EndCall = 0x40000122u
}

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

unsafe partial class SDL
{
	/// <summary>
	/// A mask used to map scancodes to keycodes.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Keycode">documentation</see> for more details.
	/// </remarks>
	public const uint ScancodeMask = 1u << 30;

	/// <summary>
	/// Map a scancode value to a virtual key value.
	/// </summary>
	/// <param name="scancode">The <see cref="SDL_Scancode"/> to convert.</param>
	/// <returns>The equivalent <see cref="SDL_Keycode"/> for the given scancode.</returns>
	[Macro]
	public static SDL_Keycode ScancodeToKeycode(SDL_Scancode scancode) => (SDL_Keycode)((uint)scancode | ScancodeMask);
}