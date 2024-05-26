using System.Runtime.InteropServices;

namespace SDL3;

// SDL_events.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_events.h
unsafe partial class SDL
{
	/// <summary>
	/// Fields shared by every event.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CommonEvent">here</see>.
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	public struct CommonEvent
	{
		/// <summary>
		/// Event type, shared with all events, <see cref="uint"/> to cover user events which are not in the <see cref="EventType"/>
		/// enumeration.
		/// </summary>
		public uint Type;

		private readonly uint _reserved;

		/// <summary>
		/// In nanoseconds, populated using <see cref="FIXME:SDL_GetTicksNS()"/>.
		/// </summary>
		public ulong Timestamp;
	}

	/// <summary>
	/// Display state change event data (FIXME:event.display.*).
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_DisplayEvent">here</see>.
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	public struct DisplayEvent
	{
		/// <summary>
		/// An entry from <see cref="EventType"/> with the prefix <c>Display</c>.
		/// </summary>
		public EventType Type;

		private readonly uint _reserved;

		/// <summary>
		/// In nanoseconds, populated using <see cref="FIXME:SDL_GetTicksNS()"/>.
		/// </summary>
		public ulong Timestamp;

		/// <summary>
		/// The associated display.
		/// </summary>
		public DisplayId DisplayId;

		/// <summary>
		/// Event dependent data.
		/// </summary>
		public int Data1;
	}

	/// <summary>
	/// Window state change event data (FIXME:event.window.*).
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_WindowEvent">here</see>.
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	public struct WindowEvent
	{
		/// <summary>
		/// An entry from <see cref="EventType"/> with the prefix <c>Window</c>.
		/// </summary>
		public EventType Type;

		private readonly uint _reserved;

		/// <summary>
		/// In nanoseconds, populated using <see cref="FIXME:SDL_GetTicksNS()"/>.
		/// </summary>
		public ulong Timestamp;

		/// <summary>
		/// The associated window.
		/// </summary>
		public WindowId WindowId;

		/// <summary>
		/// Event dependent data.
		/// </summary>
		public int Data1;

		/// <summary>
		/// Event dependent data.
		/// </summary>
		public int Data2;
	}

	/// <summary>
	/// The types of events that can be delivered.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_EventType">here</see>.
	/// </remarks>
	public enum EventType : uint
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

		#region Window events

		/// <summary>
		/// Window has been shown.
		/// </summary>
		WindowShown = 0x202,

		/// <summary>
		/// Window has been hidden.
		/// </summary>
		WindowHidden,

		/// <summary>
		/// Window has been exposed and should be redrawn.
		/// </summary>
		WindowExposed,

		/// <summary>
		/// Window has been moved to data1 and data2.
		/// </summary>
		WindowMoved,

		/// <summary>
		/// Window has been resized to data1 x data2.
		/// </summary>
		WindowResized,

		/// <summary>
		/// Window has been minimized.
		/// </summary>
		WindowMinimized,

		/// <summary>
		/// Window has been maximized.
		/// </summary>
		WindowMaximized,

		/// <summary>
		/// Window has been restored to normal size and position.
		/// </summary>
		WindowRestored,

		/// <summary>
		/// Window has gained mouse focus.
		/// </summary>
		WindowMouseEnter,

		/// <summary>
		/// Window has lost mouse focus.
		/// </summary>
		WindowMouseLeave,

		/// <summary>
		/// Window has gained keyboard focus.
		/// </summary>
		WindowFocusGained,

		/// <summary>
		/// Window has lost keyboard focus.
		/// </summary>
		WindowFocusLost,

		/// <summary>
		/// The window manager requests that the window be closed.
		/// </summary>
		WindowCloseRequested,

		/// <summary>
		/// Window is being offered a focus (should <see cref="SetWindowInputFocus"/> on itself or a subwindow, or ignore).
		/// </summary>
		WindowTakeFocus,

		/// <summary>
		/// Window had a hit test that wasn't <see cref="FIXME:SDL_HITTEST_NORMAL"/>.
		/// </summary>
		WindowHitTest,

		/// <summary>
		/// The ICC profile of the window's display has changed.
		/// </summary>
		WindowICCProfileChanged,

		/// <summary>
		/// Window has been moved to display data1.
		/// </summary>
		WindowDisplayChanged,

