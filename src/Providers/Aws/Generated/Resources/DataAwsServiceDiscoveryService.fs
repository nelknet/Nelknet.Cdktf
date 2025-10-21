namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsServiceDiscoveryServiceState<'Name, 'NamespaceId> = { assignments: ResizeArray<aws.DataAwsServiceDiscoveryService.DataAwsServiceDiscoveryServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service_discovery_service">aws_service_discovery_service</a>.
    /// </summary>
    type DataAwsServiceDiscoveryServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsServiceDiscoveryServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsServiceDiscoveryServiceState<Missing, Missing>)

        member _.Zero(()) : DataAwsServiceDiscoveryServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsServiceDiscoveryServiceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service_discovery_service#name-1">DataAwsServiceDiscoveryService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsServiceDiscoveryServiceState<Missing, 'NamespaceId>, value: string) : DataAwsServiceDiscoveryServiceState<Present, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsServiceDiscoveryServiceState<Present, 'NamespaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service_discovery_service#namespace_id-1">DataAwsServiceDiscoveryService#namespace_id</a>.
        /// </summary>
        [<CustomOperation "namespace_id">]
        member _.NamespaceId(state: DataAwsServiceDiscoveryServiceState<'Name, Missing>, value: string) : DataAwsServiceDiscoveryServiceState<'Name, Present> =
            state.assignments.Add(fun config -> config.NamespaceId <- value)
            ({ assignments = state.assignments } : DataAwsServiceDiscoveryServiceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service_discovery_service#id-1">DataAwsServiceDiscoveryService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsServiceDiscoveryServiceState<'Name, 'NamespaceId>, value: string) : DataAwsServiceDiscoveryServiceState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsServiceDiscoveryServiceState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service_discovery_service#tags-1">DataAwsServiceDiscoveryService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsServiceDiscoveryServiceState<'Name, 'NamespaceId>, value: seq<string * string>) : DataAwsServiceDiscoveryServiceState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsServiceDiscoveryServiceState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service_discovery_service#tags_all-1">DataAwsServiceDiscoveryService#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DataAwsServiceDiscoveryServiceState<'Name, 'NamespaceId>, value: seq<string * string>) : DataAwsServiceDiscoveryServiceState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DataAwsServiceDiscoveryServiceState<'Name, 'NamespaceId>

        member _.Run(state: DataAwsServiceDiscoveryServiceState<Present, Present>) : aws.DataAwsServiceDiscoveryService.DataAwsServiceDiscoveryService =
            let config = aws.DataAwsServiceDiscoveryService.DataAwsServiceDiscoveryServiceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsServiceDiscoveryService.DataAwsServiceDiscoveryService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsServiceDiscoveryService: missing required arguments. Must call: name, namespace_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsServiceDiscoveryServiceState<_, _>) : aws.DataAwsServiceDiscoveryService.DataAwsServiceDiscoveryService =
            Unchecked.defaultof<aws.DataAwsServiceDiscoveryService.DataAwsServiceDiscoveryService>
