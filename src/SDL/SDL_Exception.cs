using System;

namespace SDL_cs;

/// <summary>
/// An exception that can be thrown whenever an SDL function fails.
/// </summary>
[Serializable]
public class SDL_Exception : Exception
{
	/// <summary>
	/// Instantiates a new <see cref="SDL_Exception"/> that shows the error message returned by <see cref="SDL.GetError"/>.
	/// </summary>
	public SDL_Exception() : base($"SDL error: '{SDL.GetError()}'.") { }

	/// <summary>
	/// Instantiates a new <see cref="SDL_Exception"/> with the provided error message. The error message returned by
	/// <see cref="SDL.GetError"/> is also included.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public SDL_Exception(string message) : base($"{message} SDL error: '{SDL.GetError()}'.") { }

	/// <summary>
	/// Instantiates a new <see cref="SDL_Exception"/> with the provided error message. The error message returned by
	/// <see cref="SDL.GetError"/> is also included.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public SDL_Exception(string message, Exception inner) : base($"{message} SDL error: '{SDL.GetError()}'.", inner) { }
}