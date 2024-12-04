using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// SDL_event.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_events.h.
namespace SDL3;

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

#region Event structures

/// <summary>
/// Fields shared by every event
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CommonEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_CommonEvent
{
	/// <summary>
	/// Event type, shared with all events.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;
}

/// <summary>
/// Display state change event data (<see cref="SDL_Event.Display"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DisplayEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_DisplayEvent
{
	/// <summary>
	/// One of the <see cref="SDL_EventType"/> values that start with <c>Display</c> (e.g.
	/// <see cref="SDL_EventType.DisplayAdded"/>).
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The associated display.
	/// </summary>
	public SDL_DisplayId DisplayId;

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
/// Window state change event data (<see cref="SDL_Event.Window"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WindowEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_WindowEvent
{
	/// <summary>
	/// One of the <see cref="SDL_EventType"/> values that start with <c>Window</c> (e.g.
	/// <see cref="SDL_EventType.WindowMoved"/>).
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The associated window.
	/// </summary>
	public SDL_WindowId WindowId;

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
/// Keyboard device event structure (<see cref="SDL_Event.KeyboardDevice"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_KeyboardDeviceEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_KeyboardDeviceEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.KeyboardAdded"/> or <see cref="SDL_EventType.KeyboardRemoved"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The keyboard instance ID.
	/// </summary>
	public SDL_KeyboardId Which;
}

/// <summary>
/// Keyboard button event structure (<see cref="SDL_Event.Keyboard"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_KeyboardEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_KeyboardEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.KeyDown"/> or <see cref="SDL_EventType.KeyUp"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with keyboard focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// The keyboard instance id, or 0 if unknown or virtual
	/// </summary>
	public SDL_KeyboardId Which;

	/// <summary>
	/// SDL physical key code.
	/// </summary>
	public SDL_Scancode Scancode;

	/// <summary>
	/// SDL virtual key code.
	/// </summary>
	public SDL_Keycode Key;

	/// <summary>
	/// Current key modifiers.
	/// </summary>
	public SDL_Keymod Mod;

	/// <summary>
	/// The platform dependent scancode for this event.
	/// </summary>
	public ushort Raw;

	/// <summary>
	/// True if the key is pressed.
	/// </summary>
	[MarshalAs(SDL.NativeBool)]
	public bool Down;

	/// <summary>
	/// True if this is a key repeat.
	/// </summary>
	[MarshalAs(SDL.NativeBool)]
	public bool Repeat;
}

/// <summary>
/// Keyboard text editing event structure (<see cref="SDL_Event.TextEditing"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_TextEditingEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_TextEditingEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.TextEditing"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with keyboard focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// The editing text.
	/// </summary>
	public byte* Text;

	/// <summary>
	/// The start cursor of selected editing text, or -1 if not set.
	/// </summary>
	public int Start;

	/// <summary>
	/// The length of selected editing text, or -1 if not set.
	/// </summary>
	public int Length;
}

/// <summary>
/// Keyboard IME candidates event structure (<see cref="SDL_Event.TextEditingCandidates"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_TextEditingCandidatesEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_TextEditingCandidatesEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.TextEditingCandidates"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with keyboard focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// The list of candidates, or <see langword="null"/> if there are no candidates available.
	/// </summary>
	/// <remarks>
	/// You can use <see cref="SDL.UnmanagedToManagedStrings(byte**, int)"/> to convert this field into an array of managed strings.
	/// </remarks>
	[Const]
	public byte** Candidates;

	/// <summary>
	/// The number of strings in <see cref="Candidates"/>.
	/// </summary>
	public int NumCandidates;

	/// <summary>
	/// The index of the selected candidate, or -1 if no candidate is selected.
	/// </summary>
	public int SelectedCandidate;

	/// <summary>
	/// True if the list is horizontal, false if it's vertical.
	/// </summary>
	[MarshalAs(SDL.NativeBool)]
	public bool Horizontal;

	private readonly byte _padding1;

	private readonly byte _padding2;

	private readonly byte _padding3;
}

/// <summary>
/// Keyboard text input event structure (<see cref="SDL_Event.TextInput"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_TextInputEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_TextInputEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.TextInput"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with keyboard focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// The input text.
	/// </summary>
	public byte* Text;
}

/// <summary>
/// Mouse device event structure (<see cref="SDL_Event.MouseDevice"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseDeviceEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_MouseDeviceEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.MouseAdded"/> or <see cref="SDL_EventType.MouseRemoved"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The mouse instance ID.
	/// </summary>
	public SDL_MouseId Which;
}

