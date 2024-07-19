using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_timer.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_timer.h.
public static unsafe partial class SDL
{
	[Macro]
	public static ulong SecondsToNs(ulong s) => s * NsPerSecond;

	[Macro]
	public static double NsToSeconds(ulong ns) => ns / (double)NsPerSecond;

	[Macro]
	public static ulong MsToNs(ulong ms) => ms * NsPerMs;

	[Macro]
	public static double NsToMs(ulong ns) => ns / (double)NsPerMs;

	[Macro]
	public static ulong UsToNs(ulong us) => us * NsPerUs;

	[Macro]
	public static double NsToUs(ulong ns) => ns / (double)NsPerUs;

	/// <summary>
	/// Get the number of milliseconds since SDL library initialization.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTicks">documentation</see> for more details.
	/// </remarks>
	/// <returns>An unsigned 64-bit value representing the number of milliseconds since the SDL library initialized.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTicks")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial ulong GetTicks();

	/// <summary>
	/// Get the number of nanoseconds since SDL library initialization.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTicksNS">documentation</see> for more details.
	/// </remarks>
	/// <returns>An unsigned 64-bit value representing the number of nanoseconds since the SDL library initialized.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTicksNS")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial ulong GetTicksNs();

	/// <summary>
	/// Get the current value of the high resolution counter.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetPerformanceCounter">documentation</see> for more details.
	/// </remarks>
	/// <returns>The current counter value.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetPerformanceCounter")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial ulong GetPerformanceCounter();

	/// <summary>
	/// Get the count per second of the high resolution counter.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetPerformanceFrequency">documentation</see> for more details.
	/// </remarks>
	/// <returns>A platform-specific count per second.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetPerformanceFrequency")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial ulong GetPerformanceFrequency();

	/// <summary>
	/// Wait a specified number of milliseconds before returning.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Delay">documentation</see> for more details.
	/// </remarks>
	/// <param name="ms">The number of milliseconds to delay.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_Delay")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void Delay(uint ms);

	/// <summary>
	/// Wait a specified number of nanoseconds before returning.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DelayNS">documentation</see> for more details.
	/// </remarks>
	/// <param name="ms">The number of nanoseconds to delay.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DelayNS")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void DelayNs(ulong ns);

	/// <summary>
	/// Call a callback function at a future time.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AddTimer">documentation</see> for more details.
	/// </remarks>
	/// <param name="intervalMs">The timer delay, in milliseconds, passed to <paramref name="callback"/>.</param>
	/// <param name="callback">The <see cref="SDL_TimerCallback"/> function to call when the specified <paramref name="intervalMs"/> elapses.</param>
	/// <param name="userData">A pointer that is passed to <paramref name="callback"/>.</param>
	/// <returns>A timer ID or <see cref="SDL_TimerId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_AddTimer")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_TimerId AddTimer(uint intervalMs, SDL_TimerCallback callback, nint userData);

	/// <summary>
	/// Call a callback function at a future time.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AddTimerNS">documentation</see> for more details.
	/// </remarks>
	/// <param name="intervalNs">The timer delay, in nanoseconds, passed to <paramref name="callback"/>.</param>
	/// <param name="callback">The <see cref="SDL_NsTimerCallback"/> function to call when the specified <paramref name="intervalNs"/> elapses.</param>
	/// <param name="userData">A pointer that is passed to <paramref name="callback"/>.</param>
	/// <returns>A timer ID or <see cref="SDL_TimerId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_AddTimerNS")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_TimerId AddTimerNs(ulong intervalNs, SDL_NsTimerCallback callback, nint userData);

	/// <summary>
	/// Remove a timer created with <see cref="AddTimer(uint, SDL_TimerCallback, nint)"/> or <see cref="AddTimerNs(ulong, SDL_NsTimerCallback, nint)"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RemoveTimer">documentation</see> for more details.
	/// </remarks>
	/// <param name="timerId">The ID of the timer to remove.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RemoveTimer")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int RemoveTimer(SDL_TimerId timerId);

	/// <summary>
	/// The number of miliseconds in a second.
	/// </summary>
	public const ulong MsPerSecond = 1000uL;

	/// <summary>
	/// The number of microseconds in a second.
	/// </summary>
	public const ulong UsToSecond = 1000000uL;

	/// <summary>
	/// The number of nanoseconds in a second.
	/// </summary>
	public const ulong NsPerSecond = 1000000000uL;

	/// <summary>
	/// The number of nanoseconds in a milisecond.
	/// </summary>
	public const ulong NsPerMs = 1000000uL;

	/// <summary>
	/// The number of nanoseconds in a microsecond.
	/// </summary>
	public const ulong NsPerUs = 1000uL;
}