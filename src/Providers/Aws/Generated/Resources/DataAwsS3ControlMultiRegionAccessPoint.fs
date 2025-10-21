namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsS3ControlMultiRegionAccessPointState<'Name> = { assignments: ResizeArray<aws.DataAwsS3ControlMultiRegionAccessPoint.DataAwsS3ControlMultiRegionAccessPointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3control_multi_region_access_point">aws_s3control_multi_region_access_point</a>.
    /// </summary>
    type DataAwsS3ControlMultiRegionAccessPointBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsS3ControlMultiRegionAccessPointState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsS3ControlMultiRegionAccessPointState<Missing>)

        member _.Zero(()) : DataAwsS3ControlMultiRegionAccessPointState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsS3ControlMultiRegionAccessPointState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3control_multi_region_access_point#name-1">DataAwsS3ControlMultiRegionAccessPoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsS3ControlMultiRegionAccessPointState<Missing>, value: string) : DataAwsS3ControlMultiRegionAccessPointState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsS3ControlMultiRegionAccessPointState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3control_multi_region_access_point#account_id-1">DataAwsS3ControlMultiRegionAccessPoint#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: DataAwsS3ControlMultiRegionAccessPointState<'Name>, value: string) : DataAwsS3ControlMultiRegionAccessPointState<'Name> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : DataAwsS3ControlMultiRegionAccessPointState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3control_multi_region_access_point#id-1">DataAwsS3ControlMultiRegionAccessPoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsS3ControlMultiRegionAccessPointState<'Name>, value: string) : DataAwsS3ControlMultiRegionAccessPointState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsS3ControlMultiRegionAccessPointState<'Name>

        member _.Run(state: DataAwsS3ControlMultiRegionAccessPointState<Present>) : aws.DataAwsS3ControlMultiRegionAccessPoint.DataAwsS3ControlMultiRegionAccessPoint =
            let config = aws.DataAwsS3ControlMultiRegionAccessPoint.DataAwsS3ControlMultiRegionAccessPointConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsS3ControlMultiRegionAccessPoint.DataAwsS3ControlMultiRegionAccessPoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsS3ControlMultiRegionAccessPoint: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsS3ControlMultiRegionAccessPointState<_>) : aws.DataAwsS3ControlMultiRegionAccessPoint.DataAwsS3ControlMultiRegionAccessPoint =
            Unchecked.defaultof<aws.DataAwsS3ControlMultiRegionAccessPoint.DataAwsS3ControlMultiRegionAccessPoint>
