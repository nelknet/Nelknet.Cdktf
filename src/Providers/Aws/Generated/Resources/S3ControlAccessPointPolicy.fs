namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3ControlAccessPointPolicyState<'AccessPointArn, 'Policy> = { assignments: ResizeArray<aws.S3ControlAccessPointPolicy.S3ControlAccessPointPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_point_policy">aws_s3control_access_point_policy</a>.
    /// </summary>
    type S3ControlAccessPointPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3ControlAccessPointPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlAccessPointPolicyState<Missing, Missing>)

        member _.Zero(()) : S3ControlAccessPointPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlAccessPointPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_point_policy#access_point_arn-1">S3ControlAccessPointPolicy#access_point_arn</a>.
        /// </summary>
        [<CustomOperation "access_point_arn">]
        member _.AccessPointArn(state: S3ControlAccessPointPolicyState<Missing, 'Policy>, value: string) : S3ControlAccessPointPolicyState<Present, 'Policy> =
            state.assignments.Add(fun config -> config.AccessPointArn <- value)
            ({ assignments = state.assignments } : S3ControlAccessPointPolicyState<Present, 'Policy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_point_policy#policy-1">S3ControlAccessPointPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: S3ControlAccessPointPolicyState<'AccessPointArn, Missing>, value: string) : S3ControlAccessPointPolicyState<'AccessPointArn, Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : S3ControlAccessPointPolicyState<'AccessPointArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_point_policy#id-1">S3ControlAccessPointPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3ControlAccessPointPolicyState<'AccessPointArn, 'Policy>, value: string) : S3ControlAccessPointPolicyState<'AccessPointArn, 'Policy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3ControlAccessPointPolicyState<'AccessPointArn, 'Policy>

        member _.Run(state: S3ControlAccessPointPolicyState<Present, Present>) : aws.S3ControlAccessPointPolicy.S3ControlAccessPointPolicy =
            let config = aws.S3ControlAccessPointPolicy.S3ControlAccessPointPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.S3ControlAccessPointPolicy.S3ControlAccessPointPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3ControlAccessPointPolicy: missing required arguments. Must call: access_point_arn, policy.", 9999, IsError = true)>]
        member _.Run(_: S3ControlAccessPointPolicyState<_, _>) : aws.S3ControlAccessPointPolicy.S3ControlAccessPointPolicy =
            Unchecked.defaultof<aws.S3ControlAccessPointPolicy.S3ControlAccessPointPolicy>
