namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkInterfacePermissionState<'AwsAccountId, 'NetworkInterfaceId, 'Permission> = { assignments: ResizeArray<aws.NetworkInterfacePermission.NetworkInterfacePermissionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface_permission">aws_network_interface_permission</a>.
    /// </summary>
    type NetworkInterfacePermissionBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkInterfacePermissionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfacePermissionState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkInterfacePermissionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfacePermissionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface_permission#aws_account_id-1">NetworkInterfacePermission#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: NetworkInterfacePermissionState<Missing, 'NetworkInterfaceId, 'Permission>, value: string) : NetworkInterfacePermissionState<Present, 'NetworkInterfaceId, 'Permission> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            ({ assignments = state.assignments } : NetworkInterfacePermissionState<Present, 'NetworkInterfaceId, 'Permission>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface_permission#network_interface_id-1">NetworkInterfacePermission#network_interface_id</a>.
        /// </summary>
        [<CustomOperation "network_interface_id">]
        member _.NetworkInterfaceId(state: NetworkInterfacePermissionState<'AwsAccountId, Missing, 'Permission>, value: string) : NetworkInterfacePermissionState<'AwsAccountId, Present, 'Permission> =
            state.assignments.Add(fun config -> config.NetworkInterfaceId <- value)
            ({ assignments = state.assignments } : NetworkInterfacePermissionState<'AwsAccountId, Present, 'Permission>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface_permission#permission-1">NetworkInterfacePermission#permission</a>.
        /// </summary>
        [<CustomOperation "permission">]
        member _.Permission(state: NetworkInterfacePermissionState<'AwsAccountId, 'NetworkInterfaceId, Missing>, value: string) : NetworkInterfacePermissionState<'AwsAccountId, 'NetworkInterfaceId, Present> =
            state.assignments.Add(fun config -> config.Permission <- value)
            ({ assignments = state.assignments } : NetworkInterfacePermissionState<'AwsAccountId, 'NetworkInterfaceId, Present>)

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_interface_permission#timeouts-1">NetworkInterfacePermission#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkInterfacePermissionState<'AwsAccountId, 'NetworkInterfaceId, 'Permission>, value: aws.NetworkInterfacePermission.NetworkInterfacePermissionTimeouts) : NetworkInterfacePermissionState<'AwsAccountId, 'NetworkInterfaceId, 'Permission> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkInterfacePermissionState<'AwsAccountId, 'NetworkInterfaceId, 'Permission>

        member _.Run(state: NetworkInterfacePermissionState<Present, Present, Present>) : aws.NetworkInterfacePermission.NetworkInterfacePermission =
            let config = aws.NetworkInterfacePermission.NetworkInterfacePermissionConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkInterfacePermission.NetworkInterfacePermission(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkInterfacePermission: missing required arguments. Must call: aws_account_id, network_interface_id, permission.", 9999, IsError = true)>]
        member _.Run(_: NetworkInterfacePermissionState<_, _, _>) : aws.NetworkInterfacePermission.NetworkInterfacePermission =
            Unchecked.defaultof<aws.NetworkInterfacePermission.NetworkInterfacePermission>
