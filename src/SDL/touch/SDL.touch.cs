using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SDL3;

// SDL_touch.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_touch.h.
public static unsafe partial class SDL
{
	/// <summary>
	/// Get a list of registered touch fingers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTouchDevices">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">A pointer filled in with the number of fingers returned, may be <see langword="null"/>.</param>
	/// <returns>A null-terminated array of touch device IDs or <see langword="null"/> on failure; call <see cref="GetError"/> for more information. This should be freed with <see cref="free(nint)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTouchDevices")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_TouchId* GetTouchDevices(int* count);

	/// <summary>
	/// Get the touch device name as reported from the driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTouchDeviceName">documentation</see> for more details.
	/// </remarks>
	/// <param name="touchId">The touch device instance ID.</param>
	/// <returns>Touch device name, or <see langword="null"/> on failure; call <see cref="GetError"/> for more details.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTouchDeviceName")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string? GetTouchDeviceName(SDL_TouchId touchId);

	/// <summary>
	/// Get the type of the given touch device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTouchDeviceType">documentation</see> for more details.
	/// </remarks>
	/// <param name="touchId">The ID of a touch device.</param>
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
	/// <param name="touchId">The ID of a touch device.</param>
	/// <param name="count">A pointer filled in with the number of fingers returned, can be <see langword="null"/>.</param>
	/// <returns>A <see langword="null"/> terminated array of <see cref="SDL_Finger"/> pointers or <see langword="null"/> on failure; call <see cref="GetError"/> for more information. This is a single allocation that should be freed with <see cref="free(nint)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTouchFingers")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Finger** GetTouchFingers(SDL_TouchId touchId, int* count);

	/// <summary>
	/// Used as the device ID for mouse events simulated with touch input.
	/// </summary>
	public static SDL_MouseId TouchMouseId => unchecked((SDL_MouseId)(-1));

	/// <summary>
	/// Used as the device ID for touch events simulated with mouse input.
	/// </summary>
	public static SDL_TouchId MouseTouchId => unchecked((SDL_TouchId)(-1));
}