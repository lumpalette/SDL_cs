using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL3;

// SDL_power.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_power.h.
unsafe partial class SDL
{
	/// <summary>
	/// Get the current power supply details.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetPowerInfo">documentation</see> for more details.
	/// </remarks>
	/// <param name="seconds">A pointer filled in with the seconds of battery life left. This will be filled in with -1 if we can't determine a value or there is no battery.</param>
	/// <param name="percent">A pointer filled in with the percentage of battery life left, between 0 and 100. This will be filled in with -1 we can't determine a value or there is no battery.</param>
	/// <returns>The current battery state or <see cref="SDL_PowerState.Error"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetPowerInfo")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PowerState GetPowerInfo(int* seconds, int* percent);
}