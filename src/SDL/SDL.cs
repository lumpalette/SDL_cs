using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Defines the C# bindings, properties and constants to interact with the SDL API.
/// </summary>
public static unsafe partial class SDL
{
	/// <summary>
	/// A collection of properties, used in various SDL systems.
	/// </summary>
	public static partial class Prop;

	/// <summary>
	/// The name of the library: SDL3.
	/// </summary>
	internal const string LibraryName = "SDL3";

	/// <summary>
	/// The size of SDL_bool: an i4.
	/// </summary>
	internal const UnmanagedType NativeBool = UnmanagedType.I4;
}