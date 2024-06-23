using System;

namespace SDL_cs;

/// <summary>
/// Pen flags. These share a bitmask space with <see cref="SDL_MouseButton"/> and friends.
/// </summary>
[Flags]
public enum SDL_PenFlags : byte
{
	DownBitIndex = 13,
	InkBitIndex = 14,
	EraserBitIndex = 15,
	AxisBitOffset = 16
}