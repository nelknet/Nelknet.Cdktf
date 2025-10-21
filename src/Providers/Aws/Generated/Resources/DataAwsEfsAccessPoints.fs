namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEfsAccessPointsState<'FileSystemId> = { assignments: ResizeArray<aws.DataAwsEfsAccessPoints.DataAwsEfsAccessPointsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/efs_access_points">aws_efs_access_points</a>.
    /// </summary>
    type DataAwsEfsAccessPointsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEfsAccessPointsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEfsAccessPointsState<Missing>)

        member _.Zero(()) : DataAwsEfsAccessPointsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEfsAccessPointsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/efs_access_points#file_system_id-1">DataAwsEfsAccessPoints#file_system_id</a>.
        /// </summary>
        [<CustomOperation "file_system_id">]
        member _.FileSystemId(state: DataAwsEfsAccessPointsState<Missing>, value: string) : DataAwsEfsAccessPointsState<Present> =
            state.assignments.Add(fun config -> config.FileSystemId <- value)
            ({ assignments = state.assignments } : DataAwsEfsAccessPointsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/efs_access_points#id-1">DataAwsEfsAccessPoints#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEfsAccessPointsState<'FileSystemId>, value: string) : DataAwsEfsAccessPointsState<'FileSystemId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEfsAccessPointsState<'FileSystemId>

        member _.Run(state: DataAwsEfsAccessPointsState<Present>) : aws.DataAwsEfsAccessPoints.DataAwsEfsAccessPoints =
            let config = aws.DataAwsEfsAccessPoints.DataAwsEfsAccessPointsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEfsAccessPoints.DataAwsEfsAccessPoints(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEfsAccessPoints: missing required arguments. Must call: file_system_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEfsAccessPointsState<_>) : aws.DataAwsEfsAccessPoints.DataAwsEfsAccessPoints =
            Unchecked.defaultof<aws.DataAwsEfsAccessPoints.DataAwsEfsAccessPoints>
