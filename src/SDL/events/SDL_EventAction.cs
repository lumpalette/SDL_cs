namespace SDL3;

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