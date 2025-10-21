namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEfsMountTargetState = { assignments: ResizeArray<aws.DataAwsEfsMountTarget.DataAwsEfsMountTargetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/efs_mount_target">aws_efs_mount_target</a>.
    /// </summary>
    type DataAwsEfsMountTargetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEfsMountTargetState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEfsMountTargetState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/efs_mount_target#access_point_id-1">DataAwsEfsMountTarget#access_point_id</a>.
        /// </summary>
        [<CustomOperation "access_point_id">]
        member _.AccessPointId(state: DataAwsEfsMountTargetState, value: string) : DataAwsEfsMountTargetState =
            state.assignments.Add(fun config -> config.AccessPointId <- value)
            state : DataAwsEfsMountTargetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/efs_mount_target#file_system_id-1">DataAwsEfsMountTarget#file_system_id</a>.
        /// </summary>
        [<CustomOperation "file_system_id">]
        member _.FileSystemId(state: DataAwsEfsMountTargetState, value: string) : DataAwsEfsMountTargetState =
            state.assignments.Add(fun config -> config.FileSystemId <- value)
            state : DataAwsEfsMountTargetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/efs_mount_target#id-1">DataAwsEfsMountTarget#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEfsMountTargetState, value: string) : DataAwsEfsMountTargetState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEfsMountTargetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/efs_mount_target#mount_target_id-1">DataAwsEfsMountTarget#mount_target_id</a>.
        /// </summary>
        [<CustomOperation "mount_target_id">]
        member _.MountTargetId(state: DataAwsEfsMountTargetState, value: string) : DataAwsEfsMountTargetState =
            state.assignments.Add(fun config -> config.MountTargetId <- value)
            state : DataAwsEfsMountTargetState

        member _.Run(state: DataAwsEfsMountTargetState) : aws.DataAwsEfsMountTarget.DataAwsEfsMountTarget =
            let config = aws.DataAwsEfsMountTarget.DataAwsEfsMountTargetConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEfsMountTarget.DataAwsEfsMountTarget(StackContext.get (), logicalId, config)
