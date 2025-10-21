namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsServiceDiscoveryHttpNamespaceState<'Name> = { assignments: ResizeArray<aws.DataAwsServiceDiscoveryHttpNamespace.DataAwsServiceDiscoveryHttpNamespaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service_discovery_http_namespace">aws_service_discovery_http_namespace</a>.
    /// </summary>
    type DataAwsServiceDiscoveryHttpNamespaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsServiceDiscoveryHttpNamespaceState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServiceDiscoveryHttpNamespaceState<Missing>)

        member _.Zero(()) : DataAwsServiceDiscoveryHttpNamespaceState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServiceDiscoveryHttpNamespaceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service_discovery_http_namespace#name-1">DataAwsServiceDiscoveryHttpNamespace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsServiceDiscoveryHttpNamespaceState<Missing>, value: string) : DataAwsServiceDiscoveryHttpNamespaceState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsServiceDiscoveryHttpNamespaceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service_discovery_http_namespace#id-1">DataAwsServiceDiscoveryHttpNamespace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsServiceDiscoveryHttpNamespaceState<'Name>, value: string) : DataAwsServiceDiscoveryHttpNamespaceState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsServiceDiscoveryHttpNamespaceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service_discovery_http_namespace#tags-1">DataAwsServiceDiscoveryHttpNamespace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsServiceDiscoveryHttpNamespaceState<'Name>, value: seq<string * string>) : DataAwsServiceDiscoveryHttpNamespaceState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsServiceDiscoveryHttpNamespaceState<'Name>

        member _.Run(state: DataAwsServiceDiscoveryHttpNamespaceState<Present>) : aws.DataAwsServiceDiscoveryHttpNamespace.DataAwsServiceDiscoveryHttpNamespace =
            let config = aws.DataAwsServiceDiscoveryHttpNamespace.DataAwsServiceDiscoveryHttpNamespaceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsServiceDiscoveryHttpNamespace.DataAwsServiceDiscoveryHttpNamespace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsServiceDiscoveryHttpNamespace: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsServiceDiscoveryHttpNamespaceState<_>) : aws.DataAwsServiceDiscoveryHttpNamespace.DataAwsServiceDiscoveryHttpNamespace =
            Unchecked.defaultof<aws.DataAwsServiceDiscoveryHttpNamespace.DataAwsServiceDiscoveryHttpNamespace>
