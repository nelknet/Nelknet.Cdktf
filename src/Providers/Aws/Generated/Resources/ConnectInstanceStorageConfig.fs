namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConnectInstanceStorageConfigState<'InstanceId, 'ResourceType, 'StorageConfig> = { assignments: ResizeArray<aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config">aws_connect_instance_storage_config</a>.
    /// </summary>
    type ConnectInstanceStorageConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConnectInstanceStorageConfigState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectInstanceStorageConfigState<Missing, Missing, Missing>)

        member _.Zero(()) : ConnectInstanceStorageConfigState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectInstanceStorageConfigState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#instance_id-1">ConnectInstanceStorageConfig#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: ConnectInstanceStorageConfigState<Missing, 'ResourceType, 'StorageConfig>, value: string) : ConnectInstanceStorageConfigState<Present, 'ResourceType, 'StorageConfig> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : ConnectInstanceStorageConfigState<Present, 'ResourceType, 'StorageConfig>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#resource_type-1">ConnectInstanceStorageConfig#resource_type</a>.
        /// </summary>
        [<CustomOperation "resource_type">]
        member _.ResourceType(state: ConnectInstanceStorageConfigState<'InstanceId, Missing, 'StorageConfig>, value: string) : ConnectInstanceStorageConfigState<'InstanceId, Present, 'StorageConfig> =
            state.assignments.Add(fun config -> config.ResourceType <- value)
            ({ assignments = state.assignments } : ConnectInstanceStorageConfigState<'InstanceId, Present, 'StorageConfig>)

        /// <summary>
        /// storage_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#storage_config-1">ConnectInstanceStorageConfig#storage_config</a>
        /// </summary>
        [<CustomOperation "storage_config">]
        member _.StorageConfig(state: ConnectInstanceStorageConfigState<'InstanceId, 'ResourceType, Missing>, value: aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfig) : ConnectInstanceStorageConfigState<'InstanceId, 'ResourceType, Present> =
            state.assignments.Add(fun config -> config.StorageConfig <- value)
            ({ assignments = state.assignments } : ConnectInstanceStorageConfigState<'InstanceId, 'ResourceType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#id-1">ConnectInstanceStorageConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConnectInstanceStorageConfigState<'InstanceId, 'ResourceType, 'StorageConfig>, value: string) : ConnectInstanceStorageConfigState<'InstanceId, 'ResourceType, 'StorageConfig> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConnectInstanceStorageConfigState<'InstanceId, 'ResourceType, 'StorageConfig>

        member _.Run(state: ConnectInstanceStorageConfigState<Present, Present, Present>) : aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfig =
            let config = aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfigConfig()
            for setter in state.assignments do
                setter config
            aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.connectInstanceStorageConfig: missing required arguments. Must call: instance_id, resource_type, storage_config.", 9999, IsError = true)>]
        member _.Run(_: ConnectInstanceStorageConfigState<_, _, _>) : aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfig =
            Unchecked.defaultof<aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfig>
