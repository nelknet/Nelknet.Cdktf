namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3ControlAccessGrantsLocationState<'IamRoleArn, 'LocationScope> = { assignments: ResizeArray<aws.S3ControlAccessGrantsLocation.S3ControlAccessGrantsLocationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grants_location">aws_s3control_access_grants_location</a>.
    /// </summary>
    type S3ControlAccessGrantsLocationBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3ControlAccessGrantsLocationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlAccessGrantsLocationState<Missing, Missing>)

        member _.Zero(()) : S3ControlAccessGrantsLocationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlAccessGrantsLocationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grants_location#iam_role_arn-1">S3ControlAccessGrantsLocation#iam_role_arn</a>.
        /// </summary>
        [<CustomOperation "iam_role_arn">]
        member _.IamRoleArn(state: S3ControlAccessGrantsLocationState<Missing, 'LocationScope>, value: string) : S3ControlAccessGrantsLocationState<Present, 'LocationScope> =
            state.assignments.Add(fun config -> config.IamRoleArn <- value)
            ({ assignments = state.assignments } : S3ControlAccessGrantsLocationState<Present, 'LocationScope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grants_location#location_scope-1">S3ControlAccessGrantsLocation#location_scope</a>.
        /// </summary>
        [<CustomOperation "location_scope">]
        member _.LocationScope(state: S3ControlAccessGrantsLocationState<'IamRoleArn, Missing>, value: string) : S3ControlAccessGrantsLocationState<'IamRoleArn, Present> =
            state.assignments.Add(fun config -> config.LocationScope <- value)
            ({ assignments = state.assignments } : S3ControlAccessGrantsLocationState<'IamRoleArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grants_location#account_id-1">S3ControlAccessGrantsLocation#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: S3ControlAccessGrantsLocationState<'IamRoleArn, 'LocationScope>, value: string) : S3ControlAccessGrantsLocationState<'IamRoleArn, 'LocationScope> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : S3ControlAccessGrantsLocationState<'IamRoleArn, 'LocationScope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grants_location#tags-1">S3ControlAccessGrantsLocation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: S3ControlAccessGrantsLocationState<'IamRoleArn, 'LocationScope>, value: seq<string * string>) : S3ControlAccessGrantsLocationState<'IamRoleArn, 'LocationScope> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : S3ControlAccessGrantsLocationState<'IamRoleArn, 'LocationScope>

        member _.Run(state: S3ControlAccessGrantsLocationState<Present, Present>) : aws.S3ControlAccessGrantsLocation.S3ControlAccessGrantsLocation =
            let config = aws.S3ControlAccessGrantsLocation.S3ControlAccessGrantsLocationConfig()
            for setter in state.assignments do
                setter config
            aws.S3ControlAccessGrantsLocation.S3ControlAccessGrantsLocation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3ControlAccessGrantsLocation: missing required arguments. Must call: iam_role_arn, location_scope.", 9999, IsError = true)>]
        member _.Run(_: S3ControlAccessGrantsLocationState<_, _>) : aws.S3ControlAccessGrantsLocation.S3ControlAccessGrantsLocation =
            Unchecked.defaultof<aws.S3ControlAccessGrantsLocation.S3ControlAccessGrantsLocation>
