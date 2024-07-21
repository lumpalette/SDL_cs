using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SDL_cs;

// SDL_gamepad.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_gamepad.h.
public static unsafe partial class SDL
{
	/// <summary>
	/// Add support for gamepads that SDL is unaware of or change the binding of an existing gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AddGamepadMapping">documentation</see> for more details.
	/// </remarks>
	/// <param name="mapping">The mapping string.</param>
	/// <returns>1 if a new mapping is added, 0 if an existing mapping is updated, -1 on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_AddGamepadMapping", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int AddGamepadMapping(string mapping);

	// TODO: implement SDL_AddGamepadMappingsFromIO()

	/// <summary>
	/// Load a set of gamepad mappings from a file.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AddGamepadMappingsFromFile">documentation</see> for more details.
	/// </remarks>
	/// <param name="file">The mappings file to load.</param>
	/// <returns>The number of mappings added or -1 on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_AddGamepadMappingsFromFile", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int AddGamepadMappingsFromFile(string file);

	/// <summary>
	/// Reinitialize the SDL mapping database to its initial state.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ReloadGamepadMappings">documentation</see> for more details.
	/// </remarks>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ReloadGamepadMappings")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int ReloadGamepadMappings();

	/// <summary>
	/// Get the current gamepad mappings.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadMappings">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">A pointer filled in with the number of mappings returned.</param>
	/// <returns>
	/// An array of the mapping strings, null-terminated, or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.
	/// </returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadMappings")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial byte** GetGamepadMappings(out int count);

	/// <summary>
	/// Get the gamepad mapping string for a given GUID.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadMappingForGUID">documentation</see> for more details.
	/// </remarks>
	/// <param name="guid">A structure containing the GUID for which a mapping is desired.</param>
	/// <returns>A mapping string or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadMappingForGUID", StringMarshallingCustomType = typeof(SDLManagedString))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetGamepadMappingForGuid(SDL_JoystickGuid guid);

	/// <summary>
	/// Get the current mapping of a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadMapping">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad you want to get the current mapping for.</param>
	/// <returns>A string that has the gamepad's mapping or <see langword="null"/> if no mapping is available; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadMapping", StringMarshallingCustomType = typeof(SDLManagedString))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetGamepadMapping(SDL_Gamepad* gamepad);

	/// <summary>
	/// Set the current mapping of a joystick or gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetGamepadMapping">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The joystick instance ID.</param>
	/// <param name="mapping">the mapping to use for this device, or <see langword="null"/> to clear the mapping.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetGamepadMapping", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetGamepadMapping(SDL_JoystickId instanceId, string mapping);

	/// <summary>
	/// Return whether a gamepad is currently connected.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasGamepad">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if a gamepad is connected, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasGamepad")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasGamepad();

	/// <summary>
	/// Get a list of currently connected gamepads.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepads">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">A pointer filled in with the number of gamepads returned.</param>
	/// <returns>A null-terminated array of joystick instance IDs or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepads")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_JoystickId* GetGamepads(out int count);

	/// <summary>
	/// Check if the given joystick is supported by the gamepad interface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_IsGamepad">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The joystick instance ID.</param>
	/// <returns>True if the given joystick is supported by the gamepad interface, false if it isn't or it's an invalid index.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_IsGamepad")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool IsGamepad(SDL_JoystickId instanceId);

	/// <summary>
	/// Get the implementation-dependent name of a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadNameForID">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The joystick instance ID.</param>
	/// <returns>The name of the selected gamepad. If no name can be found, this function returns <see langword="null"/>; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadNameForID", StringMarshallingCustomType = typeof(SDLManagedString))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetGamepadNameForId(SDL_JoystickId instanceId);

	/// <summary>
	/// Get the implementation dependent path of a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadPathForID">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The joystick instance ID.</param>
	/// <returns>The path of the selected gamepad. If no path can be found, this function returns <see langword="null"/>; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadPathForID", StringMarshallingCustomType = typeof(SDLManagedString))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetGamepadPathForId(SDL_JoystickId instanceId);

	/// <summary>
	/// Get the player index of a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadPlayerIndexForID">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The joystick instance ID.</param>
	/// <returns>The player index of a gamepad, or -1 if it's not available.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadPlayerIndexForID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetGamepadPlayerIndexForId(SDL_JoystickId instanceId);

	/// <summary>
	/// Get the implementation-dependent GUID of a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadGUIDForID">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The joystick instance ID.</param>
	/// <returns>The GUID of the selected gamepad. If called on an invalid index, this function returns a zero GUID.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadGUIDForID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_JoystickGuid GetGamepadGuidForId(SDL_JoystickId instanceId);

