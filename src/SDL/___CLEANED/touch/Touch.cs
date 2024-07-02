using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_touch.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_touch.h.
unsafe partial class SDL
{
	/// <summary>
	/// Get a list of registered touch devices.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTouchDevices">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">The number of devices returned.</param>
	/// <returns>An array of touch device IDs, or <see langword="null"/> on error; call <see cref="GetError"/> for more details.</returns>
	public static SDL_TouchId[]? GetTouchDevices(out int count)
	{
		fixed (int* countPtr = &count)
		{
			var d = SDL_PInvoke.SDL_GetTouchDevices(countPtr);
			if (d is null)
			{
				return null;
			}
			var devices = new SDL_TouchId[count];
			for (int i = 0; i < count; i++)
			{
				devices[i] = d[i];
			}
			Free(d);
			return devices;
		}
	}

	/// <summary>
	/// Get the touch device name as reported from the driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTouchDeviceName">documentation</see> for more details.
	/// </remarks>
	/// <param name="touchId">The touch device instance ID.</param>
	/// <returns>Touch device name, or <see langword="null"/> on error; call <see cref="GetError"/> for more details.</returns>
	public static string? GetTouchDeviceName(SDL_TouchId touchId)
	{
		return Marshal.PtrToStringUTF8((nint)SDL_PInvoke.SDL_GetTouchDeviceName(touchId));
	}

	/// <summary>
	/// Get the type of the given touch device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTouchDeviceType">documentation</see> for more details.
	/// </remarks>
	/// <param name="touchId">The touch device instance ID.</param>
	/// <returns>The touch device type.</returns>
	public static SDL_TouchDeviceType GetTouchDeviceType(SDL_TouchId touchId)
	{
		return SDL_PInvoke.SDL_GetTouchDeviceType(touchId);
	}

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
			var f = SDL_PInvoke.SDL_GetTouchFingers(touchId, countPtr);
			if (f is null)
			{
				return null;
			}
			var fingers = new SDL_Finger[count];
			for (int i = 0; i < count; i++)
			{
				fingers[i] = *f[i];
			}
			Free(f);
			return fingers;
		}
	}

	/// <summary>
	/// Used as the device ID for mouse events simulated with touch input.
	/// </summary>
	public static SDL_MouseId TouchMouseId
	{
		get
		{
			unchecked
			{
				return (SDL_MouseId)(-1);
			}
		}
	}

	/// <summary>
	/// Used as the device ID for touch events simulated with mouse input.
	/// </summary>
	public static SDL_TouchId MouseTouchId
	{
		get
		{
			unchecked
			{
				return (SDL_TouchId)(-1);
			}
		}
	}
}