/// <summary>
/// Mouse motion event structure (<see cref="SDL_EventType.MouseMotion"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseMotionEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_MouseMotionEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.MouseMotion"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with mouse focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// The mouse instance ID, <see cref="SDL.TouchMouseId"/>, or <see cref="FIXME:SDL_PEN_MOUSEID"/>.
	/// </summary>
	public SDL_MouseId Which;

	/// <summary>
	/// The current button state.
	/// </summary>
	public SDL_MouseButtonFlags State;

	/// <summary>
	/// X coordinate, relative to window.
	/// </summary>
	public float X;

	/// <summary>
	/// Y coordinate, relative to window.
	/// </summary>
	public float Y;

	/// <summary>
	/// The relative motion in the X direction.
	/// </summary>
	public float XRel;

	/// <summary>
	/// The relative motion in the Y direction.
	/// </summary>
	public float YRel;
}

/// <summary>
/// Mouse button event structure (<see cref="SDL_Event.MouseButton"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_MouseButtonEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.MouseButtonDown"/> or <see cref="SDL_EventType.MouseButtonUp"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with mouse focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// The mouse instance ID, <see cref="SDL.TouchMouseId"/>.
	/// </summary>
	public SDL_MouseId Which;

	/// <summary>
	/// The mouse button index.
	/// </summary>
	public byte Button;

	/// <summary>
	/// True if the button is pressed.
	/// </summary>
	[MarshalAs(SDL.NativeBool)]
	public bool Down;

	/// <summary>
	/// 1 for single-click, 2 for double-click, etc.
	/// </summary>
	public byte Clicks;

	private readonly byte _padding;

	/// <summary>
	/// X coordinate, relative to window.
	/// </summary>
	public float X;

	/// <summary>
	/// Y coordinate, relative to window.
	/// </summary>
	public float Y;
}

/// <summary>
/// Mouse wheel event structure (<see cref="SDL_Event.MouseWheel"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseWheelEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_MouseWheelEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.MouseWheel"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with mouse focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// The mouse instance ID, <see cref="SDL.TouchMouseId"/>, or <see cref="FIXME:SDL_PEN_MOUSEID"/>.
	/// </summary>
	public SDL_MouseId Which;

	/// <summary>
	/// The amount scrolled horizontally, positive to the right and negative to the left.
	/// </summary>
	public float X;

	/// <summary>
	/// The amount scrolled vertically, positive away from the user and negative toward the user.
	/// </summary>
	public float Y;

	/// <summary>
	/// Set to one of the <see cref="SDL_MouseWheelDirection"/> values.
	/// </summary>
	/// <remarks>
	/// When <see cref="SDL_MouseWheelDirection.Flipped"/> the values in X and Y will be opposite. Multiply by -1 to change
	/// them back.
	/// </remarks>
	public SDL_MouseWheelDirection Direction;

	/// <summary>
	/// X coordinate, relative to window.
	/// </summary>
	public float MouseX;

	/// <summary>
	/// Y coordinate, relative to window.
	/// </summary>
	public float MouseY;
}

/// <summary>
/// Joystick axis motion event structure (<see cref="SDL_Event.JoyAxis"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_JoyAxisEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_JoyAxisEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.JoystickAxisMotion"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The joystick instance ID.
	/// </summary>
	public SDL_JoystickId Which;

	/// <summary>
	/// The joystick axis index.
	/// </summary>
	public byte Axis;

	private readonly byte _padding1;

	private readonly byte _padding2;

	private readonly byte _padding3;

	/// <summary>
	/// The axis value (range: -32768 to 32767).
	/// </summary>
	public short Value;

	private readonly byte _padding4;
}

/// <summary>
/// Joystick trackball motion event structure (<see cref="SDL_Event.JoyBall"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_JoyBallEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_JoyBallEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.JoystickBallMotion"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The joystick instance ID.
	/// </summary>
	public SDL_JoystickId Which;

	/// <summary>
	/// The joystick trackball index.
	/// </summary>
	public byte Ball;

	private readonly byte _padding1;

	private readonly byte _padding2;

	private readonly byte _padding3;

	/// <summary>
	/// The relative motion in the X direction.
	/// </summary>
	public int XRel;

	/// <summary>
	/// The relative motion in the Y direction.
	/// </summary>
	public int YRel;
}

/// <summary>
/// Joystick hat position change event structure (<see cref="SDL_Event.JoyHat"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_JoyHatEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_JoyHatEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.JoystickHatMotion"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The joystick instance ID.
	/// </summary>
	public SDL_JoystickId Which;

	/// <summary>
	/// The joystick hat index.
	/// </summary>
	public byte Hat;

	/// <summary>
	/// The hat position value.
	/// </summary>
	public SDL_JoystickHatPosition Value;

	private readonly byte _padding1;

	private readonly byte _padding2;
}

