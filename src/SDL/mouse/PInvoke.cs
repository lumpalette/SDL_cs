using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_mouse.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_mouse.h
unsafe partial class SDL
{
	[Macro]
	public static uint Button(int x)
	{
		return 1u << (x - 1);
	}

	/// <summary>
	/// Return whether a mouse is currently connected.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_HasMouse">here</see> for more details.
	/// </remarks>
	/// <returns> True if a mouse is connected, false otherwise. </returns>
	public static bool HasMouse()
	{
		return _PInvoke() == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_HasMouse", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Get a list of currently connected mice.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetMice">here</see> for more details.
	/// </remarks>
	/// <param name="count"> Returns the number of mice returned </param>
	/// <returns> An array of mouse instance ids or null on error; call <see cref="GetError"/> for more details. </returns>
	public static SDL_MouseId[]? GetMice(out int count)
	{
		fixed (int* countPtr = &count)
		{
			SDL_MouseId* m = _PInvoke(countPtr);
			if (m is null)
			{
				return null;
			}
			SDL_MouseId[] mice = new SDL_MouseId[count];
			for (int i = 0; i < count; i++)
			{
				mice[i] = m[i];
			}
			Free(m);
			return mice;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetMice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_MouseId* _PInvoke(int* count);
	}

	/// <summary>
	/// Get the name of a mouse.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetMouseInstanceName">here</see> for more details.
	/// </remarks>
	/// <param name="mouseId"> The mouse instance ID. </param>
	/// <returns> The name of the selected mouse, or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static string? GetMouseInstanceName(SDL_MouseId mouseId)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(mouseId));

		[DllImport(LibraryName, EntryPoint = "SDL_GetMouseInstanceName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_MouseId mouseId);
	}

	/// <summary>
	/// Get the window which currently has mouse focus.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetMouseFocus">here</see> for more details.
	/// </remarks>
	/// <returns> The windows with mouse focus. </returns>
	public static SDL_Window* GetMouseFocus()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetMouseFocus", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Window* _PInvoke();
	}

	/// <summary>
	/// Retrieve the current state of the mouse.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetMouseState">here</see> for more details.
	/// </remarks>
	/// <param name="x"> Returns the x coordinate of the mouse cursor position relative to the focus window. </param>
	/// <param name="y"> Returns the y coordinate of the mouse cursor position relative to the focus window. </param>
	/// <returns> A 32-bit button bitmask of the current button state. </returns>
	public static SDL_MouseButtonFlags GetMouseState(out float x, out float y)
	{
		fixed (float* xPtr = &x, yPtr = &y)
		{
			return _PInvoke(xPtr, yPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetMouseState", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_MouseButtonFlags _PInvoke(float* x, float* y);
	}

	/// <summary>
	/// Get the current state of the mouse in relation to the desktop.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetGlobalMouseState">here</see> for more details.
	/// </remarks>
	/// <param name="x"> Returns the current X coord relative to the desktop. </param>
	/// <param name="y"> Returns the current X coord relative to the desktop. </param>
	/// <returns> The current button state as a bitmask. </returns>
	public static SDL_MouseButtonFlags GetGlobalMouseState(out float x, out float y)
	{
		fixed (float* xPtr = &x, yPtr = &y)
		{
			return _PInvoke(xPtr, yPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetGlobalMouseState", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_MouseButtonFlags _PInvoke(float* x, float* y);
	}

	/// <summary>
	/// Retrieve the relative state of the mouse.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetRelativeMouseState">here</see> for more details.
	/// </remarks>
	/// <param name="x"> Returns the last recorded x coordinate of the mouse. </param>
	/// <param name="y"> Returns the last recorded y coordinate of the mouse. </param>
	/// <returns> A 32-bit button bitmask of the relative button state. </returns>
	public static SDL_MouseButtonFlags GetRelativeMouseState(out float x, out float y)
	{
		fixed (float* xPtr = &x, yPtr = &y)
		{
			return _PInvoke(xPtr, yPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetRelativeMouseState", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_MouseButtonFlags _PInvoke(float* x, float* y);
	}

	/// <summary>
	/// Move the mouse cursor to the given position within the window.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_WarpMouseInWindows">here</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to move the mouse into, or null for the current mouse focus. </param>
	/// <param name="x"> The x coordinate within the window. </param>
	/// <param name="y"> The y coordinate within the window. </param>
	public static void WarpMouseInWindows(SDL_Window* window, float x, float y)
	{
		_PInvoke(window, x, y);

		[DllImport(LibraryName, EntryPoint = "SDL_WarpMouseInWindows", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(SDL_Window* window, float x, float y);
	}

	/// <summary>
	/// Move the mouse to the given position in global screen space.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_WarpMouseGlobal">here</see> for more details.
	/// </remarks>
	/// <param name="x"> The x coordinate. </param>
	/// <param name="y"> The y coordinate. </param>
	public static void WarpMouseGlobal(float x, float y)
	{
		_PInvoke(x, y);

		[DllImport(LibraryName, EntryPoint = "SDL_WarpMouseGlobal", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(float x, float y);
	}

	/// <summary>
	/// Set relative mouse mode.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetRelativeMouseMode">here</see> for more details.
	/// </remarks>
	/// <param name="enabled"> True to enable relative mode, false to disable. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetRelativeMouseMode(bool enabled)
	{
		return _PInvoke(enabled ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetRelativeMouseMode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(int enabled);
	}

	/// <summary>
	/// Capture the mouse and to track input outside an SDL window.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CaptureMouse">here</see> for more details.
	/// </remarks>
	/// <param name="enabled"> True to enable capturing, false to disable. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int CaptureMouse(bool enabled)
	{
		return _PInvoke(enabled ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_CaptureMouse", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(int enabled);
	}

	/// <summary>
	/// Query whether relative mouse mode is enabled.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetRelativeMouseMode">here</see> for more details.
	/// </remarks>
	/// <returns> True if relative mode is enabled or false otherwise. </returns>
	public static bool GetRelativeMouseMode()
	{
		return _PInvoke() == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_GetRelativeMouseMode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Create a cursor using the specified bitmap data and mask (in MSB format).
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CreateCursor">here</see> for more details.
	/// </remarks>
	/// <param name="data"> The color value for each pixel of the cursor. </param>
	/// <param name="mask"> The mask value for each pixel of the cursor. </param>
	/// <param name="width"> The width of the cursor, must be a multiple of 8 bits. </param>
	/// <param name="height"> The height of the cursor. </param>
	/// <param name="hotX"> The x-axis offset from the left of the cursor image to the mouse x position, in the range of 0 to <paramref name="width"/> - 1. </param>
	/// <param name="hotY"> The y-axis offset from the top of the cursor image to the mouse y position, in the range of 0 to <paramref name="height"/> - 1. </param>
	/// <returns> A new cursor with the specified parameters on success or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Cursor* CreateCursor(byte[] data, byte[] mask, int width, int height, int hotX, int hotY) // CHECK:overload
	{
		fixed (byte* dataPtr = data, maskPtr = mask)
		{
			return _PInvoke(dataPtr, maskPtr, width, height, hotX, hotY);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_CreateCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Cursor* _PInvoke(byte* data, byte* mask, int width, int height, int hotX, int hotY);
	}

	/// <summary>
	/// Create a color cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CreateColorCursor">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> An <see cref="SDL_Surface"/> structure representing the cursor image. </param>
	/// <param name="hotX"> The x position of the cursor hot spot. </param>
	/// <param name="hotY"> The y position of the cursor hot spot. </param>
	/// <returns> The new cursor on success or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Cursor* CreateCursor(SDL_Surface* surface, int hotX, int hotY) // CHECK:overload
	{
		// i'm not sure if an overload is appropiate here, but i'll leave it like this for now.
		return _PInvoke(surface, hotX, hotY);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateColorCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Cursor* _PInvoke(SDL_Surface* surface, int hotX, int hotY);
	}

	/// <summary>
	/// Create a system cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CreateSystemCursor">here</see> for more details.
	/// </remarks>
	/// <param name="id"> An <see cref="SDL_SystemCursor"/> enum value. </param>
	/// <returns> A cursor on success or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Cursor* CreateCursor(SDL_SystemCursor id) // CHECK:overload
	{
		return _PInvoke(id);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateSystemCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Cursor* _PInvoke(SDL_SystemCursor id);
	}

	/// <summary>
	/// Set the active cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetCursor">here</see> for more details.
	/// </remarks>
	/// <param name="cursor"> A cursor to make active. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetCursor(SDL_Cursor* cursor)
	{
		return _PInvoke(cursor);

		[DllImport(LibraryName, EntryPoint = "SDL_SetCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Cursor* cursor);
	}

	/// <summary>
	/// Get the active cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetCursor">here</see> for more details.
	/// </remarks>
	/// <returns> The active cursor or null if there is no mouse. </returns>
	public static SDL_Cursor* GetCursor()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Cursor* _PInvoke();
	}

	/// <summary>
	/// Get the default cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetDefaultCursor">here</see> for more details.
	/// </remarks>
	/// <returns> The default cursor on success or null on failure. </returns>
	public static SDL_Cursor* GetDefaultCursor()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetDefaultCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Cursor* _PInvoke();
	}

	/// <summary>
	/// Free a previously-created cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyCursor">here</see> for more details.
	/// </remarks>
	/// <param name="cursor"> The cursor to free. </param>
	public static void DestroyCursor(SDL_Cursor* cursor)
	{
		_PInvoke(cursor);

		[DllImport(LibraryName, EntryPoint = "SDL_DestroyCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Cursor* _PInvoke(SDL_Cursor* cursor);
	}

	/// <summary>
	/// Show the cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_ShowCursor">here</see> for more details.
	/// </remarks>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int ShowCursor()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_ShowCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Hide the cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_HideCursor">here</see> for more details.
	/// </remarks>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int HideCursor()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_HideCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Return whether the cursor is currently being shown.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CursorVisible">here</see> for more details.
	/// </remarks>
	/// <returns> True if the cursor is being shown, or false if the cursor is hidden. </returns>
	public static bool CursorVisible()
	{
		return _PInvoke() == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_CursorVisible", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}
}