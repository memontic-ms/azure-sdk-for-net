// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The SentimentDocumentResult. </summary>
    internal partial class SentimentDocumentResult : DocumentResult
    {
        /// <summary> Initializes a new instance of <see cref="SentimentDocumentResult"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="sentiment"> Predicted sentiment for document (Negative, Neutral, Positive, or Mixed). </param>
        /// <param name="confidenceScores"> Document level sentiment confidence scores between 0 and 1 for each sentiment class. </param>
        /// <param name="sentences"> Sentence level sentiment analysis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="warnings"/>, <paramref name="confidenceScores"/> or <paramref name="sentences"/> is null. </exception>
        public SentimentDocumentResult(string id, IEnumerable<DocumentWarning> warnings, TextSentiment sentiment, SentimentConfidenceScores confidenceScores, IEnumerable<SentenceSentimentInternal> sentences) : base(id, warnings)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(warnings, nameof(warnings));
            Argument.AssertNotNull(confidenceScores, nameof(confidenceScores));
            Argument.AssertNotNull(sentences, nameof(sentences));

            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Sentences = sentences.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SentimentDocumentResult"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="sentiment"> Predicted sentiment for document (Negative, Neutral, Positive, or Mixed). </param>
        /// <param name="confidenceScores"> Document level sentiment confidence scores between 0 and 1 for each sentiment class. </param>
        /// <param name="sentences"> Sentence level sentiment analysis. </param>
        internal SentimentDocumentResult(string id, IList<DocumentWarning> warnings, TextDocumentStatistics? statistics, TextSentiment sentiment, SentimentConfidenceScores confidenceScores, IList<SentenceSentimentInternal> sentences) : base(id, warnings, statistics)
        {
            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Sentences = sentences;
        }

        /// <summary> Predicted sentiment for document (Negative, Neutral, Positive, or Mixed). </summary>
        public TextSentiment Sentiment { get; set; }
        /// <summary> Document level sentiment confidence scores between 0 and 1 for each sentiment class. </summary>
        public SentimentConfidenceScores ConfidenceScores { get; set; }
        /// <summary> Sentence level sentiment analysis. </summary>
        public IList<SentenceSentimentInternal> Sentences { get; }
    }
}
