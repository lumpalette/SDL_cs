﻿using System;

namespace SDL3;

/// <summary>
/// Indicates that a pointer is a constant pointer.
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public sealed class ConstAttribute : Attribute;