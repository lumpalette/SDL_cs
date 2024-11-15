﻿namespace SDL3;

/// <summary>
/// The types of events that can be delivered.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EventType">documentation</see> for more details.
/// </remarks>
public enum SDL_EventType : uint
{
	/// <summary>
	/// Unused (do not remove).
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
	/// <para>
	/// This event must be handled in a callback set with <see cref="SDL.AddEventWatch"/>.
	/// </para>
	/// <para>
	/// Called on iOS in <c>applicationWillTerminate()</c>. Called on Android in <c>onDestroy()</c>.
	/// </para>
	/// </remarks>
	Terminating,

	/// <summary>
	/// The application is low on memory, free memory if possible.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This event must be handled in a callback set with <see cref="SDL.AddEventWatch"/>.
	/// </para>
	/// <para>
	/// Called on iOS in <c>applicationDidReceiveMemoryWarning()</c>. Called on Android in <c>onTrimMemory()</c>.
	/// </para>
	/// </remarks>
	LowMemory,

	/// <summary>
	/// The application is about to enter the background.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This event must be handled in a callback set with <see cref="SDL.AddEventWatch"/>.
	/// </para>
	/// <para>
	/// Called on iOS in <c>applicationWillResignActive()</c>. Called on Android in <c>onPause()</c>.
	/// </para>
	/// </remarks>
	WillEnterBackground,

	/// <summary>
	/// The application did enter the background and may not get CPU for some time.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This event must be handled in a callback set with <see cref="SDL.AddEventWatch"/>.
	/// </para>
	/// <para>
	/// Called on iOS in <c>applicationDidEnterBackground()</c>. Called on Android in <c>onPause()</c>.
	/// </para>
	/// </remarks>
	DidEnterBackground,

	/// <summary>
	/// The application is about to enter the foreground.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This event must be handled in a callback set with <see cref="SDL.AddEventWatch"/>.
	/// </para>
	/// <para>
	/// Called on iOS in <c>applicationWillEnterForeground()</c>. Called on Android in <c>onResume()</c>.
	/// </para>
	/// </remarks>
	WillEnterForeground,

	/// <summary>
	/// The application is now interactive.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This event must be handled in a callback set with <see cref="SDL.AddEventWatch"/>.
	/// </para>
	/// <para>
	/// Called on iOS in <c>applicationDidBecomeActive()</c>. Called on Android in <c>onResume()</c>.
	/// </para>
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
	/// Display orientation has changed to <c>Data1</c>.
	/// </summary>
	DisplayOrientation = 0x151,

	/// <summary>
	/// Display has been added to the system
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
	/// Display has changed desktop mode.
	/// </summary>
	DisplayDesktopModeChanged,

	/// <summary>
	/// Display has changed current mode.
	/// </summary>
	DisplayCurrentModeChanged,

	/// <summary>
	/// Display has changed content scale.
	/// </summary>
	DisplayContentScaleChanged,

	/// <summary>
	/// The first event in the category of "Display".
	/// </summary>
	DisplayFirst = DisplayOrientation,

	/// <summary>
	/// The last event in the category of "Display".
	/// </summary>
	DisplayLast = DisplayContentScaleChanged,

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
	/// Window has been exposed and should be redrawn, and can be redrawn directly from event watchers for this event.
	/// </summary>
	WindowExposed,

	/// <summary>
	/// Window has been moved to <c>Data1</c>, <c>Data2</c>.
	/// </summary>
	WindowMoved,

	/// <summary>
	/// Window has been resized to <c>Data1</c> x <c>Data2</c>.
	/// </summary>
	WindowResized,

	/// <summary>
	/// The pixel size of the window has changed to <c>Data1</c> x <c>Data2</c>.
	/// </summary>
	WindowPixelSizeChanged,

	/// <summary>
	/// The pixel size of a Metal view associated with the window has changed.
	/// </summary>
	WindowMetalViewResized,

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
	/// Window had a hit test that wasn't <see cref="SDL_HitTestResult.Normal"/>.
	/// </summary>
	WindowHitTest,

	/// <summary>
	/// The ICC profile of the window's display has changed.
	/// </summary>
	WindowICCProfileChanged,

