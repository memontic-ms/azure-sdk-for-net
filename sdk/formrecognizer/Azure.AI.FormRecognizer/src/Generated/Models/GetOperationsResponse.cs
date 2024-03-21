// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> List Operations response object. </summary>
    internal partial class GetOperationsResponse
    {
        /// <summary> Initializes a new instance of <see cref="GetOperationsResponse"/>. </summary>
        /// <param name="value"> List of operations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal GetOperationsResponse(IEnumerable<OperationSummary> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="GetOperationsResponse"/>. </summary>
        /// <param name="value"> List of operations. </param>
        /// <param name="nextLink"> Link to the next page of operations. </param>
        internal GetOperationsResponse(IReadOnlyList<OperationSummary> value, Uri nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of operations. </summary>
        public IReadOnlyList<OperationSummary> Value { get; }
        /// <summary> Link to the next page of operations. </summary>
        public Uri NextLink { get; }
    }
}
