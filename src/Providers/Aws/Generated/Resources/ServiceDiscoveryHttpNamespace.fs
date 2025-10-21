namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServiceDiscoveryHttpNamespaceState<'Name> = { assignments: ResizeArray<aws.ServiceDiscoveryHttpNamespace.ServiceDiscoveryHttpNamespaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_http_namespace">aws_service_discovery_http_namespace</a>.
    /// </summary>
    type ServiceDiscoveryHttpNamespaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServiceDiscoveryHttpNamespaceState<Missing> =
            ({ assignments = ResizeArray() } : ServiceDiscoveryHttpNamespaceState<Missing>)

        member _.Zero(()) : ServiceDiscoveryHttpNamespaceState<Missing> =
            ({ assignments = ResizeArray() } : ServiceDiscoveryHttpNamespaceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_http_namespace#name-1">ServiceDiscoveryHttpNamespace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServiceDiscoveryHttpNamespaceState<Missing>, value: string) : ServiceDiscoveryHttpNamespaceState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServiceDiscoveryHttpNamespaceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_http_namespace#description-1">ServiceDiscoveryHttpNamespace#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ServiceDiscoveryHttpNamespaceState<'Name>, value: string) : ServiceDiscoveryHttpNamespaceState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ServiceDiscoveryHttpNamespaceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_http_namespace#id-1">ServiceDiscoveryHttpNamespace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServiceDiscoveryHttpNamespaceState<'Name>, value: string) : ServiceDiscoveryHttpNamespaceState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServiceDiscoveryHttpNamespaceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_http_namespace#tags-1">ServiceDiscoveryHttpNamespace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ServiceDiscoveryHttpNamespaceState<'Name>, value: seq<string * string>) : ServiceDiscoveryHttpNamespaceState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ServiceDiscoveryHttpNamespaceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_http_namespace#tags_all-1">ServiceDiscoveryHttpNamespace#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ServiceDiscoveryHttpNamespaceState<'Name>, value: seq<string * string>) : ServiceDiscoveryHttpNamespaceState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ServiceDiscoveryHttpNamespaceState<'Name>

        member _.Run(state: ServiceDiscoveryHttpNamespaceState<Present>) : aws.ServiceDiscoveryHttpNamespace.ServiceDiscoveryHttpNamespace =
            let config = aws.ServiceDiscoveryHttpNamespace.ServiceDiscoveryHttpNamespaceConfig()
            for setter in state.assignments do
                setter config
            aws.ServiceDiscoveryHttpNamespace.ServiceDiscoveryHttpNamespace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.serviceDiscoveryHttpNamespace: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: ServiceDiscoveryHttpNamespaceState<_>) : aws.ServiceDiscoveryHttpNamespace.ServiceDiscoveryHttpNamespace =
            Unchecked.defaultof<aws.ServiceDiscoveryHttpNamespace.ServiceDiscoveryHttpNamespace>
