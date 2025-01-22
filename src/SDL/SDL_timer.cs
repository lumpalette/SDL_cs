using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// SDL_timer.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_timer.h.
namespace SDL3;

/// <summary>
/// Definition of the timer ID type.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_TimerID">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_TimerId : uint
{
	/// <summary>
	/// An invalid/null timer ID.
	/// </summary>
	Invalid = 0
}

unsafe partial class SDL
{
	/// <summary>
	/// Number of miliseconds in a second.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MS_PER_SECOND">documentation</see> for more details.
	/// </remarks>
	public const ulong MsPerSecond = 1000uL;

	/// <summary>
	/// Number of microseconds in a second.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_US_PER_SECOND">documentation</see> for more details.
	/// </remarks>
	public const ulong UsToSecond = 1000000uL;

	/// <summary>
	/// Number of nanoseconds in a second.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_NS_PER_SECOND">documentation</see> for more details.
	/// </remarks>
	public const ulong NsPerSecond = 1000000000uL;

	/// <summary>
	/// Number of nanoseconds in a milisecond.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_NS_PER_MS">documentation</see> for more details.
	/// </remarks>
	public const ulong NsPerMs = 1000000uL;

	/// <summary>
	/// Number of nanoseconds in a microsecond.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_NS_PER_US">documentation</see> for more details.
	/// </remarks>
	public const ulong NsPerUs = 1000uL;

	/// <summary>
	/// Convert seconds to nanoseconds.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SECONDS_TO_NS">documentation</see> for more details.
	/// </remarks>
	/// <param name="s">The number of seconds to convert.</param>
	/// <returns><paramref name="s"/>, expressed in nanoseconds.</returns>
	[Macro]
	public static ulong SecondsToNs(ulong s) => s * NsPerSecond;

	/// <summary>
	/// Convert nanoseconds to seconds.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_NS_TO_SECONDS">documentation</see> for more details.
	/// </remarks>
	/// <param name="ns">The number of nanoseconds to convert.</param>
	/// <returns><paramref name="ns"/>, expressed in seconds.</returns>
	[Macro]
	public static double NsToSeconds(ulong ns) => ns / (double)NsPerSecond;

	/// <summary>
	/// Convert milliseconds to nanoseconds.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MS_TO_NS">documentation</see> for more details.
	/// </remarks>
	/// <param name="ms">The number of miliseconds to convert.</param>
	/// <returns><paramref name="ms"/>, expressed in nanoseconds.</returns>
	[Macro]
	public static ulong MsToNs(ulong ms) => ms * NsPerMs;

	/// <summary>
	/// Convert nanoseconds to milliseconds.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_NS_TO_MS">documentation</see> for more details.
	/// </remarks>
	/// <param name="ns">The number of nanoseconds to convert.</param>
	/// <returns><paramref name="ns"/>, expressed in milliseconds.</returns>
	[Macro]
	public static double NsToMs(ulong ns) => ns / (double)NsPerMs;

	/// <summary>
	/// Convert microseconds to nanoseconds.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_US_TO_NS">documentation</see> for more details.
	/// </remarks>
	/// <param name="us">The number of microseconds to convert.</param>
	/// <returns><paramref name="us"/>, expressed in nanoseconds.</returns>
	[Macro]
	public static ulong UsToNs(ulong us) => us * NsPerUs;

	/// <summary>
	/// Convert nanoseconds to microseconds.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_NS_TO_US">documentation</see> for more details.
	/// </remarks>
	/// <param name="ns">The number of nanoseconds to convert.</param>
	/// <returns><paramref name="ns"/>, expressed in microseconds.</returns>
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
	/// <param name="ns">The number of nanoseconds to delay.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DelayNS")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void DelayNs(ulong ns);

	/// <summary>
	/// Wait a specified number of nanoseconds before returning.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DelayPrecise">documentation</see> for more details.
	/// </remarks>
	/// <param name="ns">The number of nanoseconds to delay.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DelayPrecise")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void DelayPrecise(ulong ns);

	/// <summary>
	/// Call a callback function at a future time.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AddTimer">documentation</see> for more details.
	/// </remarks>
	/// <param name="intervalMs">The timer delay, in milliseconds, passed to <paramref name="callback"/>.</param>
	/// <param name="callback">The <c>SDL_TimerCallback</c> function to call when the specified <paramref name="intervalMs"/> elapses.</param>
	/// <param name="userData">A pointer that is passed to <paramref name="callback"/>.</param>
	/// <returns>A timer ID or <see cref="SDL_TimerId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_AddTimer")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_TimerId AddTimer(uint intervalMs, delegate* unmanaged[Cdecl]<nint, SDL_TimerId, uint, uint> callback, nint userData);

	/// <summary>
	/// Call a callback function at a future time.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AddTimerNS">documentation</see> for more details.
	/// </remarks>
	/// <param name="intervalNs">The timer delay, in nanoseconds, passed to <paramref name="callback"/>.</param>
	/// <param name="callback">The <c>SDL_NsTimerCallback</c> function to call when the specified <paramref name="intervalNs"/> elapses.</param>
	/// <param name="userData">A pointer that is passed to <paramref name="callback"/>.</param>
	/// <returns>A timer ID or <see cref="SDL_TimerId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_AddTimerNS")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_TimerId AddTimerNs(ulong intervalNs, delegate* unmanaged[Cdecl]<nint, SDL_TimerId, ulong, ulong> callback, nint userData);

	/// <summary>
	/// Remove a timer created with <see cref="AddTimer"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RemoveTimer">documentation</see> for more details.
	/// </remarks>
	/// <param name="timerId">The ID of the timer to remove.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RemoveTimer")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool RemoveTimer(SDL_TimerId timerId);
}