using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_touch.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_touch.h.
unsafe partial class SDL
{
	/// <summary>
	/// Get a list of registered touch devices.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetTouchDevices">here</see> for more details.
	/// </remarks>
	/// <param name="count"> Returns the number of devices. </param>
	/// <returns> An array of touch device IDs, or null on error; call <see cref="GetError"/> for more details. </returns>
	public static SDL_TouchId[]? GetTouchDevices(out int count)
	{
		fixed (int* c = &count)
		{
			SDL_TouchId* d = _PInvoke(c);
			if (d is null)
			{
				return null;
			}
			SDL_TouchId[] devices = new SDL_TouchId[count];
			for (int i = 0; i < count; i++)
			{
				devices[i] = d[i];
			}
			Free(d);
			return devices;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetTouchDevices", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_TouchId* _PInvoke(int* count);
	}

	/// <summary>
	/// Get the touch device name as reported from the driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetTouchDeviceName">here</see> for more details.
	/// </remarks>
	/// <param name="touchId"> The touch device instance ID. </param>
	/// <returns> Touch device name, or null on error; call <see cref="GetError"/> for more details. </returns>
	public static string? GetTouchDeviceName(SDL_TouchId touchId)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(touchId));

		[DllImport(LibraryName, EntryPoint = "SDL_GetTouchDeviceName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_TouchId touchId);
	}

	/// <summary>
	/// Get the type of the given touch device.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetTouchDeviceType">here</see> for more details.
	/// </remarks>
	/// <param name="touchId"> The touch device instance ID. </param>
	/// <returns> The touch device type. </returns>
	public static SDL_TouchDeviceType GetTouchDeviceType(SDL_TouchId touchId)
	{
		return _PInvoke(touchId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetTouchDeviceType", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_TouchDeviceType _PInvoke(SDL_TouchId touchId);
	}

	/// <summary>
	/// Get a list of active fingers for a given touch device.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetTouchFingers">here</see> for more details.
	/// </remarks>
	/// <param name="touchId"> The touch device instance ID. </param>
	/// <param name="count"> Returns the number of fingers. </param>
	/// <returns> An array of <see cref="SDL_Finger"/> structures, or null on error; call <see cref="GetError"/> for more details. </returns>
	public static SDL_Finger[]? GetTouchFingers(SDL_TouchId touchId, out int count)
	{
		fixed (int* c = &count)
		{
			SDL_Finger** f = _PInvoke(touchId, c);
			if (f is null)
			{
				return null;
			}
			SDL_Finger[] fingers = new SDL_Finger[count];
			for (int i = 0; i < count; i++)
			{
				fingers[i] = *f[i];
			}
			Free(f);
			return fingers;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetTouchFingers", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Finger** _PInvoke(SDL_TouchId touchId, int* count);
	}

	/// <summary>
	/// Used as the device ID for mouse events simulated with touch input.
	/// </summary>
	public static SDL_MouseId TouchMouseId => new(uint.MaxValue);

	/// <summary>
	/// Used as the device ID for touch events simulated with mouse input.
	/// </summary>
	public static SDL_TouchId MouseTouchId => new(uint.MaxValue);
}