		/// <summary>
		/// Window display scale has been changed.
		/// </summary>
		WindowDisplayScaleChanged,

		/// <summary>
		/// The window has been occluded.
		/// </summary>
		WindowOccluded,

		/// <summary>
		/// The window has entered fullscreen mode.
		/// </summary>
		WindowEnterFullscreenMode,

		/// <summary>
		/// The window has left fullscreen mode
		/// </summary>
		WindowLeaveFullscreenMode,

		/// <summary>
		/// The window with the associated ID is being or has been destroyed.
		/// </summary>
		/// <remarks>
		/// If this message is being handled in an event watcher, the window handle is still valid and can still be used
		/// to retrieve any userdata associated with the window. Otherwise, the handle has already been destroyed and all
		/// resources associated with it are invalid.
		/// </remarks>
		WindowDestroyed,

		/// <summary>
		/// Window has gained focus of the pressure-sensitive pen with ID "data1".
		/// </summary>
		WindowPenEnter,

		/// <summary>
		/// Window has lost focus of the pressure-sensitive pen with ID "data1".
		/// </summary>
		WindowPenLeave,

		WindowFirst = WindowShown,
		WindowLast = WindowPenLeave,

		#endregion

		#region Keyboard events

		/// <summary>
		/// Key pressed.
		/// </summary>
		KeyDown = 0x300,

		/// <summary>
		/// Key released.
		/// </summary>
		KeyUp,

		/// <summary>
		/// Keyboard text editing (composition).
		/// </summary>
		TextEditing,

		/// <summary>
		/// Keyboard text input.
		/// </summary>
		TextInput,

		/// <summary>
		/// Keymap changed due to a system event such as an input language or keyboard layout change.
		/// </summary>
		KeymapChanged,

		/// <summary>
		/// A new keyboard has been inserted into the system.
		/// </summary>
		KeyboardAdded,

		/// <summary>
		/// A keyboard has been removed.
		/// </summary>
		KeyboardRemoved,

		#endregion

		#region Mouse events

		/// <summary>
		/// Mouse moved.
		/// </summary>
		MouseMotion = 0x400,

		/// <summary>
		/// Mouse button pressed.
		/// </summary>
		MouseButtonDown,

		/// <summary>
		/// Mouse button released.
		/// </summary>
		MouseButtonUp,

		/// <summary>
		/// Mouse wheel motion.
		/// </summary>
		MouseWheel,

		/// <summary>
		/// A new mouse has been inserted into the system.
		/// </summary>
		MouseAdded,

		/// <summary>
		/// A mouse has been removed.
		/// </summary>
		MouseRemoved,

		#endregion

		#region Joystick events

		/// <summary>
		/// Joystick axis motion.
		/// </summary>
		JoystickAxisMotion = 0x600,

		/// <summary>
		/// Joystick trackball motion.
		/// </summary>
		JoystickBallMotion,

		/// <summary>
		/// Joystick hat position change.
		/// </summary>
		JoystickHatMotion,

		/// <summary>
		/// Joystick button pressed.
		/// </summary>
		JoystickButtonDown,

		/// <summary>
		/// Joystick button released.
		/// </summary>
		JoystickButtonUp,

		/// <summary>
		/// A new joystick has been inserted into the system.
		/// </summary>
		JoystickAdded,

		/// <summary>
		/// An opened joystick has been removed.
		/// </summary>
		JoystickRemoved,

		/// <summary>
		/// Joystick battery level change.
		/// </summary>
		JoystickBatteryUpdated,

		/// <summary>
		/// Joystick update is complete.
		/// </summary>
		JoystickUpdateComplete,

		#endregion

		#region Gamepad events

		/// <summary>
		/// Gamepad axis motion.
		/// </summary>
		GamepadAxisMotion = 0x650,

		/// <summary>
		/// Gamepad button pressed.
		/// </summary>
		GamepadButtonDown,

		/// <summary>
		/// Gamepad button released.
		/// </summary>
		GamepadButtonUp,

		/// <summary>
		/// A new gamepad has been inserted into the system.
		/// </summary>
		GamepadAdded,

		/// <summary>
		/// An opened gamepad has been removed.
		/// </summary>
		GamepadRemoved,

		/// <summary>
		/// The gamepad mapping was updated.
		/// </summary>
		GamepadRemapped,

