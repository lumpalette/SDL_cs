using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_timer.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_timer.h.
unsafe partial class SDL
{
	/// <summary>
	/// Get the number of milliseconds since SDL library initialization.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetTicks">here</see> for more details.
	/// </remarks>
	/// <returns> An unsigned 64-bit value representing the number of milliseconds since the SDL library initialized. </returns>
	public static ulong GetTicksMs()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetTicks", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern ulong _PInvoke();
	}

	/// <summary>
	/// Get the number of nanoseconds since SDL library initialization.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetTicksNS">here</see> for more details.
	/// </remarks>
	/// <returns> An unsigned 64-bit value representing the number of nanoseconds since the SDL library initialized. </returns>
	public static ulong GetTicksNs()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetTicksNS", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern ulong _PInvoke();
	}

	/// <summary>
	/// Get the current value of the high resolution counter.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetPerformanceCounter">here</see> for more details.
	/// </remarks>
	/// <returns> The current counter value. </returns>
	public static ulong GetPerformanceCounter()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetPerformanceCounter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern ulong _PInvoke();
	}

	/// <summary>
	/// Get the count per second of the high resolution counter.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetPerformanceFrequency">here</see> for more details.
	/// </remarks>
	/// <returns> A platform-specific count per second. </returns>
	public static ulong GetPerformanceFrequency()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetPerformanceFrequency", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern ulong _PInvoke();
	}

	/// <summary>
	/// Wait a specified number of milliseconds before returning.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_Delay">here</see> for more details.
	/// </remarks>
	/// <param name="ms"> The number of milliseconds to delay. </param>
	public static void DelayMs(uint ms)
	{
		_PInvoke(ms);

		[DllImport(LibraryName, EntryPoint = "SDL_Delay", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(uint ms);
	}

	/// <summary>
	/// Wait a specified number of nanoseconds before returning.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_DelayNS">here</see> for more details.
	/// </remarks>
	/// <param name="ms"> The number of nanoseconds to delay. </param>
	public static void DelayNs(ulong ns)
	{
		_PInvoke(ns);

		[DllImport(LibraryName, EntryPoint = "SDL_DelayNS", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(ulong ns);
	}

	/// <summary>
	/// Call a callback function at a future time.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_AddTimer">here</see> for more details.
	/// </remarks>
	/// <param name="intervalMs"> The timer delay, in milliseconds, passed to <paramref name="callback"/>. </param>
	/// <param name="callback"> The <see cref="SDL_TimerMsCallback"/> function to call when the specified <paramref name="intervalMs"/> elapses. </param>
	/// <param name="userData"> A pointer that is passed to <paramref name="callback"/>. </param>
	/// <returns> A timer ID or 0 if an error occurs; call <see cref="GetError"/> for more information. </returns>
	public static SDL_TimerId SDL_AddTimerMs(uint intervalMs, SDL_TimerMsCallback callback, void* userData)
	{
		return _PInvoke(intervalMs, callback, userData);

		[DllImport(LibraryName, EntryPoint = "FUNC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_TimerId _PInvoke(uint intervalMs, SDL_TimerMsCallback callback, void* userData);
	}

	/// <summary>
	/// Call a callback function at a future time.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_AddTimerNS">here</see> for more details.
	/// </remarks>
	/// <param name="intervalNs"> The timer delay, in nanoseconds, passed to <paramref name="callback"/>. </param>
	/// <param name="callback"> The <see cref="SDL_TimerNsCallback"/> function to call when the specified <paramref name="intervalNs"/> elapses. </param>
	/// <param name="userData"> A pointer that is passed to <paramref name="callback"/>. </param>
	/// <returns> A timer ID or 0 if an error occurs; call <see cref="GetError"/> for more information. </returns>
	public static SDL_TimerId SDL_AddTimerNs(ulong intervalNs, SDL_TimerNsCallback callback, void* userData)
	{
		return _PInvoke(intervalNs, callback, userData);

		[DllImport(LibraryName, EntryPoint = "FUNC", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_TimerId _PInvoke(ulong intervalMs, SDL_TimerNsCallback callback, void* userData);
	}

	/// <summary>
	/// Remove a timer created with <see cref="SDL_AddTimerMs(uint, SDL_TimerMsCallback, void*)"/> or <see cref="SDL_AddTimerNs(ulong, SDL_TimerNsCallback, void*)"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_RemoveTimer">here</see> for more details.
	/// </remarks>
	/// <param name="timerId"> The ID of the timer to remove. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int RemoveTimer(SDL_TimerId timerId)
	{
		return _PInvoke(timerId);

		[DllImport(LibraryName, EntryPoint = "SDL_RemoveTimer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_TimerId timerId);
	}

	[Macro]
	public static ulong SecondsToNs(ulong s)
	{
		return s * NsPerSecond;
	}

	[Macro]
	public static double NsToSeconds(ulong ns)
	{
		return ns / (double)NsPerSecond;
	}

	[Macro]
	public static ulong MsToNs(ulong ms)
	{
		return ms * NsPerMs;
	}

	[Macro]
	public static double NsToMs(ulong ns)
	{
		return ns / (double)NsPerMs;
	}

	[Macro]
	public static ulong UsToNs(ulong us)
	{
		return us * NsPerUs;
	}

	[Macro]
	public static double NsToUs(ulong ns)
	{
		return ns / (double)NsPerUs;
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