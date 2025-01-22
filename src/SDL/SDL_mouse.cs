﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

// SDL_mouse.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_mouse.h.
namespace SDL3;

/// <summary>
/// This is a unique ID for a mouse for the time it is connected to the system, and is never reused for the lifetime of the application.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseID">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_MouseId : uint
{
	/// <summary>
	/// An invalid/null mouse device ID.
	/// </summary>
	Invalid = 0
}

/// <summary>
/// The structure used to identify an SDL cursor.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Cursor">documentation</see> for more details.
/// </remarks>
[Opaque]
public unsafe struct SDL_Cursor;

/// <summary>
/// Cursor types for <see cref="SDL.CreateSystemCursor(SDL_SystemCursor)"/>.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SystemCursor">documentation</see> for more details.
/// </remarks>
public enum SDL_SystemCursor
{
	/// <summary>
	/// Default cursor. Usually an arrow.
	/// </summary>
	Default,

	/// <summary>
	/// Text selection. Usually an I-beam.
	/// </summary>
	Text,

	/// <summary>
	/// Wait. Usually an hourglass or watch or spinning ball.
	/// </summary>
	Wait,

	/// <summary>
	/// Crosshair.
	/// </summary>
	Crosshair,

	/// <summary>
	/// Program is busy but still interactive. Usually it's <see cref="Wait"/> with an arrow.
	/// </summary>
	Progress,

	/// <summary>
	/// Double arrow pointing northwest and southeast.
	/// </summary>
	NWSEResize,

	/// <summary>
	/// Double arrow pointing northeast and southwest.
	/// </summary>
	NESWResize,

	/// <summary>
	/// Double arrow pointing west and east.
	/// </summary>
	EWResize,

	/// <summary>
	/// Double arrow pointing north and south.
	/// </summary>
	NSResize,

	/// <summary>
	/// Four pointed arrow pointing north, south, east, and west.
	/// </summary>
	Move,

	/// <summary>
	/// Not permitted. Usually a slashed circle or crossbones.
	/// </summary>
	NotAllowed, // that's better.

	/// <summary>
	/// Pointer that indicates a link. Usually a pointing hand.
	/// </summary>
	Pointer,

	/// <summary>
	/// Window resize top-left. This may be a single arrow or a double arrow like <see cref="NWSEResize"/>.
	/// </summary>
	NWResize,

	/// <summary>
	/// Window resize top. May be <see cref="NSResize"/>.
	/// </summary>
	NResize,

	/// <summary>
	/// Window resize top-right. May be <see cref="NESWResize"/>.
	/// </summary>
	NEResize,

	/// <summary>
	/// Window resize right. May be <see cref="EWResize"/>.
	/// </summary>
	EResize,

	/// <summary>
	/// Window resize bottom-right. May be <see cref="NWSEResize"/>.
	/// </summary>
	SEResize,

	/// <summary>
	/// Window resize bottom. May be <see cref="NSResize"/>.
	/// </summary>
	SResize,

	/// <summary>
	/// Window resize bottom-left. May be <see cref="NESWResize"/>.
	/// </summary>
	SW,

	/// <summary>
	/// Window resize left. May be <see cref="EWResize"/>.
	/// </summary>
	WResize,

	Count
}

/// <summary>
/// Scroll direction types for the Scroll event.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseWheelDirection">documentation</see> for more details.
/// </remarks>
public enum SDL_MouseWheelDirection
{
	/// <summary>
	/// The scroll direction is normal.
	/// </summary>
	Normal,

	/// <summary>
	/// The scroll direction is flipped/natural.
	/// </summary>
	Flipped
}

/// <summary>
/// A bitmask of pressed mouse buttons, as reported by <see cref="SDL.GetMouseState(float*, float*)"/>, etc.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_MouseButtonFlags : uint;

unsafe partial class SDL
{
	/// <summary>
	/// Left mouse button.
	/// </summary>
	public const byte ButtonLeft = 1;

	/// <summary>
	/// Middle mouse button.
	/// </summary>
	public const byte ButtonMiddle = 2;

	/// <summary>
	/// Right mouse button.
	/// </summary>
	public const byte ButtonRight = 3;

