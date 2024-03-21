// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Image Classification Multilabel. Multi-label image classification is used when an image could have one or more labels
    /// from a set of labels - e.g. an image could be labeled with both 'cat' and 'dog'.
    /// </summary>
    public partial class ImageClassificationMultilabel : AutoMLVertical
    {
        /// <summary> Initializes a new instance of <see cref="ImageClassificationMultilabel"/>. </summary>
        /// <param name="trainingData"> [Required] Training data input. </param>
        /// <param name="limitSettings"> [Required] Limit settings for the AutoML job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trainingData"/> or <paramref name="limitSettings"/> is null. </exception>
        public ImageClassificationMultilabel(MachineLearningTableJobInput trainingData, ImageLimitSettings limitSettings) : base(trainingData)
        {
            Argument.AssertNotNull(trainingData, nameof(trainingData));
            Argument.AssertNotNull(limitSettings, nameof(limitSettings));

            SearchSpace = new ChangeTrackingList<ImageModelDistributionSettingsClassification>();
            LimitSettings = limitSettings;
            TaskType = TaskType.ImageClassificationMultilabel;
        }

        /// <summary> Initializes a new instance of <see cref="ImageClassificationMultilabel"/>. </summary>
        /// <param name="logVerbosity"> Log verbosity for the job. </param>
        /// <param name="targetColumnName">
        /// Target column name: This is prediction values column.
        /// Also known as label column name in context of classification tasks.
        /// </param>
        /// <param name="taskType"> [Required] Task type for AutoMLJob. </param>
        /// <param name="trainingData"> [Required] Training data input. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="primaryMetric"> Primary metric to optimize for this task. </param>
        /// <param name="modelSettings"> Settings used for training the model. </param>
        /// <param name="searchSpace"> Search space for sampling different combinations of models and their hyperparameters. </param>
        /// <param name="limitSettings"> [Required] Limit settings for the AutoML job. </param>
        /// <param name="sweepSettings"> Model sweeping and hyperparameter sweeping related settings. </param>
        /// <param name="validationData"> Validation data inputs. </param>
        /// <param name="validationDataSize">
        /// The fraction of training dataset that needs to be set aside for validation purpose.
        /// Values between (0.0 , 1.0)
        /// Applied when validation dataset is not provided.
        /// </param>
        internal ImageClassificationMultilabel(MachineLearningLogVerbosity? logVerbosity, string targetColumnName, TaskType taskType, MachineLearningTableJobInput trainingData, IDictionary<string, BinaryData> serializedAdditionalRawData, ClassificationMultilabelPrimaryMetric? primaryMetric, ImageModelSettingsClassification modelSettings, IList<ImageModelDistributionSettingsClassification> searchSpace, ImageLimitSettings limitSettings, ImageSweepSettings sweepSettings, MachineLearningTableJobInput validationData, double? validationDataSize) : base(logVerbosity, targetColumnName, taskType, trainingData, serializedAdditionalRawData)
        {
            PrimaryMetric = primaryMetric;
            ModelSettings = modelSettings;
            SearchSpace = searchSpace;
            LimitSettings = limitSettings;
            SweepSettings = sweepSettings;
            ValidationData = validationData;
            ValidationDataSize = validationDataSize;
            TaskType = taskType;
        }

        /// <summary> Initializes a new instance of <see cref="ImageClassificationMultilabel"/> for deserialization. </summary>
        internal ImageClassificationMultilabel()
        {
        }

        /// <summary> Primary metric to optimize for this task. </summary>
        public ClassificationMultilabelPrimaryMetric? PrimaryMetric { get; set; }
        /// <summary> Settings used for training the model. </summary>
        public ImageModelSettingsClassification ModelSettings { get; set; }
        /// <summary> Search space for sampling different combinations of models and their hyperparameters. </summary>
        public IList<ImageModelDistributionSettingsClassification> SearchSpace { get; set; }
        /// <summary> [Required] Limit settings for the AutoML job. </summary>
        public ImageLimitSettings LimitSettings { get; set; }
        /// <summary> Model sweeping and hyperparameter sweeping related settings. </summary>
        public ImageSweepSettings SweepSettings { get; set; }
        /// <summary> Validation data inputs. </summary>
        public MachineLearningTableJobInput ValidationData { get; set; }
        /// <summary>
        /// The fraction of training dataset that needs to be set aside for validation purpose.
        /// Values between (0.0 , 1.0)
        /// Applied when validation dataset is not provided.
        /// </summary>
        public double? ValidationDataSize { get; set; }
    }
}
