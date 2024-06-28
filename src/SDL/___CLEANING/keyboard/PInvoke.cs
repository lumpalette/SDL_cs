using System.Runtime.InteropServices;
using System.Text;

namespace SDL_cs;

// SDL_keyboard.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_keyboard.h
unsafe partial class SDL
{
	/// <summary>
	/// Return whether a keyboard is currently connected.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasKeyboard">documentation</see> for more details.
	/// </remarks>
	/// <returns> True if a keyboard is connected, false otherwise. </returns>
	public static bool HasKeyboard()
	{
		return _PInvoke() == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_HasKeyboard", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Get a list of currently connected keyboards.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyboards">documentation</see> for more details.
	/// </remarks>
	/// <param name="count"> Returns the number of keyboards returned. </param>
	/// <returns> An array of keyboard instance ids, or null on error; call <see cref="GetError"/> for more details. </returns>
	public static SDL_KeyboardId[]? GetKeyboards(out int count)
	{
		fixed (int* countPtr = &count)
		{
			SDL_KeyboardId* keyboardsPtr = _PInvoke(countPtr);
			if (keyboardsPtr is null)
			{
				return null;
			}
			SDL_KeyboardId[] keyboards = new SDL_KeyboardId[count];
			for (int i = 0; i < count; i++)
			{
				keyboards[i] = keyboardsPtr[i];
			}
			Free(keyboardsPtr);
			return keyboards;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetKeyboards", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_KeyboardId* _PInvoke(int* count);
	}

	/// <summary>
	/// Get the name of a keyboard.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyboardInstanceName">documentation</see> for more details.
	/// </remarks>
	/// <param name="keyboardId"> The keyboard instance ID. </param>
	/// <returns> The name of the selected keyboard, or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static string? GetKeyboardInstanceName(SDL_KeyboardId keyboardId)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(keyboardId));

		[DllImport(LibraryName, EntryPoint = "SDL_GetKeyboardInstanceName", CallingConvention = CallingConvention.Cdecl)]
		static extern byte* _PInvoke(SDL_KeyboardId keyboardId);
	}

	/// <summary>
	/// Query the window which currently has keyboard focus.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyboardFocus">documentation</see> for more details.
	/// </remarks>
	/// <returns> The window with keyboard focus. </returns>
	public static SDL_Window* GetKeyboardFocus()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetKeyboardFocus", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Window* _PInvoke();
	}

