using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Defines the C# bindings to operate with SDL.
/// </summary>
public static unsafe partial class SDL
{
	private const string LibraryName = "SDL3";

	private const UnmanagedType NativeBool = UnmanagedType.I4;
}