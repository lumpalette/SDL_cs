using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_mouse.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_mouse.h
unsafe partial class SDL
{
	[Macro]
	public static uint Button(byte x)
	{
		return 1u << (x - 1);
	}

	/// <summary>
	/// Return whether a mouse is currently connected.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasMouse">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if a mouse is connected, false otherwise.</returns>
	public static bool HasMouse()
	{
		return SDL_PInvoke.SDL_HasMouse() == 1;
	}

	/// <summary>
	/// Get a list of currently connected mice.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetMice">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">The number of mice returned.</param>
	/// <returns>An array of mouse instance ids or <see langword="null"/> on error; call <see cref="GetError"/> for more details.</returns>
	public static SDL_MouseId[]? GetMice(out int count)
	{
		fixed (int* countPtr = &count)
		{
			var m = SDL_PInvoke.SDL_GetMice(countPtr);
			if (m is null)
			{
				return null;
			}
			var mice = new SDL_MouseId[count];
			for (int i = 0; i < count; i++)
			{
				mice[i] = m[i];
			}
			Free(m);
			return mice;
		}
	}

	/// <summary>
	/// Get the name of a mouse.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetMouseInstanceName">documentation</see> for more details.
	/// </remarks>
	/// <param name="mouseId">The mouse instance ID.</param>
	/// <returns>The name of the selected mouse, or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	public static string? GetMouseInstanceName(SDL_MouseId mouseId)
	{
		return Marshal.PtrToStringUTF8((nint)SDL_PInvoke.SDL_GetMouseInstanceName(mouseId));
	}

	/// <summary>
	/// Get the window which currently has mouse focus.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetMouseFocus">documentation</see> for more details.
	/// </remarks>
	/// <returns>The windows with mouse focus.</returns>
	public static SDL_Window* GetMouseFocus()
	{
		return SDL_PInvoke.SDL_GetMouseFocus();
	}

	/// <summary>
	/// Retrieve the current state of the mouse.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetMouseState">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">The x coordinate of the mouse cursor position relative to the focus window.</param>
	/// <param name="y">The y coordinate of the mouse cursor position relative to the focus window.</param>
	/// <returns>A 32-bit button bitmask of the current button state.</returns>
	public static SDL_MouseButtonFlags GetMouseState(out float x, out float y)
	{
		fixed (float* xPtr = &x, yPtr = &y)
		{
			return SDL_PInvoke.SDL_GetMouseState(xPtr, yPtr);
		}
	}

	/// <summary>
	/// Get the current state of the mouse in relation to the desktop.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGlobalMouseState">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">The current X coord relative to the desktop.</param>
	/// <param name="y">The current X coord relative to the desktop.</param>
	/// <returns>The current button state as a bitmask.</returns>
	public static SDL_MouseButtonFlags GetGlobalMouseState(out float x, out float y)
	{
		fixed (float* xPtr = &x, yPtr = &y)
		{
			return SDL_PInvoke.SDL_GetGlobalMouseState(xPtr, yPtr);
		}
	}

	/// <summary>
	/// Retrieve the relative state of the mouse.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRelativeMouseState">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">The last recorded x coordinate of the mouse.</param>
	/// <param name="y">The last recorded y coordinate of the mouse.</param>
	/// <returns>A 32-bit button bitmask of the relative button state.</returns>
	public static SDL_MouseButtonFlags GetRelativeMouseState(out float x, out float y)
	{
		fixed (float* xPtr = &x, yPtr = &y)
		{
			return SDL_PInvoke.SDL_GetRelativeMouseState(xPtr, yPtr);
		}
	}

	/// <summary>
	/// Move the mouse cursor to the given position within the window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WarpMouseInWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to move the mouse into, or <see langword="null"/> for the current mouse focus.</param>
	/// <param name="x">The x coordinate within the window.</param>
	/// <param name="y">The y coordinate within the window.</param>
	public static void WarpMouseInWindow(SDL_Window* window, float x, float y)
	{
		SDL_PInvoke.SDL_WarpMouseInWindow(window, x, y);
	}

	/// <summary>
	/// Move the mouse to the given position in global screen space.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WarpMouseGlobal">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">The x coordinate.</param>
	/// <param name="y">The y coordinate.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int WarpMouseGlobal(float x, float y)
	{
		return SDL_PInvoke.SDL_WarpMouseGlobal(x, y);
	}

	/// <summary>
	/// Set relative mouse mode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRelativeMouseMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="enabled">True to enable relative mode, false to disable.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetRelativeMouseMode(bool enabled)
	{
		return SDL_PInvoke.SDL_SetRelativeMouseMode(enabled ? 1 : 0);
	}

	/// <summary>
	/// Capture the mouse and to track input outside an SDL window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CaptureMouse">documentation</see> for more details.
	/// </remarks>
	/// <param name="enabled">True to enable capturing, false to disable.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int CaptureMouse(bool enabled)
	{
		return SDL_PInvoke.SDL_CaptureMouse(enabled ? 1 : 0);
	}