	/// <summary>
	/// Side mouse button 1.
	/// </summary>
	public const byte ButtonX1 = 4;

	/// <summary>
	/// Side mouse button 2.
	/// </summary>
	public const byte ButtonX2 = 5;

	/// <summary>
	/// Left mouse button bitmask.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
	/// </remarks>
	public static SDL_MouseButtonFlags ButtonLMask => ButtonMask(ButtonLeft);

	/// <summary>
	/// Middle mouse button bitmask.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
	/// </remarks>
	public static SDL_MouseButtonFlags ButtonMMask => ButtonMask(ButtonMiddle);

	/// <summary>
	/// Right mouse button bitmask.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
	/// </remarks>
	public static SDL_MouseButtonFlags ButtonRMask => ButtonMask(ButtonRight);

	/// <summary>
	/// Side mouse button 1 bitmask.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
	/// </remarks>
	public static SDL_MouseButtonFlags ButtonX1Mask => ButtonMask(ButtonX1);

	/// <summary>
	/// Side mouse button 2 bitmask.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
	/// </remarks>
	public static SDL_MouseButtonFlags ButtonX2Mask => ButtonMask(ButtonX2);

	/// <summary>
	/// Please refer to <see cref="SDL_MouseButtonFlags"/> for details.
	/// </summary>
	[Macro]
	public static SDL_MouseButtonFlags ButtonMask(byte x) => (SDL_MouseButtonFlags)(1u << (x - 1));

	/// <summary>
	/// Return whether a mouse is currently connected.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasMouse">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if a mouse is connected, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasMouse")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool HasMouse();

	/// <summary>
	/// Get a list of currently connected mice.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetMice">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">A pointer filled in with the number of mice returned, may be <see langword="null"/>.</param>
	/// <returns>A null-terminated array of mouse instance IDs or <see langword="null"/> on failure; call <see cref="GetError"/> for more details. This should be freed with <see cref="free(void*)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetMice")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_MouseId* GetMice(int* count);

	/// <summary>
	/// Get the name of a mouse.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetMouseNameForID">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The mouse instance ID.</param>
	/// <returns>The name of the selected mouse, or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetMouseNameForID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string? GetMouseNameForId(SDL_MouseId instanceId);

	/// <summary>
	/// Get the window which currently has mouse focus.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetMouseFocus">documentation</see> for more details.
	/// </remarks>
	/// <returns>The window with mouse focus.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetMouseFocus")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Window* GetMouseFocus();

	/// <summary>
	/// Retrieve the current state of the mouse.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetMouseState">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">The x coordinate of the mouse cursor position relative to the focus window.</param>
	/// <param name="y">The y coordinate of the mouse cursor position relative to the focus window.</param>
	/// <returns>A 32-bit button bitmask of the current button state.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetMouseState")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_MouseButtonFlags GetMouseState(float* x, float* y);

	/// <summary>
	/// Get the current state of the mouse in relation to the desktop.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGlobalMouseState">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">The current X coord relative to the desktop.</param>
	/// <param name="y">The current X coord relative to the desktop.</param>
	/// <returns>The current button state as a bitmask which can be tested using the <see cref="ButtonMask(byte)"/> macros.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGlobalMouseState")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_MouseButtonFlags GetGlobalMouseState(float* x, float* y);

	/// <summary>
	/// Retrieve the relative state of the mouse.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRelativeMouseState">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">The last recorded x coordinate of the mouse.</param>
	/// <param name="y">The last recorded y coordinate of the mouse.</param>
	/// <returns>A 32-bit button bitmask of the relative button state.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRelativeMouseState")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_MouseButtonFlags GetRelativeMouseState(float* x, float* y);

	/// <summary>
	/// Move the mouse cursor to the given position within the window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WarpMouseInWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to move the mouse into, or <see langword="null"/> for the current mouse focus.</param>
	/// <param name="x">The x coordinate within the window.</param>
	/// <param name="y">The y coordinate within the window.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_WarpMouseInWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void WarpMouseInWindow(SDL_Window* window, float x, float y);