/// <summary>
/// Joystick button event structure (<see cref="SDL_Event.JoyButton"/>)
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_JoyButtonEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_JoyButtonEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.JoystickButtonDown"/> or <see cref="SDL_EventType.JoystickButtonUp"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The joystick instance ID.
	/// </summary>
	public SDL_JoystickId Which;

	/// <summary>
	/// The joystick button index.
	/// </summary>
	public byte Button;

	/// <summary>
	/// True if the button is pressed.
	/// </summary>
	[MarshalAs(SDL.NativeBool)]
	public bool Down;

	private readonly byte _padding1;

	private readonly byte _padding2;
}

/// <summary>
/// Joystick device event structure (<see cref="SDL_Event.JoyDevice"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_JoyDeviceEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_JoyDeviceEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.JoystickAdded"/>, <see cref="SDL_EventType.JoystickRemoved"/> or
	/// <see cref="SDL_EventType.JoystickUpdateComplete"/>,
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The joystick instance ID.
	/// </summary>
	public SDL_JoystickId Which;
}

/// <summary>
/// Joysick battery level change event structure (<see cref="SDL_Event.JoyBattery"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_JoyBatteryEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_JoyBatteryEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.JoystickBatteryUpdated"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The joystick instance ID.
	/// </summary>
	public SDL_JoystickId Which;

	/// <summary>
	/// The joystick battery state.
	/// </summary>
	public SDL_PowerState State;

	/// <summary>
	/// The joystick battery percent charge remaining.
	/// </summary>
	public int Percent;
}

/// <summary>
/// Gamepad axis motion event structure (<see cref="SDL_Event.GamepadAxis"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadAxisEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_GamepadAxisEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.GamepadAxisMotion"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The joystick instance ID.
	/// </summary>
	public SDL_JoystickId Which;

	/// <summary>
	/// The gamepad axis (<see cref="SDL_GamepadAxis"/>).
	/// </summary>
	public byte Axis;

	private readonly byte _padding1;

	private readonly byte _padding2;

	private readonly byte _padding3;

	/// <summary>
	/// The axis value (range: -32768 to 32767).
	/// </summary>
	public short Value;

	private readonly ushort _padding4;
}

/// <summary>
/// Gamepad button event structure (<see cref="SDL_Event.GamepadButton"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadButtonEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_GamepadButtonEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.GamepadButtonDown"/> or <see cref="SDL_EventType.GamepadButtonUp"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The joystick instance ID.
	/// </summary>
	public SDL_JoystickId Which;

	/// <summary>
	/// The gamepad button (<see cref="SDL_GamepadButton"/>).
	/// </summary>
	public byte Button;

	/// <summary>
	/// True if the button is pressed.
	/// </summary>
	[MarshalAs(SDL.NativeBool)]
	public bool Down;

	private readonly byte _padding1;

	private readonly byte _padding2;
}

/// <summary>
/// Gamepad device event structure (<see cref="SDL_Event.GamepadDevice"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadDeviceEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_GamepadDeviceEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.GamepadAdded"/>, <see cref="SDL_EventType.GamepadRemoved"/>,
	/// <see cref="SDL_EventType.GamepadRemapped"/>, <see cref="SDL_EventType.GamepadUpdateComplete"/> or
	/// <see cref="SDL_EventType.GamepadSteamHandleUpdated"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The joystick instance ID.
	/// </summary>
	public SDL_JoystickId Which;
}

/// <summary>
/// Gamepad touchpad event structure (<see cref="SDL_Event.GamepadTouchpad"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadTouchpadEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_GamepadTouchpadEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.GamepadTouchpadDown"/>, <see cref="SDL_EventType.GamepadTouchpadMotion"/> or
	/// <see cref="SDL_EventType.GamepadTouchpadUp"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The joystick instance ID.
	/// </summary>
	public SDL_JoystickId Which;

	/// <summary>
	/// The index of the touchpad.
	/// </summary>
	public int Touchpad;

	/// <summary>
	/// The index of the finger on the touchpad.
	/// </summary>
	public int Finger;

	/// <summary>
	/// Normalized in the range 0...1 with 0 being on the left.
	/// </summary>
	public float X;

	/// <summary>
	/// Normalized in the range 0...1 with 0 being at the top.
	/// </summary>
	public float Y;

	/// <summary>
	/// Normalized in the range 0...1.
	/// </summary>
	public float Pressure;
}

