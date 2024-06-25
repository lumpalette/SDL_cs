using System.Runtime.InteropServices;
using System.Text;

namespace SDL_cs;

// SDL_gamepad.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_gamepad.h.
unsafe partial class SDL
{
	/// <summary>
	/// Add support for gamepads that SDL is unaware of or change the binding of an existing gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AddGamepadMapping">documentation</see> for more details.
	/// </remarks>
	/// <param name="mapping"> The mapping string. </param>
	/// <returns> 1 if a new mapping is added, 0 if an existing mapping is updated, -1 on error; call <see cref="GetError"/> for more information. </returns>
	public static int AddGamepadMapping(string mapping)
	{
		fixed (byte* mappingPtr = Encoding.UTF8.GetBytes(mapping))
		{
			return _PInvoke(mappingPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_AddGamepadMapping", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(byte* mapping);
	}

	/// <summary>
	/// Load a set of gamepad mappings from a file.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AddGamepadMappingsFromFile">documentation</see> for more details.
	/// </remarks>
	/// <param name="file"> The mappings file to load. </param>
	/// <returns> the number of mappings added or -1 on error; call <see cref="GetError"/> for more information. </returns>
	public static int AddGamepadMappingsFromFile(string file)
	{
		fixed (byte* filePtr = Encoding.UTF8.GetBytes(file))
		{
			return _PInvoke(filePtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_AddGamepadMappingsFromFile", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(byte* mapping);
	}

	/// <summary>
	/// Reinitialize the SDL mapping database to its initial state.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ReloadGamepadMappings">documentation</see> for more details.
	/// </remarks>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int ReloadGamepadMappings()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_ReloadGamepadMappings", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Get the current gamepad mappings.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadMappings">documentation</see> for more details.
	/// </remarks>
	/// <param name="count"> Returns the number of mappings. </param>
	/// <returns> An array of the mapping strings or null on error. </returns>
	public static string[]? GetGamepadMappings(out int count)
	{
		fixed (int* countPtr = &count)
		{
			byte** mappingsPtr = _PInvoke(countPtr);
			if (mappingsPtr is null)
			{
				return null;
			}
			string[] mappings = new string[count];
			for (int i = 0; i < count; i++)
			{
				mappings[i] = Marshal.PtrToStringUTF8((nint)mappingsPtr[i])!; // i'll assume this cannot be null.
			}
			Free(mappingsPtr);
			return mappings;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadMappings", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte** _PInvoke(int* count);
	}

	/// <summary>
	/// Get the gamepad mapping string for a given GUID.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadMappingForGUID">documentation</see> for more details.
	/// </remarks>
	/// <param name="guid"> A structure containing the GUID for which a mapping is desired. </param>
	/// <returns> A mapping string or null on error; call <see cref="GetError"/> for more information. </returns>
	public static string? GetGamepadMappingForGuid(SDL_JoystickGuid guid)
	{
		byte* m = _PInvoke(guid);
		if (m is not null)
		{
			string mapping = Marshal.PtrToStringUTF8((nint)m)!;
			Free(m);
			return mapping;
		}
		return null;

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadMappingForGUID", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_JoystickGuid guid);
	}

	/// <summary>
	/// Get the current mapping of a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadMapping">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad you want to get the current mapping for. </param>
	/// <returns> A string that has the gamepad's mapping or null if no mapping is available; call <see cref="GetError"/> for more information. </returns>
	public static string? GetGamepadMapping(SDL_Gamepad* gamepad)
	{
		byte* m = _PInvoke(gamepad);
		if (m is not null)
		{
			string mapping = Marshal.PtrToStringUTF8((nint)m)!;
			Free(m);
			return mapping;
		}
		return null;

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadMapping", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Set the current mapping of a joystick or gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetGamepadMapping">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <param name="mapping"></param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetGamepadMapping(SDL_JoystickId joystickId, string mapping)
	{
		return _PInvoke(joystickId, mapping);

		[DllImport(LibraryName, EntryPoint = "SDL_SetGamepadMapping", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_JoystickId joystickId, string mapping);
	}

	/// <summary>
	/// Return whether a gamepad is currently connected.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasGamepad">documentation</see> for more details.
	/// </remarks>
	/// <returns> True if a gamepad is connected, false otherwise. </returns>
	public static bool HasGamepad()
	{
		return _PInvoke() == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_HasGamepad", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Get a list of currently connected gamepads.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepads">documentation</see> for more details.
	/// </remarks>
	/// <param name="count"> Returns the number of gamepads. </param>
	/// <returns> An array of joystick instance ids, or null on error; call <see cref="GetError"/> for more details. </returns>
	public static SDL_JoystickId[]? GetGamepads(out int count)
	{
		fixed (int* countPtr = &count)
		{
			SDL_JoystickId* gamepadsPtr = _PInvoke(countPtr);
			if (gamepadsPtr is null)
			{
				return null;
			}
			SDL_JoystickId[] gamepads = new SDL_JoystickId[count];
			for (int i = 0; i < count; i++)
			{
				gamepads[i] = gamepadsPtr[i];
			}
			Free(gamepadsPtr);
			return gamepads;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepads", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_JoystickId* _PInvoke(int* count);
	}

	/// <summary>
	/// Check if the given joystick is supported by the gamepad interface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_IsGamepad">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> True if the given joystick is supported by the gamepad interface, false if it isn't or it's an invalid index. </returns>
	public static bool IsGamepad(SDL_JoystickId joystickId)
	{
		return _PInvoke(joystickId) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_IsGamepad", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the implementation dependent name of a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadInstanceName">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> The name of the selected gamepad. If no name can be found, this function returns null; call <see cref="GetError"/> for more information. </returns>
	public static string? GetGamepadInstanceName(SDL_JoystickId joystickId)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(joystickId));

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadInstanceName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the implementation dependent path of a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadInstancePath">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> The path of the selected gamepad. If no path can be found, this function returns null; call <see cref="GetError"/> for more information. </returns>
	public static string? GetGamepadInstancePath(SDL_JoystickId joystickId)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(joystickId));

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadInstancePath", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the player index of a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadInstancePlayerIndex">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> The player index of a gamepad, or -1 if it's not available. </returns>
	public static int GetGamepadInstancePlayerIndex(SDL_JoystickId joystickId)
	{
		return _PInvoke(joystickId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadInstancePlayerIndex", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the implementation-dependent GUID of a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadInstanceGUID">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> The GUID of the selected gamepad. If called on an invalid index, this function returns a zero GUID. </returns>
	public static SDL_JoystickGuid GetGamepadInstanceGuid(SDL_JoystickId joystickId)
	{
		return _PInvoke(joystickId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadInstanceGUID", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_JoystickGuid _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the USB vendor ID of a gamepad, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadInstanceVendor">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> The USB vendor ID of the selected gamepad. If called on an invalid index, this function returns zero. </returns>
	public static ushort GetGamepadInstanceVendor(SDL_JoystickId joystickId)
	{
		return _PInvoke(joystickId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadInstanceVendor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern ushort _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the USB product ID of a gamepad, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadInstanceProduct">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> The USB product ID of the selected gamepad. If called on an invalid index, this function returns zero. </returns>
	public static ushort GetGamepadInstanceProduct(SDL_JoystickId joystickId)
	{
		return _PInvoke(joystickId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadInstanceProduct", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern ushort _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the product version of a gamepad, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadInstanceProductVersion">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> The product version of the selected gamepad. If called on an invalid index, this function returns zero. </returns>
	public static ushort GetGamepadInstanceProductVersion(SDL_JoystickId joystickId)
	{
		return _PInvoke(joystickId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadInstanceProductVersion", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern ushort _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the type of a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadInstanceType">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> The gamepad type. </returns>
	public static SDL_GamepadType GetGamepadInstanceType(SDL_JoystickId joystickId)
	{
		return _PInvoke(joystickId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadInstanceType", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_GamepadType _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the type of a gamepad, ignoring any mapping override.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRealGamepadInstanceType">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> The gamepad type. </returns>
	public static SDL_GamepadType GetRealGamepadInstanceType(SDL_JoystickId joystickId)
	{
		return _PInvoke(joystickId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetRealGamepadInstanceType", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_GamepadType _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the mapping of a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadInstanceMapping">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> The mapping string. Returns null if no mapping is available. </returns>
	public static string? GetGamepadInstanceMapping(SDL_JoystickId joystickId)
	{
		byte* m = _PInvoke(joystickId);
		if (m is not null)
		{
			string mapping = Marshal.PtrToStringUTF8((nint)m)!;
			Free(m);
			return mapping;
		}
		return null;

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadInstanceMapping", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Open a gamepad for use.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_OpenGamepad">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> A gamepad identifier or null if an error occurred; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Gamepad* OpenGamepad(SDL_JoystickId joystickId)
	{
		return _PInvoke(joystickId);

		[DllImport(LibraryName, EntryPoint = "SDL_OpenGamepad", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Gamepad* _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the <see cref="SDL_Gamepad"/> associated with a joystick instance ID, if it has been opened.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadFromInstanceID">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID of the gamepad. </param>
	/// <returns> An <see cref="SDL_Gamepad"/> on success or null on failure or if it hasn't been opened yet; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Gamepad* GetGamepadFromInstanceId(SDL_JoystickId joystickId)
	{
		return _PInvoke(joystickId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadFromInstanceID", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Gamepad* _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the <see cref="SDL_Gamepad"/> associated with a player index.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadFromPlayerIndex">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The player index, which different from the instance ID. </param>
	/// <returns> The <see cref="SDL_Gamepad"/> associated with a player index. </returns>
	public static SDL_Gamepad* GetGamepadFromPlayerIndex(int playerIndex)
	{
		return _PInvoke(playerIndex);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadFromPlayerIndex", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Gamepad* _PInvoke(int playerIndex);
	}

	/// <summary>
	/// Get the properties associated with an opened gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> A gamepad identifier previously returned by <see cref="OpenGamepad(SDL_JoystickId)"/>. </param>
	/// <returns> A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_PropertiesId GetGamepadProperties(SDL_Gamepad* gamepad)
	{
		return _PInvoke(gamepad);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_PropertiesId _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Get the instance ID of an opened gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadInstanceID">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> A gamepad identifier previously returned by <see cref="OpenGamepad(SDL_JoystickId)"/>. </param>
	/// <returns> The instance ID of the specified gamepad on success or 0 on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_JoystickId GetGamepadInstanceId(SDL_Gamepad* gamepad)
	{
		return _PInvoke(gamepad);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadInstanceID", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_JoystickId _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Get the implementation-dependent name for an opened gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadName">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> A gamepad identifier previously returned by <see cref="OpenGamepad(SDL_JoystickId)"/>. </param>
	/// <returns> The implementation dependent name for the gamepad, or null if there is no name or the identifier passed is invalid. </returns>
	public static string? GetGamepadName(SDL_Gamepad* gamepad)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(gamepad));

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Get the implementation-dependent path for an opened gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadPath">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> A gamepad identifier previously returned by <see cref="OpenGamepad(SDL_JoystickId)"/>. </param>
	/// <returns> The implementation dependent path for the gamepad, or null if there is no name or the identifier passed is invalid. </returns>
	public static string? GetGamepadPath(SDL_Gamepad* gamepad)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(gamepad));

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadPath", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Get the type of an opened gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadType">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad object to query. </param>
	/// <returns> The gamepad type, or <see cref="SDL_GamepadType.Unknown"/> if it's not available. </returns>
	public static SDL_GamepadType GetGamepadType(SDL_Gamepad* gamepad)
	{
		return _PInvoke(gamepad);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadType", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_GamepadType _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Get the type of an opened gamepad, ignoring any mapping override.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRealGamepadType">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad object to query. </param>
	/// <returns> The gamepad type, or <see cref="SDL_GamepadType.Unknown"/> if it's not available. </returns>
	public static SDL_GamepadType GetRealGamepadType(SDL_Gamepad* gamepad)
	{
		return _PInvoke(gamepad);

		[DllImport(LibraryName, EntryPoint = "SDL_GetRealGamepadType", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_GamepadType _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Get the player index of an opened gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadPlayerIndex">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad object to query. </param>
	/// <returns> The player index for gamepad, or -1 if it's not available. </returns>
	public static int GetGamepadPlayerIndex(SDL_Gamepad* gamepad)
	{
		return _PInvoke(gamepad);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadPlayerIndex", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Set the player index of an opened gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetGamepadPlayerIndex">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad object to adjust. </param>
	/// <param name="playerIndex"> Player index to assign to this gamepad, or -1 to clear the player index and turn off player LEDs. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetGamepadPlayerIndex(SDL_Gamepad* gamepad, int playerIndex)
	{
		return _PInvoke(gamepad);

		[DllImport(LibraryName, EntryPoint = "SDL_SetGamepadPlayerIndex", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Get the USB vendor ID of an opened gamepad, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadVendor">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad object to query. </param>
	/// <returns> The USB vendor ID, or zero if unavailable. </returns>
	public static ushort GetGamepadVendor(SDL_Gamepad* gamepad)
	{
		return _PInvoke(gamepad);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadVendor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern ushort _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Get the USB product ID of an opened gamepad, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadProduct">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad object to query. </param>
	/// <returns> The USB product ID, or zero if unavailable. </returns>
	public static ushort GetGamepadProduct(SDL_Gamepad* gamepad)
	{
		return _PInvoke(gamepad);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadProduct", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern ushort _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Get the product version of an opened gamepad, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadProductVersion">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad object to query. </param>
	/// <returns> The USB product version, or zero if unavailable. </returns>
	public static ushort GetGamepadProductVersion(SDL_Gamepad* gamepad)
	{
		return _PInvoke(gamepad);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadProductVersion", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern ushort _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Get the firmware version of an opened gamepad, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadFirmwareVersion">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad object to query. </param>
	/// <returns> The gamepad firmware version, or zero if unavailable. </returns>
	public static ushort GetGamepadFirmwareVersion(SDL_Gamepad* gamepad)
	{
		return _PInvoke(gamepad);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadFirmwareVersion", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern ushort _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Get the serial number of an opened gamepad, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadSerial">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad object to query. </param>
	/// <returns> The serial number, or null if is not available. </returns>
	public static string? GetGamepadSerial(SDL_Gamepad* gamepad)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(gamepad));

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadSerial", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Get the Steam Input handle of an opened gamepad, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadSteamHandle">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad object to query. </param>
	/// <returns> The gamepad handle, or 0 if unavailable. </returns>
	public static ulong GetGamepadSteamHandle(SDL_Gamepad* gamepad)
	{
		return _PInvoke(gamepad);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadSteamHandle", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern ulong _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Get the connection state of a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadConnectionState">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad object to query. </param>
	/// <returns> The connection state on success or <see cref="SDL_JoystickConnectionState.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_JoystickConnectionState GetGamepadConnectionState(SDL_Gamepad* gamepad)
	{
		return _PInvoke(gamepad);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadConnectionState", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_JoystickConnectionState _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Get the battery state of a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadPowerInfo">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad object to query. </param>
	/// <param name="percent"> Returns the percentage of battery life left, between 0 and 100. This will return -1 if SDL can't determine a value or there is no battery. </param>
	/// <returns> The current battery state. </returns>
	public static SDL_PowerState GetGamepadPowerInfo(SDL_Gamepad* gamepad, out int percent)
	{
		fixed (int* percentPtr = &percent)
		{
			return _PInvoke(gamepad, percentPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadPowerInfo", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_PowerState _PInvoke(SDL_Gamepad* gamepad, int* percent);
	}

	/// <summary>
	/// Check if a gamepad has been opened and is currently connected.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadConnected">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> A gamepad identifier previously returned by <see cref="OpenGamepad(SDL_JoystickId)"/>. </param>
	/// <returns> True if the gamepad has been opened and is currently connected, or false if not. </returns>
	public static bool GamepadConnected(SDL_Gamepad* gamepad)
	{
		return _PInvoke(gamepad) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_GamepadConnected", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Get the underlying joystick from a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadJoystick">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad object that you want to get a joystick from. </param>
	/// <returns> An <see cref="SDL_Joystick"/> object or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Joystick* GetGamepadJoystick(SDL_Gamepad* gamepad)
	{
		return _PInvoke(gamepad);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadJoystick", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Joystick* _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Set the state of gamepad event processing.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetGamepadEventsEnabled">documentation</see> for more details.
	/// </remarks>
	/// <param name="enabled"> Whether to process gamepad events or not. </param>
	public static void SetGamepadEventsEnabled(bool enabled)
	{
		_PInvoke(enabled ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetGamepadEventsEnabled", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(int enabled);
	}

	/// <summary>
	/// Query the state of gamepad event processing.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadEventsEnabled">documentation</see> for more details.
	/// </remarks>
	/// <returns> True if gamepad events are being processed, false otherwise. </returns>
	public static bool GamepadEventsEnabled()
	{
		return _PInvoke() == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_GamepadEventsEnabled", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Get the SDL joystick layer bindings for a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadBindings">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> A gamepad. </param>
	/// <param name="count"> Returns the number of bindings </param>
	/// <returns> An array of bindings, or null on error; call <see cref="GetError"/> for more details. </returns>
	public static SDL_GamepadBinding[]? GetGamepadBindings(SDL_Gamepad* gamepad, out int count)
	{
		fixed (int* countPtr = &count)
		{
			SDL_GamepadBinding** bindingsPtr = _PInvoke(gamepad, countPtr);
			if (bindingsPtr is null)
			{
				return null;
			}
			SDL_GamepadBinding[] bindings = new SDL_GamepadBinding[count];
			for (int i = 0; i < count; i++)
			{
				bindings[i] = *bindingsPtr[i];
			}
			Free(bindingsPtr);
			return bindings;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadBindings", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_GamepadBinding** _PInvoke(SDL_Gamepad* gamepad, int* count);
	}

	/// <summary>
	/// Manually pump gamepad updates if not using the loop.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateGamepads">documentation</see> for more details.
	/// </remarks>
	public static void UpdateGamepads()
	{
		_PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_UpdateGamepads", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke();
	}

	/// <summary>
	/// Convert a string into <see cref="SDL_GamepadType"/> enum.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadTypeFromString">documentation</see> for more details.
	/// </remarks>
	/// <param name="str"> String representing a <see cref="SDL_GamepadType"/>. </param>
	/// <returns> The <see cref="SDL_GamepadType"/> enum corresponding to the input string, or <see cref="SDL_GamepadType.Unknown"/> if no match was found. </returns>
	public static SDL_GamepadType GetGamepadTypeFromString(string str)
	{
		fixed (byte* strPtr = Encoding.UTF8.GetBytes(str))
		{
			return _PInvoke(strPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadTypeFromString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_GamepadType _PInvoke(byte* str);
	}

	/// <summary>
	/// Convert from an <see cref="SDL_GamepadType"/> enum to a string.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadStringForType">documentation</see> for more details.
	/// </remarks>
	/// <param name="type"> An enum value for a given <see cref="SDL_GamepadType"/>. </param>
	/// <returns> A string for the given type, or null if an invalid type is specified. The string returned is of the format used by <see cref="SDL_Gamepad"/> mapping strings. </returns>
	public static string? GetGamepadStringForType(SDL_GamepadType type)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(type));

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadStringForType", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_GamepadType type);
	}

	/// <summary>
	/// Convert a string into <see cref="SDL_GamepadAxis"/> enum.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadAxisFromString">documentation</see> for more details.
	/// </remarks>
	/// <param name="str"> String representing a <see cref="SDL_GamepadAxis"/>. </param>
	/// <returns> The <see cref="SDL_GamepadAxis"/> enum corresponding to the input string, or <see cref="SDL_GamepadAxis.Invalid"/> if no match was found.  </returns>
	public static SDL_GamepadAxis GetGamepadAxisFromString(string str)
	{
		fixed (byte* strPtr = Encoding.UTF8.GetBytes(str))
		{
			return _PInvoke(strPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadAxisFromString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_GamepadAxis _PInvoke(byte* str);
	}

	/// <summary>
	/// Convert from an SDL_GamepadAxis enum to a string.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadStringForAxis">documentation</see> for more details.
	/// </remarks>
	/// <param name="axis"> An enum value for a given <see cref="SDL_GamepadAxis"/>. </param>
	/// <returns> A string for the given axis, or null if an invalid axis is specified. The string returned is of the format used by <see cref="SDL_Gamepad"/> mapping strings. </returns>
	public static string? GetGamepadStringForAxis(SDL_GamepadAxis axis)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(axis));

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadStringForAxis", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_GamepadAxis axis);
	}

	/// <summary>
	/// Query whether a gamepad has a given axis.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadHasAxis">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> A gamepad. </param>
	/// <param name="axis"> An axis enum value (an <see cref="SDL_GamepadAxis"/> value). </param>
	/// <returns> True if the gamepad has this axis, false otherwise. </returns>
	public static bool GamepadHasAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis)
	{
		return _PInvoke(gamepad, axis) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_GamepadHasAxis", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);
	}

	/// <summary>
	/// Get the current state of an axis control on a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadAxis">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> A gamepad. </param>
	/// <param name="axis"> An axis index (an <see cref="SDL_GamepadAxis"/> value). </param>
	/// <returns> Axis state (including 0) on success or 0 (also) on failure; call <see cref="GetError"/> for more information. </returns>
	public static short GetGamepadAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis)
	{
		return _PInvoke(gamepad, axis);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadAxis", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern short _PInvoke(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);
	}

	/// <summary>
	/// Convert a string into an <see cref="SDL_GamepadButton"/> enum.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadButtonFromString">documentation</see> for more details.
	/// </remarks>
	/// <param name="str"> String representing a <see cref="SDL_GamepadButton"/>. </param>
	/// <returns> The <see cref="SDL_GamepadButton"/> enum corresponding to the input string, or <see cref="SDL_GamepadButton.Invalid"/> if no match was found. </returns>
	public static SDL_GamepadButton GetGamepadButtonFromString(string str)
	{
		fixed (byte* strPtr = Encoding.UTF8.GetBytes(str))
		{
			return _PInvoke(strPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadButtonFromString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_GamepadButton _PInvoke(byte* str);
	}

	/// <summary>
	/// Convert from an SDL_GamepadButton enum to a string.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadStringForButton">documentation</see> for more details.
	/// </remarks>
	/// <param name="button"> An enum value for a given <see cref="SDL_GamepadButton"/>. </param>
	/// <returns> A string for the given button, or null if an invalid button is specified. The string returned is of the format used by <see cref="SDL_Gamepad"/> mapping strings. </returns>
	public static string? GetGamepadStringForButton(SDL_GamepadButton button)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(button));

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadStringForButton", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_GamepadButton button);
	}

	/// <summary>
	/// Query whether a gamepad has a given button.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadHasButton">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> A gamepad. </param>
	/// <param name="button"> A button enum value (an <see cref="SDL_GamepadButton"/> value). </param>
	/// <returns> True if the gamepad has this button, false otherwise. </returns>
	public static bool GamepadHasButton(SDL_Gamepad* gamepad, SDL_GamepadButton button)
	{
		return _PInvoke(gamepad, button) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_GamepadHasButton", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Gamepad* gamepad, SDL_GamepadButton button);
	}

	/// <summary>
	/// Get the current state of a button on a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadButton">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> A gamepad. </param>
	/// <param name="button"> A button index (one of the <see cref="SDL_GamepadButton"/> values). </param>
	/// <returns> 1 for pressed state or 0 for not pressed state or error; call <see cref="GetError"/> for more information. </returns>
	public static byte GetGamepadButton(SDL_Gamepad* gamepad, SDL_GamepadButton button)
	{
		return _PInvoke(gamepad, button);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadButton", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte _PInvoke(SDL_Gamepad* gamepad, SDL_GamepadButton button);
	}

	/// <summary>
	/// Get the label of a button on a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadButtonLabelForType">documentation</see> for more details.
	/// </remarks>
	/// <param name="type"> The type of gamepad to check. </param>
	/// <param name="button"> A button index (one of the <see cref="SDL_GamepadButton"/> values). </param>
	/// <returns> The <see cref="SDL_GamepadButtonLabel"/> enum corresponding to the button label. </returns>
	public static SDL_GamepadButtonLabel GetGamepadButtonLabelForType(SDL_GamepadType type, SDL_GamepadButton button)
	{
		return _PInvoke(type, button);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadButtonLabelForType", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_GamepadButtonLabel _PInvoke(SDL_GamepadType type, SDL_GamepadButton button);
	}

	/// <summary>
	/// Get the label of a button on a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadButtonLabel">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> A gamepad. </param>
	/// <param name="button"> A button index (one of the <see cref="SDL_GamepadButton"/> values). </param>
	/// <returns> The <see cref="SDL_GamepadButtonLabel"/> enum corresponding to the button label. </returns>
	public static SDL_GamepadButtonLabel GetGamepadButtonLabel(SDL_Gamepad* gamepad, SDL_GamepadButton button)
	{
		return _PInvoke(gamepad, button);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadButtonLabel", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_GamepadButtonLabel _PInvoke(SDL_Gamepad* gamepad, SDL_GamepadButton button);
	}

	/// <summary>
	/// Get the number of touchpads on a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumGamepadTouchpads">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> A gamepad. </param>
	/// <returns> The number of touchpads. </returns>
	public static int GetNumGamepadTouchpads(SDL_Gamepad* gamepad)
	{
		return _PInvoke(gamepad);

		[DllImport(LibraryName, EntryPoint = "SDL_GetNumGamepadTouchpads", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Get the number of supported simultaneous fingers on a touchpad on a game gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumGamepadTouchpadFingers">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> A gamepad. </param>
	/// <param name="touchpad"> A touchpad. </param>
	/// <returns> The number of supported simultaneous fingers. </returns>
	public static int GetNumGamepadTouchpadFingers(SDL_Gamepad* gamepad, int touchpad)
	{
		return _PInvoke(gamepad, touchpad);

		[DllImport(LibraryName, EntryPoint = "SDL_GetNumGamepadTouchpadFingers", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Gamepad* gamepad, int touchpad);
	}

	/// <summary>
	/// Return whether a gamepad has a particular sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadHasSensor">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad to query. </param>
	/// <param name="type"> The type of sensor to query. </param>
	/// <returns> True if the sensor exists, false otherwise. </returns>
	public static bool GamepadHasSensor(SDL_Gamepad* gamepad, SDL_SensorType type)
	{
		return _PInvoke(gamepad, type) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_GamepadHasSensor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Gamepad* gamepad, SDL_SensorType type);
	}

	/// <summary>
	/// Set whether data reporting for a gamepad sensor is enabled.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetGamepadSensorEnabled">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad to update. </param>
	/// <param name="type"> The type of sensor to enable/disable. </param>
	/// <param name="enabled"> Whether data reporting should be enabled. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetGamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type, bool enabled)
	{
		return _PInvoke(gamepad, type, enabled ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetGamepadSensorEnabled", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Gamepad* gamepad, SDL_SensorType type, int enabled);
	}

	/// <summary>
	/// Query whether sensor data reporting is enabled for a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadSensorEnabled">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad to query. </param>
	/// <param name="type"> The type of sensor to query. </param>
	/// <returns> True if the sensor is enabled, false otherwise. </returns>
	public static bool GamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type)
	{
		return _PInvoke(gamepad, type) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_GamepadSensorEnabled", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Gamepad* gamepad, SDL_SensorType type);
	}

	/// <summary>
	/// Get the data rate (number of events per second) of a gamepad sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadSensorDataRate">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad to query. </param>
	/// <param name="type"> The type of sensor to query. </param>
	/// <returns> The data rate, or 0.0f if the data rate is not available. </returns>
	public static float GetGamepadSensorDataRate(SDL_Gamepad* gamepad, SDL_SensorType type)
	{
		return _PInvoke(gamepad, type);

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadSensorDataRate", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern float _PInvoke(SDL_Gamepad* gamepad, SDL_SensorType type);
	}

	/// <summary>
	/// Get the current state of a gamepad sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadSensorData">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad to query. </param>
	/// <param name="type"> The type of sensor to query. </param>
	/// <param name="data"> Returns the current sensor state. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetGamepadSensorData(SDL_Gamepad* gamepad, SDL_SensorType type, out float[] data)
	{
		fixed (float* dataPtr = data)
		{
			return _PInvoke(gamepad, type, dataPtr, data.Length);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadSensorData", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Gamepad* gamepad, SDL_SensorType type, float* data, int numValues);
	}

	/// <summary>
	/// Start a rumble effect on a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RumbleGamepad">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad to vibrate. </param>
	/// <param name="lowFrequencyRumble"> The intensity of the low frequency (left) rumble motor, from 0 to 0xFFFF. </param>
	/// <param name="highFrequencyRumble"> The intensity of the high frequency (right) rumble motor, from 0 to 0xFFFF. </param>
	/// <param name="durationMs"> The duration of the rumble effect, in milliseconds. </param>
	/// <returns> 0, or -1 if rumble isn't supported on this gamepad. </returns>
	public static int RumbleGamepad(SDL_Gamepad* gamepad, ushort lowFrequencyRumble, ushort highFrequencyRumble, uint durationMs)
	{
		return _PInvoke(gamepad, lowFrequencyRumble, highFrequencyRumble, durationMs);

		[DllImport(LibraryName, EntryPoint = "SDL_RumbleGamepad", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Gamepad* gamepad, ushort lowFrequencyRumble, ushort highFrequencyRumble, uint durationMs);
	}

	/// <summary>
	/// Start a rumble effect in the gamepad's triggers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RumbleGamepadTriggers">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad to vibrate. </param>
	/// <param name="leftRumble"> The intensity of the left trigger rumble motor, from 0 to 0xFFFF. </param>
	/// <param name="rightRumble"> The intensity of the right trigger rumble motor, from 0 to 0xFFFF. </param>
	/// <param name="durationMs"> The duration of the rumble effect, in milliseconds. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int RumbleGamepadTriggers(SDL_Gamepad* gamepad, ushort leftRumble, ushort rightRumble, uint durationMs)
	{
		return _PInvoke(gamepad, leftRumble, rightRumble, durationMs);

		[DllImport(LibraryName, EntryPoint = "SDL_RumbleGamepadTriggers", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Gamepad* gamepad, ushort leftRumble, ushort rightRumble, uint durationMs);
	}

	/// <summary>
	/// Update a gamepad's LED color.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetGamepadLED">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad to update. </param>
	/// <param name="red"> The intensity of the red LED. </param>
	/// <param name="green"> The intensity of the green LED. </param>
	/// <param name="blue"> The intensity of the blue LED. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetGamepadLed(SDL_Gamepad* gamepad, byte red, byte green, byte blue)
	{
		return _PInvoke(gamepad, red, green, blue);

		[DllImport(LibraryName, EntryPoint = "SDL_SetGamepadLED", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Gamepad* gamepad, byte red, byte green, byte blue);
	}

	/// <summary>
	/// Send a gamepad specific effect packet.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SendGamepadEffect">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad to affect. </param>
	/// <param name="data"> The data to send to the gamepad. </param>
	/// <param name="size"> The size of the data to send to the gamepad. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SendGamepadEffect(SDL_Gamepad* gamepad, void* data, int size)
	{
		return _PInvoke(gamepad, data, size);

		[DllImport(LibraryName, EntryPoint = "SDL_SendGamepadEffect", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Gamepad* gamepad, void* data, int size);
	}

	/// <summary>
	/// Close a gamepad previously opened with <see cref="OpenGamepad(SDL_JoystickId)"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CloseGamepad">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> A gamepad identifier previously returned by <see cref="OpenGamepad(SDL_JoystickId)"/>. </param>
	public static void CloseGamepad(SDL_Gamepad* gamepad)
	{
		_PInvoke(gamepad);

		[DllImport(LibraryName, EntryPoint = "SDL_CloseGamepad", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(SDL_Gamepad* gamepad);
	}

	/// <summary>
	/// Return the sfSymbolsName for a given button on a gamepad on Apple platforms.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadAppleSFSymbolsNameForButton">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad to query. </param>
	/// <param name="button"> A button on the gamepad. </param>
	/// <returns> The sfSymbolsName or null if the name can't be found. </returns>
	public static string? GetGamepadAppleSFSymbolsNameForButton(SDL_Gamepad* gamepad, SDL_GamepadButton button)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(gamepad, button));

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForButton", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_Gamepad* gamepad, SDL_GamepadButton button);
	}

	/// <summary>
	/// Return the sfSymbolsName for a given axis on a gamepad on Apple platforms.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadAppleSFSymbolsNameForAxis">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad"> The gamepad to query. </param>
	/// <param name="axis"> An axis on the gamepad. </param>
	/// <returns> The sfSymbolsName or null if the name can't be found. </returns>
	public static string? GetGamepadAppleSFSymbolsNameForAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(gamepad, axis));

		[DllImport(LibraryName, EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForAxis", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);
	}
}