namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3ControlMultiRegionAccessPointPolicyState<'Details> = { assignments: ResizeArray<aws.S3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point_policy">aws_s3control_multi_region_access_point_policy</a>.
    /// </summary>
    type S3ControlMultiRegionAccessPointPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3ControlMultiRegionAccessPointPolicyState<Missing> =
            ({ assignments = ResizeArray() } : S3ControlMultiRegionAccessPointPolicyState<Missing>)

        member _.Zero(()) : S3ControlMultiRegionAccessPointPolicyState<Missing> =
            ({ assignments = ResizeArray() } : S3ControlMultiRegionAccessPointPolicyState<Missing>)

        /// <summary>
        /// details block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point_policy#details-1">S3ControlMultiRegionAccessPointPolicy#details</a>
        /// </summary>
        [<CustomOperation "details">]
        member _.Details(state: S3ControlMultiRegionAccessPointPolicyState<Missing>, value: aws.S3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyDetails) : S3ControlMultiRegionAccessPointPolicyState<Present> =
            state.assignments.Add(fun config -> config.Details <- value)
            ({ assignments = state.assignments } : S3ControlMultiRegionAccessPointPolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point_policy#account_id-1">S3ControlMultiRegionAccessPointPolicy#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: S3ControlMultiRegionAccessPointPolicyState<'Details>, value: string) : S3ControlMultiRegionAccessPointPolicyState<'Details> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : S3ControlMultiRegionAccessPointPolicyState<'Details>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point_policy#id-1">S3ControlMultiRegionAccessPointPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3ControlMultiRegionAccessPointPolicyState<'Details>, value: string) : S3ControlMultiRegionAccessPointPolicyState<'Details> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3ControlMultiRegionAccessPointPolicyState<'Details>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point_policy#timeouts-1">S3ControlMultiRegionAccessPointPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: S3ControlMultiRegionAccessPointPolicyState<'Details>, value: aws.S3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyTimeouts) : S3ControlMultiRegionAccessPointPolicyState<'Details> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : S3ControlMultiRegionAccessPointPolicyState<'Details>

        member _.Run(state: S3ControlMultiRegionAccessPointPolicyState<Present>) : aws.S3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicy =
            let config = aws.S3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.S3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3ControlMultiRegionAccessPointPolicy: missing required arguments. Must call: details.", 9999, IsError = true)>]
        member _.Run(_: S3ControlMultiRegionAccessPointPolicyState<_>) : aws.S3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicy =
            Unchecked.defaultof<aws.S3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicy>
