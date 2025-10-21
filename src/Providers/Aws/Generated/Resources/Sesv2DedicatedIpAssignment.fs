namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Sesv2DedicatedIpAssignmentState<'DestinationPoolName, 'Ip> = { assignments: ResizeArray<aws.Sesv2DedicatedIpAssignment.Sesv2DedicatedIpAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_dedicated_ip_assignment">aws_sesv2_dedicated_ip_assignment</a>.
    /// </summary>
    type Sesv2DedicatedIpAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : Sesv2DedicatedIpAssignmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Sesv2DedicatedIpAssignmentState<Missing, Missing>)

        member _.Zero(()) : Sesv2DedicatedIpAssignmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Sesv2DedicatedIpAssignmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_dedicated_ip_assignment#destination_pool_name-1">Sesv2DedicatedIpAssignment#destination_pool_name</a>.
        /// </summary>
        [<CustomOperation "destination_pool_name">]
        member _.DestinationPoolName(state: Sesv2DedicatedIpAssignmentState<Missing, 'Ip>, value: string) : Sesv2DedicatedIpAssignmentState<Present, 'Ip> =
            state.assignments.Add(fun config -> config.DestinationPoolName <- value)
            ({ assignments = state.assignments } : Sesv2DedicatedIpAssignmentState<Present, 'Ip>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_dedicated_ip_assignment#ip-1">Sesv2DedicatedIpAssignment#ip</a>.
        /// </summary>
        [<CustomOperation "ip">]
        member _.Ip(state: Sesv2DedicatedIpAssignmentState<'DestinationPoolName, Missing>, value: string) : Sesv2DedicatedIpAssignmentState<'DestinationPoolName, Present> =
            state.assignments.Add(fun config -> config.Ip <- value)
            ({ assignments = state.assignments } : Sesv2DedicatedIpAssignmentState<'DestinationPoolName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_dedicated_ip_assignment#id-1">Sesv2DedicatedIpAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Sesv2DedicatedIpAssignmentState<'DestinationPoolName, 'Ip>, value: string) : Sesv2DedicatedIpAssignmentState<'DestinationPoolName, 'Ip> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Sesv2DedicatedIpAssignmentState<'DestinationPoolName, 'Ip>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_dedicated_ip_assignment#timeouts-1">Sesv2DedicatedIpAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Sesv2DedicatedIpAssignmentState<'DestinationPoolName, 'Ip>, value: aws.Sesv2DedicatedIpAssignment.Sesv2DedicatedIpAssignmentTimeouts) : Sesv2DedicatedIpAssignmentState<'DestinationPoolName, 'Ip> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Sesv2DedicatedIpAssignmentState<'DestinationPoolName, 'Ip>

        member _.Run(state: Sesv2DedicatedIpAssignmentState<Present, Present>) : aws.Sesv2DedicatedIpAssignment.Sesv2DedicatedIpAssignment =
            let config = aws.Sesv2DedicatedIpAssignment.Sesv2DedicatedIpAssignmentConfig()
            for setter in state.assignments do
                setter config
            aws.Sesv2DedicatedIpAssignment.Sesv2DedicatedIpAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesv2DedicatedIpAssignment: missing required arguments. Must call: destination_pool_name, ip.", 9999, IsError = true)>]
        member _.Run(_: Sesv2DedicatedIpAssignmentState<_, _>) : aws.Sesv2DedicatedIpAssignment.Sesv2DedicatedIpAssignment =
            Unchecked.defaultof<aws.Sesv2DedicatedIpAssignment.Sesv2DedicatedIpAssignment>
