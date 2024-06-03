using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace SDL3;

// SDL_mouse.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_mouse.h
unsafe partial class SDL
{
	/// <summary>
	/// Represents an id for a mouse. The structure is a wrapper for an unsigned 32-bit integer.
	/// </summary>
	[Wrapper]
	public readonly struct MouseId
	{
		internal MouseId(uint value)
		{
			_value = value;
		}

		/// <inheritdoc/>
		public override bool Equals([NotNullWhen(true)] object? obj)
		{
			if (obj is MouseId cast)
			{
				return _value == cast._value;
			}
			return false;
		}

		/// <inheritdoc/>
		public override int GetHashCode()
		{
			return _value.GetHashCode();
		}

		public static explicit operator uint(MouseId x) => x._value;
		public static explicit operator MouseId(uint x) => new(x);

		public static bool operator ==(MouseId a, MouseId b) => a._value == b._value;
		public static bool operator !=(MouseId a, MouseId b) => a._value != b._value;

		private readonly uint _value;
	}

	/// <summary>
	/// The structure that represents a cursor in SDL. This structure is an opaque type.
	/// </summary>
	[Opaque]
	public readonly struct Cursor;

	/// <summary>
	/// Cursor types for <see cref="CreateCursor(SystemCursor)"/>.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SystemCursor">here</see>.
	/// </remarks>
	public enum SystemCursor
	{
		/// <summary>
		/// Default cursor. Usually an arrow.
		/// </summary>
		Default,

		/// <summary>
		/// I-beam.
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
		NorthwestSoutheastResize,

		/// <summary>
		/// Double arrow pointing northeast and southwest.
		/// </summary>
		NortheastSouthwestResize,

		/// <summary>
		/// Double arrow pointing west and east.
		/// </summary>
		EastWestResize,

		/// <summary>
		/// Double arrow pointing north and south.
		/// </summary>
		NorthSouthResize,

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
		/// Window resize top-left (or <see cref="NorthwestSoutheastResize"/>).
		/// </summary>
		NorthwestResize,

		/// <summary>
		/// Window resize top (or <see cref="NorthSouthResize"/>).
		/// </summary>
		NorthResize,

		/// <summary>
		/// Window resize top-right (or <see cref="NortheastSouthwestResize"/>)
		/// </summary>
		NortheastResize,

		/// <summary>
		/// Window resize right (or <see cref="EastWestResize"/>).
		/// </summary>
		EastResize,

		/// <summary>
		/// Window resize bottom-right (or <see cref="NorthwestSoutheastResize"/>)
		/// </summary>
		SoutheastResize,

		/// <summary>
		/// Window resize bottom (or <see cref="NorthSouthResize"/>).
		/// </summary>
		SouthResize,

		/// <summary>
		/// Window resize bottom-left (or <see cref="NortheastSouthwestResize"/>).
		/// </summary>
		SouthwestResize,

		/// <summary>
		/// Window resize left (or <see cref="EastWestResize"/>). 
		/// </summary>
		WestResize
	}

	/// <summary>
	/// Scroll direction types for the Scroll event.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_MouseWheelDirection">here</see>.
	/// </remarks>
	public enum MouseWheelDirection
	{
		/// <summary>
		/// The scroll direction is normal.
		/// </summary>
		Normal,

		/// <summary>
		/// The scroll direction is flipped / natural.
		/// </summary>
		Flipped
	}

	/// <summary>
	/// Enumeration of mouse buttons.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">here</see>.
	/// </remarks>
	public enum MouseButtonType : byte
	{
		/// <summary>
		/// Left mouse button.
		/// </summary>
		Left = 1,

		/// <summary>
		/// Middle mouse button.
		/// </summary>
		Middle = 2,

		/// <summary>
		/// Right mouse button.
		/// </summary>
		Right = 3,

		/// <summary>
		/// Side mouse button 1.
		/// </summary>
		X1 = 4,

		/// <summary>
		/// Side mouse button 2.
		/// </summary>
		X2 = 5
	}

