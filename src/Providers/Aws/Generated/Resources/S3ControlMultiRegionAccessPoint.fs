namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3ControlMultiRegionAccessPointState<'Details> = { assignments: ResizeArray<aws.S3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point">aws_s3control_multi_region_access_point</a>.
    /// </summary>
    type S3ControlMultiRegionAccessPointBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3ControlMultiRegionAccessPointState<Missing> =
            ({ assignments = ResizeArray() } : S3ControlMultiRegionAccessPointState<Missing>)

        member _.Zero(()) : S3ControlMultiRegionAccessPointState<Missing> =
            ({ assignments = ResizeArray() } : S3ControlMultiRegionAccessPointState<Missing>)

        /// <summary>
        /// details block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point#details-1">S3ControlMultiRegionAccessPoint#details</a>
        /// </summary>
        [<CustomOperation "details">]
        member _.Details(state: S3ControlMultiRegionAccessPointState<Missing>, value: aws.S3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointDetails) : S3ControlMultiRegionAccessPointState<Present> =
            state.assignments.Add(fun config -> config.Details <- value)
            ({ assignments = state.assignments } : S3ControlMultiRegionAccessPointState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point#account_id-1">S3ControlMultiRegionAccessPoint#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: S3ControlMultiRegionAccessPointState<'Details>, value: string) : S3ControlMultiRegionAccessPointState<'Details> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : S3ControlMultiRegionAccessPointState<'Details>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point#id-1">S3ControlMultiRegionAccessPoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3ControlMultiRegionAccessPointState<'Details>, value: string) : S3ControlMultiRegionAccessPointState<'Details> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3ControlMultiRegionAccessPointState<'Details>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point#timeouts-1">S3ControlMultiRegionAccessPoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: S3ControlMultiRegionAccessPointState<'Details>, value: aws.S3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointTimeouts) : S3ControlMultiRegionAccessPointState<'Details> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : S3ControlMultiRegionAccessPointState<'Details>

        member _.Run(state: S3ControlMultiRegionAccessPointState<Present>) : aws.S3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPoint =
            let config = aws.S3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPointConfig()
            for setter in state.assignments do
                setter config
            aws.S3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3ControlMultiRegionAccessPoint: missing required arguments. Must call: details.", 9999, IsError = true)>]
        member _.Run(_: S3ControlMultiRegionAccessPointState<_>) : aws.S3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPoint =
            Unchecked.defaultof<aws.S3ControlMultiRegionAccessPoint.S3ControlMultiRegionAccessPoint>
