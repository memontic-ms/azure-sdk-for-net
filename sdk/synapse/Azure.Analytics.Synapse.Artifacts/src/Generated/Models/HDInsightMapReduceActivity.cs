// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> HDInsight MapReduce activity type. </summary>
    public partial class HDInsightMapReduceActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of <see cref="HDInsightMapReduceActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="className"> Class name. Type: string (or Expression with resultType string). </param>
        /// <param name="jarFilePath"> Jar path. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="className"/> or <paramref name="jarFilePath"/> is null. </exception>
        public HDInsightMapReduceActivity(string name, object className, object jarFilePath) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(className, nameof(className));
            Argument.AssertNotNull(jarFilePath, nameof(jarFilePath));

            StorageLinkedServices = new ChangeTrackingList<LinkedServiceReference>();
            Arguments = new ChangeTrackingList<object>();
            ClassName = className;
            JarFilePath = jarFilePath;
            JarLibs = new ChangeTrackingList<object>();
            Defines = new ChangeTrackingDictionary<string, object>();
            Type = "HDInsightMapReduce";
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightMapReduceActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="storageLinkedServices"> Storage linked service references. </param>
        /// <param name="arguments"> User specified arguments to HDInsightActivity. </param>
        /// <param name="getDebugInfo"> Debug info option. </param>
        /// <param name="className"> Class name. Type: string (or Expression with resultType string). </param>
        /// <param name="jarFilePath"> Jar path. Type: string (or Expression with resultType string). </param>
        /// <param name="jarLinkedService"> Jar linked service reference. </param>
        /// <param name="jarLibs"> Jar libs. </param>
        /// <param name="defines"> Allows user to specify defines for the MapReduce job request. </param>
        internal HDInsightMapReduceActivity(string name, string type, string description, ActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, IList<LinkedServiceReference> storageLinkedServices, IList<object> arguments, HDInsightActivityDebugInfoOption? getDebugInfo, object className, object jarFilePath, LinkedServiceReference jarLinkedService, IList<object> jarLibs, IDictionary<string, object> defines) : base(name, type, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            StorageLinkedServices = storageLinkedServices;
            Arguments = arguments;
            GetDebugInfo = getDebugInfo;
            ClassName = className;
            JarFilePath = jarFilePath;
            JarLinkedService = jarLinkedService;
            JarLibs = jarLibs;
            Defines = defines;
            Type = type ?? "HDInsightMapReduce";
        }

        /// <summary> Storage linked service references. </summary>
        public IList<LinkedServiceReference> StorageLinkedServices { get; }
        /// <summary> User specified arguments to HDInsightActivity. </summary>
        public IList<object> Arguments { get; }
        /// <summary> Debug info option. </summary>
        public HDInsightActivityDebugInfoOption? GetDebugInfo { get; set; }
        /// <summary> Class name. Type: string (or Expression with resultType string). </summary>
        public object ClassName { get; set; }
        /// <summary> Jar path. Type: string (or Expression with resultType string). </summary>
        public object JarFilePath { get; set; }
        /// <summary> Jar linked service reference. </summary>
        public LinkedServiceReference JarLinkedService { get; set; }
        /// <summary> Jar libs. </summary>
        public IList<object> JarLibs { get; }
        /// <summary> Allows user to specify defines for the MapReduce job request. </summary>
        public IDictionary<string, object> Defines { get; }
    }
}
