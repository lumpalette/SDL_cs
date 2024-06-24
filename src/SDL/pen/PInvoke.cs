using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_pen.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_pen.h.
unsafe partial class SDL
{
	[Macro]
	public static SDL_PenCapabilityFlags PenCapability(uint capbit)
	{
		return (SDL_PenCapabilityFlags)(1u << (int)capbit);
	}

	[Macro]
	public static SDL_PenCapabilityFlags PenAxisCapability(uint axis)
	{
		return PenCapability(axis + PenFlagAxisBitOffset);
	}

	/// <summary>
	/// Retrieves all pens that are connected to the system.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetPens">here</see> for more details.
	/// </remarks>
	/// <param name="count"> Returns the number of pens in the array. </param>
	/// <returns> An array of <see cref="SDL_PenId"/> values, or null on error. On a null return, <see cref="GetError"/> is set. </returns>
	public static SDL_PenId[]? GetPens(out int count)
	{
		fixed (int* countPtr = &count)
		{
			SDL_PenId* pensPtr = _PInvoke(countPtr);
			if (pensPtr is null)
			{
				return null;
			}
			SDL_PenId[] pens = new SDL_PenId[count];
			for (int i = 0; i < count; i++)
			{
				pens[i] = pensPtr[i];
			}
			Free(pensPtr);
			return pens;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetPens", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_PenId* _PInvoke(int* count);
	}

	/// <summary>
	/// Retrieves the pen's current status.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetPenStatus">here</see> for more details.
	/// </remarks>
	/// <param name="penId"> The pen to query. </param>
	/// <param name="x"> Returns the pen x coordinate. </param>
	/// <param name="y"> Returns the pen y coordinate. </param>
	/// <param name="axes"> Returns the axis information. The axes are in the same order as <see cref="SDL_PenAxis"/>. </param>
	/// <returns>
	/// A bit mask with the current pen button states (<see cref="SDL_MouseButtonFlags.ButtonLMask"/>, etc.), possibly
	/// <see cref="SDL_PenCapabilityFlags.Down"/>, and exactly one of <see cref="SDL_PenCapabilityFlags.Ink"/> or
	/// <see cref="SDL_PenCapabilityFlags.Eraser"/>, or 0 on error (see <see cref="GetError"/>).
	/// </returns>
	public static uint GetPenStatus(SDL_PenId penId, out float x, out float y, out float[] axes)
	{
		fixed (float* xPtr = &x, yPtr = &y, axesPtr = axes)
		{
			return _PInvoke(penId, xPtr, yPtr, axesPtr, (ulong)axes.LongLength);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetPenStatus", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern uint _PInvoke(SDL_PenId penId, float* x, float* y, float* axes, ulong numAxes);
	}

	/// <summary>
	/// Retrieves the <see cref="SDL_Guid"/> for a given <see cref="SDL_PenId"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetPenGUID">here</see> for more details.
	/// </remarks>
	/// <param name="penId"> The pen to query. </param>
	/// <returns> The corresponding pen GUID; persistent across multiple sessions. If <paramref name="penId"/> is <see cref="SDL_PenId.Invalid"/>, returns an all-zeroes GUID. </returns>
	public static SDL_Guid GetPenGuid(SDL_PenId penId)
	{
		return _PInvoke(penId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetPenGUID", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Guid _PInvoke(SDL_PenId penId);
	}

	/// <summary>
	/// Retrieves axesPtr human-readable description for a <see cref="SDL_PenId"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetPenName">here</see> for more details.
	/// </remarks>
	/// <param name="penId"> The pen to query. </param>
	/// <returns> A string that contains the name of the pen, intended for human consumption. Returns null on error (cf.<see cref="GetError"/>). </returns>
	public static string? GetPenName(SDL_PenId penId)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(penId));

		[DllImport(LibraryName, EntryPoint = "SDL_GetPenName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_PenId penId);
	}

	/// <summary>
	/// Retrieves capability flags for a given <see cref="SDL_PenId"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetPenCapabilities">here</see> for more details.
	/// </remarks>
	/// <param name="penId"> The pen to query. </param>
	/// <param name="capabilities"> Returns detail information about pen capabilities, such as the number of buttons. </param>
	/// <returns> A set of capability flags, cf. <see cref="PenCapability(uint)"/>. </returns>
	public static SDL_PenCapabilityFlags GetPenCapabilities(SDL_PenId penId, out SDL_PenCapabilityInfo capabilities)
	{
		fixed (SDL_PenCapabilityInfo* capabilitiesPtr = &capabilities)
		{
			return _PInvoke(penId, capabilitiesPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetPenCapabilities", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_PenCapabilityFlags _PInvoke(SDL_PenId penId, SDL_PenCapabilityInfo* capabilities);
	}

	/// <summary>
	/// Retrieves the pen type for a given <see cref="SDL_PenId"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetPenType">here</see> for more details.
	/// </remarks>
	/// <param name="penId"> The pen to query. </param>
	/// <returns> the corresponding pen type (cf. <see cref="SDL_PenSubtype"/>) or <see cref="SDL_PenSubtype.Unknown"/> on error. </returns>
	public static SDL_PenSubtype GetPenType(SDL_PenId penId)
	{
		return _PInvoke(penId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetPenType", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_PenSubtype _PInvoke(SDL_PenId penId);
	}

	/// <summary>
	/// Device ID for mouse events triggered by pen events.
	/// </summary>
	public static SDL_MouseId PenMouseId => new(uint.MaxValue - 2);

	public const int PenFlagDownBitIndex = 13;
	public const int PenFlagInkBitIndex = 14;
	public const int PenFlagEraserBitIndex = 15;
	public const int PenFlagAxisBitOffset = 16;
}