	/// <summary>
	/// Window has been moved to display <c>Data1</c>.
	/// </summary>
	WindowDisplayChanged,

	/// <summary>
	/// Window display scale has been changed.
	/// </summary>
	WindowDisplayScaleChanged,

	/// <summary>
	/// The window safe area has been changed.
	/// </summary>
	WindowSafeAreaChanged,

	/// <summary>
	/// The window has been occluded.
	/// </summary>
	WindowOccluded,

	/// <summary>
	/// The window has entered fullscreen mode.
	/// </summary>
	WindowEnterFullscreen,

	/// <summary>
	/// The window has left fullscreen mode.
	/// </summary>
	WindowLeaveFullscreen,

	/// <summary>
	/// The window with the associated ID is being or has been destroyed.
	/// </summary>
	/// <remarks>
	/// If this message is being handled in an event watcher, the window handle is still valid and can still be used to retrieve
	/// any properties associated with the window. Otherwise, the handle has already been destroyed and all resources associated
	/// with it are invalid.
	/// </remarks>
	WindowDestroyed,

	/// <summary>
	/// Window HDR properties have changed.
	/// </summary>
	WindowHdrStateChanged,

	/// <summary>
	/// The first event in the category of "Window".
	/// </summary>
	WindowFirst = WindowShown,

	/// <summary>
	/// The last event in the category of "Window".
	/// </summary>
	WindowLast = WindowHdrStateChanged,

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

	/// <summary>
	/// Keyboard text editing candidates.
	/// </summary>
	TextEditingCandidates,

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
	/// A gamepad has been removed.
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
	/// Gamepad touchpad finger was lifted
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

	FingerDown = 0x700,
	FingerUp,
	FingerMotion,

	#endregion

	#region Clipboard events

	/// <summary>
	/// The clipboard or primary selection changed.
	/// </summary>
	ClipboardUpdate = 0x900,

	#endregion

	#region Drag and drop events

	/// <summary>
	/// The system requests a file open.
	/// </summary>
	DropFile = 0x1000,

	/// <summary>
	/// Text/plain drag-and-drop event.
	/// </summary>
	DropText,

	/// <summary>
	/// A new set of drops is beginning (<see langword="null"/> filename).
	/// </summary>
	DropBegin,

	/// <summary>
	/// Current set of drops is now complete (<see langword="null"/> filename).
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
	/// Pressure-sensitive pen has become available.
	/// </summary>
	PenProximityIn = 0x1300,

	/// <summary>
	/// Pressure-sensitive pen has become unavailable.
	/// </summary>
	PenProximityOut,

	/// <summary>
	/// Pressure-sensitive pen touched drawing surface.
	/// </summary>
	PenDown,

	/// <summary>
	/// Pressure-sensitive pen stopped touching drawing surface.
	/// </summary>
	PenUp,

	/// <summary>
	/// Pressure-sensitive pen button pressed.
	/// </summary>
	PenButtonDown,

	/// <summary>
	/// Pressure-sensitive pen button released.
	/// </summary>
	PenButtonUp,

	/// <summary>
	/// Pressure-sensitive pen is moving on the tablet.
	/// </summary>
	PenMotion,

	/// <summary>
	/// Pressure-sensitive pen angle/pressure/etc changed.
	/// </summary>
	PenAxis,

	#endregion

	#region Camera hotplug events

	/// <summary>
	/// A new camera device is available
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

	/// <summary>
	/// The device has been lost and can't be recovered.
	/// </summary>
	RenderDeviceLost,

	#endregion

	#region Reserved events for private platforms

	Private0 = 0x4000,
	Private1,
	Private2,
	Private3,

	#endregion

	#region Internal events

	/// <summary>
	/// Signals the end of an event poll cycle.
	/// </summary>
	PollSentinel = 0x7F00,

	#endregion

	/// <summary>
	/// Events <see cref="User"/> through <see cref="Last"/> are for your use and should be allocated with
	/// <see cref="SDL.RegisterEvents(int)"/>.
	/// </summary>
	User = 0x8000,

	/// <summary>
	/// This last event is only for bounding internal arrays.
	/// </summary>
	Last = 0xFFFF
}