	/// <summary>
	/// Query whether relative mouse mode is enabled.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRelativeMouseMode">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if relative mode is enabled or false otherwise.</returns>
	public static bool GetRelativeMouseMode()
	{
		return SDL_PInvoke.SDL_GetRelativeMouseMode() == 1;
	}

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
	public static SDL_Cursor* CreateCursor(byte[] data, byte[] mask, int width, int height, int hotX, int hotY)
	{
		fixed (byte* dataPtr = data, maskPtr = mask)
		{
			return SDL_PInvoke.SDL_CreateCursor(dataPtr, maskPtr, width, height, hotX, hotY);
		}
	}

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
	public static SDL_Cursor* CreateCursor(SDL_Surface* surface, int hotX, int hotY)
	{
		return SDL_PInvoke.SDL_CreateColorCursor(surface, hotX, hotY);
	}

	/// <summary>
	/// Create a system cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateSystemCursor">documentation</see> for more details.
	/// </remarks>
	/// <param name="id">An <see cref="SDL_SystemCursor"/> enum value.</param>
	/// <returns>A cursor on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	public static SDL_Cursor* CreateCursor(SDL_SystemCursor id)
	{
		return SDL_PInvoke.SDL_CreateSystemCursor(id);
	}

	/// <summary>
	/// Set the active cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetCursor">documentation</see> for more details.
	/// </remarks>
	/// <param name="cursor">A cursor to make active.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetCursor(SDL_Cursor* cursor)
	{
		return SDL_PInvoke.SDL_SetCursor(cursor);
	}

	/// <summary>
	/// Get the active cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCursor">documentation</see> for more details.
	/// </remarks>
	/// <returns>The active cursor or <see langword="null"/> if there is no mouse.</returns>
	public static SDL_Cursor* GetCursor()
	{
		return SDL_PInvoke.SDL_GetCursor();
	}

	/// <summary>
	/// Get the default cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDefaultCursor">documentation</see> for more details.
	/// </remarks>
	/// <returns>The default cursor on success or <see langword="null"/> on failure.</returns>
	public static SDL_Cursor* GetDefaultCursor()
	{
		return SDL_PInvoke.SDL_GetDefaultCursor();
	}

	/// <summary>
	/// Free a previously-created cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyCursor">documentation</see> for more details.
	/// </remarks>
	/// <param name="cursor">The cursor to free.</param>
	public static void DestroyCursor(SDL_Cursor* cursor)
	{
		SDL_PInvoke.SDL_DestroyCursor(cursor);
	}

	/// <summary>
	/// Show the cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ShowCursor">documentation</see> for more details.
	/// </remarks>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int ShowCursor()
	{
		return SDL_PInvoke.SDL_ShowCursor();
	}

	/// <summary>
	/// Hide the cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HideCursor">documentation</see> for more details.
	/// </remarks>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int HideCursor()
	{
		return SDL_PInvoke.SDL_HideCursor();
	}

	/// <summary>
	/// Return whether the cursor is currently being shown.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CursorVisible">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the cursor is being shown, or false if the cursor is hidden.</returns>
	public static bool CursorVisible()
	{
		return SDL_PInvoke.SDL_CursorVisible() == 1;
	}

	/// <summary>
	/// Button 1: Left mouse button.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
	/// </remarks>
	public const byte ButtonLeft = 1;

	/// <summary>
	/// Button 2: Middle mouse button.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
	/// </remarks>
	public const byte ButtonMiddle = 2;

	/// <summary>
	/// Button 3: Right mouse button.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
	/// </remarks>
	public const byte ButtonRight = 3;

	/// <summary>
	/// Button 4: Side mouse button 1.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
	/// </remarks>
	public const byte ButtonX1 = 4;

	/// <summary>
	/// Button 5: Side mouse button 2.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
	/// </remarks>
	public const byte ButtonX2 = 5;

	/// <summary>
	/// Left mouse button mask.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
	/// </remarks>
	public static SDL_MouseButtonFlags ButtonLeftMask => (SDL_MouseButtonFlags)Button(ButtonLeft);

	/// <summary>
	/// Middle mouse button mask.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
	/// </remarks>
	public static SDL_MouseButtonFlags ButtonMiddleMask => (SDL_MouseButtonFlags)Button(ButtonMiddle);

	/// <summary>
	/// Right mouse button mask.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
	/// </remarks>
	public static SDL_MouseButtonFlags ButtonRightMask => (SDL_MouseButtonFlags)Button(ButtonRight);

	/// <summary>
	/// Side mouse button 1 mask.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
	/// </remarks>
	public static SDL_MouseButtonFlags ButtonX1Mask => (SDL_MouseButtonFlags)Button(ButtonX1);

	/// <summary>
	/// Side mouse button 2 mask.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
	/// </remarks>
	public static SDL_MouseButtonFlags ButtonX2Mask => (SDL_MouseButtonFlags)Button(ButtonX2);
}