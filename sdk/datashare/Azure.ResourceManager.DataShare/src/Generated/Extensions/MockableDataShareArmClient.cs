// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.DataShare.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableDataShareArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableDataShareArmClient"/> class for mocking. </summary>
        protected MockableDataShareArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDataShareArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDataShareArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableDataShareArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataShareAccountResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataShareAccountResource.CreateResourceIdentifier" /> to create a <see cref="DataShareAccountResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataShareAccountResource"/> object. </returns>
        public virtual DataShareAccountResource GetDataShareAccountResource(ResourceIdentifier id)
        {
            DataShareAccountResource.ValidateResourceId(id);
            return new DataShareAccountResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataShareConsumerInvitationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataShareConsumerInvitationResource.CreateResourceIdentifier" /> to create a <see cref="DataShareConsumerInvitationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataShareConsumerInvitationResource"/> object. </returns>
        public virtual DataShareConsumerInvitationResource GetDataShareConsumerInvitationResource(ResourceIdentifier id)
        {
            DataShareConsumerInvitationResource.ValidateResourceId(id);
            return new DataShareConsumerInvitationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ShareDataSetResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ShareDataSetResource.CreateResourceIdentifier" /> to create a <see cref="ShareDataSetResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ShareDataSetResource"/> object. </returns>
        public virtual ShareDataSetResource GetShareDataSetResource(ResourceIdentifier id)
        {
            ShareDataSetResource.ValidateResourceId(id);
            return new ShareDataSetResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ShareDataSetMappingResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ShareDataSetMappingResource.CreateResourceIdentifier" /> to create a <see cref="ShareDataSetMappingResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ShareDataSetMappingResource"/> object. </returns>
        public virtual ShareDataSetMappingResource GetShareDataSetMappingResource(ResourceIdentifier id)
        {
            ShareDataSetMappingResource.ValidateResourceId(id);
            return new ShareDataSetMappingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataShareInvitationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataShareInvitationResource.CreateResourceIdentifier" /> to create a <see cref="DataShareInvitationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataShareInvitationResource"/> object. </returns>
        public virtual DataShareInvitationResource GetDataShareInvitationResource(ResourceIdentifier id)
        {
            DataShareInvitationResource.ValidateResourceId(id);
            return new DataShareInvitationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataShareResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataShareResource.CreateResourceIdentifier" /> to create a <see cref="DataShareResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataShareResource"/> object. </returns>
        public virtual DataShareResource GetDataShareResource(ResourceIdentifier id)
        {
            DataShareResource.ValidateResourceId(id);
            return new DataShareResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ProviderShareSubscriptionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ProviderShareSubscriptionResource.CreateResourceIdentifier" /> to create a <see cref="ProviderShareSubscriptionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ProviderShareSubscriptionResource"/> object. </returns>
        public virtual ProviderShareSubscriptionResource GetProviderShareSubscriptionResource(ResourceIdentifier id)
        {
            ProviderShareSubscriptionResource.ValidateResourceId(id);
            return new ProviderShareSubscriptionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ShareSubscriptionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ShareSubscriptionResource.CreateResourceIdentifier" /> to create a <see cref="ShareSubscriptionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ShareSubscriptionResource"/> object. </returns>
        public virtual ShareSubscriptionResource GetShareSubscriptionResource(ResourceIdentifier id)
        {
            ShareSubscriptionResource.ValidateResourceId(id);
            return new ShareSubscriptionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataShareSynchronizationSettingResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataShareSynchronizationSettingResource.CreateResourceIdentifier" /> to create a <see cref="DataShareSynchronizationSettingResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataShareSynchronizationSettingResource"/> object. </returns>
        public virtual DataShareSynchronizationSettingResource GetDataShareSynchronizationSettingResource(ResourceIdentifier id)
        {
            DataShareSynchronizationSettingResource.ValidateResourceId(id);
            return new DataShareSynchronizationSettingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataShareTriggerResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataShareTriggerResource.CreateResourceIdentifier" /> to create a <see cref="DataShareTriggerResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataShareTriggerResource"/> object. </returns>
        public virtual DataShareTriggerResource GetDataShareTriggerResource(ResourceIdentifier id)
        {
            DataShareTriggerResource.ValidateResourceId(id);
            return new DataShareTriggerResource(Client, id);
        }
    }
}