		/// <summary>
		/// Gamepad touchpad was touched.
		/// </summary>
		GamepadTouchpadDown,

		/// <summary>
		/// Gamepad touchpad finger was moved.
		/// </summary>
		GamepadTouchpadMotion,

		/// <summary>
		/// Gamepad touchpad finger was lifted.
		/// </summary>
		GamepadTouchpadUp,

		/// <summary>
		/// Gamepad sensor was updated.
		/// </summary>
		GamepadSensorUpdate,

		/// <summary>
		/// Gamepad update is complete.
		/// </summary>
		GamepadUpdateComplete,

		/// <summary>
		/// Gamepad Steam handle has changed.
		/// </summary>
		GamepadSteamHandleUpdated,

		#endregion

		#region Touch events

		/// <summary>
		/// Finger is placed on a touch device.
		/// </summary>
		FingerDown = 0x700,

		/// <summary>
		/// Finger is lifted from a touch device.
		/// </summary>
		FingerUp,

		/// <summary>
		/// Finger is moved on a touch device.
		/// </summary>
		FingerMotion,

		#endregion

		#region Clipboard events

		/// <summary>
		/// The clipboard or primary selection changed
		/// </summary>
		ClipboardUpdate = 0x900,

		#endregion

		#region Drag and drop events

		/// <summary>
		/// The system requests a file open
		/// </summary>
		DropFile = 0x1000,

		/// <summary>
		/// Text/plain drag-and-drop event.
		/// </summary>
		DropText,

		/// <summary>
		/// A new set of drops is beginning (null filename).
		/// </summary>
		DropBegin,

		/// <summary>
		/// Current set of drops is now complete (null filename).
		/// </summary>
		DropComplete,

		/// <summary>
		/// Position while moving over the window.
		/// </summary>
		DropPosition,

		#endregion

		#region Audio hotplug events

		/// <summary>
		/// A new audio device is available.
		/// </summary>
		AudioDeviceAdded = 0x1100,

		/// <summary>
		/// An audio device has been removed.
		/// </summary>
		AudioDeviceRemoved,

		/// <summary>
		/// An audio device's format has been changed by the system.
		/// </summary>
		AudioDeviceFormatChanged,

		#endregion

		#region Sensor events

		/// <summary>
		/// A sensor was updated.
		/// </summary>
		SensorUpdate = 0x1200,

		#endregion

		#region Pressure-sensitive pen events

		/// <summary>
		/// Pressure-sensitive pen touched drawing surface.
		/// </summary>
		PenDown = 0x1300,

		/// <summary>
		/// Pressure-sensitive pen stopped touching drawing surface.
		/// </summary>
		PenUp,

		/// <summary>
		/// Pressure-sensitive pen moved, or angle/pressure changed.
		/// </summary>
		PenMotion,

		/// <summary>
		/// Pressure-sensitive pen button pressed.
		/// </summary>
		PenButtonDown,

		/// <summary>
		/// Pressure-sensitive pen button released.
		/// </summary>
		PenButtonUp,

		#endregion

		#region Camera hotplug events

		/// <summary>
		/// A new camera device is available.
		/// </summary>
		CameraDeviceAdded = 0x1400,

		/// <summary>
		/// A camera device has been removed.
		/// </summary>
		CameraDeviceRemoved,

		/// <summary>
		/// A camera device has been approved for use by the user.
		/// </summary>
		CameraDeviceApproved,

		/// <summary>
		/// A camera device has been denied for use by the user.
		/// </summary>
		CameraDeviceDenied,

		#endregion

		#region Render events

		/// <summary>
		/// The render targets have been reset and their contents need to be updated.
		/// </summary>
		RenderTargetsReset = 0x2000,

		/// <summary>
		/// The device has been reset and all textures need to be recreated.
		/// </summary>
		RenderDeviceReset,

		#endregion

		#region Internal events

		/// <summary>
		/// Signals the end of an event poll cycle.
		/// </summary>
		PollSentinel = 0x7F00,

		#endregion

		/// <summary>
		/// Events <see cref="User"/> through <see cref="Last"/> are for your use and should be allocated with
		/// <see cref="FIXME:SDL_RegisterEvents()"/>.
		/// </summary>
		User = 0x8000,

		/// <summary>
		/// This last event is only for bounding internal arrays.
		/// </summary>
		Last = 0xFFFF
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