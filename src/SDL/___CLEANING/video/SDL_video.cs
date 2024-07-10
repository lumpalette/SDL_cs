using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_video.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_video.h.
unsafe partial class SDL
{
	public static uint WindowposUndefinedDisplay(uint x) => WindowposUndefinedMask | x;

	public static bool WindowposIsUndefined(uint x) => (x & 0xFFFF0000) == WindowposUndefinedMask;

	public static uint WindowposCenteredDisplay(uint x) => WindowposCenteredMask | x;

	public static bool WindowposIsCentered(uint x) => (x & 0xFFFF0000) == WindowposCenteredMask;

	/// <summary>
	/// Get the number of video drivers compiled into SDL.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumVideoDrivers">documentation</see> for more details.
	/// </remarks>
	/// <returns>A number >= 1 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetNumVideoDrivers")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetNumVideoDrivers();

	/// <summary>
	/// Get the name of a built in video driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetVideoDriver">documentation</see> for more details.
	/// </remarks>
	/// <param name="index">The index of a video driver.</param>
	/// <returns>The name of the video driver with the given <paramref name="index"/>.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetVideoDriver", StringMarshallingCustomType = typeof(SDLManagedStringMarshaller))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetVideoDriver(int index);

	/// <summary>
	/// Get the name of the currently initialized video driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentVideoDriver">documentation</see> for more details.
	/// </remarks>
	/// <returns>The name of the current video driver or <see langword="null"/> if no driver has been initialized.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentVideoDriver", StringMarshallingCustomType = typeof(SDLManagedStringMarshaller))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetCurrentVideoDriver();

	/// <summary>
	/// Get the current system theme.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSystemTheme">documentation</see> for more details.
	/// </remarks>
	/// <returns>The current system theme, light, dark, or unknown.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSystemTheme")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_SystemTheme GetSystemTheme();

	/// <summary>
	/// Get a list of currently connected displays.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplays">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">A pointer filled in with the number of displays returned.</param>
	/// <returns>A null-terminated array of display instance IDs which should be freed with <see cref="Free(void*)"/>, or <see langword="null"/> on error; call <see cref="GetError"/> for more details.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplays")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_DisplayId* GetDisplays(out int count);

	/// <summary>
	/// Return the primary display.
	/// </summary>
	/// <returns>The instance ID of the primary display on success or <see cref="SDL_DisplayId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetPrimaryDisplay")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_DisplayId GetPrimaryDisplay();

	public const uint WindowposUndefinedMask = 0x1FFF0000u;

	public const uint WindowposCenteredMask = 0x2FFF0000u;
}