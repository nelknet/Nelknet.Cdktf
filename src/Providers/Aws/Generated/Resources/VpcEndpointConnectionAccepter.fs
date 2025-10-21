namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcEndpointConnectionAccepterState<'VpcEndpointId, 'VpcEndpointServiceId> = { assignments: ResizeArray<aws.VpcEndpointConnectionAccepter.VpcEndpointConnectionAccepterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_connection_accepter">aws_vpc_endpoint_connection_accepter</a>.
    /// </summary>
    type VpcEndpointConnectionAccepterBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcEndpointConnectionAccepterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointConnectionAccepterState<Missing, Missing>)

        member _.Zero(()) : VpcEndpointConnectionAccepterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointConnectionAccepterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_connection_accepter#vpc_endpoint_id-1">VpcEndpointConnectionAccepter#vpc_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "vpc_endpoint_id">]
        member _.VpcEndpointId(state: VpcEndpointConnectionAccepterState<Missing, 'VpcEndpointServiceId>, value: string) : VpcEndpointConnectionAccepterState<Present, 'VpcEndpointServiceId> =
            state.assignments.Add(fun config -> config.VpcEndpointId <- value)
            ({ assignments = state.assignments } : VpcEndpointConnectionAccepterState<Present, 'VpcEndpointServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_connection_accepter#vpc_endpoint_service_id-1">VpcEndpointConnectionAccepter#vpc_endpoint_service_id</a>.
        /// </summary>
        [<CustomOperation "vpc_endpoint_service_id">]
        member _.VpcEndpointServiceId(state: VpcEndpointConnectionAccepterState<'VpcEndpointId, Missing>, value: string) : VpcEndpointConnectionAccepterState<'VpcEndpointId, Present> =
            state.assignments.Add(fun config -> config.VpcEndpointServiceId <- value)
            ({ assignments = state.assignments } : VpcEndpointConnectionAccepterState<'VpcEndpointId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_connection_accepter#id-1">VpcEndpointConnectionAccepter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcEndpointConnectionAccepterState<'VpcEndpointId, 'VpcEndpointServiceId>, value: string) : VpcEndpointConnectionAccepterState<'VpcEndpointId, 'VpcEndpointServiceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcEndpointConnectionAccepterState<'VpcEndpointId, 'VpcEndpointServiceId>

        member _.Run(state: VpcEndpointConnectionAccepterState<Present, Present>) : aws.VpcEndpointConnectionAccepter.VpcEndpointConnectionAccepter =
            let config = aws.VpcEndpointConnectionAccepter.VpcEndpointConnectionAccepterConfig()
            for setter in state.assignments do
                setter config
            aws.VpcEndpointConnectionAccepter.VpcEndpointConnectionAccepter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcEndpointConnectionAccepter: missing required arguments. Must call: vpc_endpoint_id, vpc_endpoint_service_id.", 9999, IsError = true)>]
        member _.Run(_: VpcEndpointConnectionAccepterState<_, _>) : aws.VpcEndpointConnectionAccepter.VpcEndpointConnectionAccepter =
            Unchecked.defaultof<aws.VpcEndpointConnectionAccepter.VpcEndpointConnectionAccepter>
