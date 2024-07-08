using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_touch.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_touch.h.
unsafe partial class SDL
{
	/// <summary>
	/// Get a list of registered touch fingers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTouchDevices">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">The number of fingers returned.</param>
	/// <returns>An array of touch device IDs, or <see langword="null"/> on error; call <see cref="GetError"/> for more details.</returns>
	public static SDL_TouchId[]? GetTouchDevices(out int count)
	{
		fixed (int* countPtr = &count)
		{
			SDL_TouchId[]? devices = null;
			SDL_TouchId* devicesPtr = SDL_GetTouchDevices(countPtr);
			if (devicesPtr is not null)
			{
				devices = new SDL_TouchId[count];
				for (int i = 0; i < count; i++)
				{
					devices[i] = devicesPtr[i];
				}
				Free(devicesPtr);
			}
			return devices;
		}

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_TouchId* SDL_GetTouchDevices(int* count);
	}

	/// <summary>
	/// Get the touch device name as reported from the driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTouchDeviceName">documentation</see> for more details.
	/// </remarks>
	/// <param name="touchId">The touch device instance ID.</param>
	/// <returns>Touch device name, or <see langword="null"/> on error; call <see cref="GetError"/> for more details.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTouchDeviceName", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetTouchDeviceName(SDL_TouchId touchId);

	/// <summary>
	/// Get the type of the given touch device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTouchDeviceType">documentation</see> for more details.
	/// </remarks>
	/// <param name="touchId">The touch device instance ID.</param>
	/// <returns>The touch device type.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTouchDeviceType")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_TouchDeviceType GetTouchDeviceType(SDL_TouchId touchId);

	/// <summary>
	/// Get a list of active fingers for a given touch device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTouchFingers">documentation</see> for more details.
	/// </remarks>
	/// <param name="touchId">The touch device instance ID.</param>
	/// <param name="count">The number of fingers returned.</param>
	/// <returns>An array of <see cref="SDL_Finger"/> structures, or <see langword="null"/> on error; call <see cref="GetError"/> for more details.</returns>
	public static SDL_Finger[]? GetTouchFingers(SDL_TouchId touchId, out int count)
	{
		fixed (int* countPtr = &count)
		{
			SDL_Finger[]? fingers = null;
			SDL_Finger* fingersPtr = SDL_GetTouchFingers(countPtr);
			if (fingersPtr is not null)
			{
				fingers = new SDL_Finger[count];
				for (int i = 0; i < count; i++)
				{
					fingers[i] = fingersPtr[i];
				}
				Free(fingersPtr);
			}
			return fingers;
		}

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Finger* SDL_GetTouchFingers(int* count);
	}

	/// <summary>
	/// Used as the device ID for mouse events simulated with touch input.
	/// </summary>
	public static SDL_MouseId TouchMouseId => unchecked((SDL_MouseId)(-1));

	/// <summary>
	/// Used as the device ID for touch events simulated with mouse input.
	/// </summary>
	public static SDL_TouchId MouseTouchId => unchecked((SDL_TouchId)(-1));
}