/// <summary>
/// Gamepad sensor event structure (<see cref="SDL_Event.GamepadSensor"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadSensorEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_GamepadSensorEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.GamepadSensorUpdate"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The joystick instance ID.
	/// </summary>
	public SDL_JoystickId Which;

	/// <summary>
	/// The type of the sensor, one of the values of <see cref="SDL_SensorType"/>.
	/// </summary>
	public SDL_SensorType Sensor;

	/// <summary>
	/// Up to 3 values from the sensor, as defined in SDL_sensor.h.
	/// </summary>
	public fixed float Data[3];

	/// <summary>
	/// The timestamp of the sensor reading in nanoseconds, not necessarily synchronized with the system clock.
	/// </summary>
	public ulong SensorTimestamp;
}

/// <summary>
/// Audio device event structure (<see cref="SDL_Event.AudioDevice"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioDeviceEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_AudioDeviceEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.AudioDeviceAdded"/>, <see cref="SDL_EventType.AudioDeviceRemoved"/> or
	/// <see cref="SDL_EventType.AudioDeviceFormatChanged"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// <see cref="SDL_AudioDeviceId"/> for the device being added or removed or changing.
	/// </summary>
	public SDL_AudioDeviceId Which;

	/// <summary>
	/// False if a playback device, true if a recording device.
	/// </summary>
	[MarshalAs(SDL.NativeBool)]
	public bool Recording;
}

/// <summary>
/// Camera device event structure (<see cref="SDL_Event.CameraDevice"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CameraDeviceEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_CameraDeviceEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.CameraDeviceAdded"/>, <see cref="SDL_EventType.CameraDeviceRemoved"/>,
	/// <see cref="SDL_EventType.CameraDeviceApproved"/> or <see cref="SDL_EventType.CameraDeviceDenied"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// <see cref="FIXME:SDL_CameraID"/> for the device being added or removed or changing
	/// </summary>
	public uint Which; // TODO: implement SDL_camera.h
}

/// <summary>
/// Renderer event structure (<see cref="SDL_Event.Render"/>).
/// </summary>
public struct SDL_RenderEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.RenderTargetsReset"/>, <see cref="SDL_EventType.RenderDeviceReset"/> or
	/// <see cref="SDL_EventType.RenderDeviceLost"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window containing the renderer in question.
	/// </summary>
	public SDL_WindowId WindowId;
}

/// <summary>
/// Touch finger event structure (<see cref="SDL_Event.TouchFinger"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_TouchFingerEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_TouchFingerEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.FingerMotion"/>, <see cref="SDL_EventType.FingerDown"/> or
	/// <see cref="SDL_EventType.FingerUp"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The touch device ID.
	/// </summary>
	public SDL_TouchId TouchId;

	/// <summary>
	/// The finger ID.
	/// </summary>
	public SDL_FingerId FingerId;

	/// <summary>
	/// Normalized in the range 0...1.
	/// </summary>
	public float X;

	/// <summary>
	/// Normalized in the range 0...1.
	/// </summary>
	public float Y;

	/// <summary>
	/// Normalized in the range -1...1.
	/// </summary>
	public float Dx;

	/// <summary>
	/// Normalized in the range -1...1.
	/// </summary>
	public float Dy;

	/// <summary>
	/// Normalized in the range 0...1.
	/// </summary>
	public float Pressure;

	/// <summary>
	/// The window underneath the finger, if any.
	/// </summary>
	public SDL_WindowId WindowId;
}

/// <summary>
/// Pressure-sensitive pen proximity event structure (<see cref="SDL_Event.PenProximity"/>)
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_PenProximityEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.PenProximityIn"/> or <see cref="SDL_EventType.PenProximityOut"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with pen focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// The pen instance ID.
	/// </summary>
	public SDL_PenId Which;
}

/// <summary>
/// Pressure-sensitive pen motion event structure (<see cref="SDL_Event.PenMotion"/>).
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_PenMotionEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.PenMotion"/>.	
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with pen focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// The pen instance ID.
	/// </summary>
	public SDL_PenId Which;

	/// <summary>
	/// Complete pen input state at time of event.
	/// </summary>
	public SDL_PenInputFlags PenState;

	/// <summary>
	/// X coordinate, relative to window
	/// </summary>
	public float X;

	/// <summary>
	/// Y coordinate, relative to window
	/// </summary>
	public float Y;
}

