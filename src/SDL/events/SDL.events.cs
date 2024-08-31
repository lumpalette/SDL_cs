 using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL3;

// SDL_event.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_mouse.h.
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

	/// <summary>
	/// A value that signifies a button is no longer pressed.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RELEASED">documentation</see> for more details.
	/// </remarks>
	public const byte Released = 0;

	/// <summary>
	/// A value that signifies a button has been pressed down.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PRESSED">documentation</see> for more details.
	/// </remarks>
	public const byte Pressed = 1;
}