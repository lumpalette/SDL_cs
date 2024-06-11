using System;

namespace SDL_cs;

/// <summary>
/// The flags on An <see cref="SDL_Surface"/>.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SurfaceFlags">here</see>.
/// </remarks>
[Flags]
public enum SDL_SurfaceFlags : uint
{
	/// <summary>
	/// Surface uses preallocated memory.
	/// </summary>
	PreAlloc = 0x00000001u,

	/// <summary>
	/// Surface is RLE encoded.
	/// </summary>
	RleAccel = 0x00000002u,

	/// <summary>
	/// Surface is referenced internally.
	/// </summary>
	DontFree = 0x00000004u,

	/// <summary>
	/// Surface uses aligned memory.
	/// </summary>
	SimdAligned = 0x00000008u,

	/// <summary>
	/// Surface uses properties.
	/// </summary>
	UsesProperties = 0x00000010u
}