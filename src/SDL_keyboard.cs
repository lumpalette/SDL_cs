using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SDL3;

// SDL_keyboard.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_keyboard.h
unsafe partial class SDL
{
	/// <summary>
	/// Represents a unique id for a keyboard. This structure serves as a wrapper for an unsigned 32-bit integer.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_KeyboardID">here</see>.
	/// </remarks>
	public readonly struct KeyboardId
	{
		internal KeyboardId(uint value)
		{
			Id = value;
		}

		/// <summary>
		/// An invalid id for a keyboard.
		/// </summary>
		/// <remarks>
		/// This is used when a function that returns a <see cref="KeyboardId"/> instance fails.
		/// </remarks>
		public static KeyboardId Invalid => new();

		/// <summary>
		/// The id value, as an unsigned 32-bit integer.
		/// </summary>
		public readonly uint Id;
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
		return _PInvokeHasKeyboard() == 1;
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_HasKeyboard")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeHasKeyboard();

	/// <summary>
	/// Get a list of currently connected keyboards.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyboards">here</see>.
	/// </remarks>
	/// <param name="count"> Returns the number of keyboards returned. </param>
	/// <returns> An array of keyboard instance IDs, or null on error; call <see cref="GetError"/> for more details. </returns>
	public static KeyboardId[]? GetKeyboards(out int count)
	{
		fixed (int* c = &count)
		{
			KeyboardId* k = _PInvokeGetKeyboards(c);
			if (k is null)
			{
				return null;
			}
			var keyboards = new KeyboardId[count];
			for (int i = 0; i < count; i++)
			{
				keyboards[i] = k[i];
			}
			_PInvokeFree(k);
			return keyboards;
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyboards")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial KeyboardId* _PInvokeGetKeyboards(int* count);

	/// <summary>
	/// Get the name of a keyboard.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyboardInstanceName">here</see>.
	/// </remarks>
	/// <param name="keyboardId"> The keyboard instance ID. </param>
	/// <returns> The name of the selected keyboard, or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static string? GetKeyboardInstanceName(KeyboardId keyboardId)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvokeGetKeyboardInstanceName(keyboardId));
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyboardInstanceName")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial byte* _PInvokeGetKeyboardInstanceName(KeyboardId keyboardId);

	/// <summary>
	/// Query the window which currently has keyboard focus.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyboardFocus">here</see>.
	/// </remarks>
	/// <returns> The window with keyboard focus. </returns>
	public static Window* GetKeyboardFocus()
	{
		return _PInvokeGetKeyboardFocus();
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyboardFocus")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Window* _PInvokeGetKeyboardFocus();

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
			return _PInvokeGetKeyboardState(n);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyboardState")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial byte* _PInvokeGetKeyboardState(int* numKeys);

	/// <summary>
	/// Clear the state of the keyboard.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ResetKeyboard">here</see>.
	/// </remarks>
	public static void ResetKeyboard()
	{
		_PInvokeResetKeyboard();
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_ResetKeyboard")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial void _PInvokeResetKeyboard();

	/// <summary>
	/// Get the current key modifier state for the keyboard.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetModState">here</see>.
	/// </remarks>
	/// <returns> An OR'd combination of the modifier keys for the keyboard. See <see cref="Keymod"/> for details. </returns>
	public static Keymod GetModState()
	{
		return _PInvokeGetModState();
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetModState")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Keymod _PInvokeGetModState();

	/// <summary>
	/// Set the current key modifier state for the keyboard.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetModState">here</see>.
	/// </remarks>
	/// <param name="modState"> The desired <see cref="Keymod"/> for the keyboard. </param>
	public static void SetModState(Keymod modState)
	{
		_PInvokeSetModState(modState);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetModState")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial void _PInvokeSetModState(Keymod modState);

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
		return _PInvokeGetKeyFromScancode(scancode);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyFromScancode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Keycode _PInvokeGetKeyFromScancode(Scancode scancode);

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
		return _PInvokeGetScancodeFromKey(key);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetScancodeFromKey")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Scancode _PInvokeGetScancodeFromKey(Keycode key);

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
		return Marshal.PtrToStringUTF8((nint)_PInvokeGetScancodeName(scancode))!;
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetScancodeName")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial byte* _PInvokeGetScancodeName(Scancode scancode);

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
			return _PInvokeGetScancodeFromName(n);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetScancodeFromName")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Scancode _PInvokeGetScancodeFromName(byte* name);

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
		return Marshal.PtrToStringUTF8((nint)_PInvokeGetKeyName(key))!;
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyName")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial byte* _PInvokeGetKeyName(Keycode key);

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
			return _PInvokeGetKeyFromName(n);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyFromName")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Keycode _PInvokeGetKeyFromName(byte* name);

	/// <summary>
	/// Start accepting Unicode text input events.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_StartTextInput">here</see>.
	/// </remarks>
	public static void StartTextInput()
	{
		_PInvokeStartTextInput();
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_StartTextInput")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial void _PInvokeStartTextInput();

	/// <summary>
	/// Check whether or not Unicode text input events are enabled.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_TextInputActive">here</see>.
	/// </remarks>
	/// <returns> True if text input events are enabled else false. </returns>
	public static bool TextInputActive()
	{
		return _PInvokeTextInputActive() == 1;
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_TextInputActive")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeTextInputActive();

	/// <summary>
	/// Stop receiving any text input events.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_StopTextInput">here</see>.
	/// </remarks>
	public static void StopTextInput()
	{
		_PInvokeStopTextInput();
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_StopTextInput")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial void _PInvokeStopTextInput();

	/// <summary>
	/// Dismiss the composition window/IME without disabling the subsystem.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ClearComposition">here</see>.
	/// </remarks>
	public static void ClearComposition()
	{
		_PInvokeClearComposition();
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_ClearComposition")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial void _PInvokeClearComposition();

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
			return _PInvokeSetTextInputRect(&r);
		}
		return _PInvokeSetTextInputRect(null);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetTextInputRect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetTextInputRect(Rect* rect);

	/// <summary>
	/// Check whether the platform has screen keyboard support.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_HasScreenKeyboardSupport">here</see>.
	/// </remarks>
	/// <returns> True if the platform has some screen keyboard support or false if not. </returns>
	public static bool HasScreenKeyboardSupport()
	{
		return _PInvokeHasScreenKeyboardSupport() == 1;
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_HasScreenKeyboardSupport")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeHasScreenKeyboardSupport();

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
		return _PInvokeScreenKeyboardShown(window) == 1;
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_ScreenKeyboardShown")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeScreenKeyboardShown(Window* window);
}