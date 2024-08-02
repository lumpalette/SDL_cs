using System;
using System.ComponentModel;

namespace SDL3;

/// <summary>
/// Indicates that an <see langword="enum"/> or <see langword="struct"/> is a typedef.
/// </summary>
[AttributeUsage(AttributeTargets.Enum | AttributeTargets.Struct)]
[EditorBrowsable(EditorBrowsableState.Never)]
public sealed class TypedefAttribute : Attribute;