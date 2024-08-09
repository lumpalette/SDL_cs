namespace SDL3;

/// <summary>
/// The actions that can be done in <see cref="SDL.PeepEvents(SDL_Event*, int, SDL_EventAction, SDL_EventType, SDL_EventType)"/>.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EventAction">documentation</see> for more details.
/// </remarks>
public enum SDL_EventAction
{
	/// <summary>
	/// Events will be added to the back of the event queue.
	/// </summary>
	AddEvent,

	/// <summary>
	/// Events at the front of the event queue, within the specified minimum and maximum type, will be returned
	/// to the caller and will not be removed from the queue.
	/// </summary>
	PeekEvent,

	/// <summary>
	/// Events at the front of the event queue, within the specified minimum and maximum type, will be returned
	/// to the caller and will be removed from the queue.
	/// </summary>
	GetEvent
}