	/// <summary>
	/// Get the USB vendor ID of a gamepad, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadVendorForID">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The joystick instance ID.</param>
	/// <returns>The USB vendor ID of the selected gamepad. If called on an invalid index, this function returns zero.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadVendorForID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial ushort GetGamepadVendorForId(SDL_JoystickId instanceId);

	/// <summary>
	/// Get the USB product ID of a gamepad, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadProductForID">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The joystick instance ID.</param>
	/// <returns>The USB product ID of the selected gamepad. If called on an invalid index, this function returns zero.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadProductForID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial ushort GetGamepadProductForId(SDL_JoystickId instanceId);

	/// <summary>
	/// Get the product version of a gamepad, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadProductVersionForID">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The joystick instance ID.</param>
	/// <returns>The product version of the selected gamepad. If called on an invalid index, this function returns zero.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadProductVersionForID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial ushort GetGamepadProductVersionForId(SDL_JoystickId instanceId);

	/// <summary>
	/// Get the type of a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadTypeForID">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The joystick instance ID.</param>
	/// <returns>The gamepad type.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadTypeForID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_GamepadType GetGamepadTypeForId(SDL_JoystickId instanceId);

	/// <summary>
	/// Get the type of a gamepad, ignoring any mapping override.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRealGamepadTypeForID">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The joystick instance ID.</param>
	/// <returns>The gamepad type.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRealGamepadTypeForID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_GamepadType GetRealGamepadTypeForId(SDL_JoystickId instanceId);

	/// <summary>
	/// Get the mapping of a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadMappingForID">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The joystick instance ID.</param>
	/// <returns>The mapping string. Returns <see langword="null"/> if no mapping is available.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadMappingForID", StringMarshallingCustomType = typeof(SDLManagedString))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetGamepadMappingForId(SDL_JoystickId instanceId);

	/// <summary>
	/// Open a gamepad for use.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_OpenGamepad">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The joystick instance ID.</param>
	/// <returns>A gamepad identifier or <see langword="null"/> if an error occurred; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_OpenGamepad")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Gamepad* OpenGamepad(SDL_JoystickId instanceId);

	/// <summary>
	/// Get the <see cref="SDL_Gamepad"/> associated with a joystick instance ID, if it has been opened.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadFromID">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The joystick instance ID.</param>
	/// <returns>An <see cref="SDL_Gamepad"/> on success or <see langword="null"/> on failure or if it hasn't been opened yet; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadFromID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Gamepad* GetGamepadFromId(SDL_JoystickId instanceId);

	/// <summary>
	/// Get the <see cref="SDL_Gamepad"/> associated with a player index.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadFromPlayerIndex">documentation</see> for more details.
	/// </remarks>
	/// <param name="playerIndex">The player index, which different from the instance ID.</param>
	/// <returns>The <see cref="SDL_Gamepad"/> associated with a player index.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadFromPlayerIndex")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Gamepad* GetGamepadFromPlayerIndex(int playerIndex);

	/// <summary>
	/// Get the properties associated with an opened gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">A gamepad identifier previously returned by <see cref="OpenGamepad(SDL_JoystickId)"/>.</param>
	/// <returns>A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PropertiesId GetGamepadProperties(SDL_Gamepad* gamepad);

	/// <summary>
	/// Get the instance ID of an opened gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadID">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">A gamepad identifier previously returned by <see cref="OpenGamepad(SDL_JoystickId)"/>.</param>
	/// <returns>The instance ID of the specified gamepad on success or <see cref="SDL_JoystickId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_JoystickId GetGamepadId(SDL_Gamepad* gamepad);

	/// <summary>
	/// Get the implementation-dependent name for an opened gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadName">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">A gamepad identifier previously returned by <see cref="OpenGamepad(SDL_JoystickId)"/>.</param>
	/// <returns>The implementation dependent name for the gamepad, or <see langword="null"/> if there is no name or the identifier passed is invalid.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadName", StringMarshallingCustomType = typeof(SDLManagedString))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetGamepadName(SDL_Gamepad* gamepad);

	/// <summary>
	/// Get the implementation-dependent path for an opened gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadPath">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">A gamepad identifier previously returned by <see cref="OpenGamepad(SDL_JoystickId)"/>.</param>
	/// <returns>The implementation dependent path for the gamepad, or <see langword="null"/> if there is no path or the identifier passed is invalid.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadPath", StringMarshallingCustomType = typeof(SDLManagedString))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetGamepadPath(SDL_Gamepad* gamepad);