/// <summary>
/// Pressure-sensitive pen touched event structure (<see cref="SDL_Event.PenTouch"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PenTouchEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_PenTouchEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.PenDown"/> or <see cref="SDL_EventType.PenUp"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with pen focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// The pen instance ID.
	/// </summary>
	public SDL_PenId Which;

	/// <summary>
	/// Complete pen input state at time of event.
	/// </summary>
	public SDL_PenInputFlags PenState;

	/// <summary>
	/// X coordinate, relative to window.
	/// </summary>
	public float X;

	/// <summary>
	/// Y coordinate, relative to window.
	/// </summary>
	public float Y;

	/// <summary>
	/// True if eraser end is used (not all pens support this).
	/// </summary>
	[MarshalAs(SDL.NativeBool)]
	public bool Eraser;

	/// <summary>
	/// True if the pen is touching or false if the pen is lifted off.
	/// </summary>
	[MarshalAs(SDL.NativeBool)]
	public bool Down;
}

/// <summary>
/// Pressure-sensitive pen button event structure (<see cref="SDL_Event.PenButton"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PenButtonEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_PenButtonEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.PenButtonDown"/> or <see cref="SDL_EventType.PenButtonUp"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with pen focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// The pen instance ID.
	/// </summary>
	public SDL_PenId Which;

	/// <summary>
	/// Complete pen input state at time of event.
	/// </summary>
	public SDL_PenInputFlags PenState;

	/// <summary>
	/// X coordinate, relative to window.
	/// </summary>
	public float X;

	/// <summary>
	/// Y coordinate, relative to window.
	/// </summary>
	public float Y;

	/// <summary>
	/// The pen button index (first button is 1).
	/// </summary>
	public byte Button;

	/// <summary>
	/// True if the button is pressed.
	/// </summary>
	[MarshalAs(SDL.NativeBool)]
	public bool Down;
}

/// <summary>
/// Pressure-sensitive pen pressure / angle event structure (<see cref="SDL_Event.PenAxis"/>).
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_PenAxisEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.PenAxis"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with pen focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// The pen instance ID.
	/// </summary>
	public SDL_PenId Which;

	/// <summary>
	/// Complete pen input state at time of event.
	/// </summary>
	public SDL_PenInputFlags PenState;

	/// <summary>
	/// X coordinate, relative to window.
	/// </summary>
	public float X;

	/// <summary>
	/// Y coordinate, relative to window.
	/// </summary>
	public float Y;

	/// <summary>
	/// Axis that has changed.
	/// </summary>
	public SDL_PenAxis Axis;

	/// <summary>
	/// New value of axis.
	/// </summary>
	public float Value;
}

/// <summary>
/// An event used to drop text or request a file open by the system (<see cref="SDL_Event.Drop"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DropEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_DropEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.DropBegin"/>, <see cref="SDL_EventType.DropFile"/>,
	/// <see cref="SDL_EventType.DropText"/>, <see cref="SDL_EventType.DropComplete"/> or
	/// <see cref="SDL_EventType.DropPosition"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window that was dropped on, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// X coordinate, relative to window (not on begin).
	/// </summary>
	public float X;

	/// <summary>
	/// Y coordinate, relative to window (not on begin).
	/// </summary>
	public float Y;

	/// <summary>
	/// The source app that sent this drop event, or <see langword="null"/> if that isn't available.
	/// </summary>
	public byte* Source;

	/// <summary>
	/// The text for <see cref="SDL_EventType.DropText"/> and the file name for <see cref="SDL_EventType.DropFile"/>,
	/// <see langword="null"/> for other events.
	/// </summary>
	public byte* Data;
}

/// <summary>
/// An event triggered when the clipboard contents have changed (<see cref="SDL_Event.Clipboard"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ClipboardEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_ClipboardEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.ClipboardUpdate"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// Are we owning the clipboard? (internal update).
	/// </summary>
	[MarshalAs(SDL.NativeBool)]
	public bool Owner;

	/// <summary>
	/// Number of mime type.
	/// </summary>
	public int NMimeTypes;

	/// <summary>
	/// Current mime types.
	/// </summary>
	/// <remarks>
	/// You can use <see cref="SDL.UnmanagedToManagedStrings(byte**, int)"/> to convert this field into an array of managed strings.
	/// </remarks>
	[Const]
	public byte** MimeTypes;
}

/// <summary>
/// Sensor event structure (<see cref="SDL_Event.Sensor"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SensorEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_SensorEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.SensorUpdate"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The instance ID of the sensor.
	/// </summary>
	public SDL_SensorId Which;

	/// <summary>
	/// Up to 6 values from the sensor - additional values can be queried using
	/// <see cref="SDL.GetSensorData(SDL_Sensor*, float*, int)"/>.
	/// </summary>
	public fixed float Data[6];

	/// <summary>
	/// The timestamp of the sensor reading in nanoseconds, not necessarily synchronized with the system clock.
	/// </summary>
	public ulong SensorTimestamp;
}

