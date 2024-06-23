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
	DownMask = 1u << SDL_PenFlags.DownBitIndex,

	/// <summary>
	/// Pen has a regular drawing tip (FIXME:SDL_GetPenCapabilities). For events (FIXME:SDL_PenButtonEvent,
	/// FIXME:SDL_PenMotionEvent, FIXME:SDL_GetPenStatus) this flag is mutually exclusive with <see cref="PenEraserMask"/>.
	/// </summary>
	InkMask = 1u << SDL_PenFlags.InkBitIndex,

	/// <summary>
	/// Pen has an eraser tip (FIXME:SDL_GetPenCapabilities) or is being used as eraser (FIXME:SDL_PenButtonEvent,
	/// FIXME:SDL_PenMotionEvent, FIXME:SDL_GetPenStatus).
	/// </summary>
	EraserMask = 1u << SDL_PenFlags.EraserBitIndex,

	/// <summary>
	/// Pen provides pressure information in axis <see cref="SDL_PenAxis.Pressure"/>.
	/// </summary>
	AxisPressureMask = 1u << (SDL_PenAxis.Pressure + SDL_PenFlags.AxisBitOffset),

	/// <summary>
	/// Pen provides horizontal tilt information in axis <see cref="SDL_PenAxis.XTilt"/>.
	/// </summary>
	AxisXTiltMask = 1u << (SDL_PenAxis.XTilt + SDL_PenFlags.AxisBitOffset),

	/// <summary>
	/// Pen provides vertical tilt information in axis <see cref="SDL_PenAxis.YTilt"/>.
	/// </summary>
	AxisYTiltMask = 1u << (SDL_PenAxis.YTilt + SDL_PenFlags.AxisBitOffset),

	/// <summary>
	/// Pen provides distance to drawing tablet in <see cref="SDL_PenAxis.Distance"/>.
	/// </summary>
	AxisDistanceMask = 1u << (SDL_PenAxis.Distance + SDL_PenFlags.AxisBitOffset),

	/// <summary>
	/// Pen provides barrel rotation information in axis <see cref="SDL_PenAxis.Rotation"/>.
	/// </summary>
	AxisRotationMask = 1u << (SDL_PenAxis.Rotation + SDL_PenFlags.AxisBitOffset),

	/// <summary>
	/// Pen provides slider/finger wheel or similar in axis <see cref="SDL_PenAxis.Slider"/>
	/// </summary>
	AxisSliderMask = 1u << (SDL_PenAxis.Slider + SDL_PenFlags.AxisBitOffset),

	AxisBidirectionalMasks = AxisXTiltMask | AxisYTiltMask
}