	/// <summary>
	/// Get the type of an opened gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadType">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad object to query.</param>
	/// <returns>The gamepad type, or <see cref="SDL_GamepadType.Unknown"/> if it's not available.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadType")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_GamepadType GetGamepadType(SDL_Gamepad* gamepad);

	/// <summary>
	/// Get the type of an opened gamepad, ignoring any mapping override.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRealGamepadType">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad object to query.</param>
	/// <returns>The gamepad type, or <see cref="SDL_GamepadType.Unknown"/> if it's not available.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRealGamepadType")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_GamepadType GetRealGamepadType(SDL_Gamepad* gamepad);
	
	/// <summary>
	/// Get the player index of an opened gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadPlayerIndex">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad object to query.</param>
	/// <returns>The player index for gamepad, or -1 if it's not available.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadPlayerIndex")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetGamepadPlayerIndex(SDL_Gamepad* gamepad);

	/// <summary>
	/// Set the player index of an opened gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetGamepadPlayerIndex">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad object to adjust.</param>
	/// <param name="playerIndex">Player index to assign to this gamepad, or -1 to clear the player index and turn off player LEDs.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetGamepadPlayerIndex")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetGamepadPlayerIndex(SDL_Gamepad* gamepad, int playerIndex);

	/// <summary>
	/// Get the USB vendor ID of an opened gamepad, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadVendor">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad object to query.</param>
	/// <returns>The USB vendor ID, or zero if unavailable.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadVendor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial ushort GetGamepadVendor(SDL_Gamepad* gamepad);

	/// <summary>
	/// Get the USB product ID of an opened gamepad, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadProduct">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad object to query.</param>
	/// <returns>The USB product ID, or zero if unavailable.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadProduct")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial ushort GetGamepadProduct(SDL_Gamepad* gamepad);

	/// <summary>
	/// Get the product version of an opened gamepad, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/GetGamepadProductVersion">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad object to query.</param>
	/// <returns>The USB product version, or zero if unavailable.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadProductVersion")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial ushort GetGamepadProductVersion(SDL_Gamepad* gamepad);

	/// <summary>
	/// Get the firmware version of an opened gamepad, if available.
	/// </summary>
	/// <param name="gamepad">The gamepad object to query.</param>
	/// <returns>The gamepad firmware version, or zero if unavailable.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadFirmwareVersion")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial ushort GetGamepadFirmwareVersion(SDL_Gamepad* gamepad);

	/// <summary>
	/// Get the serial number of an opened gamepad, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadSerial">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad object to query.</param>
	/// <returns>The serial number, or <see langword="null"/> if unavailable.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadSerial", StringMarshallingCustomType = typeof(SDLManagedString))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetGamepadSerial(SDL_Gamepad* gamepad);

	/// <summary>
	/// Get the Steam Input handle of an opened gamepad, if available.
	/// </summary>
	/// <param name="gamepad">The gamepad object to query.</param>
	/// <returns>The gamepad handle, or 0 if unavailable.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadSteamHandle")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial ulong GetGamepadSteamHandle(SDL_Gamepad* gamepad);

	/// <summary>
	/// Get the connection state of a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadConnectionState">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad object to query.</param>
	/// <returns>The connection state on success or <see cref="SDL_JoystickConnectionState.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadConnectionState")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_JoystickConnectionState GetGamepadConnectionState(SDL_Gamepad* gamepad);

	/// <summary>
	/// Get the battery state of a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadPowerInfo">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad object to query.</param>
	/// <param name="percent">A pointer filled in with the percentage of battery life left, between 0 and 100. This will be filled in with -1 we can't determine a value or there is no battery.</param>
	/// <returns>The current battery state.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadPowerInfo")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PowerState GetGamepadPowerInfo(SDL_Gamepad* gamepad, out int percent);

	/// <summary>
	/// Check if a gamepad has been opened and is currently connected.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadConnected">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">A gamepad identifier previously returned by <see cref="OpenGamepad(SDL_JoystickId)"/>.</param>
	/// <returns>True if the gamepad has been opened and is currently connected, or false if not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GamepadConnected")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GamepadConnected(SDL_Gamepad* gamepad);

	/// <summary>
	/// Get the underlying joystick from a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadJoystick">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad object that you want to get a joystick from.</param>
	/// <returns>An <see cref="SDL_Joystick"/> object or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadJoystick")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Joystick* GetGamepadJoystick(SDL_Gamepad* gamepad);

