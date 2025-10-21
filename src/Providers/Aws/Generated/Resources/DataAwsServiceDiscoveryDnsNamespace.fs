namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsServiceDiscoveryDnsNamespaceState<'Name, 'Type> = { assignments: ResizeArray<aws.DataAwsServiceDiscoveryDnsNamespace.DataAwsServiceDiscoveryDnsNamespaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service_discovery_dns_namespace">aws_service_discovery_dns_namespace</a>.
    /// </summary>
    type DataAwsServiceDiscoveryDnsNamespaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsServiceDiscoveryDnsNamespaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsServiceDiscoveryDnsNamespaceState<Missing, Missing>)

        member _.Zero(()) : DataAwsServiceDiscoveryDnsNamespaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsServiceDiscoveryDnsNamespaceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service_discovery_dns_namespace#name-1">DataAwsServiceDiscoveryDnsNamespace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsServiceDiscoveryDnsNamespaceState<Missing, 'Type>, value: string) : DataAwsServiceDiscoveryDnsNamespaceState<Present, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsServiceDiscoveryDnsNamespaceState<Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service_discovery_dns_namespace#type-1">DataAwsServiceDiscoveryDnsNamespace#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DataAwsServiceDiscoveryDnsNamespaceState<'Name, Missing>, value: string) : DataAwsServiceDiscoveryDnsNamespaceState<'Name, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : DataAwsServiceDiscoveryDnsNamespaceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service_discovery_dns_namespace#id-1">DataAwsServiceDiscoveryDnsNamespace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsServiceDiscoveryDnsNamespaceState<'Name, 'Type>, value: string) : DataAwsServiceDiscoveryDnsNamespaceState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsServiceDiscoveryDnsNamespaceState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service_discovery_dns_namespace#tags-1">DataAwsServiceDiscoveryDnsNamespace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsServiceDiscoveryDnsNamespaceState<'Name, 'Type>, value: seq<string * string>) : DataAwsServiceDiscoveryDnsNamespaceState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsServiceDiscoveryDnsNamespaceState<'Name, 'Type>

        member _.Run(state: DataAwsServiceDiscoveryDnsNamespaceState<Present, Present>) : aws.DataAwsServiceDiscoveryDnsNamespace.DataAwsServiceDiscoveryDnsNamespace =
            let config = aws.DataAwsServiceDiscoveryDnsNamespace.DataAwsServiceDiscoveryDnsNamespaceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsServiceDiscoveryDnsNamespace.DataAwsServiceDiscoveryDnsNamespace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsServiceDiscoveryDnsNamespace: missing required arguments. Must call: name, type.", 9999, IsError = true)>]
        member _.Run(_: DataAwsServiceDiscoveryDnsNamespaceState<_, _>) : aws.DataAwsServiceDiscoveryDnsNamespace.DataAwsServiceDiscoveryDnsNamespace =
            Unchecked.defaultof<aws.DataAwsServiceDiscoveryDnsNamespace.DataAwsServiceDiscoveryDnsNamespace>
