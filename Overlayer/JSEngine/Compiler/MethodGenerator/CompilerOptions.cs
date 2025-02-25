﻿using System;

namespace JSEngine.Compiler
{
    /// <summary>
    /// Represents a set of options that influence the compiler.
    /// </summary>
    public sealed class CompilerOptions
    {
        /// <summary>
        /// Creates a new CompilerOptions instance.
        /// </summary>
        public CompilerOptions()
        {
        }

        /// <summary>
        /// Gets or sets a value that indicates whether to force ES5 strict mode, even if the code
        /// does not contain a strict mode directive ("use strict").  The default is <c>false</c>.
        /// </summary>
        public bool ForceStrictMode { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates what compatibility mode to use.
        /// </summary>
        public CompatibilityMode CompatibilityMode { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether to disassemble any generated IL and store it
        /// in the associated function.
        /// </summary>
        public bool EnableILAnalysis { get; set; }

        /// <summary>
        /// Performs a shallow clone of this instance.
        /// </summary>
        /// <returns> A shallow clone of this instance. </returns>
        public CompilerOptions Clone()
        {
            return (CompilerOptions)this.MemberwiseClone();
        }
    }
}