using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_joystick.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_joystick.h
unsafe partial class SDL
{
	// FIXME: implement SDL_VirtualJoystickTouchpadDesc
	// FIXME: implement SDL_VirtualJoystickSensorDesc
	// FIXME: implement SDL_VirtualJoystickDesc

	/// <summary>
	/// Locking for atomic access to the joystick API.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_LockJoysticks">here</see> for more details.
	/// </remarks>
	public static void LockJoysticks()
	{
		_PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_LockJoysticks", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke();
	}

	/// <summary>
	/// Unlocking for atomic access to the joystick API.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_UnlockJoysticks">here</see> for more details.
	/// </remarks>
	public static void UnlockJoysticks()
	{
		_PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_UnlockJoysticks", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke();
	}

	/// <summary>
	/// Return whether a joystick is currently connected.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_HasJoysticks">here</see> for more details.
	/// </remarks>
	/// <returns> True if a joystick is connected, false otherwise. </returns>
	public static bool HasJoysticks()
	{
		return _PInvoke() == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_HasJoysticks", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Get a list of currently connected joysticks.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoysticks">here</see> for more details.
	/// </remarks>
	/// <param name="count"> Returns the number of joysticks. </param>
	/// <returns> An array of joystick instance ids, or null on error; <see cref="GetError"/> for more details. </returns>
	public static SDL_JoystickId[]? GetJoysticks(out int count)
	{
		fixed (int* countPtr = &count)
		{
			SDL_JoystickId* joysticksPtr = _PInvoke(countPtr);
			if (joysticksPtr is null)
			{
				return null;
			}
			SDL_JoystickId[] joysticks = new SDL_JoystickId[count];
			for (int i = 0; i < count; i++)
			{
				joysticks[i] = joysticksPtr[i];
			}
			Free(joysticksPtr);
			return joysticks;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoysticks", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_JoystickId* _PInvoke(int* count);
	}

	/// <summary>
	/// Get the implementation dependent name of a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickInstanceName">here</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> The name of the selected joystick. If no name can be found, this function returns null; call <see cref="GetError"/> for more information. </returns>
	public static string? GetJoystickInstanceName(SDL_JoystickId joystickId)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(joystickId));

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickInstanceName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the implementation dependent path of a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickInstancePath">here</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> The path of the selected joystick. If no path can be found, this function returns null; call <see cref="GetError"/> for more information. </returns>
	public static string? GetJoystickInstancePath(SDL_JoystickId joystickId)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(joystickId));

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickInstancePath", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the player index of a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickInstancePlayerIndex">here</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> The player index of a joystick, or -1 if it's not available. </returns>
	public static int GetJoystickInstancePlayerIndex(SDL_JoystickId joystickId)
	{
		return _PInvoke(joystickId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickInstancePlayerIndex", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the implementation-dependent GUID of a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickInstanceGUID">here</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> The GUID of the selected joystick. If called with an invalid <paramref name="joystickId"/>, this function returns a zero GUID. </returns>
	public static SDL_JoystickGuid GetJoystickInstanceGuid(SDL_JoystickId joystickId)
	{
		return _PInvoke(joystickId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickInstanceGUID", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_JoystickGuid _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the USB vendor ID of a joystick, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickInstanceVendor">here</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> The USB vendor ID of the selected joystick. If called with an invalid <paramref name="joystickId"/>, this function returns 0. </returns>
	public static ushort GetJoystickInstanceVendor(SDL_JoystickId joystickId)
	{
		return _PInvoke(joystickId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickInstanceVendor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern ushort _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the USB product ID of a joystick, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickInstanceProduct">here</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> The USB product ID of the selected joystick. If called with an invalid <paramref name="joystickId"/>, this function returns 0. </returns>
	public static ushort GetJoystickInstanceProduct(SDL_JoystickId joystickId)
	{
		return _PInvoke(joystickId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickInstanceProduct", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern ushort _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the product version of a joystick, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickInstanceProductVersion">here</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> the product version of the selected joystick. If called with an invalid <paramref name="joystickId"/>, this function returns 0. </returns>
	public static ushort GetJoystickInstanceProductVersion(SDL_JoystickId joystickId)
	{
		return _PInvoke(joystickId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickInstanceProductVersion", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern ushort _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the type of a joystick, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickInstanceType">here</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> The <see cref="SDL_JoystickType"/> of the selected joystick. If called with an invalid <paramref name="joystickId"/>, this function returns <see cref="SDL_JoystickType.Unknown"/>. </returns>
	public static SDL_JoystickType GetJoystickInstanceType(SDL_JoystickId joystickId)
	{
		return _PInvoke(joystickId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickInstanceType", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_JoystickType _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Open a joystick for use.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_OpenJoystick">here</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The joystick instance ID. </param>
	/// <returns> A joystick identifier or null if an error occurred; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Joystick* OpenJoystick(SDL_JoystickId joystickId)
	{
		return _PInvoke(joystickId);

		[DllImport(LibraryName, EntryPoint = "SDL_OpenJoystick", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Joystick* _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the <see cref="SDL_Joystick"/> associated with an instance ID, if it has been opened.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickFromInstanceID">here</see> for more details.
	/// </remarks>
	/// <param name="joystickId"> The instance ID to get the <see cref="SDL_JoystickId"/> for. </param>
	/// <returns> An <see cref="SDL_Joystick"/> on success or null on failure or if it hasn't been opened yet; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Joystick* GetJoystickFromInstanceId(SDL_JoystickId joystickId)
	{
		return _PInvoke(joystickId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickFromInstanceID", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Joystick* _PInvoke(SDL_JoystickId joystickId);
	}

	/// <summary>
	/// Get the <see cref="SDL_Joystick"/> associated with a player index.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickFromPlayerIndex">here</see> for more details.
	/// </remarks>
	/// <param name="playerIndex"> The player index to get the <see cref="SDL_Joystick"/> for. </param>
	/// <returns> An <see cref="SDL_Joystick"/> on success or null on failure or if it hasn't been opened yet; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Joystick* GetJoystickFromPlayerIndex(int playerIndex)
	{
		return _PInvoke(playerIndex);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickFromPlayerIndex", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Joystick* _PInvoke(int playerIndex);
	}

	// FIXME: implement SDL_AttachVirtualJoystick()
	// FIXME: implement SDL_DetachVirtualJoystick()
	// FIXME: implement SDL_IsJoystickVirtual()
	// FIXME: implement SDL_SetJoystickVirtualAxis()
	// FIXME: implement SDL_SetJoystickVirtualBall()
	// FIXME: implement SDL_SetJoystickVirtualButton()
	// FIXME: implement SDL_SetJoystickVirtualHat()
	// FIXME: implement SDL_SetJoystickVirtualTouchpad()
	// FIXME: implement SDL_SendJoystickVirtualSensorData()

	/// <summary>
	/// Get the properties associated with a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickProperties">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The <see cref="Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>. </param>
	/// <returns> A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_PropertiesId GetJoystickProperties(SDL_Joystick* joystick)
	{
		return _PInvoke(joystick);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_PropertiesId _PInvoke(SDL_Joystick* joystick);
	}

	/// <summary>
	/// Get the implementation dependent name of a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickName">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>. </param>
	/// <returns> The name of the selected joystick. If no name can be found, this function returns null; call <see cref="GetError"/> for more information. </returns>
	public static string? GetJoystickName(SDL_Joystick* joystick)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(joystick));

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_Joystick* joystick);
	}

	/// <summary>
	/// Get the implementation dependent path of a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickPath">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>. </param>
	/// <returns> The path of the selected joystick. If no path can be found, this function returns null; call <see cref="GetError"/> for more information. </returns>
	public static string? GetJoystickPath(SDL_Joystick* joystick)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(joystick));

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickPath", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_Joystick* joystick);
	}

	/// <summary>
	/// Get the player index of an opened joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickPlayerIndex">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>. </param>
	/// <returns> The player index, or -1 if it's not available. </returns>
	public static int GetJoystickPlayerIndex(SDL_Joystick* joystick)
	{
		return _PInvoke(joystick);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickPlayerIndex", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Joystick* joystick);
	}

	/// <summary>
	/// Set the player index of an opened joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetJoystickPlayerIndex">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>. </param>
	/// <param name="playerIndex"> Player index to assign to this joystick, or -1 to clear the player index and turn off player LEDs. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetJoystickPlayerIndex(SDL_Joystick* joystick, int playerIndex)
	{
		return _PInvoke(joystick, playerIndex);

		[DllImport(LibraryName, EntryPoint = "SDL_SetJoystickPlayerIndex", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Joystick* joystick, int playerIndex);
	}

	/// <summary>
	/// Get the implementation-dependent GUID for the joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickGUID">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>. </param>
	/// <returns> The GUID of the given joystick. If called on an invalid index, this function returns a zero GUID; call <see cref="GetError"/> for more information. </returns>
	public static SDL_JoystickGuid GetJoystickGuid(SDL_Joystick* joystick)
	{
		return _PInvoke(joystick);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickGUID", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_JoystickGuid _PInvoke(SDL_Joystick* joystick);
	}

	/// <summary>
	/// Get the USB vendor ID of an opened joystick, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickVendor">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>. </param>
	/// <returns> The USB vendor ID of the selected joystick, or 0 if unavailable. </returns>
	public static ushort GetJoystickVendor(SDL_Joystick* joystick)
	{
		return _PInvoke(joystick);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickVendor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern ushort _PInvoke(SDL_Joystick* joystick);
	}

	/// <summary>
	/// Get the USB product ID of an opened joystick, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickProduct">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>. </param>
	/// <returns> The USB product ID of the selected joystick, or 0 if unavailable. </returns>
	public static ushort GetJoystickProduct(SDL_Joystick* joystick)
	{
		return _PInvoke(joystick);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickProduct", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern ushort _PInvoke(SDL_Joystick* joystick);
	}

	/// <summary>
	/// Get the product version of an opened joystick, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickProductVersion">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>. </param>
	/// <returns> The product version of the selected joystick, or 0 if unavailable. </returns>
	public static ushort GetJoystickProductVersion(SDL_Joystick* joystick)
	{
		return _PInvoke(joystick);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickProductVersion", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern ushort _PInvoke(SDL_Joystick* joystick);
	}

	/// <summary>
	/// Get the firmware version of an opened joystick, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickFirmwareVersion">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>. </param>
	/// <returns> The firmware version of the selected joystick, or 0 if unavailable. </returns>
	public static ushort GetJoystickFirmwareVersion(SDL_Joystick* joystick)
	{
		return _PInvoke(joystick);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickFirmwareVersion", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern ushort _PInvoke(SDL_Joystick* joystick);
	}

	/// <summary>
	/// Get the serial number of an opened joystick, if available.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickSerial">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>. </param>
	/// <returns> The serial number of the selected joystick, or null if unavailable. </returns>
	public static string? GetJoystickSerial(SDL_Joystick* joystick)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(joystick));

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickSerial", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_Joystick* joystick);
	}

	/// <summary>
	/// Get the type of an opened joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickType">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>. </param>
	/// <returns> The <see cref="SDL_JoystickType"/> of the selected joystick. </returns>
	public static SDL_JoystickType GetJoystickType(SDL_Joystick* joystick)
	{
		return _PInvoke(joystick);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickType", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_JoystickType _PInvoke(SDL_Joystick* joystick);
	}

	/// <summary>
	/// Get an ASCII string representation for a given <see cref="SDL_JoystickGuid"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickGUIDString">here</see> for more details.
	/// </remarks>
	/// <param name="guid"> The <see cref="SDL_JoystickGuid"/> you wish to convert to string. </param>
	/// <param name="pszGuid"> Returns the converted string. </param>
	/// <param name="cbGuid"> The number of characters that <paramref name="pszGuid"/> should have. The minimum and default value is 33. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetJoystickGuidString(SDL_JoystickGuid guid, out string? pszGuid, int cbGuid)
	{
		return GuidToString((SDL_Guid)guid, out pszGuid, cbGuid);
	}

	/// <summary>
	/// Convert a GUID string into a SDL_JoystickGUID structure.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickGUIDFromString">here</see> for more details.
	/// </remarks>
	/// <returns> An <see cref="SDL_JoystickGuid"/> structure. </returns>
	public static SDL_JoystickGuid GetJoystickGuidFromString(string pchGuid)
	{
		return (SDL_JoystickGuid)GuidFromString(pchGuid);
	}

	/// <summary>
	/// Get the device information encoded in an <see cref="SDL_JoystickGuid"/> structure.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickGUIDInfo">here</see> for more details.
	/// </remarks>
	/// <param name="guid"> The <see cref="SDL_JoystickGuid"/> you wish to get info about. </param>
	/// <param name="vendor"> Returns the the device VID, or 0 if not available. </param>
	/// <param name="product"> Returns the device PID, or 0 if not available. </param>
	/// <param name="version"> Returns the device version, or 0 if not available. </param>
	/// <param name="crc16"> Returns a CRC used to distinguish different products with the same VID/PID, or 0 if not available. </param>
	public static void GetJoystickGuidInfo(SDL_JoystickGuid guid, out ushort vendor, out ushort product, out ushort version, out ushort crc16)
	{
		fixed (ushort* v = &vendor, p = &product, e = &version, c = &crc16)
		{
			_PInvoke(guid, v, p, e, c);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickGUIDInfo", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(SDL_JoystickGuid joystick, ushort* vendor, ushort* product, ushort* version, ushort* crc16);
	}

	/// <summary>
	/// Get the status of a specified joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_JoystickConnected">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The joystick to query. </param>
	/// <returns> True if the joystick has been opened, false if it has not; call <see cref="GetError"/> for more information. </returns>
	public static bool JoystickConnected(SDL_Joystick* joystick)
	{
		return _PInvoke(joystick) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_JoystickConnected", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Joystick* joystick);
	}

	/// <summary>
	/// Get the instance ID of an opened joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickInstanceID">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>. </param>
	/// <returns> The instance ID of the specified joystick on success or 0 on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_JoystickId GetJoystickInstanceId(SDL_Joystick* joystick)
	{
		return _PInvoke(joystick);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickInstanceID", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_JoystickId _PInvoke(SDL_Joystick* joystick);
	}

	/// <summary>
	/// Get the number of general axis controls on a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumJoystickAxes">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>. </param>
	/// <returns> The number of axis controls/number of axes on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetNumJoystickAxes(SDL_Joystick* joystick)
	{
		return _PInvoke(joystick);

		[DllImport(LibraryName, EntryPoint = "SDL_GetNumJoystickAxes", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Joystick* joystick);
	}

	/// <summary>
	/// Get the number of trackballs on a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumJoystickBalls">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>. </param>
	/// <returns> The number of trackballs on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetNumJoystickBalls(SDL_Joystick* joystick)
	{
		return _PInvoke(joystick);

		[DllImport(LibraryName, EntryPoint = "SDL_GetNumJoystickBalls", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Joystick* joystick);
	}

	/// <summary>
	/// Get the number of POV hats on a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumJoystickHats">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>. </param>
	/// <returns> The number of POV hats on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetNumJoystickHats(SDL_Joystick* joystick)
	{
		return _PInvoke(joystick);

		[DllImport(LibraryName, EntryPoint = "SDL_GetNumJoystickHats", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Joystick* joystick);
	}

	/// <summary>
	/// Get the number of buttons on a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumJoystickButtons">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The <see cref="SDL_Joystick"/> obtained from <see cref="OpenJoystick(SDL_JoystickId)"/>. </param>
	/// <returns> The number of buttons on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetNumJoystickButtons(SDL_Joystick* joystick)
	{
		return _PInvoke(joystick);

		[DllImport(LibraryName, EntryPoint = "SDL_GetNumJoystickButtons", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Joystick* joystick);
	}

	/// <summary>
	/// Set the state of joystick event processing.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetJoystickEventsEnabled">here</see> for more details.
	/// </remarks>
	/// <param name="enabled"> Whether to process joystick events or not. </param>
	public static void SetJoystickEventsEnabled(bool enabled)
	{
		_PInvoke(enabled ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetJoystickEventsEnabled", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(int enabled);
	}

	/// <summary>
	/// Query the state of joystick event processing.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_JoystickEventsEnabled">here</see> for more details.
	/// </remarks>
	/// <returns> True if joystick events are being processed, false otherwise. </returns>
	public static bool JoystickEventsEnabled()
	{
		return _PInvoke() == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_JoystickEventsEnabled", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Update the current state of the open joysticks.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateJoysticks">here</see> for more details.
	/// </remarks>
	public static void UpdateJoysticks()
	{
		_PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_UpdateJoysticks", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke();
	}

	/// <summary>
	/// Get the current state of an axis control on a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickAxis">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> An <see cref="SDL_Joystick"/> structure containing joystick information. </param>
	/// <param name="axis"> The axis to query; the axis indices start at index 0. </param>
	/// <returns> A 16-bit signed integer representing the current position of the axis or 0 on failure; call <see cref="GetError"/> for more information. </returns>
	public static short GetJoystickAxis(SDL_Joystick* joystick, int axis)
	{
		return _PInvoke(joystick, axis);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickAxis", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern short _PInvoke(SDL_Joystick* joystick, int axis);
	}

	/// <summary>
	/// Get the initial state of an axis control on a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickAxisInitialState">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> An <see cref="SDL_Joystick"/> structure containing joystick information. </param>
	/// <param name="axis"> The axis to query; the axis indices start at index 0. </param>
	/// <param name="state"> Returns the initial value. </param>
	/// <returns> True if this axis has any initial value, or false if not. </returns>
	public static bool GetJoystickAxisInitialState(SDL_Joystick* joystick, int axis, out short state)
	{
		fixed (short* s = &state)
		{
			return _PInvoke(joystick, axis, s) == 1;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickAxisInitialState", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Joystick* joystick, int axis, short* state);
	}

	/// <summary>
	/// Get the ball axis change since the last poll.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickBall">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The <see cref="SDL_Joystick"/> to query. </param>
	/// <param name="ball"> The ball index to query; ball indices start at index 0. </param>
	/// <param name="dx"> Returns the difference in the x axis position since the last poll. </param>
	/// <param name="dy"> Returns the difference in the y axis position since the last poll. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetJoystickBall(SDL_Joystick* joystick, int ball, out int dx, out int dy)
	{
		fixed (int* x = &dx, y = &dy)
		{
			return _PInvoke(joystick, ball, x, y);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickAxisInitialState", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Joystick* joystick, int ball, int* dx, int* dy);
	}

	/// <summary>
	/// Get the current state of a POV hat on a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickHat">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> An <see cref="SDL_Joystick"/> structure containing joystick information. </param>
	/// <param name="hat"> The hat index to get the state from; indices start at index 0. </param>
	/// <returns> The current hat position. </returns>
	public static SDL_JoystickHatPosition GetJoystickHat(SDL_Joystick* joystick, int hat)
	{
		return _PInvoke(joystick, hat);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickHat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_JoystickHatPosition _PInvoke(SDL_Joystick* joystick, int hat);
	}

	/// <summary>
	/// Get the current state of a button on a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickButton">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> An <see cref="SDL_Joystick"/> structure containing joystick information. </param>
	/// <param name="button"> The button index to get the state from; indices start at index 0. </param>
	/// <returns> 1 if the specified button is pressed, 0 otherwise. </returns>
	public static byte GetJoystickButton(SDL_Joystick* joystick, int button)
	{
		return _PInvoke(joystick, button);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickButton", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte _PInvoke(SDL_Joystick* joystick, int button);
	}

	/// <summary>
	/// Start a rumble effect.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_RumbleJoystick">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The joystick to vibrate. </param>
	/// <param name="lowFrequencyRumble"> The intensity of the low frequency (left) rumble motor, from 0 to 0xFFFF. </param>
	/// <param name="highFrequencyRumble"> The intensity of the high frequency (right) rumble motor, from 0 to 0xFFFF. </param>
	/// <param name="durationMs"> The duration of the rumble effect, in milliseconds. </param>
	/// <returns> 0, or -1 if rumble isn't supported on this joystick. </returns>
	public static int RumbleJoystick(SDL_Joystick* joystick, ushort lowFrequencyRumble, ushort highFrequencyRumble, uint durationMs)
	{
		return _PInvoke(joystick, lowFrequencyRumble, highFrequencyRumble, durationMs);

		[DllImport(LibraryName, EntryPoint = "SDL_RumbleJoystick", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Joystick* joystick, ushort lowFrequencyRumble, ushort highFrequencyRumble, uint durationMs);
	}

	/// <summary>
	/// Start a rumble effect in the joystick's triggers.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_RumbleJoystickTriggers">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The joystick to vibrate </param>
	/// <param name="leftRumble"> The intensity of the left trigger rumble motor, from 0 to 0xFFFF. </param>
	/// <param name="rightRumble"> The intensity of the right trigger rumble motor, from 0 to 0xFFFF. </param>
	/// <param name="durationMs"> The duration of the rumble effect, in milliseconds. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int RumbleJoystickTriggers(SDL_Joystick* joystick, ushort leftRumble, ushort rightRumble, uint durationMs)
	{
		return _PInvoke(joystick, leftRumble, rightRumble, durationMs);

		[DllImport(LibraryName, EntryPoint = "SDL_RumbleJoystickTriggers", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Joystick* joystick, ushort leftRumble, ushort rightRumble, uint durationMs);
	}

	/// <summary>
	/// Update a joystick's LED color.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetJoystickLED">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The joystick to update. </param>
	/// <param name="red"> The intensity of the red LED. </param>
	/// <param name="green"> The intensity of the green LED. </param>
	/// <param name="blue"> The intensity of the blue LED. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetJoystickLed(SDL_Joystick* joystick, byte red, byte green, byte blue)
	{
		return _PInvoke(joystick, red, green, blue);

		[DllImport(LibraryName, EntryPoint = "SDL_SetJoystickLED", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Joystick* joystick, byte red, byte green, byte blue);
	}

	/// <summary>
	/// Send a joystick specific effect packet.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SendJoystickEffect">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The joystick to affect. </param>
	/// <param name="data"> The data to send to the joystick. </param>
	/// <param name="size"> The size of the data to send to the joystick. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SendJoystickEffect(SDL_Joystick* joystick, void* data, int size)
	{
		return _PInvoke(joystick, data, size);

		[DllImport(LibraryName, EntryPoint = "SDL_SendJoystickEffect", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Joystick* joystick, void* data, int size);
	}

	/// <summary>
	/// Close a joystick previously opened with <see cref="OpenJoystick(SDL_JoystickId)"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CloseJoystick">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The joystick device to close. </param>
	public static void CloseJoystick(SDL_Joystick* joystick)
	{
		_PInvoke(joystick);

		[DllImport(LibraryName, EntryPoint = "SDL_CloseJoystick", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(SDL_Joystick* joystick);
	}

	/// <summary>
	/// Get the connection state of a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickConnectionState">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The joystick to query. </param>
	/// <returns> The connection state on success or <see cref="SDL_JoystickConnectionState.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_JoystickConnectionState GetJoystickConnectionState(SDL_Joystick* joystick)
	{
		return _PInvoke(joystick);

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickConnectionState", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_JoystickConnectionState _PInvoke(SDL_Joystick* joystick);
	}

	/// <summary>
	/// Get the battery state of a joystick.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetJoystickPowerInfo">here</see> for more details.
	/// </remarks>
	/// <param name="joystick"> The joystick to query. </param>
	/// <param name="percent"> Returns the percentage of battery life left, between 0 and 100. This will return -1 if SDL can't determine a value or there is no battery. </param>
	/// <returns> The current battery state or <see cref="SDL_PowerState.Error"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_PowerState GetJoystickPowerInfo(SDL_Joystick* joystick, out int percent)
	{
		fixed (int* p = &percent)
		{
			return _PInvoke(joystick, p);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetJoystickPowerInfo", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_PowerState _PInvoke(SDL_Joystick* joystick, int* percent);
	}

	/// <summary>
	/// The largest value an <see cref="SDL_Joystick"/>'s axis can report.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_JOYSTICK_AXIS_MAX">here</see> for more details.
	/// </remarks>
	public const short JoystickAxisMax = short.MaxValue;

	/// <summary>
	/// The smallest value an <see cref="SDL_Joystick"/>'s axis can report.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_JOYSTICK_AXIS_MIN">here</see> for more details.
	/// </remarks>
	public const short JoystickAxisMin = short.MinValue;

	/// <summary>
	/// Set max recognized G-force from accelerometer.
	/// </summary>
	public const float IPhoneMaxGForce = 5.0f;
}