namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServiceDiscoveryServiceState<'Name> = { assignments: ResizeArray<aws.ServiceDiscoveryService.ServiceDiscoveryServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service">aws_service_discovery_service</a>.
    /// </summary>
    type ServiceDiscoveryServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServiceDiscoveryServiceState<Missing> =
            ({ assignments = ResizeArray() } : ServiceDiscoveryServiceState<Missing>)

        member _.Zero(()) : ServiceDiscoveryServiceState<Missing> =
            ({ assignments = ResizeArray() } : ServiceDiscoveryServiceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#name-1">ServiceDiscoveryService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServiceDiscoveryServiceState<Missing>, value: string) : ServiceDiscoveryServiceState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServiceDiscoveryServiceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#description-1">ServiceDiscoveryService#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ServiceDiscoveryServiceState<'Name>, value: string) : ServiceDiscoveryServiceState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ServiceDiscoveryServiceState<'Name>

        /// <summary>
        /// dns_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#dns_config-1">ServiceDiscoveryService#dns_config</a>
        /// </summary>
        [<CustomOperation "dns_config">]
        member _.DnsConfig(state: ServiceDiscoveryServiceState<'Name>, value: aws.ServiceDiscoveryService.ServiceDiscoveryServiceDnsConfig) : ServiceDiscoveryServiceState<'Name> =
            state.assignments.Add(fun config -> config.DnsConfig <- value)
            state : ServiceDiscoveryServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#force_destroy-1">ServiceDiscoveryService#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: ServiceDiscoveryServiceState<'Name>, value: bool) : ServiceDiscoveryServiceState<'Name> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : ServiceDiscoveryServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#force_destroy-1">ServiceDiscoveryService#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: ServiceDiscoveryServiceState<'Name>, value: HashiCorp.Cdktf.IResolvable) : ServiceDiscoveryServiceState<'Name> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : ServiceDiscoveryServiceState<'Name>

        /// <summary>
        /// health_check_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#health_check_config-1">ServiceDiscoveryService#health_check_config</a>
        /// </summary>
        [<CustomOperation "health_check_config">]
        member _.HealthCheckConfig(state: ServiceDiscoveryServiceState<'Name>, value: aws.ServiceDiscoveryService.ServiceDiscoveryServiceHealthCheckConfig) : ServiceDiscoveryServiceState<'Name> =
            state.assignments.Add(fun config -> config.HealthCheckConfig <- value)
            state : ServiceDiscoveryServiceState<'Name>

        /// <summary>
        /// health_check_custom_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#health_check_custom_config-1">ServiceDiscoveryService#health_check_custom_config</a>
        /// </summary>
        [<CustomOperation "health_check_custom_config">]
        member _.HealthCheckCustomConfig(state: ServiceDiscoveryServiceState<'Name>, value: aws.ServiceDiscoveryService.ServiceDiscoveryServiceHealthCheckCustomConfig) : ServiceDiscoveryServiceState<'Name> =
            state.assignments.Add(fun config -> config.HealthCheckCustomConfig <- value)
            state : ServiceDiscoveryServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#id-1">ServiceDiscoveryService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServiceDiscoveryServiceState<'Name>, value: string) : ServiceDiscoveryServiceState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServiceDiscoveryServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#namespace_id-1">ServiceDiscoveryService#namespace_id</a>.
        /// </summary>
        [<CustomOperation "namespace_id">]
        member _.NamespaceId(state: ServiceDiscoveryServiceState<'Name>, value: string) : ServiceDiscoveryServiceState<'Name> =
            state.assignments.Add(fun config -> config.NamespaceId <- value)
            state : ServiceDiscoveryServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#tags-1">ServiceDiscoveryService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ServiceDiscoveryServiceState<'Name>, value: seq<string * string>) : ServiceDiscoveryServiceState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ServiceDiscoveryServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#tags_all-1">ServiceDiscoveryService#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ServiceDiscoveryServiceState<'Name>, value: seq<string * string>) : ServiceDiscoveryServiceState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ServiceDiscoveryServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#type-1">ServiceDiscoveryService#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: ServiceDiscoveryServiceState<'Name>, value: string) : ServiceDiscoveryServiceState<'Name> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : ServiceDiscoveryServiceState<'Name>

        member _.Run(state: ServiceDiscoveryServiceState<Present>) : aws.ServiceDiscoveryService.ServiceDiscoveryService =
            let config = aws.ServiceDiscoveryService.ServiceDiscoveryServiceConfig()
            for setter in state.assignments do
                setter config
            aws.ServiceDiscoveryService.ServiceDiscoveryService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.serviceDiscoveryService: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: ServiceDiscoveryServiceState<_>) : aws.ServiceDiscoveryService.ServiceDiscoveryService =
            Unchecked.defaultof<aws.ServiceDiscoveryService.ServiceDiscoveryService>
