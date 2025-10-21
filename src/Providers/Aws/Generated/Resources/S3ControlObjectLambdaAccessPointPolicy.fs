namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3ControlObjectLambdaAccessPointPolicyState<'Name, 'Policy> = { assignments: ResizeArray<aws.S3ControlObjectLambdaAccessPointPolicy.S3ControlObjectLambdaAccessPointPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_object_lambda_access_point_policy">aws_s3control_object_lambda_access_point_policy</a>.
    /// </summary>
    type S3ControlObjectLambdaAccessPointPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3ControlObjectLambdaAccessPointPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlObjectLambdaAccessPointPolicyState<Missing, Missing>)

        member _.Zero(()) : S3ControlObjectLambdaAccessPointPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlObjectLambdaAccessPointPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_object_lambda_access_point_policy#name-1">S3ControlObjectLambdaAccessPointPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: S3ControlObjectLambdaAccessPointPolicyState<Missing, 'Policy>, value: string) : S3ControlObjectLambdaAccessPointPolicyState<Present, 'Policy> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : S3ControlObjectLambdaAccessPointPolicyState<Present, 'Policy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_object_lambda_access_point_policy#policy-1">S3ControlObjectLambdaAccessPointPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: S3ControlObjectLambdaAccessPointPolicyState<'Name, Missing>, value: string) : S3ControlObjectLambdaAccessPointPolicyState<'Name, Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : S3ControlObjectLambdaAccessPointPolicyState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_object_lambda_access_point_policy#account_id-1">S3ControlObjectLambdaAccessPointPolicy#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: S3ControlObjectLambdaAccessPointPolicyState<'Name, 'Policy>, value: string) : S3ControlObjectLambdaAccessPointPolicyState<'Name, 'Policy> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : S3ControlObjectLambdaAccessPointPolicyState<'Name, 'Policy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_object_lambda_access_point_policy#id-1">S3ControlObjectLambdaAccessPointPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3ControlObjectLambdaAccessPointPolicyState<'Name, 'Policy>, value: string) : S3ControlObjectLambdaAccessPointPolicyState<'Name, 'Policy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3ControlObjectLambdaAccessPointPolicyState<'Name, 'Policy>

        member _.Run(state: S3ControlObjectLambdaAccessPointPolicyState<Present, Present>) : aws.S3ControlObjectLambdaAccessPointPolicy.S3ControlObjectLambdaAccessPointPolicy =
            let config = aws.S3ControlObjectLambdaAccessPointPolicy.S3ControlObjectLambdaAccessPointPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.S3ControlObjectLambdaAccessPointPolicy.S3ControlObjectLambdaAccessPointPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3ControlObjectLambdaAccessPointPolicy: missing required arguments. Must call: name, policy.", 9999, IsError = true)>]
        member _.Run(_: S3ControlObjectLambdaAccessPointPolicyState<_, _>) : aws.S3ControlObjectLambdaAccessPointPolicy.S3ControlObjectLambdaAccessPointPolicy =
            Unchecked.defaultof<aws.S3ControlObjectLambdaAccessPointPolicy.S3ControlObjectLambdaAccessPointPolicy>
