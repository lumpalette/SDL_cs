using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_joystick.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_joystick.h
unsafe partial class SDL
{
	/// <summary>
	/// Locking for atomic access to the joystick API.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_LockJoysticks">documentation</see> for more details.
	/// </remarks>
	[LibraryImport(LibraryName, EntryPoint = "SDL_LockJoysticks")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void LockJoysticks();

	/// <summary>
	/// Unlocking for atomic access to the joystick API.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UnlockJoysticks">documentation</see> for more details.
	/// </remarks>
	[LibraryImport(LibraryName, EntryPoint = "SDL_UnlockJoysticks")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void UnlockJoysticks();

	/// <summary>
	/// Return whether a joystick is currently connected.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasJoystick">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if a joystick is connected, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasJoystick")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(UnmanagedType.I4)]
	public static partial bool HasJoystick();

	/// <summary>
	/// Get a list of currently connected joysticks.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoysticks">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">A pointer filled in with the number of joysticks returned.</param>
	/// <returns>A 0 terminated array of joystick instance IDs which should be freed with <see cref="Free(void*)"/>, or <see langword="null"/> on error; <see cref="GetError"/> for more details.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoysticks")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_JoystickId* GetJoysticks(out int count);

	/// <summary>
	/// Get the implementation dependent name of a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickInstanceName">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId">The joystick instance ID.</param>
	/// <returns>The name of the selected joystick. If no name can be found, this function returns <see langword="null"/>; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickInstanceName", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetJoystickInstanceName(SDL_JoystickId joystickId);

	/// <summary>
	/// Get the implementation dependent path of a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickInstancePath">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId">The joystick instance ID.</param>
	/// <returns>The path of the selected joystick. If no path can be found, this function returns <see langword="null"/>; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickInstancePath", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetJoystickInstancePath(SDL_JoystickId joystickId);

	/// <summary>
	/// Get the player index of a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickInstancePlayerIndex">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId">The joystick instance ID.</param>
	/// <returns>The player index of a joystick, or -1 if it's not available.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickInstancePlayerIndex")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetJoystickInstancePlayerIndex(SDL_JoystickId joystickId);

	/// <summary>
	/// Get the implementation-dependent GUID of a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickInstanceGUID">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId">The joystick instance ID.</param>
	/// <returns>The GUID of the selected joystick. If called with an invalid <paramref name="joystickId"/>, this function returns a zero GUID.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickInstanceGUID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_JoystickGuid GetJoystickInstanceGuid(SDL_JoystickId joystickId);

	/// <summary>
	/// Get the USB vendor ID of a joystick, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickInstanceVendor">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId">The joystick instance ID.</param>
	/// <returns>The USB vendor ID of the selected joystick. If called with an invalid <paramref name="joystickId"/>, this function returns 0.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickInstanceVendor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial ushort GetJoystickInstanceVendor(SDL_JoystickId joystickId);

	/// <summary>
	/// Get the USB product ID of a joystick, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickInstanceProduct">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId">The joystick instance ID.</param>
	/// <returns>The USB product ID of the selected joystick. If called with an invalid <paramref name="joystickId"/>, this function returns 0.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickInstanceProduct")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial ushort GetJoystickInstanceProduct(SDL_JoystickId joystickId);

	/// <summary>
	/// Get the product version of a joystick, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickInstanceProductVersion">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId">The joystick instance ID.</param>
	/// <returns>The product version of the selected joystick. If called with an invalid <paramref name="joystickId"/>, this function returns 0.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickInstanceProductVersion")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial ushort GetJoystickInstanceProductVersion(SDL_JoystickId joystickId);

	/// <summary>
	/// Get the type of a joystick, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickInstanceType">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId">The joystick instance ID.</param>
	/// <returns>The <see cref="SDL_JoystickType"/> of the selected joystick. If called with an invalid <paramref name="joystickId"/>, this function returns <see cref="SDL_JoystickType.Unknown"/>.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickInstanceType")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_JoystickType GetJoystickInstanceType(SDL_JoystickId joystickId);

	/// <summary>
	/// Open a joystick for use.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_OpenJoystick">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId">The joystick instance ID.</param>
	/// <returns>A joystick identifier or <see langword="null"/> if an error occurred; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_OpenJoystick")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Joystick* OpenJoystick(SDL_JoystickId joystickId);

	/// <summary>
	/// Get the <see cref="SDL_Joystick"/> associated with an instance ID, if it has been opened.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickFromInstanceID">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId">The instance ID to get the <see cref="SDL_JoystickId"/> for.</param>
	/// <returns>An <see cref="SDL_Joystick"/> on success or <see langword="null"/> on failure or if it hasn't been opened yet; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickFromInstanceID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Joystick* GetJoystickFromInstanceId(SDL_JoystickId joystickId);

	/// <summary>
	/// Get the <see cref="SDL_Joystick"/> associated with a player index, if it has been opened.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickFromPlayerIndex">documentation</see> for more details.
	/// </remarks>
	/// <param name="playerIndex">The player index to get the <see cref="SDL_Joystick"/> for.</param>
	/// <returns>An <see cref="SDL_Joystick"/> on success or <see langword="null"/> on failure or if it hasn't been opened yet; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickFromPlayerIndex")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Joystick* GetJoystickFromPlayerIndex(int playerIndex);

	/// <summary>
	/// Attach a new virtual joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AttachVirtualJoystick">documentation</see> for more details.
	/// </remarks>
	/// <param name="desc">Joystick description.</param>
	/// <returns>The joystick instance ID, or <see cref="SDL_JoystickId.Invalid"/> if an error occurred; call <see cref="GetError"/> for more information.</returns>
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AttachVirtualJoystick")]
	public static extern SDL_JoystickId AttachVirtualJoystick([In] in SDL_VirtualJoystickDesc desc);

	/// <summary>
	/// Detach a virtual joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DetachVirtualJoystick">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId">The joystick instance ID, previously returned from <see cref="AttachVirtualJoystick(in SDL_VirtualJoystickDesc)"/>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DetachVirtualJoystick")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int DetachVirtualJoystick(SDL_JoystickId joystickId);


	/// <summary>
	/// Query whether or not a joystick is virtual.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_IsJoystickVirtual">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystickId">The joystick instance ID.</param>
	/// <returns>True if the joystick is virtual, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_IsJoystickVirtual")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(UnmanagedType.I4)]
	public static partial bool IsJoystickVirtual(SDL_JoystickId joystickId);

	/// <summary>
	/// Set the state of an axis on an opened virtual joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetJoystickVirtualAxis">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The virtual joystick on which to set state.</param>
	/// <param name="axis">The index of the axis on the virtual joystick to update.</param>
	/// <param name="value">The new value for the specified axis.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetJoystickVirtualAxis")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetJoystickVirtualAxis(SDL_Joystick* joystick, int axis, short value);

	/// <summary>
	/// Generate ball motion on an opened virtual joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetJoystickVirtualBall">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The virtual joystick on which to set state.</param>
	/// <param name="ball">The index of the ball on the virtual joystick to update.</param>
	/// <param name="xRelative">The relative motion on the X axis.</param>
	/// <param name="yRelative">The relative motion on the Y axis.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetJoystickVirtualBall")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetJoystickVirtualBall(SDL_Joystick* joystick, int ball, short xRelative, short yRelative);

	/// <summary>
	/// Set the state of a button on an opened virtual joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetJoystickVirtualButton">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The virtual joystick on which to set state.</param>
	/// <param name="button">The index of the button on the virtual joystick to update.</param>
	/// <param name="value">The new value for the specified button.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetJoystickVirtualButton")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetJoystickVirtualButton(SDL_Joystick* joystick, int button, byte value);

	/// <summary>
	/// Set the state of a hat on an opened virtual joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetJoystickVirtualHat">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The virtual joystick on which to set state.</param>
	/// <param name="hat">The index of the hat on the virtual joystick to update.</param>
	/// <param name="value">The new value for the specified hat.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetJoystickVirtualHat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetJoystickVirtualHat(SDL_Joystick* joystick, int hat, byte value);

	/// <summary>
	/// Set touchpad finger state on an opened virtual joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetJoystickVirtualTouchpad">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The virtual joystick on which to set state.</param>
	/// <param name="touchpad">The index of the touchpad on the virtual joystick to update.</param>
	/// <param name="finger">The index of the finger on the touchpad to set.</param>
	/// <param name="state"><see cref="SDL_InputState.Pressed"/> if the finger is pressed, <see cref="SDL_InputState.Released"/> if the finger is released.</param>
	/// <param name="x">The x coordinate of the finger on the touchpad, normalized 0 to 1, with the origin in the upper left.</param>
	/// <param name="y">The y coordinate of the finger on the touchpad, normalized 0 to 1, with the origin in the upper left.</param>
	/// <param name="pressure">The pressure of the finger.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetJoystickVirtualTouchpad")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetJoystickVirtualTouchpad(SDL_Joystick* joystick, int touchpad, int finger, SDL_InputState state, float x, float y, float pressure);

	/// <summary>
	/// Send a sensor update for an opened virtual joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SendJoystickVirtualSensorData">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The virtual joystick on which to set state.</param>
	/// <param name="type">The type of the sensor on the virtual joystick to update.</param>
	/// <param name="sensorTimestamp">A 64-bit timestamp in nanoseconds associated with the sensor reading.</param>
	/// <param name="data">The data associated with the sensor reading.</param>
	/// <param name="numValues">The number of values pointed to by <paramref name="data"/>. Corresponds to <paramref name="data"/>.Length.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SendJoystickVirtualSensorData")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SendJoystickVirtualSensorData(SDL_Joystick* joystick, SDL_SensorType type, ulong sensorTimestamp, [In] float[] data, int numValues);

	/// <summary>
	/// Get the properties associated with a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The <see cref="Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>.</param>
	/// <returns>A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PropertiesId GetJoystickProperties(SDL_Joystick* joystick);

	/// <summary>
	/// Get the implementation dependent name of a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickName">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>.</param>
	/// <returns>The name of the selected joystick. If no name can be found, this function returns null; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickName", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetJoystickName(SDL_Joystick* joystick);

	/// <summary>
	/// Get the implementation dependent path of a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickPath">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>.</param>
	/// <returns>The path of the selected joystick. If no path can be found, this function returns null; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickPath", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetJoystickPath(SDL_Joystick* joystick);

	/// <summary>
	/// Get the player index of an opened joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickPlayerIndex">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>.</param>
	/// <returns>The player index, or -1 if it's not available.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickPlayerIndex")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetJoystickPlayerIndex(SDL_Joystick* joystick);

	/// <summary>
	/// Set the player index of an opened joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetJoystickPlayerIndex">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>.</param>
	/// <param name="playerIndex">Player index to assign to this joystick, or -1 to clear the player index and turn off player LEDs.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetJoystickPlayerIndex")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetJoystickPlayerIndex(SDL_Joystick* joystick, int playerIndex);

	/// <summary>
	/// Get the implementation-dependent GUID for the joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickGUID">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>.</param>
	/// <returns>The GUID of the given joystick. If called on an invalid index, this function returns a zero GUID; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickGUID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_JoystickGuid GetJoystickGuid(SDL_Joystick* joystick);

	/// <summary>
	/// Get the USB vendor ID of an opened joystick, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickVendor">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>.</param>
	/// <returns>The USB vendor ID of the selected joystick, or 0 if unavailable.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickVendor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial ushort GetJoystickVendor(SDL_Joystick* joystick);

	/// <summary>
	/// Get the USB product ID of an opened joystick, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickProduct">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>.</param>
	/// <returns>The USB product ID of the selected joystick, or 0 if unavailable.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickProduct")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial ushort GetJoystickProduct(SDL_Joystick* joystick);

	/// <summary>
	/// Get the product version of an opened joystick, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickProductVersion">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>.</param>
	/// <returns>The product version of the selected joystick, or 0 if unavailable.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickProductVersion")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial ushort GetJoystickProductVersion(SDL_Joystick* joystick);

	/// <summary>
	/// Get the firmware version of an opened joystick, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickFirmwareVersion">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>.</param>
	/// <returns>The firmware version of the selected joystick, or 0 if unavailable.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickFirmwareVersion")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial ushort GetJoystickFirmwareVersion(SDL_Joystick* joystick);

	/// <summary>
	/// Get the serial number of an opened joystick, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickSerial">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>.</param>
	/// <returns>The serial number of the selected joystick, or null if unavailable.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickSerial", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetJoystickSerial(SDL_Joystick* joystick);

	/// <summary>
	/// Get the type of an opened joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickType">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>. </param>
	/// <returns> The <see cref="SDL_JoystickType"/> of the selected joystick. </returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickType")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_JoystickType GetJoystickType(SDL_Joystick* joystick);

	/// <summary>
	/// Get an ASCII string representation for a given <see cref="SDL_JoystickGuid"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickGUIDString">documentation</see> for more details.
	/// </remarks>
	/// <param name="guid">The <see cref="SDL_JoystickGuid"/> you wish to convert to string.</param>
	/// <param name="pszGuid">The converted string.</param>
	/// <param name="cbGuid">The number of characters that <paramref name="pszGuid"/> should have. The minimum and default value is 33.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int GetJoystickGuidString(SDL_JoystickGuid guid, out string? pszGuid, int cbGuid)
	{
		return GuidToString((SDL_Guid)guid, out pszGuid, cbGuid);
	}

	/// <summary>
	/// Convert a GUID string into a SDL_JoystickGUID structure.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickGUIDFromString">documentation</see> for more details.
	/// </remarks>
	/// <returns>An <see cref="SDL_JoystickGuid"/> structure.</returns>
	public static SDL_JoystickGuid GetJoystickGuidFromString(string pchGuid)
	{
		return (SDL_JoystickGuid)GuidFromString(pchGuid);
	}

	/// <summary>
	/// Get the device information encoded in an <see cref="SDL_JoystickGuid"/> structure.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickGUIDInfo">documentation</see> for more details.
	/// </remarks>
	/// <param name="guid">The <see cref="SDL_JoystickGuid"/> you wish to get info about.</param>
	/// <param name="vendor">A pointer filled in with the device VID, or 0 if not available.</param>
	/// <param name="product">A pointer filled in with the device PID, or 0 if not available.</param>
	/// <param name="version">A pointer filled in with the device version, or 0 if not available.</param>
	/// <param name="crc16">A pointer filled in with a CRC used to distinguish different products with the same VID/PID, or 0 if not available.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickGUIDInfo")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void GetJoystickGuidInfo(SDL_JoystickGuid guid, out ushort vendor, out ushort product, out ushort version, out ushort crc16);

	/// <summary>
	/// Get the status of a specified joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_JoystickConnected">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The joystick to query.</param>
	/// <returns>True if the joystick has been opened, false if it has not; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_JoystickConnected")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(UnmanagedType.I4)]
	public static partial bool JoystickConnected(SDL_Joystick* joystick);

	/// <summary>
	/// Get the instance ID of an opened joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickInstanceID">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">An <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>.</param>
	/// <returns>The instance ID of the specified joystick on success or 0 on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickInstanceID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_JoystickId GetJoystickInstanceId(SDL_Joystick* joystick);

	/// <summary>
	/// Get the number of general axis controls on a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumJoystickAxes">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">An <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>.</param>
	/// <returns>The number of axis controls/number of axes on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetNumJoystickAxes")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetNumJoystickAxes(SDL_Joystick* joystick);

	/// <summary>
	/// Get the number of trackballs on a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumJoystickBalls">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">An <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>.</param>
	/// <returns>The number of trackballs on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetNumJoystickBalls")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetNumJoystickBalls(SDL_Joystick* joystick);

	/// <summary>
	/// Get the number of POV hats on a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumJoystickHats">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">An <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>.</param>
	/// <returns>The number of POV hats on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetNumJoystickHats")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetNumJoystickHats(SDL_Joystick* joystick);

	/// <summary>
	/// Get the number of buttons on a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumJoystickButtons">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">An <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>.</param>
	/// <returns>The number of buttons on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetNumJoystickButtons")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetNumJoystickButtons(SDL_Joystick* joystick);

	/// <summary>
	/// Set the state of joystick event processing.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetJoystickEventsEnabled">documentation</see> for more details.
	/// </remarks>
	/// <param name="enabled">Whether to process joystick events or not.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetJoystickEventsEnabled")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void SetJoystickEventsEnabled([MarshalAs(UnmanagedType.I4)] bool enabled);

	/// <summary>
	/// Query the state of joystick event processing.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_JoystickEventsEnabled">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if joystick events are being processed, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_JoystickEventsEnabled")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(UnmanagedType.I4)]
	public static partial bool JoystickEventsEnabled();

	/// <summary>
	/// Update the current state of the open joysticks.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateJoysticks">documentation</see> for more details.
	/// </remarks>
	[LibraryImport(LibraryName, EntryPoint = "SDL_UpdateJoysticks")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void UpdateJoysticks();

	/// <summary>
	/// Get the current state of an axis control on a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickAxis">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">An <see cref="SDL_Joystick"/> structure containing joystick information.</param>
	/// <param name="axis">The axis to query; the axis indices start at index 0.</param>
	/// <returns>A 16-bit signed integer representing the current position of the axis or 0 on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickAxis")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial short GetJoystickAxis(SDL_Joystick* joystick, int axis);

	/// <summary>
	/// Get the initial state of an axis control on a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickAxisInitialState">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">An <see cref="SDL_Joystick"/> structure containing joystick information.</param>
	/// <param name="axis">The axis to query; the axis indices start at index 0.</param>
	/// <param name="state">Upon return, the initial value is supplied here.</param>
	/// <returns>True if this axis has any initial value, or false if not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickAxisInitialState")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(UnmanagedType.I4)]
	public static partial bool GetJoystickAxisInitialState(SDL_Joystick* joystick, int axis, out short state);

	/// <summary>
	/// Get the ball axis change since the last poll.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickBall">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The <see cref="SDL_Joystick"/> to query.</param>
	/// <param name="ball">The ball index to query; ball indices start at index 0.</param>
	/// <param name="dx">Stores the difference in the x axis position since the last poll.</param>
	/// <param name="dy">Stores the difference in the y axis position since the last poll.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickBall")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetJoystickBall(SDL_Joystick* joystick, int ball, out int dx, out int dy);

	/// <summary>
	/// Get the current state of a POV hat on a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickHat">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">An <see cref="SDL_Joystick"/> structure containing joystick information.</param>
	/// <param name="hat">The hat index to get the state from; indices start at index 0.</param>
	/// <returns>The current hat position.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickHat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_JoystickHatPosition GetJoystickHat(SDL_Joystick* joystick, int hat);

	/// <summary>
	/// Get the current state of a button on a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickButton">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">An <see cref="SDL_Joystick"/> structure containing joystick information.</param>
	/// <param name="button">The button index to get the state from; indices start at index 0.</param>
	/// <returns>1 if the specified button is pressed, 0 otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickButton")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_InputState GetJoystickButton(SDL_Joystick* joystick, int button);

	/// <summary>
	/// Start a rumble effect.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RumbleJoystick">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The joystick to vibrate.</param>
	/// <param name="lowFrequencyRumble">The intensity of the low frequency (left) rumble motor, from 0 to 0xFFFF.</param>
	/// <param name="highFrequencyRumble">The intensity of the high frequency (right) rumble motor, from 0 to 0xFFFF.</param>
	/// <param name="durationMs">The duration of the rumble effect, in milliseconds.</param>
	/// <returns>0, or -1 if rumble isn't supported on this joystick.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RumbleJoystick")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int RumbleJoystick(SDL_Joystick* joystick, ushort lowFrequencyRumble, ushort highFrequencyRumble, uint durationMs);

	/// <summary>
	/// Start a rumble effect in the joystick's triggers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RumbleJoystickTriggers">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The joystick to vibrate.</param>
	/// <param name="leftRumble">The intensity of the left trigger rumble motor, from 0 to 0xFFFF.</param>
	/// <param name="rightRumble">The intensity of the right trigger rumble motor, from 0 to 0xFFFF.</param>
	/// <param name="durationMs">The duration of the rumble effect, in milliseconds.</param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RumbleJoystickTriggers")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int RumbleJoystickTriggers(SDL_Joystick* joystick, ushort leftRumble, ushort rightRumble, uint durationMs);

	/// <summary>
	/// Update a joystick's LED color.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetJoystickLED">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The joystick to update.</param>
	/// <param name="red">The intensity of the red LED.</param>
	/// <param name="green">The intensity of the green LED.</param>
	/// <param name="blue">The intensity of the blue LED.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetJoystickLED")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetJoystickLED(SDL_Joystick* joystick, byte red, byte green, byte blue);

	/// <summary>
	/// Send a joystick specific effect packet.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SendJoystickEffect">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The joystick to affect.</param>
	/// <param name="data">The data to send to the joystick.</param>
	/// <param name="size">The size of the data to send to the joystick.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SendJoystickEffect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SendJoystickEffect(SDL_Joystick* joystick, nint data, int size);

	/// <summary>
	/// Close a joystick previously opened with <see cref="OpenJoystick(SDL_JoystickId)"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CloseJoystick">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The joystick device to close.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CloseJoystick")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void CloseJoystick(SDL_Joystick* joystick);

	/// <summary>
	/// Get the connection state of a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickConnectionState">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The joystick to query.</param>
	/// <returns>The connection state on success or <see cref="SDL_JoystickConnectionState.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickConnectionState")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_JoystickConnectionState GetJoystickConnectionState(SDL_Joystick* joystick);

	/// <summary>
	/// Get the battery state of a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickPowerInfo">documentation</see> for more details.
	/// </remarks>
	/// <param name="joystick">The joystick to query.</param>
	/// <param name="percent">A pointer filled in with the percentage of battery life left, between 0 and 100. This will return -1 if we can't determine a value or there is no battery.</param>
	/// <returns>The current battery state or <see cref="SDL_PowerState.Error"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickPowerInfo")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PowerState GetJoystickPowerInfo(SDL_Joystick* joystick, out int percent);

	/// <summary>
	/// The largest value an <see cref="SDL_Joystick"/>'s axis can report.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_JOYSTICK_AXIS_MAX">documentation</see> for more details.
	/// </remarks>
	public const short JoystickAxisMax = short.MaxValue;

	/// <summary>
	/// The smallest value an <see cref="SDL_Joystick"/>'s axis can report.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_JOYSTICK_AXIS_MIN">documentation</see> for more details.
	/// </remarks>
	public const short JoystickAxisMin = short.MinValue;

	/// <summary>
	/// Set max recognized G-force from accelerometer.
	/// </summary>
	public const float IPhoneMaxGForce = 5.0f;
}