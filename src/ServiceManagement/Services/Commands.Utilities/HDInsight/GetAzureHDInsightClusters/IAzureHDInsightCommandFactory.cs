﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------
namespace Microsoft.WindowsAzure.Management.HDInsight.Cmdlet.GetAzureHDInsightClusters
{
    using Commands.CommandInterfaces;

    internal interface IAzureHDInsightCommandFactory
    {
        IAddAzureHDInsightConfigValuesCommand CreateAddConfig();

        IAddAzureHDInsightMetastoreCommand CreateAddMetastore();

        IAddAzureHDInsightStorageCommand CreateAddStorage();

        INewAzureHDInsightClusterCommand CreateCreate();

        IRemoveAzureHDInsightClusterCommand CreateDelete();

        IGetAzureHDInsightClusterCommand CreateGet();

        IGetAzureHDInsightJobOutputCommand CreateGetJobOutput();

        IGetAzureHDInsightJobCommand CreateGetJobs();

        IGetAzureHDInsightPropertiesCommand CreateGetProperties();

        IInvokeHiveCommand CreateInvokeHive();

        IManageAzureHDInsightHttpAccessCommand CreateManageHttpAccess();

        INewAzureHDInsightClusterConfigCommand CreateNewConfig();

        INewAzureHDInsightHiveJobDefinitionCommand CreateNewHiveDefinition();

        INewAzureHDInsightMapReduceJobDefinitionCommand CreateNewMapReduceDefinition();

        INewAzureHDInsightPigJobDefinitionCommand CreateNewPigJobDefinition();

        INewAzureHDInsightSqoopJobDefinitionCommand CreateNewSqoopDefinition();

        INewAzureHDInsightStreamingJobDefinitionCommand CreateNewStreamingMapReduceDefinition();

        ISetAzureHDInsightDefaultStorageCommand CreateSetDefaultStorage();

        IStartAzureHDInsightJobCommand CreateStartJob();

        IStopAzureHDInsightJobCommand CreateStopJob();

        IUseAzureHDInsightClusterCommand CreateUseCluster();

        IWaitAzureHDInsightJobCommand CreateWaitJobs();
    }
}
