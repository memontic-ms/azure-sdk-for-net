// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="SecuritySubAssessmentResource"/> and their operations.
    /// Each <see cref="SecuritySubAssessmentResource"/> in the collection will belong to the same instance of <see cref="SecurityAssessmentResource"/>.
    /// To get a <see cref="SecuritySubAssessmentCollection"/> instance call the GetSecuritySubAssessments method from an instance of <see cref="SecurityAssessmentResource"/>.
    /// </summary>
    public partial class SecuritySubAssessmentCollection : ArmCollection, IEnumerable<SecuritySubAssessmentResource>, IAsyncEnumerable<SecuritySubAssessmentResource>
    {
        private readonly ClientDiagnostics _securitySubAssessmentSubAssessmentsClientDiagnostics;
        private readonly SubAssessmentsRestOperations _securitySubAssessmentSubAssessmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecuritySubAssessmentCollection"/> class for mocking. </summary>
        protected SecuritySubAssessmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecuritySubAssessmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecuritySubAssessmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securitySubAssessmentSubAssessmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", SecuritySubAssessmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecuritySubAssessmentResource.ResourceType, out string securitySubAssessmentSubAssessmentsApiVersion);
            _securitySubAssessmentSubAssessmentsRestClient = new SubAssessmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securitySubAssessmentSubAssessmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SecurityAssessmentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SecurityAssessmentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a security sub-assessment on your scanned resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/assessments/{assessmentName}/subAssessments/{subAssessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubAssessments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecuritySubAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subAssessmentName"> The Sub-Assessment Key - Unique key for the sub-assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subAssessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subAssessmentName"/> is null. </exception>
        public virtual async Task<Response<SecuritySubAssessmentResource>> GetAsync(string subAssessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subAssessmentName, nameof(subAssessmentName));

            using var scope = _securitySubAssessmentSubAssessmentsClientDiagnostics.CreateScope("SecuritySubAssessmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _securitySubAssessmentSubAssessmentsRestClient.GetAsync(Id.Parent, Id.Name, subAssessmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecuritySubAssessmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a security sub-assessment on your scanned resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/assessments/{assessmentName}/subAssessments/{subAssessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubAssessments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecuritySubAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subAssessmentName"> The Sub-Assessment Key - Unique key for the sub-assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subAssessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subAssessmentName"/> is null. </exception>
        public virtual Response<SecuritySubAssessmentResource> Get(string subAssessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subAssessmentName, nameof(subAssessmentName));

            using var scope = _securitySubAssessmentSubAssessmentsClientDiagnostics.CreateScope("SecuritySubAssessmentCollection.Get");
            scope.Start();
            try
            {
                var response = _securitySubAssessmentSubAssessmentsRestClient.Get(Id.Parent, Id.Name, subAssessmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecuritySubAssessmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get security sub-assessments on all your scanned resources inside a scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/assessments/{assessmentName}/subAssessments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubAssessments_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecuritySubAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecuritySubAssessmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecuritySubAssessmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securitySubAssessmentSubAssessmentsRestClient.CreateListRequest(Id.Parent, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securitySubAssessmentSubAssessmentsRestClient.CreateListNextPageRequest(nextLink, Id.Parent, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SecuritySubAssessmentResource(Client, SecuritySubAssessmentData.DeserializeSecuritySubAssessmentData(e)), _securitySubAssessmentSubAssessmentsClientDiagnostics, Pipeline, "SecuritySubAssessmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get security sub-assessments on all your scanned resources inside a scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/assessments/{assessmentName}/subAssessments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubAssessments_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecuritySubAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecuritySubAssessmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecuritySubAssessmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securitySubAssessmentSubAssessmentsRestClient.CreateListRequest(Id.Parent, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securitySubAssessmentSubAssessmentsRestClient.CreateListNextPageRequest(nextLink, Id.Parent, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SecuritySubAssessmentResource(Client, SecuritySubAssessmentData.DeserializeSecuritySubAssessmentData(e)), _securitySubAssessmentSubAssessmentsClientDiagnostics, Pipeline, "SecuritySubAssessmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/assessments/{assessmentName}/subAssessments/{subAssessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubAssessments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecuritySubAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subAssessmentName"> The Sub-Assessment Key - Unique key for the sub-assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subAssessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subAssessmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string subAssessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subAssessmentName, nameof(subAssessmentName));

            using var scope = _securitySubAssessmentSubAssessmentsClientDiagnostics.CreateScope("SecuritySubAssessmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securitySubAssessmentSubAssessmentsRestClient.GetAsync(Id.Parent, Id.Name, subAssessmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/assessments/{assessmentName}/subAssessments/{subAssessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubAssessments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecuritySubAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subAssessmentName"> The Sub-Assessment Key - Unique key for the sub-assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subAssessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subAssessmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string subAssessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subAssessmentName, nameof(subAssessmentName));

            using var scope = _securitySubAssessmentSubAssessmentsClientDiagnostics.CreateScope("SecuritySubAssessmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _securitySubAssessmentSubAssessmentsRestClient.Get(Id.Parent, Id.Name, subAssessmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/assessments/{assessmentName}/subAssessments/{subAssessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubAssessments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecuritySubAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subAssessmentName"> The Sub-Assessment Key - Unique key for the sub-assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subAssessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subAssessmentName"/> is null. </exception>
        public virtual async Task<NullableResponse<SecuritySubAssessmentResource>> GetIfExistsAsync(string subAssessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subAssessmentName, nameof(subAssessmentName));

            using var scope = _securitySubAssessmentSubAssessmentsClientDiagnostics.CreateScope("SecuritySubAssessmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _securitySubAssessmentSubAssessmentsRestClient.GetAsync(Id.Parent, Id.Name, subAssessmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SecuritySubAssessmentResource>(response.GetRawResponse());
                return Response.FromValue(new SecuritySubAssessmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Security/assessments/{assessmentName}/subAssessments/{subAssessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubAssessments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecuritySubAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subAssessmentName"> The Sub-Assessment Key - Unique key for the sub-assessment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subAssessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subAssessmentName"/> is null. </exception>
        public virtual NullableResponse<SecuritySubAssessmentResource> GetIfExists(string subAssessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subAssessmentName, nameof(subAssessmentName));

            using var scope = _securitySubAssessmentSubAssessmentsClientDiagnostics.CreateScope("SecuritySubAssessmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _securitySubAssessmentSubAssessmentsRestClient.Get(Id.Parent, Id.Name, subAssessmentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SecuritySubAssessmentResource>(response.GetRawResponse());
                return Response.FromValue(new SecuritySubAssessmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecuritySubAssessmentResource> IEnumerable<SecuritySubAssessmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecuritySubAssessmentResource> IAsyncEnumerable<SecuritySubAssessmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
