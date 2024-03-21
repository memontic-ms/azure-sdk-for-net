// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_SqlDatabaseAdvisorResource
    {
        // Get database advisor
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDatabaseAdvisor()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/DatabaseAdvisorGet.json
            // this example is just showing the usage of "DatabaseAdvisors_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseAdvisorResource created on azure
            // for more information of creating SqlDatabaseAdvisorResource, please refer to the document of SqlDatabaseAdvisorResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "workloadinsight-demos";
            string serverName = "misosisvr";
            string databaseName = "IndexAdvisor_test_3";
            string advisorName = "CreateIndex";
            ResourceIdentifier sqlDatabaseAdvisorResourceId = SqlDatabaseAdvisorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, advisorName);
            SqlDatabaseAdvisorResource sqlDatabaseAdvisor = client.GetSqlDatabaseAdvisorResource(sqlDatabaseAdvisorResourceId);

            // invoke the operation
            SqlDatabaseAdvisorResource result = await sqlDatabaseAdvisor.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlAdvisorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update database advisor
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateDatabaseAdvisor()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/DatabaseAdvisorUpdate.json
            // this example is just showing the usage of "DatabaseAdvisors_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseAdvisorResource created on azure
            // for more information of creating SqlDatabaseAdvisorResource, please refer to the document of SqlDatabaseAdvisorResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "workloadinsight-demos";
            string serverName = "misosisvr";
            string databaseName = "IndexAdvisor_test_3";
            string advisorName = "CreateIndex";
            ResourceIdentifier sqlDatabaseAdvisorResourceId = SqlDatabaseAdvisorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, advisorName);
            SqlDatabaseAdvisorResource sqlDatabaseAdvisor = client.GetSqlDatabaseAdvisorResource(sqlDatabaseAdvisorResourceId);

            // invoke the operation
            SqlAdvisorData data = new SqlAdvisorData()
            {
                AutoExecuteStatus = AutoExecuteStatus.Disabled,
            };
            SqlDatabaseAdvisorResource result = await sqlDatabaseAdvisor.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlAdvisorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
