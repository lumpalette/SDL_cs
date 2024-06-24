using System;

namespace SDL_cs;

/// <summary>
/// Pen capabilities reported by <see cref="SDL.GetPenCapabilities"/>.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_PenCapabilityFlags">here</see> for more details.
/// </remarks>
[Flags]
public enum SDL_PenCapabilityFlags : uint
{
	/// <summary>
	/// Pen tip is currently touching the drawing surface.
	/// </summary>
	Down = 1u << SDL.PenFlagDownBitIndex,

	/// <summary>
	/// Pen has a regular drawing tip (<see cref="SDL.GetPenCapabilities(SDL_PenId, out SDL_PenCapabilityInfo)"/>). For events
	/// (<see cref="SDL_PenButtonEvent"/>, <see cref="SDL_PenMotionEvent"/>,
	/// <see cref="SDL.GetPenStatus(SDL_PenId, out float, out float, out float[])"/>) this flag is mutually exclusive with
	/// <see cref="Eraser"/>.
	/// </summary>
	Ink = 1u << SDL.PenFlagInkBitIndex,

	/// <summary>
	/// Pen has an eraser tip (<see cref="SDL.GetPenCapabilities(SDL_PenId, out SDL_PenCapabilityInfo)"/>) or is being used as
	/// eraser (<see cref="SDL_PenButtonEvent"/>, <see cref="SDL_PenMotionEvent"/>,
	/// <see cref="SDL.GetPenStatus(SDL_PenId, out float, out float, out float[])"/>).
	/// </summary>
	Eraser = 1u << SDL.PenFlagEraserBitIndex,

	/// <summary>
	/// Pen provides pressure information in axis <see cref="SDL_PenAxis.Pressure"/>.
	/// </summary>
	AxisPressure = 1u << (SDL_PenAxis.Pressure + SDL.PenFlagAxisBitOffset),

	/// <summary>
	/// Pen provides horizontal tilt information in axis <see cref="SDL_PenAxis.XTilt"/>.
	/// </summary>
	AxisXTilt = 1u << (SDL_PenAxis.XTilt + SDL.PenFlagAxisBitOffset),

	/// <summary>
	/// Pen provides vertical tilt information in axis <see cref="SDL_PenAxis.YTilt"/>.
	/// </summary>
	AxisYTilt = 1u << (SDL_PenAxis.YTilt + SDL.PenFlagAxisBitOffset),

	/// <summary>
	/// Pen provides distance to drawing tablet in <see cref="SDL_PenAxis.Distance"/>.
	/// </summary>
	AxisDistance = 1u << (SDL_PenAxis.Distance + SDL.PenFlagAxisBitOffset),

	/// <summary>
	/// Pen provides barrel rotation information in axis <see cref="SDL_PenAxis.Rotation"/>.
	/// </summary>
	AxisRotation = 1u << (SDL_PenAxis.Rotation + SDL.PenFlagAxisBitOffset),

	/// <summary>
	/// Pen provides slider/finger wheel or similar in axis <see cref="SDL_PenAxis.Slider"/>
	/// </summary>
	AxisSlider = 1u << (SDL_PenAxis.Slider + SDL.PenFlagAxisBitOffset),

	AxisBidirectional = AxisXTilt | AxisYTilt
}