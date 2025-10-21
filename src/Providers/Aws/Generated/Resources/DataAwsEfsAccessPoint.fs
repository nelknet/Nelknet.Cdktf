namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEfsAccessPointState<'AccessPointId> = { assignments: ResizeArray<aws.DataAwsEfsAccessPoint.DataAwsEfsAccessPointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/efs_access_point">aws_efs_access_point</a>.
    /// </summary>
    type DataAwsEfsAccessPointBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEfsAccessPointState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEfsAccessPointState<Missing>)

        member _.Zero(()) : DataAwsEfsAccessPointState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEfsAccessPointState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/efs_access_point#access_point_id-1">DataAwsEfsAccessPoint#access_point_id</a>.
        /// </summary>
        [<CustomOperation "access_point_id">]
        member _.AccessPointId(state: DataAwsEfsAccessPointState<Missing>, value: string) : DataAwsEfsAccessPointState<Present> =
            state.assignments.Add(fun config -> config.AccessPointId <- value)
            ({ assignments = state.assignments } : DataAwsEfsAccessPointState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/efs_access_point#id-1">DataAwsEfsAccessPoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEfsAccessPointState<'AccessPointId>, value: string) : DataAwsEfsAccessPointState<'AccessPointId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEfsAccessPointState<'AccessPointId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/efs_access_point#tags-1">DataAwsEfsAccessPoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEfsAccessPointState<'AccessPointId>, value: seq<string * string>) : DataAwsEfsAccessPointState<'AccessPointId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEfsAccessPointState<'AccessPointId>

        member _.Run(state: DataAwsEfsAccessPointState<Present>) : aws.DataAwsEfsAccessPoint.DataAwsEfsAccessPoint =
            let config = aws.DataAwsEfsAccessPoint.DataAwsEfsAccessPointConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEfsAccessPoint.DataAwsEfsAccessPoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEfsAccessPoint: missing required arguments. Must call: access_point_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEfsAccessPointState<_>) : aws.DataAwsEfsAccessPoint.DataAwsEfsAccessPoint =
            Unchecked.defaultof<aws.DataAwsEfsAccessPoint.DataAwsEfsAccessPoint>