	/// <summary>
	/// A bitmask of pressed mouse buttons, as reported by <see cref="GetMouseState(out float, out float)"/>, etc.
	/// </summary>
	[Flags]
	public enum MouseButtonFlags : uint
	{
		Lmask = 1u << (MouseButtonType.Left - 1),
		Mmask = 1u << (MouseButtonType.Middle - 1),
		Rmask = 1u << (MouseButtonType.Right - 1),
		X1mask = 1u << (MouseButtonType.X1 - 1),
		X2mask = 1u << (MouseButtonType.X2 - 1)
	}

	/// <summary>
	/// Return whether a mouse is currently connected.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_HasMouse">here</see>.
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
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetMice">here</see>.
	/// </remarks>
	/// <param name="count"> Returns the number of mice returned </param>
	/// <returns> An array of mouse instance ids or null on error; call <see cref="GetError"/> for more details. </returns>
	public static MouseId[]? GetMice(out int count)
	{
		fixed (int* c = &count)
		{
			MouseId* m = _PInvoke(c);
			if (m is null)
			{
				return null;
			}
			var mice = new MouseId[count];
			for (int i = 0; i < count; i++)
			{
				mice[i] = m[i];
			}
			Free(m);
			return mice;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetMice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern MouseId* _PInvoke(int* count);
	}

	/// <summary>
	/// Get the name of a mouse.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetMouseInstanceName">here</see>.
	/// </remarks>
	/// <param name="mouseId"> The mouse instance id. </param>
	/// <returns> The name of the selected mouse, or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static string? GetMouseInstanceName(MouseId mouseId)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(mouseId));

		[DllImport(LibraryName, EntryPoint = "SDL_GetMouseInstanceName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(MouseId mouseId);
	}

	/// <summary>
	/// Get the window which currently has mouse focus.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetMouseFocus">here</see>.
	/// </remarks>
	/// <returns> The windows with mouse focus. </returns>
	public static Window* GetMouseFocus()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetMouseFocus", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Window* _PInvoke();
	}

	/// <summary>
	/// Retrieve the current state of the mouse.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetMouseState">here</see>.
	/// </remarks>
	/// <param name="x"> Returns the x coordinate of the mouse cursor position relative to the focus window. </param>
	/// <param name="y"> Returns the y coordinate of the mouse cursor position relative to the focus window. </param>
	/// <returns> A 32-bit button bitmask of the current button state. </returns>
	public static MouseButtonFlags GetMouseState(out float x, out float y)
	{
		fixed (float* xx = &x, yy = &y)
		{
			return _PInvoke(xx, yy);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetMouseState", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern MouseButtonFlags _PInvoke(float* x, float* y);
	}

	/// <summary>
	/// Get the current state of the mouse in relation to the desktop.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetGlobalMouseState">here</see>.
	/// </remarks>
	/// <param name="x"> Returns the current X coord relative to the desktop. </param>
	/// <param name="y"> Returns the current X coord relative to the desktop. </param>
	/// <returns> The current button state as a bitmask. </returns>
	public static MouseButtonFlags GetGlobalMouseState(out float x, out float y)
	{
		fixed (float* xx = &x, yy = &y)
		{
			return _PInvoke(xx, yy);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetGlobalMouseState", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern MouseButtonFlags _PInvoke(float* x, float* y);
	}
	
	/// <summary>
	/// Retrieve the relative state of the mouse.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetRelativeMouseState">here</see>.
	/// </remarks>
	/// <param name="x"> Returns the last recorded x coordinate of the mouse. </param>
	/// <param name="y"> Returns the last recorded y coordinate of the mouse. </param>
	/// <returns> A 32-bit button bitmask of the relative button state. </returns>
	public static MouseButtonFlags GetRelativeMouseState(out float x, out float y)
	{
		fixed (float* xx = &x, yy = &y)
		{
			return _PInvoke(xx, yy);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetRelativeMouseState", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern MouseButtonFlags _PInvoke(float* x, float* y);
	}

	/// <summary>
	/// Move the mouse cursor to the given position within the window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_WarpMouseInWindows">here</see>.
	/// </remarks>
	/// <param name="window"> The window to move the mouse into, or null for the current mouse focus. </param>
	/// <param name="x"> The x coordinate within the window. </param>
	/// <param name="y"> The y coordinate within the window. </param>
	public static void WarpMouseInWindows(Window* window, float x, float y)
	{
		_PInvoke(window, x, y);

		[DllImport(LibraryName, EntryPoint = "SDL_WarpMouseInWindows", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(Window* window, float x, float y);
	}

	/// <summary>
	/// Move the mouse to the given position in global screen space.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_WarpMouseGlobal">here</see>.
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
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetRelativeMouseMode">here</see>.
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
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CaptureMouse">here</see>.
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
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetRelativeMouseMode">here</see>.
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
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreateCursor">here</see>.
	/// </remarks>
	/// <param name="data"> The color value for each pixel of the cursor. </param>
	/// <param name="mask"> The mask value for each pixel of the cursor. </param>
	/// <param name="width"> The width of the cursor, must be a multiple of 8 bits. </param>
	/// <param name="height"> The height of the cursor. </param>
	/// <param name="hotX"> The x-axis offset from the left of the cursor image to the mouse x position, in the range of 0 to <paramref name="width"/> - 1. </param>
	/// <param name="hotY"> The y-axis offset from the top of the cursor image to the mouse y position, in the range of 0 to <paramref name="height"/> - 1. </param>
	/// <returns> A new cursor with the specified parameters on success or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static Cursor* CreateCursor(byte[] data, byte[] mask, int width, int height, int hotX, int hotY) // CHECK:overload
	{
		fixed (byte* d = data, m = mask)
		{
			return _PInvoke(d, m, width, height, hotX, hotY);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_CreateCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Cursor* _PInvoke(byte* data, byte* mask, int width, int height, int hotX, int hotY);
	}

	/// <summary>
	/// Create a color cursor.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreateColorCursor">here</see>.
	/// </remarks>
	/// <param name="surface"> A <see cref="Surface"/> structure representing the cursor image. </param>
	/// <param name="hotX"> The x position of the cursor hot spot. </param>
	/// <param name="hotY"> The y position of the cursor hot spot. </param>
	/// <returns> The new cursor on success or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static Cursor* CreateCursor(Surface* surface, int hotX, int hotY) // CHECK:overload
	{
		// i'm not sure if an overload is appropiate here, but i'll leave it like this for now.
		return _PInvoke(surface, hotX, hotY);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateColorCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Cursor* _PInvoke(Surface* surface, int hotX, int hotY);
	}

	/// <summary>
	/// Create a system cursor.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreateSystemCursor">here</see>.
	/// </remarks>
	/// <param name="id"> A <see cref="SystemCursor"/> enum value. </param>
	/// <returns> A cursor on success or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static Cursor* CreateCursor(SystemCursor id) // CHECK:overload
	{
		return _PInvoke(id);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateSystemCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Cursor* _PInvoke(SystemCursor id);
	}

	/// <summary>
	/// Set the active cursor.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetCursor">here</see>.
	/// </remarks>
	/// <param name="cursor"> A cursor to make active. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetCursor(Cursor* cursor)
	{
		return _PInvoke(cursor);

		[DllImport(LibraryName, EntryPoint = "SDL_SetCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Cursor* cursor);
	}

	/// <summary>
	/// Get the active cursor.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetCursor">here</see>.
	/// </remarks>
	/// <returns> The active cursor or null if there is no mouse. </returns>
	public static Cursor* GetCursor()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Cursor* _PInvoke();
	}

	/// <summary>
	/// Get the default cursor.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetDefaultCursor">here</see>.
	/// </remarks>
	/// <returns> The default cursor on success or null on failure. </returns>
	public static Cursor* GetDefaultCursor()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetDefaultCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Cursor* _PInvoke();
	}

	/// <summary>
	/// Free a previously-created cursor.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyCursor">here</see>.
	/// </remarks>
	/// <param name="cursor"> The cursor to free. </param>
	public static void DestroyCursor(Cursor* cursor)
	{
		_PInvoke(cursor);

		[DllImport(LibraryName, EntryPoint = "SDL_DestroyCursor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Cursor* _PInvoke(Cursor* cursor);
	}

	/// <summary>
	/// Show the cursor.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ShowCursor">here</see>.
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
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_HideCursor">here</see>.
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
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CursorVisible">here</see>.
	/// </remarks>
	/// <returns> True if the cursor is being shown, or false if the cursor is hidden. </returns>
	public static bool CursorVisible()
	{
		return _PInvoke() == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_CursorVisible", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}
}