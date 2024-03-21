// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> An object describing the location and semantic content of a document. </summary>
    public partial class AnalyzedDocument
    {
        /// <summary> Initializes a new instance of <see cref="AnalyzedDocument"/>. </summary>
        /// <param name="documentType"> Document type. </param>
        /// <param name="spans"> Location of the document in the reading order concatenated content. </param>
        /// <param name="confidence"> Confidence of correctly extracting the document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="documentType"/> or <paramref name="spans"/> is null. </exception>
        internal AnalyzedDocument(string documentType, IEnumerable<DocumentSpan> spans, float confidence)
        {
            Argument.AssertNotNull(documentType, nameof(documentType));
            Argument.AssertNotNull(spans, nameof(spans));

            DocumentType = documentType;
            BoundingRegions = new ChangeTrackingList<BoundingRegion>();
            Spans = spans.ToList();
            Fields = new ChangeTrackingDictionary<string, DocumentField>();
            Confidence = confidence;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzedDocument"/>. </summary>
        /// <param name="documentType"> Document type. </param>
        /// <param name="boundingRegions"> Bounding regions covering the document. </param>
        /// <param name="spans"> Location of the document in the reading order concatenated content. </param>
        /// <param name="fields"> Dictionary of named field values. </param>
        /// <param name="confidence"> Confidence of correctly extracting the document. </param>
        internal AnalyzedDocument(string documentType, IReadOnlyList<BoundingRegion> boundingRegions, IReadOnlyList<DocumentSpan> spans, IReadOnlyDictionary<string, DocumentField> fields, float confidence)
        {
            DocumentType = documentType;
            BoundingRegions = boundingRegions;
            Spans = spans;
            Fields = fields;
            Confidence = confidence;
        }
        /// <summary> Bounding regions covering the document. </summary>
        public IReadOnlyList<BoundingRegion> BoundingRegions { get; }
        /// <summary> Location of the document in the reading order concatenated content. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
        /// <summary> Dictionary of named field values. </summary>
        public IReadOnlyDictionary<string, DocumentField> Fields { get; }
        /// <summary> Confidence of correctly extracting the document. </summary>
        public float Confidence { get; }
    }
}
