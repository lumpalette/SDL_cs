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
public unsafe struct SDL_TextEditingCandidatesEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.TextEditingCandidates"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with keyboard focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// The list of candidates, or <see langword="null"/> if there are no candidates available.
	/// </summary>
	/// <remarks>
	/// Use <see cref="SDL.UnmanagedToManagedStrings(byte**, int)"/> to convert this field into an array of managed strings.
	/// </remarks>
	public byte** Candidates;

	/// <summary>
	/// The number of strings in <see cref="Candidates"/>.
	/// </summary>
	public int NumCandidates;

	/// <summary>
	/// The index of the selected candidate, or -1 if no candidate is selected.
	/// </summary>
	public int SelectedCandidate;

	/// <summary>
	/// True if the list is horizontal, false if it's vertical.
	/// </summary>
	public bool Horizontal
	{
		readonly get => _horizontal == 1;
		set => _horizontal = value ? 1 : 0;
	}

	private int _horizontal;

	private readonly byte _padding1;

	private readonly byte _padding2;
	
	private readonly byte _padding3;
}