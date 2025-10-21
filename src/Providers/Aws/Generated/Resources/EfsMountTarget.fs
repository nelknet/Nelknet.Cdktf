namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EfsMountTargetState<'FileSystemId, 'SubnetId> = { assignments: ResizeArray<aws.EfsMountTarget.EfsMountTargetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_mount_target">aws_efs_mount_target</a>.
    /// </summary>
    type EfsMountTargetBuilder(logicalId: string) =
        member _.Yield(_: unit) : EfsMountTargetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EfsMountTargetState<Missing, Missing>)

        member _.Zero(()) : EfsMountTargetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EfsMountTargetState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_mount_target#file_system_id-1">EfsMountTarget#file_system_id</a>.
        /// </summary>
        [<CustomOperation "file_system_id">]
        member _.FileSystemId(state: EfsMountTargetState<Missing, 'SubnetId>, value: string) : EfsMountTargetState<Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.FileSystemId <- value)
            ({ assignments = state.assignments } : EfsMountTargetState<Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_mount_target#subnet_id-1">EfsMountTarget#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: EfsMountTargetState<'FileSystemId, Missing>, value: string) : EfsMountTargetState<'FileSystemId, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : EfsMountTargetState<'FileSystemId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_mount_target#id-1">EfsMountTarget#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EfsMountTargetState<'FileSystemId, 'SubnetId>, value: string) : EfsMountTargetState<'FileSystemId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EfsMountTargetState<'FileSystemId, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_mount_target#ip_address-1">EfsMountTarget#ip_address</a>.
        /// </summary>
        [<CustomOperation "ip_address">]
        member _.IpAddress(state: EfsMountTargetState<'FileSystemId, 'SubnetId>, value: string) : EfsMountTargetState<'FileSystemId, 'SubnetId> =
            state.assignments.Add(fun config -> config.IpAddress <- value)
            state : EfsMountTargetState<'FileSystemId, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_mount_target#security_groups-1">EfsMountTarget#security_groups</a>.
        /// </summary>
        [<CustomOperation "security_groups">]
        member _.SecurityGroups(state: EfsMountTargetState<'FileSystemId, 'SubnetId>, value: seq<string>) : EfsMountTargetState<'FileSystemId, 'SubnetId> =
            state.assignments.Add(fun config -> config.SecurityGroups <- (value |> Seq.toArray))
            state : EfsMountTargetState<'FileSystemId, 'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_mount_target#timeouts-1">EfsMountTarget#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EfsMountTargetState<'FileSystemId, 'SubnetId>, value: aws.EfsMountTarget.EfsMountTargetTimeouts) : EfsMountTargetState<'FileSystemId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EfsMountTargetState<'FileSystemId, 'SubnetId>

        member _.Run(state: EfsMountTargetState<Present, Present>) : aws.EfsMountTarget.EfsMountTarget =
            let config = aws.EfsMountTarget.EfsMountTargetConfig()
            for setter in state.assignments do
                setter config
            aws.EfsMountTarget.EfsMountTarget(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.efsMountTarget: missing required arguments. Must call: file_system_id, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: EfsMountTargetState<_, _>) : aws.EfsMountTarget.EfsMountTarget =
            Unchecked.defaultof<aws.EfsMountTarget.EfsMountTarget>
