using System;
using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// An exception that can be thrown whenever an SDL function fails.
/// </summary>
[Serializable]
public class SDL_Exception : Exception
{
	/// <summary>
	/// Throws an <see cref="SDL_Exception"/> if the given condition is true.
	/// </summary>
	/// <param name="condition">The condition to check.</param>
	/// <param name="message">The message of the exception if it is thrown.</param>
	public static void ThrowIf(bool condition, string message)
	{
		if (condition)
		{
			throw new SDL_Exception(message);
		}
	}

	/// <summary>
	/// Instantiates a new <see cref="SDL_Exception"/> that shows the error message returned by <see cref="SDL.GetError"/>.
	/// </summary>
	public SDL_Exception() : base($"SDL error: '{SDL.GetError()}'.") => _ = SDL.ClearError();

	/// <summary>
	/// Instantiates a new <see cref="SDL_Exception"/> with the provided error message. The error message returned by
	/// <see cref="SDL.GetError"/> is also included.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public SDL_Exception(string message) : base($"{message} SDL error: '{SDL.GetError()}'.") => _ = SDL.ClearError();

	/// <summary>
	/// Instantiates a new <see cref="SDL_Exception"/> with the provided error message. The error message returned by
	/// <see cref="SDL.GetError"/> is also included.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="inner">The exception that caused the current exception.</param>
	public SDL_Exception(string message, Exception inner) : base($"{message} SDL error: '{SDL.GetError()}'.", inner) => _ = SDL.ClearError();
}