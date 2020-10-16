// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Template Spec Version object.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TemplateSpecVersion : AzureResourceBase
    {
        /// <summary>
        /// Initializes a new instance of the TemplateSpecVersion class.
        /// </summary>
        public TemplateSpecVersion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TemplateSpecVersion class.
        /// </summary>
        /// <param name="location">The location of the Template Spec Version.
        /// It must match the location of the parent Template Spec.</param>
        /// <param name="id">String Id used to locate any resource on
        /// Azure.</param>
        /// <param name="name">Name of this resource.</param>
        /// <param name="type">Type of this resource.</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        /// <param name="artifacts">An array of Template Spec
        /// artifacts.</param>
        /// <param name="description">Template Spec version
        /// description.</param>
        /// <param name="template">The Azure Resource Manager template
        /// content.</param>
        /// <param name="uiDefinition">The Azure Resource Manager template UI
        /// definition content</param>
        /// <param name="tags">Resource tags.</param>
        public TemplateSpecVersion(string location, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), IList<TemplateSpecArtifact> artifacts = default(IList<TemplateSpecArtifact>), string description = default(string), object template = default(object), object uiDefinition = default(object), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(id, name, type, systemData)
        {
            Location = location;
            Artifacts = artifacts;
            Description = description;
            Template = template;
            UiDefinition = uiDefinition;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the location of the Template Spec Version. It must
        /// match the location of the parent Template Spec.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets an array of Template Spec artifacts.
        /// </summary>
        [JsonProperty(PropertyName = "properties.artifacts")]
        public IList<TemplateSpecArtifact> Artifacts { get; set; }

        /// <summary>
        /// Gets or sets template Spec version description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Azure Resource Manager template content.
        /// </summary>
        [JsonProperty(PropertyName = "properties.template")]
        public object Template { get; set; }

        /// <summary>
        /// Gets or sets the Azure Resource Manager template UI definition
        /// content
        /// </summary>
        [JsonProperty(PropertyName = "properties.uiDefinition")]
        public object UiDefinition { get; set; }

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (Artifacts != null)
            {
                foreach (var element in Artifacts)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Description != null)
            {
                if (Description.Length > 4096)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 4096);
                }
            }
        }
    }
}
