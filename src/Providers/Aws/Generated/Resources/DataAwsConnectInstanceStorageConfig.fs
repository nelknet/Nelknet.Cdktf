namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsConnectInstanceStorageConfigState<'AssociationId, 'InstanceId, 'ResourceType> = { assignments: ResizeArray<aws.DataAwsConnectInstanceStorageConfig.DataAwsConnectInstanceStorageConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_instance_storage_config">aws_connect_instance_storage_config</a>.
    /// </summary>
    type DataAwsConnectInstanceStorageConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsConnectInstanceStorageConfigState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectInstanceStorageConfigState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAwsConnectInstanceStorageConfigState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectInstanceStorageConfigState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_instance_storage_config#association_id-1">DataAwsConnectInstanceStorageConfig#association_id</a>.
        /// </summary>
        [<CustomOperation "association_id">]
        member _.AssociationId(state: DataAwsConnectInstanceStorageConfigState<Missing, 'InstanceId, 'ResourceType>, value: string) : DataAwsConnectInstanceStorageConfigState<Present, 'InstanceId, 'ResourceType> =
            state.assignments.Add(fun config -> config.AssociationId <- value)
            ({ assignments = state.assignments } : DataAwsConnectInstanceStorageConfigState<Present, 'InstanceId, 'ResourceType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_instance_storage_config#instance_id-1">DataAwsConnectInstanceStorageConfig#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: DataAwsConnectInstanceStorageConfigState<'AssociationId, Missing, 'ResourceType>, value: string) : DataAwsConnectInstanceStorageConfigState<'AssociationId, Present, 'ResourceType> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : DataAwsConnectInstanceStorageConfigState<'AssociationId, Present, 'ResourceType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_instance_storage_config#resource_type-1">DataAwsConnectInstanceStorageConfig#resource_type</a>.
        /// </summary>
        [<CustomOperation "resource_type">]
        member _.ResourceType(state: DataAwsConnectInstanceStorageConfigState<'AssociationId, 'InstanceId, Missing>, value: string) : DataAwsConnectInstanceStorageConfigState<'AssociationId, 'InstanceId, Present> =
            state.assignments.Add(fun config -> config.ResourceType <- value)
            ({ assignments = state.assignments } : DataAwsConnectInstanceStorageConfigState<'AssociationId, 'InstanceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_instance_storage_config#id-1">DataAwsConnectInstanceStorageConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsConnectInstanceStorageConfigState<'AssociationId, 'InstanceId, 'ResourceType>, value: string) : DataAwsConnectInstanceStorageConfigState<'AssociationId, 'InstanceId, 'ResourceType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsConnectInstanceStorageConfigState<'AssociationId, 'InstanceId, 'ResourceType>

        member _.Run(state: DataAwsConnectInstanceStorageConfigState<Present, Present, Present>) : aws.DataAwsConnectInstanceStorageConfig.DataAwsConnectInstanceStorageConfig =
            let config = aws.DataAwsConnectInstanceStorageConfig.DataAwsConnectInstanceStorageConfigConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsConnectInstanceStorageConfig.DataAwsConnectInstanceStorageConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsConnectInstanceStorageConfig: missing required arguments. Must call: association_id, instance_id, resource_type.", 9999, IsError = true)>]
        member _.Run(_: DataAwsConnectInstanceStorageConfigState<_, _, _>) : aws.DataAwsConnectInstanceStorageConfig.DataAwsConnectInstanceStorageConfig =
            Unchecked.defaultof<aws.DataAwsConnectInstanceStorageConfig.DataAwsConnectInstanceStorageConfig>
