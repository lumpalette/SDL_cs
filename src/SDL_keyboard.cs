using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace SDL3;

// SDL_keyboard.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_keyboard.h
unsafe partial class SDL
{
	/// <summary>
	/// Represents a unique id for a keyboard. The structure is a wrapper for an unsigned 32-bit integer.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_KeyboardID">here</see>.
	/// </remarks>
	[Wrapper]
	public readonly struct KeyboardId
	{
		internal KeyboardId(uint value)
		{
			_value = value;
		}

		/// <inheritdoc/>
		public override bool Equals([NotNullWhen(true)] object? obj)
		{
			if (obj is KeyboardId cast)
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

		public static explicit operator uint(KeyboardId x) => x._value;
		public static explicit operator KeyboardId(uint x) => new(x);

		public static bool operator ==(KeyboardId a, KeyboardId b) => a._value == b._value;
		public static bool operator !=(KeyboardId a, KeyboardId b) => a._value != b._value;

		private readonly uint _value;
	}

	/// <summary>
	/// The SDL keysym structure, used in key events.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_Keysym">here</see>.
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	public struct Keysym
	{
		/// <summary>
		/// SDL physical key code - see <see cref="SDL.Scancode"/> for details.
		/// </summary>
		public Scancode Scancode;

		/// <summary>
		/// SDL virtual key code - see <see cref="Keycode"/> for details.
		/// </summary>
		public Keycode Sym;

		/// <summary>
		/// Current key modifiers.
		/// </summary>
		public Keymod Mod;

		private readonly ushort _unused;
	}

	/// <summary>
	/// Return whether a keyboard is currently connected.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_HasKeyboard">here</see>.
	/// </remarks>
	/// <returns> True if a keyboard is connected, false otherwise. </returns>
	public static bool HasKeyboard()
	{
		return _PInvoke() == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_HasKeyboard", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Get a list of currently connected keyboards.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyboards">here</see>.
	/// </remarks>
	/// <param name="count"> Returns the number of keyboards returned. </param>
	/// <returns> An array of keyboard instance ids, or null on error; call <see cref="GetError"/> for more details. </returns>
	public static KeyboardId[]? GetKeyboards(out int count)
	{
		fixed (int* c = &count)
		{
			KeyboardId* k = _PInvoke(c);
			if (k is null)
			{
				return null;
			}
			var keyboards = new KeyboardId[count];
			for (int i = 0; i < count; i++)
			{
				keyboards[i] = k[i];
			}
			Free(k);
			return keyboards;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetKeyboards", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern KeyboardId* _PInvoke(int* count);
	}

	/// <summary>
	/// Get the name of a keyboard.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyboardInstanceName">here</see>.
	/// </remarks>
	/// <param name="keyboardId"> The keyboard instance id. </param>
	/// <returns> The name of the selected keyboard, or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static string? GetKeyboardInstanceName(KeyboardId keyboardId)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(keyboardId));

		[DllImport(LibraryName, EntryPoint = "SDL_GetKeyboardInstanceName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(KeyboardId keyboardId);
	}

	/// <summary>
	/// Query the window which currently has keyboard focus.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyboardFocus">here</see>.
	/// </remarks>
	/// <returns> The window with keyboard focus. </returns>
	public static Window* GetKeyboardFocus()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetKeyboardFocus", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Window* _PInvoke();
	}

	/// <summary>
	/// Get a snapshot of the current state of the keyboard.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyboardState">here</see>.
	/// </remarks>
	/// <param name="numKeys"> Returns the length of the returned array (<see cref="Scancode.NumScancodes"/>). </param>
	/// <returns> A pointer to an array of key states. </returns>
	public static byte* GetKeyboardState(out int numKeys)
	{
		fixed (int* n = &numKeys)
		{
			return _PInvoke(n);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetKeyboardState", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(int* numKeys);
	}

	/// <summary>
	/// Clear the state of the keyboard.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ResetKeyboard">here</see>.
	/// </remarks>
	public static void ResetKeyboard()
	{
		_PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_ResetKeyboard", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke();
	}

	/// <summary>
	/// Get the current key modifier state for the keyboard.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetModState">here</see>.
	/// </remarks>
	/// <returns> An OR'd combination of the modifier keys for the keyboard. See <see cref="Keymod"/> for details. </returns>
	public static Keymod GetModState()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetModState", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Keymod _PInvoke();
	}

	/// <summary>
	/// Set the current key modifier state for the keyboard.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetModState">here</see>.
	/// </remarks>
	/// <param name="modState"> The desired <see cref="Keymod"/> for the keyboard. </param>
	public static void SetModState(Keymod modState)
	{
		_PInvoke(modState);

		[DllImport(LibraryName, EntryPoint = "SDL_SetModState", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(Keymod modState);
	}

	/// <summary>
	/// Get the key code corresponding to the given scancode according to the current keyboard layout.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyFromScancode">here</see>.
	/// </remarks>
	/// <param name="scancode"> The desired <see cref="Scancode"/> to query. </param>
	/// <returns> The <see cref="Keycode"/> that corresponds to the given <see cref="Scancode"/>. </returns>
	public static Keycode GetKeyFromScancode(Scancode scancode)
	{
		return _PInvoke(scancode);

		[DllImport(LibraryName, EntryPoint = "SDL_GetKeyFromScancode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Keycode _PInvoke(Scancode scancode);
	}

	/// <summary>
	/// Get the scancode corresponding to the given key code according to the current keyboard layout.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetScancodeFromKey">here</see>.
	/// </remarks>
	/// <param name="key"> The desired <see cref="Keycode"/> to query </param>
	/// <returns> The <see cref="Scancode"/> that corresponds to the given <see cref="Keycode"/>. </returns>
	public static Scancode GetScancodeFromKey(Keycode key)
	{
		return _PInvoke(key);

		[DllImport(LibraryName, EntryPoint = "SDL_GetScancodeFromKey", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Scancode _PInvoke(Keycode key);
	}

	/// <summary>
	/// Get a human-readable name for a scancode.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetScancodeName">here</see>.
	/// </remarks>
	/// <param name="scancode"> The desired <see cref="Scancode"/> to query. </param>
	/// <returns> The name for the scancode. If the scancode doesn't have a name this function returns an empty string. </returns>
	public static string GetScancodeName(Scancode scancode)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(scancode))!;

		[DllImport(LibraryName, EntryPoint = "SDL_GetScancodeName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(Scancode scancode);
	}

	/// <summary>
	/// Get a scancode from a human-readable name.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetScancodeFromName">here</see>.
	/// </remarks>
	/// <param name="name"> The human-readable scancode name. </param>
	/// <returns> The <see cref="Scancode"/>, or <see cref="Scancode.Unknown"/> if the name wasn't recognized; call <see cref="GetError"/> for more information. </returns>
	public static Scancode GetScancodeFromName(string name)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return _PInvoke(n);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetScancodeFromName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Scancode _PInvoke(byte* name);
	}

	/// <summary>
	/// Get a human-readable name for a key.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyName">here</see>.
	/// </remarks>
	/// <param name="key"> The desired <see cref="Keycode"/> to query. </param>
	/// <returns> The name of the key. If the key doesn't have a name, this function returns an empty string. </returns>
	public static string GetKeyName(Keycode key)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(key))!;

		[DllImport(LibraryName, EntryPoint = "SDL_GetKeyName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(Keycode key);
	}

	/// <summary>
	/// Get a key code from a human-readable name.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyFromName">here</see>.
	/// </remarks>
	/// <param name="name"> The human-readable key name. </param>
	/// <returns> The <see cref="Keycode"/>, or <see cref="Keycode.Unknown"/> if the name wasn't recognized; call <see cref="GetError"/> for more information. </returns>
	public static Keycode GetKeyFromName(string name)
	{
		fixed (byte* n = Encoding.UTF8.GetBytes(name))
		{
			return _PInvoke(n);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetKeyFromName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Keycode _PInvoke(byte* name);
	}

	/// <summary>
	/// Start accepting Unicode text input events.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_StartTextInput">here</see>.
	/// </remarks>
	public static void StartTextInput()
	{
		_PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_StartTextInput", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke();
	}

	/// <summary>
	/// Check whether or not Unicode text input events are enabled.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_TextInputActive">here</see>.
	/// </remarks>
	/// <returns> True if text input events are enabled else false. </returns>
	public static bool TextInputActive()
	{
		return _PInvoke() == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_TextInputActive", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Stop receiving any text input events.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_StopTextInput">here</see>.
	/// </remarks>
	public static void StopTextInput()
	{
		_PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_StopTextInput", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke();
	}

	/// <summary>
	/// Dismiss the composition window/IME without disabling the subsystem.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ClearComposition">here</see>.
	/// </remarks>
	public static void ClearComposition()
	{
		_PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_ClearComposition", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke();
	}

	/// <summary>
	/// Set the rectangle used to type Unicode text inputs.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextInputRect">here</see>.
	/// </remarks>
	/// <param name="rect"> The <see cref="Rect"/> structure representing the rectangle to receive text (ignored if null). </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextInputRect(Rect? rect)
	{
		if (rect.HasValue)
		{
			Rect r = rect.Value;
			return _PInvoke(&r);
		}
		return _PInvoke(null);

		[DllImport(LibraryName, EntryPoint = "SDL_SetTextInputRect", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Rect* rect);
	}

	/// <summary>
	/// Check whether the platform has screen keyboard support.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_HasScreenKeyboardSupport">here</see>.
	/// </remarks>
	/// <returns> True if the platform has some screen keyboard support or false if not. </returns>
	public static bool HasScreenKeyboardSupport()
	{
		return _PInvoke() == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_HasScreenKeyboardSupport", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Check whether the screen keyboard is shown for given window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ScreenKeyboardShown">here</see>.
	/// </remarks>
	/// <param name="window"> The window for which screen keyboard should be queried. </param>
	/// <returns> True if screen keyboard is shown or false if not. </returns>
	public static bool ScreenKeyboardShown(Window* window)
	{
		return _PInvoke(window) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_ScreenKeyboardShown", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window);
	}
}