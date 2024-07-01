namespace SDL_cs;

// SDL_timer.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_timer.h.
unsafe partial class SDL
{
	/// <summary>
	/// Converts a given amount of seconds into nanoseconds.
	/// </summary>
	/// <param name="s">The number of seconds to convert.</param>
	/// <returns>The equivalent of <paramref name="s"/> in nanoseconds.</returns>
	[Macro]
	public static ulong SecondsToNs(ulong s)
	{
		return s * NsPerSecond;
	}

	/// <summary>
	/// Converts a given amount of nanoseconds into seconds.
	/// </summary>
	/// <param name="ns">The number of nanoseconds to convert.</param>
	/// <returns>The equivalent of <paramref name="ns"/> in seconds.</returns>
	[Macro]
	public static double NsToSeconds(ulong ns)
	{
		return ns / (double)NsPerSecond;
	}

	/// <summary>
	/// Converts a given amount of miliseconds into nanoseconds.
	/// </summary>
	/// <param name="ms">The number of miliseconds to convert.</param>
	/// <returns>The equivalent of <paramref name="ms"/> in nanoseconds.</returns>
	[Macro]
	public static ulong MsToNs(ulong ms)
	{
		return ms * NsPerMs;
	}

	/// <summary>
	/// Converts a given amount of nanoseconds into miliseconds.
	/// </summary>
	/// <param name="ns">The number of nanoseconds to convert.</param>
	/// <returns>The equivalent of <paramref name="ns"/> in miliseconds.</returns>
	[Macro]
	public static double NsToMs(ulong ns)
	{
		return ns / (double)NsPerMs;
	}

	/// <summary>
	/// Converts a given amount of microseconds into nanoseconds.
	/// </summary>
	/// <param name="us">The number of microseconds to convert.</param>
	/// <returns>The equivalent of <paramref name="us"/> in nanoseconds.</returns>
	[Macro]
	public static ulong UsToNs(ulong us)
	{
		return us * NsPerUs;
	}

	/// <summary>
	/// Converts a given amount of nanoseconds into microseconds.
	/// </summary>
	/// <param name="ns">The number of nanoseconds to convert.</param>
	/// <returns>The equivalent of <paramref name="ns"/> in microseconds.</returns>
	[Macro]
	public static double NsToUs(ulong ns)
	{
		return ns / (double)NsPerUs;
	}

	/// <summary>
	/// Get the number of milliseconds since SDL library initialization.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTicks">documentation</see> for more details.
	/// </remarks>
	/// <returns>An unsigned 64-bit value representing the number of milliseconds since the SDL library initialized.</returns>
	public static ulong GetTicksMs()
	{
		return SDL_PInvoke.SDL_GetTicks();
	}

	/// <summary>
	/// Get the number of nanoseconds since SDL library initialization.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTicksNS">documentation</see> for more details.
	/// </remarks>
	/// <returns>An unsigned 64-bit value representing the number of nanoseconds since the SDL library initialized.</returns>
	public static ulong GetTicksNs()
	{
		return SDL_PInvoke.SDL_GetTicksNS();
	}

	/// <summary>
	/// Get the current value of the high resolution counter.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetPerformanceCounter">documentation</see> for more details.
	/// </remarks>
	/// <returns>The current counter value.</returns>
	public static ulong GetPerformanceCounter()
	{
		return SDL_PInvoke.SDL_GetPerformanceCounter();
	}

	/// <summary>
	/// Get the count per second of the high resolution counter.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetPerformanceFrequency">documentation</see> for more details.
	/// </remarks>
	/// <returns> A platform-specific count per second. </returns>
	public static ulong GetPerformanceFrequency()
	{
		return SDL_PInvoke.SDL_GetPerformanceFrequency();
	}

	/// <summary>
	/// Wait a specified number of milliseconds before returning.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Delay">documentation</see> for more details.
	/// </remarks>
	/// <param name="ms">The number of milliseconds to delay.</param>
	public static void Delay(uint ms)
	{
		SDL_PInvoke.SDL_Delay(ms);
	}

	/// <summary>
	/// Wait a specified number of nanoseconds before returning.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DelayNS">documentation</see> for more details.
	/// </remarks>
	/// <param name="ms">The number of nanoseconds to delay.</param>
	public static void DelayNs(ulong ns)
	{
		SDL_PInvoke.SDL_DelayNS(ns);
	}

	/// <summary>
	/// Call a callback function at a future time.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AddTimer">documentation</see> for more details.
	/// </remarks>
	/// <param name="intervalMs">The timer delay, in milliseconds, passed to <paramref name="callback"/>.</param>
	/// <param name="callback">The <see cref="SDL_TimerCallback"/> function to call when the specified <paramref name="intervalMs"/> elapses.</param>
	/// <param name="userData">A pointer that is passed to <paramref name="callback"/>.</param>
	/// <returns>A timer ID or <see cref="SDL_TimerId.Invalid"/> if an error occurs; call <see cref="GetError"/> for more information.</returns>
	public static SDL_TimerId AddTimer(uint intervalMs, SDL_TimerCallback callback, void* userData)
	{
		return SDL_PInvoke.SDL_AddTimer(intervalMs, callback, userData);
	}

	/// <summary>
	/// Call a callback function at a future time.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AddTimerNS">documentation</see> for more details.
	/// </remarks>
	/// <param name="intervalNs">The timer delay, in nanoseconds, passed to <paramref name="callback"/>.</param>
	/// <param name="callback">The <see cref="SDL_NsTimerCallback"/> function to call when the specified <paramref name="intervalNs"/> elapses.</param>
	/// <param name="userData">A pointer that is passed to <paramref name="callback"/>.</param>
	/// <returns>A timer ID or <see cref="SDL_TimerId.Invalid"/> if an error occurs; call <see cref="GetError"/> for more information.</returns>
	public static SDL_TimerId AddTimerNs(ulong intervalNs, SDL_NsTimerCallback callback, void* userData)
	{
		return SDL_PInvoke.SDL_AddTimerNS(intervalNs, callback, userData);
	}

	/// <summary>
	/// Remove a timer created with <see cref="AddTimer(uint, SDL_TimerCallback, void*)"/> or <see cref="AddTimerNs(ulong, SDL_NsTimerCallback, void*)"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RemoveTimer">documentation</see> for more details.
	/// </remarks>
	/// <param name="timerId">The ID of the timer to remove.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int RemoveTimer(SDL_TimerId timerId)
	{
		return SDL_PInvoke.SDL_RemoveTimer(timerId);
	}

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