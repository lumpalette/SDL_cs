using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_events.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_events.h
unsafe partial class SDL
{
	/// <summary>
	/// Pump the event loop, gathering events from the input devices.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PumpEvents">documentation</see> for more details.
	/// </remarks>
	public static void PumpEvents()
	{
		_PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_PumpEvents", CallingConvention = CallingConvention.Cdecl)]
		static extern void _PInvoke();
	}

	/// <summary>
	/// Check the event queue for messages and optionally return them.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PeepEvents">documentation</see> for more details.
	/// </remarks>
	/// <param name="events"> Returns an array containing the retrieved events, may be null to leave the events in the queue and return the number of events that would have been stored. </param>
	/// <param name="numEvents"> If <paramref name="action"/> is <see cref="SDL_EventAction.AddEvent"/>, the number of events to add back to the event queue; if <paramref name="action"/> is <see cref="SDL_EventAction.PeekEvent"/> or <see cref="SDL_EventAction.GetEvent"/>, the maximum number of events to retrieve. </param>
	/// <param name="action"> The action to take. </param>
	/// <param name="minType"> Minimum value of the event type to be considered; <see cref="SDL_EventType.First"/> is a safe choice. </param>
	/// <param name="maxType"> Maximum value of the event type to be considered; <see cref="SDL_EventType.Last"/> is a safe choice. </param>
	/// <returns> The number of events actually stored or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int PeepEvents(out SDL_Event[]? events, int numEvents, SDL_EventAction action, SDL_EventType minType, SDL_EventType maxType)
	{
		fixed (SDL_Event* eventsPtr = events)
		{
			return _PInvoke(eventsPtr, numEvents, action, minType, maxType);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_PeepEvents", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Event* events, int numEvents, SDL_EventAction action, SDL_EventType minType, SDL_EventType maxType);
	}

	/// <summary>
	/// Check for the existence of a certain event type in the event queue.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasEvent">documentation</see> for more details.
	/// </remarks>
	/// <param name="type"> The type of event to be queried; see <see cref="SDL_EventType"/> for details. </param>
	/// <returns> True if events matching <paramref name="type"/> are present, or false if events matching <paramref name="type"/> are not present. </returns>
	public static bool HasEvent(SDL_EventType type)
	{
		return _PInvoke(type) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_HasEvent", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_EventType type);
	}

	/// <summary>
	/// Clear events of a specific type from the event queue.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FlushEvent">documentation</see> for more details.
	/// </remarks>
	/// <param name="type"> The type of event to be cleared; see <see cref="SDL_EventType"/> for details. </param>
	public static void FlushEvent(SDL_EventType type)
	{
		_PInvoke(type);

		[DllImport(LibraryName, EntryPoint = "SDL_FlushEvent", CallingConvention = CallingConvention.Cdecl)]
		static extern void _PInvoke(SDL_EventType type);
	}

	/// <summary>
	/// Clear events of a range of types from the event queue.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FlushEvents">documentation</see> for more details.
	/// </remarks>
	/// <param name="minType"> The low end of event type to be cleared, inclusive; see <see cref="SDL_EventType"/> for details. </param>
	/// <param name="maxType"> The high end of event type to be cleared, inclusive; see <see cref="SDL_EventType"/> for details. </param>
	public static void FlushEvents(SDL_EventType minType, SDL_EventType maxType)
	{
		_PInvoke(minType, maxType);

		[DllImport(LibraryName, EntryPoint = "SDL_FlushEvents", CallingConvention = CallingConvention.Cdecl)]
		static extern void _PInvoke(SDL_EventType minType, SDL_EventType maxType);
	}

	/// <summary>
	/// Poll for currently pending events.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PollEvent">documentation</see> for more details.
	/// </remarks>
	/// <param name="e"> The <see cref="SDL_Event"/> structure to be filled with the next event from the queue, or null. </param>
	/// <returns> True if this got an event or false if there are none available. </returns>
	public static bool PollEvent(SDL_Event* e)
	{
		return _PInvoke(e) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_PollEvent", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Event* e);
	}

	/// <summary>
	/// Wait indefinitely for the next available event.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WaitEvent">documentation</see> for more details.
	/// </remarks>
	/// <param name="e"> The <see cref="SDL_Event"/> structure to be filled with the next event from the queue, or null. </param>
	/// <returns> True on success or false if there was an error while waiting for events; call <see cref="GetError"/> for more information </returns>
	public static bool WaitEvent(SDL_Event* e)
	{
		return _PInvoke(e) == 1;
	
		[DllImport(LibraryName, EntryPoint = "SDL_WaitEvent", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Event* e);
	}

	/// <summary>
	/// Wait until the specified timeout (in milliseconds) for the next available event.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WaitEventTimeout">documentation</see> for more details.
	/// </remarks>
	/// <param name="e"> The <see cref="SDL_Event"/> structure to be filled in with the next event from the queue, or null. </param>
	/// <param name="timeoutMs"> The maximum number of milliseconds to wait for the next available event. </param>
	/// <returns> True if this got an event or false if the timeout elapsed without any events available. </returns>
	public static bool WaitEventTimeout(SDL_Event* e, int timeoutMs)
	{
		return _PInvoke(e, timeoutMs) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_WaitEventTimeout", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Event* e, int timeoutMs);
	}

	/// <summary>
	/// Add an event to the event queue.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PushEvent">documentation</see> for more details.
	/// </remarks>
	/// <param name="e"> The <see cref="SDL_Event"/> to be added to the queue. </param>
	/// <returns> 1 on success, 0 if the event was filtered, or a negative error code on failure; call <see cref="GetError"/> for more information. A common reason for error is the event queue being full. </returns>
	public static int PushEvent(SDL_Event* e)
	{
		return _PInvoke(e);
		
		[DllImport(LibraryName, EntryPoint = "SDL_PushEvent", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Event* e);
	}

	/// <summary>
	/// Set up a filter to process all events before they change internal state and are posted to the internal event queue.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetEventFilter">documentation</see> for more details.
	/// </remarks>
	/// <param name="filter"> An <see cref="SDL_EventFilterCallback"/> function to call when an event happens. </param>
	/// <param name="userData"> A pointer that is passed to <paramref name="filter"/>. </param>
	public static void SetEventFilter(SDL_EventFilterCallback filter, void* userData)
	{
		_PInvoke(filter, userData);

		[DllImport(LibraryName, EntryPoint = "SDL_SetEventFilter", CallingConvention = CallingConvention.Cdecl)]
		static extern void _PInvoke(SDL_EventFilterCallback filter, void* userData);
	}

	/// <summary>
	/// Query the current event filter.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetEventFilter">documentation</see> for more details.
	/// </remarks>
	/// <param name="filter"> Returns the current callback function. </param>
	/// <param name="userData"> Returns the pointer that is passed to the current event filter. </param>
	/// <returns> True on success or false if there is no event filter set. </returns>
	public static bool GetEventFilter(out SDL_EventFilterCallback? filter, out void* userData)
	{
		filter = null;
		fixed (void** userDataPtr = &userData)
		{
			void* filterPtr = null;
			int result = _PInvoke(&filterPtr, userDataPtr);
			if (filterPtr is not null)
			{
				// I didn't even knew this function existed LOL.
				filter = Marshal.GetDelegateForFunctionPointer<SDL_EventFilterCallback>((nint)filterPtr);
			}
			return result == 1;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetEventFilter", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(void** filter, void** userdata);
	}

	/// <summary>
	/// Add a callback to be triggered when an event is added to the event queue.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AddEventWatch">documentation</see> for more details.
	/// </remarks>
	/// <param name="filter"> An <see cref="SDL_EventFilterCallback"/> function to call when an event happens. </param>
	/// <param name="userData"> A pointer that is passed to <paramref name="filter"/>. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int AddEventWatch(SDL_EventFilterCallback filter, void* userData)
	{
		return _PInvoke(filter, userData);

		[DllImport(LibraryName, EntryPoint = "SDL_AddEventWatch", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_EventFilterCallback filter, void* userData);
	}

	/// <summary>
	/// Remove an event watch callback added with <see cref="AddEventWatch(SDL_EventFilterCallback, void*)"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DelEventWatch">documentation</see> for more details.
	/// </remarks>
	/// <param name="filter"> The function originally passed to <see cref="AddEventWatch(SDL_EventFilterCallback, void*)"/>. </param>
	/// <param name="userData"> The pointer originally passed to <see cref="AddEventWatch(SDL_EventFilterCallback, void*)"/>. </param>
	public static void DeleteEventWatch(SDL_EventFilterCallback filter, void* userData)
	{
		_PInvoke(filter, userData);

		[DllImport(LibraryName, EntryPoint = "SDL_DelEventWatch", CallingConvention = CallingConvention.Cdecl)]
		static extern void _PInvoke(SDL_EventFilterCallback filter, void* userData);
	}

	/// <summary>
	/// Run a specific filter function on the current event queue, removing any events for which the filter returns 0.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FilterEvents">documentation</see> for more details.
	/// </remarks>
	/// <param name="filter"> The <see cref="SDL_EventFilterCallback"/> function to call when an event happens. </param>
	/// <param name="userData"> A pointer that is passed to <paramref name="filter"/>. </param>
	public static void FilterEvents(SDL_EventFilterCallback filter, void* userData)
	{
		_PInvoke(filter, userData);

		[DllImport(LibraryName, EntryPoint = "SDL_FilterEvents", CallingConvention = CallingConvention.Cdecl)]
		static extern void _PInvoke(SDL_EventFilterCallback filter, void* userData);
	}

	/// <summary>
	/// Set the state of processing events by type.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetEventEnabled">documentation</see> for more details.
	/// </remarks>
	/// <param name="type"> The type of event; see <see cref="SDL_EventType"/> for details. </param>
	/// <param name="enabled"> Whether to process the event or not. </param>
	public static void SetEventEnabled(SDL_EventType type, bool enabled)
	{
		_PInvoke(type, enabled ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetEventEnabled", CallingConvention = CallingConvention.Cdecl)]
		static extern void _PInvoke(SDL_EventType type, int enabled);
	}

	/// <summary>
	/// Query the state of processing events by type.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EventEnabled">documentation</see> for more details.
	/// </remarks>
	/// <param name="type"> The type of event; see <see cref="SDL_EventType"/> for details. </param>
	/// <returns> True if the event is being processed, false otherwise. </returns>
	public static bool EventEnabled(SDL_EventType type)
	{
		return _PInvoke(type) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_EventEnabled", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_EventType type);
	}

	/// <summary>
	/// Allocate a set of user-defined events, and return the beginning event.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RegisterEvents">documentation</see> for more details.
	/// </remarks>
	/// <param name="numEvents"> The number of events to be allocated. </param>
	/// <returns> The beginning event number, or <see cref="SDL_EventType.First"/> if <paramref name="numEvents"/> is invalid or if there are not enough user-defined events left. </returns>
	public static SDL_EventType RegisterEvents(int numEvents)
	{
		return _PInvoke(numEvents);

		[DllImport(LibraryName, EntryPoint = "SDL_RegisterEvents", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_EventType _PInvoke(int numEvents);
	}

	/// <summary>
	/// Allocate dynamic memory for an SDL event.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AllocateEventMemory">documentation</see> for more details.
	/// </remarks>
	/// <param name="size"> The amount of memory to allocate. </param>
	/// <returns> A pointer to the memory allocated or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static void* AllocateEventMemory(ulong size)
	{
		return _PInvoke(size);

		[DllImport(LibraryName, EntryPoint = "SDL_AllocateEventMemory", CallingConvention = CallingConvention.Cdecl)]
		static extern void* _PInvoke(ulong size);
	}
}