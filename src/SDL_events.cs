namespace SDL3;

// SDL_events.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_events.h
unsafe partial class SDL
{
	/// <summary>
	/// The types of events that can be delivered.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_EventType">here</see>.
	/// </remarks>
	public enum EventType
	{
		/// <summary>
		/// Unused (do not remove)
		/// </summary>
		First = 0,

		#region Application events

		/// <summary>
		/// User-requested quit.
		/// </summary>
		Quit = 0x100,

		/// <summary>
		/// The application is being terminated by the OS.
		/// </summary>
		/// <remarks>
		/// Called on iOS in <c>applicationWillTerminate()</c>. Called on Android in <c>onDestroy()</c>.
		/// </remarks>
		Terminating,

		/// <summary>
		/// The application is low on memory, free memory if possible.
		/// </summary>
		/// <remarks>
		/// Called on iOS in <c>applicationDidReceiveMemoryWarning()</c>. Called on Android in <c>onLowMemory()</c>.
		/// </remarks>
		LowMemory,

		/// <summary>
		/// The application is about to enter the background.
		/// </summary>
		/// <remarks>
		/// Called on iOS in <c>applicationWillResignActive()</c>. Called on Android in <c>onPause()</c>.
		/// </remarks>
		WillEnterBackground,

		/// <summary>
		/// The application did enter the background and may not get CPU for some time.
		/// </summary>
		/// <remarks>
		/// Called on iOS in <c>applicationDidEnterBackground()</c>. Called on Android in <c>onPause()</c>.
		/// </remarks>
		DidEnterBackground,

		/// <summary>
		/// The application is about to enter the foreground.
		/// </summary>
		/// <remarks>
		/// Called on iOS in <c>applicationWillEnterForeground()</c>. Called on Android in <c>onResume()</c>.
		/// </remarks>
		WillEnterForeground,

		/// <summary>
		/// The application is now interactive.
		/// </summary>
		/// <remarks>
		/// Called on iOS in <c>applicationDidBecomeActive()</c>. Called on Android in <c>onResume()</c>.
		/// </remarks>
		DidEnterForeground,

		/// <summary>
		/// The user's locale preferences have changed.
		/// </summary>
		LocaleChanged,

		/// <summary>
		/// The system theme changed.
		/// </summary>
		SystemThemeChanged,

		#endregion

		#region Display events

		/// <summary>
		/// Display orientation has changed to data1.
		/// </summary>
		DisplayOrientation = 0x151,

		/// <summary>
		/// Display has been added to the system.
		/// </summary>
		DisplayAdded,

		/// <summary>
		/// Display has been removed from the system.
		/// </summary>
		DisplayRemoved,

		/// <summary>
		/// Display has changed position.
		/// </summary>
		DisplayMoved,

		/// <summary>
		/// Display has changed content scale
		/// </summary>
		DisplayContentScaleChanged,

		/// <summary>
		/// Display HDR properties have changed.
		/// </summary>
		DisplayHDRStateChanged,

		DisplayFirst = DisplayOrientation,
		DisplayLast = DisplayHDRStateChanged,

		#endregion

		#region Window events.

		#endregion
	}

	/// <summary>
	/// Keyboard/mouse released state.
	/// </summary>
	public const int RELEASED = 0;

	/// <summary>
	/// Keyboard/mouse pressed state.
	/// </summary>
	public const int PRESSED = 1;
}