namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServiceDiscoveryInstanceState<'Attributes, 'InstanceId, 'ServiceId> = { assignments: ResizeArray<aws.ServiceDiscoveryInstance.ServiceDiscoveryInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_instance">aws_service_discovery_instance</a>.
    /// </summary>
    type ServiceDiscoveryInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServiceDiscoveryInstanceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServiceDiscoveryInstanceState<Missing, Missing, Missing>)

        member _.Zero(()) : ServiceDiscoveryInstanceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServiceDiscoveryInstanceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_instance#attributes-1">ServiceDiscoveryInstance#attributes</a>.
        /// </summary>
        [<CustomOperation "attributes">]
        member _.Attributes(state: ServiceDiscoveryInstanceState<Missing, 'InstanceId, 'ServiceId>, value: seq<string * string>) : ServiceDiscoveryInstanceState<Present, 'InstanceId, 'ServiceId> =
            state.assignments.Add(fun config -> config.Attributes <- dict value)
            ({ assignments = state.assignments } : ServiceDiscoveryInstanceState<Present, 'InstanceId, 'ServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_instance#instance_id-1">ServiceDiscoveryInstance#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: ServiceDiscoveryInstanceState<'Attributes, Missing, 'ServiceId>, value: string) : ServiceDiscoveryInstanceState<'Attributes, Present, 'ServiceId> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : ServiceDiscoveryInstanceState<'Attributes, Present, 'ServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_instance#service_id-1">ServiceDiscoveryInstance#service_id</a>.
        /// </summary>
        [<CustomOperation "service_id">]
        member _.ServiceId(state: ServiceDiscoveryInstanceState<'Attributes, 'InstanceId, Missing>, value: string) : ServiceDiscoveryInstanceState<'Attributes, 'InstanceId, Present> =
            state.assignments.Add(fun config -> config.ServiceId <- value)
            ({ assignments = state.assignments } : ServiceDiscoveryInstanceState<'Attributes, 'InstanceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_instance#id-1">ServiceDiscoveryInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServiceDiscoveryInstanceState<'Attributes, 'InstanceId, 'ServiceId>, value: string) : ServiceDiscoveryInstanceState<'Attributes, 'InstanceId, 'ServiceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServiceDiscoveryInstanceState<'Attributes, 'InstanceId, 'ServiceId>

        member _.Run(state: ServiceDiscoveryInstanceState<Present, Present, Present>) : aws.ServiceDiscoveryInstance.ServiceDiscoveryInstance =
            let config = aws.ServiceDiscoveryInstance.ServiceDiscoveryInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.ServiceDiscoveryInstance.ServiceDiscoveryInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.serviceDiscoveryInstance: missing required arguments. Must call: attributes, instance_id, service_id.", 9999, IsError = true)>]
        member _.Run(_: ServiceDiscoveryInstanceState<_, _, _>) : aws.ServiceDiscoveryInstance.ServiceDiscoveryInstance =
            Unchecked.defaultof<aws.ServiceDiscoveryInstance.ServiceDiscoveryInstance>
