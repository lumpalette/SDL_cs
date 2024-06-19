using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_power.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_power.h.
unsafe partial class SDL
{
	/// <summary>
	/// Get the current power supply details.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetPowerInfo">here</see> for more details.
	/// </remarks>
	/// <param name="seconds"> Returns the seconds of battery life left. This will return -1 if SDL can't determine a value or there is no battery. </param>
	/// <param name="percent"> Returns the percentage of battery life left, between 0 and 100. This will return -1 if SDL can't determine a value or there is no battery. </param>
	/// <returns> The current battery state or <see cref="SDL_PowerState.Error"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_PowerState GetPowerInfo(out int seconds, out int percent)
	{
		fixed (int* s = &seconds, p = &percent)
		{
			return _PInvoke(s, p);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetPowerInfo", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_PowerState _PInvoke(int* seconds, int* percent);
	}
}