	/// <summary>
	/// Set the state of gamepad event processing.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetGamepadEventsEnabled">documentation</see> for more details.
	/// </remarks>
	/// <param name="enabled">Whether to process gamepad events or not.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetGamepadEventsEnabled")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void SetGamepadEventsEnabled([MarshalAs(NativeBool)] bool enabled);

	/// <summary>
	/// Query the state of gamepad event processing.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadEventsEnabled">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if gamepad events are being processed, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GamepadEventsEnabled")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GamepadEventsEnabled();

	/// <summary>
	/// Get the SDL joystick layer bindings for a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadBindings">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">A gamepad.</param>
	/// <param name="count">A pointer filled in with the number of bindings returned.</param>
	/// <returns>A null-terminated array of pointers to bindings or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadBindings")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_GamepadBinding** GetGamepadBindings(SDL_Gamepad* gamepad, out int count);

	/// <summary>
	/// Manually pump gamepad updates if not using the loop.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateGamepads">documentation</see> for more details.
	/// </remarks>
	[LibraryImport(LibraryName, EntryPoint = "SDL_UpdateGamepads")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void UpdateGamepads();

	/// <summary>
	/// Convert a string into <see cref="SDL_GamepadType"/> enum.
	/// </summary>
	/// <param name="str">String representing a <see cref="SDL_GamepadType"/> type.</param>
	/// <returns>The <see cref="SDL_GamepadType"/> enum corresponding to the input string, or <see cref="SDL_GamepadType.Unknown"/> if no match was found.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadTypeFromString", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_GamepadType GetGamepadTypeFromString(string str);

	/// <summary>
	/// Convert from an SDL_GamepadType enum to a string.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadStringForType">documentation</see> for more details.
	/// </remarks>
	/// <param name="type">Type an enum value for a given <see cref="SDL_GamepadType"/>.</param>
	/// <returns>A string for the given type, or <see langword="null"/> if an invalid type is specified. The string returned is of the format used by <see cref="SDL_Gamepad"/> mapping strings.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadStringForType", StringMarshallingCustomType = typeof(SDLManagedString))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetGamepadStringForType(SDL_GamepadType type);

	/// <summary>
	/// Convert a string into <see cref="SDL_GamepadAxis"/> enum.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/GetGamepadAxisFromString">documentation</see> for more details.
	/// </remarks>
	/// <param name="str">String representing a <see cref="SDL_Gamepad"/> axis.</param>
	/// <returns>The <see cref="SDL_GamepadAxis"/> enum corresponding to the input string, or <see cref="SDL_GamepadAxis.Invalid"/> if no match was found.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadAxisFromString", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_GamepadAxis GetGamepadAxisFromString(string str);

	/// <summary>
	/// Convert from an <see cref="SDL_GamepadAxis"/> enum to a string.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadStringForAxis">documentation</see> for more details.
	/// </remarks>
	/// <param name="axis">An enum value for a given <see cref="SDL_GamepadAxis"/>.</param>
	/// <returns>A string for the given axis, or <see langword="null"/> if an invalid axis is specified. The string returned is of the format used by <see cref="SDL_Gamepad"/> mapping strings.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadStringForAxis", StringMarshallingCustomType = typeof(SDLManagedString))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetGamepadStringForAxis(SDL_GamepadAxis axis);

	/// <summary>
	/// Query whether a gamepad has a given axis.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadHasAxis">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">A gamepad.</param>
	/// <param name="axis">An axis enum value (an <see cref="SDL_GamepadAxis"/> value).</param>
	/// <returns>True if the gamepad has this axis, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GamepadHasAxis")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GamepadHasAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

	/// <summary>
	/// Get the current state of an axis control on a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadAxis">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">A gamepad.</param>
	/// <param name="axis">An axis enum value (an <see cref="SDL_GamepadAxis"/> value).</param>
	/// <returns>Axis state (including 0) on success or 0 (also) on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadAxis")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial short GetGamepadAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

	/// <summary>
	/// Convert a string into an <see cref="SDL_GamepadButton"/> enum.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadButtonFromString">documentation</see> for more details.
	/// </remarks>
	/// <param name="str">String representing a <see cref="SDL_Gamepad"/> axis.</param>
	/// <returns>The <see cref="SDL_GamepadButton"/> enum corresponding to the input string, or <see cref="SDL_GamepadButton.Invalid"/> if no match was found.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadButtonFromString", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_GamepadButton GetGamepadButtonFromString(string str);

	/// <summary>
	/// Convert from an <see cref="SDL_GamepadButton"/> enum to a string.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadStringForButton">documentation</see> for more details.
	/// </remarks>
	/// <param name="button">An enum value for a given <see cref="SDL_GamepadButton"/>.</param>
	/// <returns>A string for the given button, or <see langword="null"/> if an invalid button is specified. The string returned is of the format used by <see cref="SDL_Gamepad"/> mapping strings.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadStringForButton", StringMarshallingCustomType = typeof(SDLManagedString))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetGamepadStringForButton(SDL_GamepadButton button);

	/// <summary>
	/// Query whether a gamepad has a given button.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadHasButton">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">A gamepad.</param>
	/// <param name="button">A button enum value (an <see cref="SDL_GamepadButton"/> value).</param>
	/// <returns>True if the gamepad has this button, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GamepadHasButton")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GamepadHasButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

	/// <summary>
	/// Get the current state of a button on a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadButton">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">A gamepad.</param>
	/// <param name="button">A button index (one of the SDL_GamepadButton values).</param>
	/// <returns>1 for pressed state or 0 for not pressed state or failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadButton")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial byte GetGamepadButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

	/// <summary>
	/// Get the label of a button on a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadButtonLabelForType">documentation</see> for more details.
	/// </remarks>
	/// <param name="type">The type of gamepad to check.</param>
	/// <param name="button">A button index (one of the <see cref="SDL_GamepadButton"/> values).</param>
	/// <returns>The <see cref="SDL_GamepadButtonLabel"/> enum corresponding to the button label.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadButtonLabelForType")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_GamepadButtonLabel GetGamepadButtonLabelForType(SDL_GamepadType type, SDL_GamepadButton button);

	/// <summary>
	/// Get the label of a button on a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadButtonLabel">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">A gamepad.</param>
	/// <param name="button">A button index (one of the <see cref="SDL_GamepadButton"/> values).</param>
	/// <returns>The <see cref="SDL_GamepadButtonLabel"/> enum corresponding to the button label.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadButtonLabel")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_GamepadButtonLabel GetGamepadButtonLabel(SDL_Gamepad* gamepad, SDL_GamepadButton button);

	/// <summary>
	/// Get the number of touchpads on a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumGamepadTouchpads">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">A gamepad.</param>
	/// <returns>Number of touchpads.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetNumGamepadTouchpads")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetNumGamepadTouchpads(SDL_Gamepad* gamepad);

	/// <summary>
	/// Get the number of supported simultaneous fingers on a touchpad on a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumGamepadTouchpadFingers">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">A gamepad.</param>
	/// <param name="touchpad">A touchpad.</param>
	/// <returns>Number of supported simultaneous fingers.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetNumGamepadTouchpadFingers")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetNumGamepadTouchpadFingers(SDL_Gamepad* gamepad, int touchpad);

	/// <summary>
	/// Get the current state of a finger on a touchpad on a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadTouchpadFinger">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">A gamepad.</param>
	/// <param name="touchpad">A touchpad.</param>
	/// <param name="finger">A finger.</param>
	/// <param name="state">Filled with state.</param>
	/// <param name="x">Filled with x position, normalized 0 to 1, with the origin in the upper left.</param>
	/// <param name="y">Filled with y position, normalized 0 to 1, with the origin in the upper left.</param>
	/// <param name="pressure">Filled with pressure value.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadTouchpadFinger")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetGamepadTouchpadFinger(SDL_Gamepad* gamepad, int touchpad, int finger, out byte state, out float x, out float y, out float pressure);

	/// <summary>
	/// Return whether a gamepad has a particular sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/GamepadHasSensor">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad to query.</param>
	/// <param name="type">The type of sensor to query.</param>
	/// <returns>True if the sensor exists, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GamepadHasSensor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GamepadHasSensor(SDL_Gamepad* gamepad, SDL_SensorType type);

	/// <summary>
	/// Set whether data reporting for a gamepad sensor is enabled.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetGamepadSensorEnabled">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad to update.</param>
	/// <param name="type">The type of sensor to enable/disable.</param>
	/// <param name="enabled">Whether data reporting should be enabled.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetGamepadSensorEnabled")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetGamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type, [MarshalAs(NativeBool)] bool enabled);

	/// <summary>
	/// Query whether sensor data reporting is enabled for a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadSensorEnabled">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad to query.</param>
	/// <param name="type">The type of sensor to query.</param>
	/// <returns>True if the sensor is enabled, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GamepadSensorEnabled")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type);

	/// <summary>
	/// Get the data rate (number of events per second) of a gamepad sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadSensorDataRate">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad to query.</param>
	/// <param name="type">The type of sensor to query.</param>
	/// <returns>The data rate, or 0.0f if the data rate is not available.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadSensorDataRate")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial float GetGamepadSensorDataRate(SDL_Gamepad* gamepad, SDL_SensorType type);

	/// <summary>
	/// Get the current state of a gamepad sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadSensorData">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad to query.</param>
	/// <param name="type">Type of sensor to query.</param>
	/// <param name="data">A pointer filled with the current sensor state.</param>
	/// <param name="numValues">The number of values to write to data. Corresponds to <paramref name="data"/>.Length.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadSensorData")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetGamepadSensorData(SDL_Gamepad* gamepad, SDL_SensorType type, [In, Out] float[] data, int numValues);

	/// <summary>
	/// Start a rumble effect on a gamepad.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RumbleGamepad">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad to vibrate.</param>
	/// <param name="lowFrequencyRumble">The intensity of the low frequency (left) rumble motor, from 0 to 0xFFFF.</param>
	/// <param name="high_frequency_rumble">The intensity of the high frequency (right) rumble motor, from 0 to 0xFFFF.</param>
	/// <param name="durationMs">The duration of the rumble effect, in milliseconds.</param>
	/// <returns>0, or -1 if rumble isn't supported on this gamepad.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RumbleGamepad")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int RumbleGamepad(SDL_Gamepad* gamepad, ushort lowFrequencyRumble, ushort high_frequency_rumble, uint durationMs);

	/// <summary>
	/// Start a rumble effect in the gamepad's triggers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RumbleGamepadTriggers">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad to vibrate.</param>
	/// <param name="leftRumble">The intensity of the left trigger rumble motor, from 0 to 0xFFFF.</param>
	/// <param name="rightRumble">The intensity of the right trigger rumble motor, from 0 to 0xFFFF.</param>
	/// <param name="durationMs">The duration of the rumble effect, in milliseconds.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RumbleGamepadTriggers")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int RumbleGamepadTriggers(SDL_Gamepad* gamepad, ushort leftRumble, ushort rightRumble, uint durationMs);

	/// <summary>
	/// Update a gamepad's LED color.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetGamepadLED">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad to update.</param>
	/// <param name="red">The intensity of the red LED.</param>
	/// <param name="green">The intensity of the green LED.</param>
	/// <param name="blue">The intensity of the blue LED.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetGamepadLED")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetGamepadLed(SDL_Gamepad* gamepad, byte red, byte green, byte blue);

	/// <summary>
	/// Send a gamepad specific effect packet.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SendGamepadEffect">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad to affect.</param>
	/// <param name="data">The data to send to the gamepad.</param>
	/// <param name="size">The size of the data to send to the gamepad.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SendGamepadEffect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SendGamepadEffect(SDL_Gamepad* gamepad, nint data, int size);

	/// <summary>
	/// Close a gamepad previously opened with <see cref="OpenGamepad(SDL_JoystickId)"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CloseGamepad">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">A gamepad identifier previously returned by <see cref="OpenGamepad(SDL_JoystickId)"/>.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CloseGamepad")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void CloseGamepad(SDL_Gamepad* gamepad);

	/// <summary>
	/// Return the sfSymbolsName for a given button on a gamepad on Apple platforms.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/GetGamepadAppleSFSymbolsNameForButton">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad to query.</param>
	/// <param name="button">A button on the gamepad.</param>
	/// <returns>The sfSymbolsName or <see langword="null"/> if the name can't be found.</returns>
	[LibraryImport(LibraryName, EntryPoint = "GetGamepadAppleSFSymbolsNameForButton", StringMarshallingCustomType = typeof(SDLManagedString))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetGamepadAppleSFSymbolsNameForButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

	/// <summary>
	/// Return the sfSymbolsName for a given axis on a gamepad on Apple platforms.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGamepadAppleSFSymbolsNameForAxis">documentation</see> for more details.
	/// </remarks>
	/// <param name="gamepad">The gamepad to query.</param>
	/// <param name="axis">An axis on the gamepad.</param>
	/// <returns>The sfSymbolsName or <see langword="null"/> if the name can't be found.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForAxis", StringMarshallingCustomType = typeof(SDLManagedString))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetGamepadAppleSFSymbolsNameForAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);
}