namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3ControlAccessGrantsInstanceResourcePolicyState<'Policy> = { assignments: ResizeArray<aws.S3ControlAccessGrantsInstanceResourcePolicy.S3ControlAccessGrantsInstanceResourcePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grants_instance_resource_policy">aws_s3control_access_grants_instance_resource_policy</a>.
    /// </summary>
    type S3ControlAccessGrantsInstanceResourcePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3ControlAccessGrantsInstanceResourcePolicyState<Missing> =
            ({ assignments = ResizeArray() } : S3ControlAccessGrantsInstanceResourcePolicyState<Missing>)

        member _.Zero(()) : S3ControlAccessGrantsInstanceResourcePolicyState<Missing> =
            ({ assignments = ResizeArray() } : S3ControlAccessGrantsInstanceResourcePolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grants_instance_resource_policy#policy-1">S3ControlAccessGrantsInstanceResourcePolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: S3ControlAccessGrantsInstanceResourcePolicyState<Missing>, value: string) : S3ControlAccessGrantsInstanceResourcePolicyState<Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : S3ControlAccessGrantsInstanceResourcePolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grants_instance_resource_policy#account_id-1">S3ControlAccessGrantsInstanceResourcePolicy#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: S3ControlAccessGrantsInstanceResourcePolicyState<'Policy>, value: string) : S3ControlAccessGrantsInstanceResourcePolicyState<'Policy> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : S3ControlAccessGrantsInstanceResourcePolicyState<'Policy>

        member _.Run(state: S3ControlAccessGrantsInstanceResourcePolicyState<Present>) : aws.S3ControlAccessGrantsInstanceResourcePolicy.S3ControlAccessGrantsInstanceResourcePolicy =
            let config = aws.S3ControlAccessGrantsInstanceResourcePolicy.S3ControlAccessGrantsInstanceResourcePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.S3ControlAccessGrantsInstanceResourcePolicy.S3ControlAccessGrantsInstanceResourcePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3ControlAccessGrantsInstanceResourcePolicy: missing required arguments. Must call: policy.", 9999, IsError = true)>]
        member _.Run(_: S3ControlAccessGrantsInstanceResourcePolicyState<_>) : aws.S3ControlAccessGrantsInstanceResourcePolicy.S3ControlAccessGrantsInstanceResourcePolicy =
            Unchecked.defaultof<aws.S3ControlAccessGrantsInstanceResourcePolicy.S3ControlAccessGrantsInstanceResourcePolicy>