	/// <summary>
	/// Move the mouse to the given position in global screen space.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WarpMouseGlobal">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">The x coordinate.</param>
	/// <param name="y">The y coordinate.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_WarpMouseGlobal")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool WarpMouseGlobal(float x, float y);

	/// <summary>
	/// Set relative mouse mode for a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowRelativeMouseMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to change.</param>
	/// <param name="enabled">True to enable relative mode, false to disable.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowRelativeMouseMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowRelativeMouseMode(SDL_Window* window, [MarshalAs(BoolSize)] bool enabled);

	/// <summary>
	/// Query whether relative mouse mode is enabled for a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowRelativeMouseMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <returns>True if relative mode is enabled for a window or false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowRelativeMouseMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GetWindowRelativeMouseMode(SDL_Window* window);

	/// <summary>
	/// Capture the mouse and to track input outside an SDL window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CaptureMouse">documentation</see> for more details.
	/// </remarks>
	/// <param name="enabled">True to enable capturing, false to disable.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CaptureMouse")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool CaptureMouse([MarshalAs(BoolSize)] bool enabled);

	/// <summary>
	/// Create a cursor using the specified bitmap data and mask (in MSB format).
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateCursor">documentation</see> for more details.
	/// </remarks>
	/// <param name="data">The color value for each pixel of the cursor.</param>
	/// <param name="mask">The mask value for each pixel of the cursor.</param>
	/// <param name="width">The width of the cursor.</param>
	/// <param name="height">The height of the cursor.</param>
	/// <param name="hotX">The x-axis offset from the left of the cursor image to the mouse x position, in the range of 0 to <paramref name="width"/> - 1.</param>
	/// <param name="hotY">The y-axis offset from the top of the cursor image to the mouse y position, in the range of 0 to <paramref name="height"/> - 1.</param>
	/// <returns>A new cursor with the specified parameters on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateCursor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Cursor* CreateCursor([Const] byte* data, [Const] byte* mask, int width, int height, int hotX, int hotY);

	/// <summary>
	/// Create a color cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateColorCursor">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">An <see cref="SDL_Surface"/> structure representing the cursor image.</param>
	/// <param name="hotX">The x position of the cursor hot spot.</param>
	/// <param name="hotY">The y position of the cursor hot spot.</param>
	/// <returns>The new cursor on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateColorCursor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Cursor* CreateColorCursor(SDL_Surface* surface, int hotX, int hotY);

	/// <summary>
	/// Create a system cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateSystemCursor">documentation</see> for more details.
	/// </remarks>
	/// <param name="id">An <see cref="SDL_SystemCursor"/> enum value.</param>
	/// <returns>A cursor on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateSystemCursor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Cursor* CreateSystemCursor(SDL_SystemCursor id);

	/// <summary>
	/// Set the active cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetCursor">documentation</see> for more details.
	/// </remarks>
	/// <param name="cursor">A cursor to make active.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetCursor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetCursor(SDL_Cursor* cursor);

	/// <summary>
	/// Get the active cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCursor">documentation</see> for more details.
	/// </remarks>
	/// <returns>The active cursor or <see langword="null"/> if there is no mouse.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCursor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Cursor* GetCursor();

	/// <summary>
	/// Get the default cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDefaultCursor">documentation</see> for more details.
	/// </remarks>
	/// <returns>The default cursor on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDefaultCursor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Cursor* GetDefaultCursor();

	/// <summary>
	/// Free a previously-created cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyCursor">documentation</see> for more details.
	/// </remarks>
	/// <param name="cursor">The cursor to free.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DestroyCursor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void DestroyCursor(SDL_Cursor* cursor);

	/// <summary>
	/// Show the cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ShowCursor">documentation</see> for more details.
	/// </remarks>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ShowCursor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool ShowCursor();

	/// <summary>
	/// Hide the cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HideCursor">documentation</see> for more details.
	/// </remarks>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HideCursor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool HideCursor();

	/// <summary>
	/// Return whether the cursor is currently being shown.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CursorVisible">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the cursor is being shown, or false if the cursor is hidden.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CursorVisible")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool CursorVisible();
}