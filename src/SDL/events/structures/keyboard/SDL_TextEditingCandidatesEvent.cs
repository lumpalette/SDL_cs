using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SDL3;

/// <summary>
/// Keyboard IME candidates event structure (<see cref="SDL_Event.TextEditingCandidates"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_TextEditingCandidatesEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct SDL_TextEditingCandidatesEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.TextEditingCandidates"/>.
	/// </summary>
	public readonly SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public readonly ulong Timestamp;

	/// <summary>
	/// The window with keyboard focus, if any.
	/// </summary>
	public readonly SDL_WindowId WindowId;

	/// <summary>
	/// The list of candidates, or <see langword="null"/> if there are no candidates available.
	/// </summary>
	/// <remarks>
	/// Use <see cref="SDL.UnmanagedToManagedStrings(byte**, int)"/> to convert this field into an array of managed strings.
	/// </remarks>
	public readonly byte** Candidates;

	/// <summary>
	/// The number of strings in <see cref="Candidates"/>.
	/// </summary>
	public readonly int NumCandidates;

	/// <summary>
	/// The index of the selected candidate, or -1 if no candidate is selected.
	/// </summary>
	public readonly int SelectedCandidate;

	/// <summary>
	/// True if the list is horizontal, false if it's vertical.
	/// </summary>
	public readonly bool Horizontal => _horizontal == 1;

	private readonly int _horizontal;
}