/// <summary>
/// The "quit requested" event (<see cref="SDL_Event.Quit"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_QuitEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_QuitEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.Quit"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;
}

/// <summary>
/// A user-defined event type (<see cref="SDL_Event.User"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UserEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_UserEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.User"/> through <see cref="SDL_EventType.Last"/> - 1.
	/// </summary>
	public uint Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The associated window if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// User defined event code.
	/// </summary>
	public int Code;

	/// <summary>
	/// User defined data pointer.
	/// </summary>
	public nint Data1;

	/// <summary>
	/// User defined data pointer.
	/// </summary>
	public nint Data2;
}

#endregion

/// <summary>
/// The structure for all events in SDL.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Event">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Explicit)]
public unsafe struct SDL_Event
{
	/// <summary>
	/// Event type, shared with all events.
	/// </summary>
	[FieldOffset(0)]
	public SDL_EventType Type;

	/// <summary>
	/// Common event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_CommonEvent Common;

	/// <summary>
	/// Display event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_DisplayEvent Display;

	/// <summary>
	/// Window event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_WindowEvent Window;

	/// <summary>
	/// Keyboard device change event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_KeyboardDeviceEvent KeyboardDevice;

	/// <summary>
	/// Keyboard event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_KeyboardEvent Keyboard;

	/// <summary>
	/// Text editing event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_TextEditingEvent TextEditing;

	/// <summary>
	/// Text editing candidates event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_TextEditingCandidatesEvent TextEditingCandidates;

	/// <summary>
	/// Text input event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_TextInputEvent TextInput;

	/// <summary>
	/// Mouse device change event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_MouseDeviceEvent MouseDevice;

	/// <summary>
	/// Mouse motion event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_MouseMotionEvent MouseMotion;

	/// <summary>
	/// Mouse button event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_MouseButtonEvent MouseButton;

	/// <summary>
	/// Mouse wheel event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_MouseWheelEvent MouseWheel;

	/// <summary>
	/// Joystick device change event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_JoyDeviceEvent JoyDevice;

	/// <summary>
	/// Joystick axis event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_JoyAxisEvent JoyAxis;

	/// <summary>
	/// Joystick ball event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_JoyBallEvent JoyBall;

	/// <summary>
	/// Joystick hat event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_JoyHatEvent JoyHat;

	/// <summary>
	/// Joystick button event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_JoyButtonEvent JoyButton;

	/// <summary>
	/// Joystick battery event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_JoyBatteryEvent JoyBattery;

	/// <summary>
	/// Gamepad device event data
	/// </summary>
	[FieldOffset(0)]
	public SDL_GamepadDeviceEvent GamepadDevice;

	/// <summary>
	/// Gamepad axis event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_GamepadAxisEvent GamepadAxis;

	/// <summary>
	/// Gamepad button event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_GamepadButtonEvent GamepadButton;

	/// <summary>
	/// Gamepad touchpad event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_GamepadTouchpadEvent GamepadTouchpad;

	/// <summary>
	/// Gamepad sensor event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_GamepadSensorEvent GamepadSensor;

	/// <summary>
	/// Audio device event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_AudioDeviceEvent AudioDevice;

	/// <summary>
	/// Camera device event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_CameraDeviceEvent CameraDevice;

	/// <summary>
	/// Sensor event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_SensorEvent Sensor;

	/// <summary>
	/// Quit request event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_QuitEvent Quit;

	/// <summary>
	/// Custom event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_UserEvent User;

	/// <summary>
	/// Touch finger event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_TouchFingerEvent TouchFinger;

	/// <summary>
	/// Pen proximity event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_PenProximityEvent PenProximity;

	/// <summary>
	/// Pen tip touching event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_PenTouchEvent PenTouch;

	/// <summary>
	/// Pen motion event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_PenMotionEvent PenMotion;

	/// <summary>
	/// Pen button event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_PenButtonEvent PenButton;

	/// <summary>
	/// Pen axis event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_PenAxisEvent PenAxis;

	/// <summary>
	/// Render event data
	/// </summary>
	[FieldOffset(0)]
	public SDL_RenderEvent Render;

	/// <summary>
	/// Drag and drop event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_DropEvent Drop;

	/// <summary>
	/// Clipboard event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_ClipboardEvent Clipboard;

	[FieldOffset(0)]
	private fixed byte _padding[128];
}

/// <summary>
/// The type of action to request from <see cref="SDL.PeepEvents(SDL_Event*, int, SDL_EventAction, SDL_EventType, SDL_EventType)"/>.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EventAction">documentation</see> for more details.
/// </remarks>
public enum SDL_EventAction
{
	/// <summary>
	/// Add events to the back of the queue.
	/// </summary>
	AddEvent,

