namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServiceDiscoveryPrivateDnsNamespaceState<'Name, 'Vpc> = { assignments: ResizeArray<aws.ServiceDiscoveryPrivateDnsNamespace.ServiceDiscoveryPrivateDnsNamespaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_private_dns_namespace">aws_service_discovery_private_dns_namespace</a>.
    /// </summary>
    type ServiceDiscoveryPrivateDnsNamespaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServiceDiscoveryPrivateDnsNamespaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServiceDiscoveryPrivateDnsNamespaceState<Missing, Missing>)

        member _.Zero(()) : ServiceDiscoveryPrivateDnsNamespaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServiceDiscoveryPrivateDnsNamespaceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_private_dns_namespace#name-1">ServiceDiscoveryPrivateDnsNamespace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServiceDiscoveryPrivateDnsNamespaceState<Missing, 'Vpc>, value: string) : ServiceDiscoveryPrivateDnsNamespaceState<Present, 'Vpc> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServiceDiscoveryPrivateDnsNamespaceState<Present, 'Vpc>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_private_dns_namespace#vpc-1">ServiceDiscoveryPrivateDnsNamespace#vpc</a>.
        /// </summary>
        [<CustomOperation "vpc">]
        member _.Vpc(state: ServiceDiscoveryPrivateDnsNamespaceState<'Name, Missing>, value: string) : ServiceDiscoveryPrivateDnsNamespaceState<'Name, Present> =
            state.assignments.Add(fun config -> config.Vpc <- value)
            ({ assignments = state.assignments } : ServiceDiscoveryPrivateDnsNamespaceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_private_dns_namespace#description-1">ServiceDiscoveryPrivateDnsNamespace#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ServiceDiscoveryPrivateDnsNamespaceState<'Name, 'Vpc>, value: string) : ServiceDiscoveryPrivateDnsNamespaceState<'Name, 'Vpc> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ServiceDiscoveryPrivateDnsNamespaceState<'Name, 'Vpc>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_private_dns_namespace#id-1">ServiceDiscoveryPrivateDnsNamespace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServiceDiscoveryPrivateDnsNamespaceState<'Name, 'Vpc>, value: string) : ServiceDiscoveryPrivateDnsNamespaceState<'Name, 'Vpc> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServiceDiscoveryPrivateDnsNamespaceState<'Name, 'Vpc>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_private_dns_namespace#tags-1">ServiceDiscoveryPrivateDnsNamespace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ServiceDiscoveryPrivateDnsNamespaceState<'Name, 'Vpc>, value: seq<string * string>) : ServiceDiscoveryPrivateDnsNamespaceState<'Name, 'Vpc> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ServiceDiscoveryPrivateDnsNamespaceState<'Name, 'Vpc>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_private_dns_namespace#tags_all-1">ServiceDiscoveryPrivateDnsNamespace#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ServiceDiscoveryPrivateDnsNamespaceState<'Name, 'Vpc>, value: seq<string * string>) : ServiceDiscoveryPrivateDnsNamespaceState<'Name, 'Vpc> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ServiceDiscoveryPrivateDnsNamespaceState<'Name, 'Vpc>

        member _.Run(state: ServiceDiscoveryPrivateDnsNamespaceState<Present, Present>) : aws.ServiceDiscoveryPrivateDnsNamespace.ServiceDiscoveryPrivateDnsNamespace =
            let config = aws.ServiceDiscoveryPrivateDnsNamespace.ServiceDiscoveryPrivateDnsNamespaceConfig()
            for setter in state.assignments do
                setter config
            aws.ServiceDiscoveryPrivateDnsNamespace.ServiceDiscoveryPrivateDnsNamespace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.serviceDiscoveryPrivateDnsNamespace: missing required arguments. Must call: name, vpc.", 9999, IsError = true)>]
        member _.Run(_: ServiceDiscoveryPrivateDnsNamespaceState<_, _>) : aws.ServiceDiscoveryPrivateDnsNamespace.ServiceDiscoveryPrivateDnsNamespace =
            Unchecked.defaultof<aws.ServiceDiscoveryPrivateDnsNamespace.ServiceDiscoveryPrivateDnsNamespace>
