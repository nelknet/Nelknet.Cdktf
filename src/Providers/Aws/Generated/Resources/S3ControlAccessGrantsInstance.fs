namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3ControlAccessGrantsInstanceState = { assignments: ResizeArray<aws.S3ControlAccessGrantsInstance.S3ControlAccessGrantsInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grants_instance">aws_s3control_access_grants_instance</a>.
    /// </summary>
    type S3ControlAccessGrantsInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3ControlAccessGrantsInstanceState =
            { assignments = ResizeArray() }

        member _.Zero(()) : S3ControlAccessGrantsInstanceState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grants_instance#account_id-1">S3ControlAccessGrantsInstance#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: S3ControlAccessGrantsInstanceState, value: string) : S3ControlAccessGrantsInstanceState =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : S3ControlAccessGrantsInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grants_instance#identity_center_arn-1">S3ControlAccessGrantsInstance#identity_center_arn</a>.
        /// </summary>
        [<CustomOperation "identity_center_arn">]
        member _.IdentityCenterArn(state: S3ControlAccessGrantsInstanceState, value: string) : S3ControlAccessGrantsInstanceState =
            state.assignments.Add(fun config -> config.IdentityCenterArn <- value)
            state : S3ControlAccessGrantsInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grants_instance#tags-1">S3ControlAccessGrantsInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: S3ControlAccessGrantsInstanceState, value: seq<string * string>) : S3ControlAccessGrantsInstanceState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : S3ControlAccessGrantsInstanceState

        member _.Run(state: S3ControlAccessGrantsInstanceState) : aws.S3ControlAccessGrantsInstance.S3ControlAccessGrantsInstance =
            let config = aws.S3ControlAccessGrantsInstance.S3ControlAccessGrantsInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.S3ControlAccessGrantsInstance.S3ControlAccessGrantsInstance(StackContext.get (), logicalId, config)