	/// <summary>
	/// Check but don't remove events from the queue front.
	/// </summary>
	PeekEvent,

	/// <summary>
	/// Retrieve/remove events from the front of the queue.
	/// </summary>
	GetEvent
}

unsafe partial class SDL
{
	/// <summary>
	/// Pump the event loop, gathering events from the input devices.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PumpEvents">documentation</see> for more details.
	/// </remarks>
	[LibraryImport(LibraryName, EntryPoint = "SDL_PumpEvents")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void PumpEvents();

	/// <summary>
	/// Check the event queue for messages and optionally return them.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PeepEvents">documentation</see> for more details.
	/// </remarks>
	/// <param name="e">Destination buffer for the retrieved events, may be <see langword="null"/> to leave the events in the queue and return the number of events that would have been stored.</param>
	/// <param name="numEvents">If <paramref name="action"/> is <see cref="SDL_EventAction.AddEvent"/>, the number of events to add back to the event queue; if <paramref name="action"/> is <see cref="SDL_EventAction.PeekEvent"/> or <see cref="SDL_EventAction.GetEvent"/>, the maximum number of events to retrieve.</param>
	/// <param name="action">Action to take.</param>
	/// <param name="minType">Minimum value of the event type to be considered; <see cref="SDL_EventType.First"/> is a safe choice.</param>
	/// <param name="maxType">Maximum value of the event type to be considered; <see cref="SDL_EventType.First"/> is a safe choice.</param>
	/// <returns>The number of events actually stored or -1 on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_PeepEvents")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int PeepEvents(SDL_Event* e, int numEvents, SDL_EventAction action, SDL_EventType minType, SDL_EventType maxType);

	/// <summary>
	/// Check for the existence of a certain event type in the event queue.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasEvent">documentation</see> for more details.
	/// </remarks>
	/// <param name="type">The type of event to be queried; see <see cref="SDL_EventType"/> for details.</param>
	/// <returns>True if events matching <paramref name="type"/> are present, or false if events matching <paramref name="type"/> are not present.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasEvent")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasEvent(SDL_EventType type);

	/// <summary>
	/// Check for the existence of certain event types in the event queue.
	/// </summary>
	/// <param name="minType">The low end of event type to be queried, inclusive; see <see cref="SDL_EventType"/> for details.</param>
	/// <param name="maxType">The high end of event type to be queried, inclusive; see <see cref="SDL_EventType"/> for details.</param>
	/// <returns>True if events with type &gt;= <paramref name="minType"/> and &lt;= <paramref name="maxType"/> are present, or false if not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasEvents")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasEvents(SDL_EventType minType, SDL_EventType maxType);

	/// <summary>
	/// Clear events of a specific type from the event queue.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FlushEvent">documentation</see> for more details.
	/// </remarks>
	/// <param name="type">The type of event to be cleared; see <see cref="SDL_EventType"/> for details.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_FlushEvent")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void FlushEvent(SDL_EventType type);

	/// <summary>
	/// Clear events of a range of types from the event queue.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FlushEvents">documentation</see> for more details.
	/// </remarks>
	/// <param name="minType">The low end of event type to be cleared, inclusive; see <see cref="SDL_EventType"/> for details.</param>
	/// <param name="maxType">The high end of event type to be cleared, inclusive; see <see cref="SDL_EventType"/> for details.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_FlushEvents")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void FlushEvents(SDL_EventType minType, SDL_EventType maxType);

	/// <summary>
	/// Poll for currently pending events.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PollEvent">documentation</see> for more details.
	/// </remarks>
	/// <param name="e">The <see cref="SDL_Event"/> structure to be filled with the next event from the queue, or <see langword="null"/>.</param>
	/// <returns>True if this got an event or false if there are none available.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_PollEvent")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool PollEvent(SDL_Event* e);

	/// <summary>
	/// Wait indefinitely for the next available event.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WaitEvent">documentation</see> for more details.
	/// </remarks>
	/// <param name="e">The <see cref="SDL_Event"/> structure to be filled in with the next event from the queue, or <see langword="null"/>.</param>
	/// <returns>True on success or false if there was an error while waiting for events; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_WaitEvent")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool WaitEvent(SDL_Event* e);

	/// <summary>
	/// Wait until the specified timeout (in milliseconds) for the next available event.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WaitEventTimeout">documentation</see> for more details.
	/// </remarks>
	/// <param name="e">The <see cref="SDL_Event"/> structure to be filled in with the next event from the queue, or <see langword="null"/>.</param>
	/// <param name="timeoutMs">The maximum number of milliseconds to wait for the next available event.</param>
	/// <returns>True if this got an event or false if the timeout elapsed without any events available.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_WaitEventTimeout")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool WaitEventTimeout(SDL_Event* e, int timeoutMs);

	/// <summary>
	/// Add an event to the event queue.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PushEvent">documentation</see> for more details.
	/// </remarks>
	/// <param name="e">The <see cref="SDL_Event"/> to be added to the queue.</param>
	/// <returns>True on success, false if the event was filtered or on failure; call <see cref="GetError"/> for more information. A common reason for error is the event queue being full.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_PushEvent")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool PushEvent(SDL_Event* e);

	/// <summary>
	/// Set up a filter to process all events before they change internal state and are posted to the internal event queue.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetEventFilter">documentation</see> for more details.
	/// </remarks>
	/// <param name="filter">An SDL_EventFilter function to call when an event happens.</param>
	/// <param name="userData">A pointer that is passed to <paramref name="filter"/>.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetEventFilter")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void SetEventFilter(delegate* unmanaged[Cdecl]<nint, SDL_Event*, int>  filter, nint userData);

	/// <summary>
	/// Query the current event filter.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetEventFilter">documentation</see> for more details.
	/// </remarks>
	/// <param name="filter">The current callback function will be stored here.</param>
	/// <param name="userData">The pointer that is passed to the current event filter will be stored here.</param>
	/// <returns>True on success or false if there is no event filter set.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetEventFilter")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetEventFilter(delegate* unmanaged[Cdecl]<nint, SDL_Event*, int> filter, nint* userData);

	/// <summary>
	/// Add a callback to be triggered when an event is added to the event queue.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AddEventWatch">documentation</see> for more details.
	/// </remarks>
	/// <param name="filter">An SDL_EventFilter function to call when an event happens.</param>
	/// <param name="userdata">A pointer that is passed to <paramref name="filter"/>.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_AddEventWatch")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool AddEventWatch(delegate* unmanaged[Cdecl]<nint, SDL_Event*, int> filter, nint userdata);

	/// <summary>
	/// Remove an event watch callback added with <see cref="AddEventWatch"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RemoveEventWatch">documentation</see> for more details.
	/// </remarks>
	/// <param name="filter">The function originally passed to <see cref="AddEventWatch"/>.</param>
	/// <param name="userdata">The pointer originally passed to <see cref="AddEventWatch"/>.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RemoveEventWatch")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void RemoveEventWatch(delegate* unmanaged[Cdecl]<nint, SDL_Event*, int> filter, nint userdata);

	/// <summary>
	/// Run a specific filter function on the current event queue, removing any events for which the filter returns 0.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FilterEvents">documentation</see> for more details.
	/// </remarks>
	/// <param name="filter">The SDL_EventFilter function to call when an event happens.</param>
	/// <param name="userdata">A pointer that is passed to <paramref name="filter"/>.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_FilterEvents")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void FilterEvents(delegate* unmanaged[Cdecl]<nint, SDL_Event*, int> filter, nint userdata);

	/// <summary>
	/// Set the state of processing events by type.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetEventEnabled">documentation</see> for more details.
	/// </remarks>
	/// <param name="type">The type of event; see <see cref="SDL_EventType"/> for details.</param>
	/// <param name="enabled">Whether to process the event or not.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetEventEnabled")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void SetEventEnabled(SDL_EventType type, [MarshalAs(NativeBool)] bool enabled);

	/// <summary>
	/// Query the state of processing events by type.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EventEnabled">documentation</see> for more details.
	/// </remarks>
	/// <param name="type">The type of event; see SDL_EventType for details.</param>
	/// <returns>True if the event is being processed, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_EventEnabled")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool EventEnabled(SDL_EventType type);

	/// <summary>
	/// Allocate a set of user-defined events, and return the beginning event number for that set of events.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RegisterEvents">documentation</see> for more details.
	/// </remarks>
	/// <param name="numEvents">The number of events to be allocated.</param>
	/// <returns>The beginning event number, or 0 if <paramref name="numEvents"/> is invalid or if there are not enough user-defined events left.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RegisterEvents")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial uint RegisterEvents(int numEvents);

	/// <summary>
	/// Get window associated with an event.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowFromEvent">documentation</see> for more details.
	/// </remarks>
	/// <param name="e">An event containing a <c>WindowId</c>.</param>
	/// <returns>The associated window on success or <see langword="null"/> if there is none.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowFromEvent")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Window* GetWindowFromEvent([Const] SDL_Event* e);
}