	/// <summary>
	/// Get a snapshot of the current state of the keyboard.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyboardState">documentation</see> for more details.
	/// </remarks>
	/// <param name="numKeys"> Returns the length of the returned. </param>
	/// <returns> A pointer to an array of key states. </returns>
	public static byte* GetKeyboardState(out int numKeys)
	{
		fixed (int* numKeysPtr = &numKeys)
		{
			return _PInvoke(numKeysPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetKeyboardState", CallingConvention = CallingConvention.Cdecl)]
		static extern byte* _PInvoke(int* numKeys);
	}

	/// <summary>
	/// Clear the state of the keyboard.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ResetKeyboard">documentation</see> for more details.
	/// </remarks>
	public static void ResetKeyboard()
	{
		_PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_ResetKeyboard", CallingConvention = CallingConvention.Cdecl)]
		static extern void _PInvoke();
	}

	/// <summary>
	/// Get the current key modifier state for the keyboard.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetModState">documentation</see> for more details.
	/// </remarks>
	/// <returns> An OR'd combination of the modifier keys for the keyboard. See <see cref="SDL_Keymod"/> for details. </returns>
	public static SDL_Keymod GetModState()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetModState", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Keymod _PInvoke();
	}

	/// <summary>
	/// Set the current key modifier state for the keyboard.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetModState">documentation</see> for more details.
	/// </remarks>
	/// <param name="modState"> The desired <see cref="SDL_Keymod"/> for the keyboard. </param>
	public static void SetModState(SDL_Keymod modState)
	{
		_PInvoke(modState);

		[DllImport(LibraryName, EntryPoint = "SDL_SetModState", CallingConvention = CallingConvention.Cdecl)]
		static extern void _PInvoke(SDL_Keymod modState);
	}

	/// <summary>
	/// Get the key code corresponding to the given scancode according to a default en_US keyboard layout.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDefaultKeyFromScancode">documentation</see> for more details.
	/// </remarks>
	/// <param name="scancode"> The desired <see cref="SDL_Scancode"/> to query. </param>
	/// <returns> The <see cref="SDL_Keycode"/> that corresponds to the given <see cref="SDL_Scancode"/>. </returns>
	public static SDL_Keycode GetDefaultKeyFromScancode(SDL_Scancode scancode)
	{
		return _PInvoke(scancode);

		[DllImport(LibraryName, EntryPoint = "SDL_GetDefaultKeyFromScancode", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Keycode _PInvoke(SDL_Scancode scancode);
	}

	/// <summary>
	/// Get the key code corresponding to the given scancode according to the current keyboard layout.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyFromScancode">documentation</see> for more details.
	/// </remarks>
	/// <param name="scancode"> The desired <see cref="SDL_Scancode"/> to query. </param>
	/// <param name="modState"> The modifier state to use when translating the scancode to a keycode. </param>
	/// <returns> The <see cref="SDL_Keycode"/> that corresponds to the given <see cref="SDL_Scancode"/>. </returns>
	public static SDL_Keycode GetKeyFromScancode(SDL_Scancode scancode, SDL_Keymod modState)
	{
		return _PInvoke(scancode, modState);

		[DllImport(LibraryName, EntryPoint = "SDL_GetKeyFromScancode", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Keycode _PInvoke(SDL_Scancode scancode, SDL_Keymod modState);
	}

	/// <summary>
	/// Get the scancode corresponding to the given key code according to a default en_US keyboard layout.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDefaultScancodeFromKey">documentation</see> for more details.
	/// </remarks>
	/// <param name="key"> The desired <see cref="SDL_Keycode"/> to query. </param>
	/// <param name="modState"> The modifier state that would be used when the scancode generates this key. </param>
	/// <returns> The <see cref="SDL_Scancode"/> that corresponds to the given <see cref="SDL_Keycode"/>. </returns>
	public static SDL_Scancode GetDefaultScancodeFromKey(SDL_Keycode key, SDL_Keymod modState)
	{
		return _PInvoke(key, &modState);

		[DllImport(LibraryName, EntryPoint = "SDL_GetDefaultScancodeFromKey", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Scancode _PInvoke(SDL_Keycode key, SDL_Keymod* modState);
	}

	/// <summary>
	/// Get the scancode corresponding to the given key code according to the current keyboard layout.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetScancodeFromKey">documentation</see> for more details.
	/// </remarks>
	/// <param name="key"> The desired <see cref="SDL_Keycode"/> to query </param>
	/// <param name="modState"> The modifier state that would be used when the scancode generates this key. </param>
	/// <returns> The <see cref="SDL_Scancode"/> that corresponds to the given <see cref="SDL_Keycode"/>. </returns>
	public static SDL_Scancode GetScancodeFromKey(SDL_Keycode key, SDL_Keymod modState)
	{
		return _PInvoke(key, &modState);

		[DllImport(LibraryName, EntryPoint = "SDL_GetScancodeFromKey", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Scancode _PInvoke(SDL_Keycode key, SDL_Keymod* modState);
	}

	/// <summary>
	/// Set a human-readable name for a scancode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetScancodeName">documentation</see> for more details.
	/// </remarks>
	/// <param name="scancode"> The desired <see cref="SDL_Scancode"/>. </param>
	/// <param name="name"> The name to use for the scancode. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetScancodeName(SDL_Scancode scancode, string name)
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name))
		{
			return _PInvoke(scancode, namePtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_SetScancodeName", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Scancode scancode, byte* name);
	}

	/// <summary>
	/// Get a human-readable name for a scancode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetScancodeName">documentation</see> for more details.
	/// </remarks>
	/// <param name="scancode"> The desired <see cref="SDL_Scancode"/> to query. </param>
	/// <returns> The name for the scancode. If the scancode doesn't have a name this function returns an empty string. </returns>
	public static string GetScancodeName(SDL_Scancode scancode)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(scancode))!;

		[DllImport(LibraryName, EntryPoint = "SDL_GetScancodeName", CallingConvention = CallingConvention.Cdecl)]
		static extern byte* _PInvoke(SDL_Scancode scancode);
	}

	/// <summary>
	/// Get a scancode from a human-readable name.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetScancodeFromName">documentation</see> for more details.
	/// </remarks>
	/// <param name="name"> The human-readable scancode name. </param>
	/// <returns> The <see cref="SDL_Scancode"/>, or <see cref="SDL_Scancode.Unknown"/> if the name wasn't recognized; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Scancode GetScancodeFromName(string name)
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name))
		{
			return _PInvoke(namePtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetScancodeFromName", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Scancode _PInvoke(byte* name);
	}

	/// <summary>
	/// Get a human-readable name for a key.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyName">documentation</see> for more details.
	/// </remarks>
	/// <param name="key"> The desired <see cref="SDL_Keycode"/> to query. </param>
	/// <returns> The name of the key. If the key doesn't have a name, this function returns an empty string. </returns>
	public static string GetKeyName(SDL_Keycode key)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(key))!;

		[DllImport(LibraryName, EntryPoint = "SDL_GetKeyName", CallingConvention = CallingConvention.Cdecl)]
		static extern byte* _PInvoke(SDL_Keycode key);
	}

	/// <summary>
	/// Get a key code from a human-readable name.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyFromName">documentation</see> for more details.
	/// </remarks>
	/// <param name="name"> The human-readable key name. </param>
	/// <returns> The <see cref="SDL_Keycode"/>, or <see cref="SDL_Keycode.Unknown"/> if the name wasn't recognized; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Keycode GetKeyFromName(string name)
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name))
		{
			return _PInvoke(namePtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetKeyFromName", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Keycode _PInvoke(byte* name);
	}

	/// <summary>
	/// Start accepting Unicode text input events.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_StartTextInput">documentation</see> for more details.
	/// </remarks>
	public static void StartTextInput()
	{
		_PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_StartTextInput", CallingConvention = CallingConvention.Cdecl)]
		static extern void _PInvoke();
	}

	/// <summary>
	/// Check whether or not Unicode text input events are enabled.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_TextInputActive">documentation</see> for more details.
	/// </remarks>
	/// <returns> True if text input events are enabled else false. </returns>
	public static bool TextInputActive()
	{
		return _PInvoke() == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_TextInputActive", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Stop receiving any text input events.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_StopTextInput">documentation</see> for more details.
	/// </remarks>
	public static void StopTextInput()
	{
		_PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_StopTextInput", CallingConvention = CallingConvention.Cdecl)]
		static extern void _PInvoke();
	}

	/// <summary>
	/// Dismiss the composition window/IME without disabling the subsystem.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ClearComposition">documentation</see> for more details.
	/// </remarks>
	public static void ClearComposition()
	{
		_PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_ClearComposition", CallingConvention = CallingConvention.Cdecl)]
		static extern void _PInvoke();
	}

	/// <summary>
	/// Set the rectangle used to type Unicode text inputs.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextInputRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="rect"> The <see cref="SDL_Rect"/> structure representing the rectangle to receive text (ignored if null). </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextInputRect(SDL_Rect* rect)
	{
		return _PInvoke(rect);

		[DllImport(LibraryName, EntryPoint = "SDL_SetTextInputRect", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Rect* rect);
	}

	/// <summary>
	/// Check whether the platform has screen keyboard support.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasScreenKeyboardSupport">documentation</see> for more details.
	/// </remarks>
	/// <returns> True if the platform has some screen keyboard support or false if not. </returns>
	public static bool HasScreenKeyboardSupport()
	{
		return _PInvoke() == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_HasScreenKeyboardSupport", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Check whether the screen keyboard is shown for given window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ScreenKeyboardShown">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window for which screen keyboard should be queried. </param>
	/// <returns> True if screen keyboard is shown or false if not. </returns>
	public static bool ScreenKeyboardShown(SDL_Window* window)
	{
		return _PInvoke(window) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_ScreenKeyboardShown", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window);
	}
}