namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3ControlAccessGrantState<'AccessGrantsLocationId, 'Permission> = { assignments: ResizeArray<aws.S3ControlAccessGrant.S3ControlAccessGrantConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grant">aws_s3control_access_grant</a>.
    /// </summary>
    type S3ControlAccessGrantBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3ControlAccessGrantState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlAccessGrantState<Missing, Missing>)

        member _.Zero(()) : S3ControlAccessGrantState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlAccessGrantState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grant#access_grants_location_id-1">S3ControlAccessGrant#access_grants_location_id</a>.
        /// </summary>
        [<CustomOperation "access_grants_location_id">]
        member _.AccessGrantsLocationId(state: S3ControlAccessGrantState<Missing, 'Permission>, value: string) : S3ControlAccessGrantState<Present, 'Permission> =
            state.assignments.Add(fun config -> config.AccessGrantsLocationId <- value)
            ({ assignments = state.assignments } : S3ControlAccessGrantState<Present, 'Permission>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grant#permission-1">S3ControlAccessGrant#permission</a>.
        /// </summary>
        [<CustomOperation "permission">]
        member _.Permission(state: S3ControlAccessGrantState<'AccessGrantsLocationId, Missing>, value: string) : S3ControlAccessGrantState<'AccessGrantsLocationId, Present> =
            state.assignments.Add(fun config -> config.Permission <- value)
            ({ assignments = state.assignments } : S3ControlAccessGrantState<'AccessGrantsLocationId, Present>)

        /// <summary>
        /// access_grants_location_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grant#access_grants_location_configuration-1">S3ControlAccessGrant#access_grants_location_configuration</a> Accepts: aws.IResolvable | aws.S3ControlAccessGrant.S3ControlAccessGrantAccessGrantsLocationConfiguration[]
        /// </summary>
        [<CustomOperation "access_grants_location_configuration">]
        member _.AccessGrantsLocationConfiguration(state: S3ControlAccessGrantState<'AccessGrantsLocationId, 'Permission>, value: HashiCorp.Cdktf.IResolvable) : S3ControlAccessGrantState<'AccessGrantsLocationId, 'Permission> =
            state.assignments.Add(fun config -> config.AccessGrantsLocationConfiguration <- value)
            state : S3ControlAccessGrantState<'AccessGrantsLocationId, 'Permission>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grant#account_id-1">S3ControlAccessGrant#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: S3ControlAccessGrantState<'AccessGrantsLocationId, 'Permission>, value: string) : S3ControlAccessGrantState<'AccessGrantsLocationId, 'Permission> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : S3ControlAccessGrantState<'AccessGrantsLocationId, 'Permission>

        /// <summary>
        /// grantee block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grant#grantee-1">S3ControlAccessGrant#grantee</a> Accepts: aws.IResolvable | aws.S3ControlAccessGrant.S3ControlAccessGrantGrantee[]
        /// </summary>
        [<CustomOperation "grantee">]
        member _.Grantee(state: S3ControlAccessGrantState<'AccessGrantsLocationId, 'Permission>, value: HashiCorp.Cdktf.IResolvable) : S3ControlAccessGrantState<'AccessGrantsLocationId, 'Permission> =
            state.assignments.Add(fun config -> config.Grantee <- value)
            state : S3ControlAccessGrantState<'AccessGrantsLocationId, 'Permission>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grant#s3_prefix_type-1">S3ControlAccessGrant#s3_prefix_type</a>.
        /// </summary>
        [<CustomOperation "s3_prefix_type">]
        member _.S3PrefixType(state: S3ControlAccessGrantState<'AccessGrantsLocationId, 'Permission>, value: string) : S3ControlAccessGrantState<'AccessGrantsLocationId, 'Permission> =
            state.assignments.Add(fun config -> config.S3PrefixType <- value)
            state : S3ControlAccessGrantState<'AccessGrantsLocationId, 'Permission>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grant#tags-1">S3ControlAccessGrant#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: S3ControlAccessGrantState<'AccessGrantsLocationId, 'Permission>, value: seq<string * string>) : S3ControlAccessGrantState<'AccessGrantsLocationId, 'Permission> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : S3ControlAccessGrantState<'AccessGrantsLocationId, 'Permission>

        member _.Run(state: S3ControlAccessGrantState<Present, Present>) : aws.S3ControlAccessGrant.S3ControlAccessGrant =
            let config = aws.S3ControlAccessGrant.S3ControlAccessGrantConfig()
            for setter in state.assignments do
                setter config
            aws.S3ControlAccessGrant.S3ControlAccessGrant(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3ControlAccessGrant: missing required arguments. Must call: access_grants_location_id, permission.", 9999, IsError = true)>]
        member _.Run(_: S3ControlAccessGrantState<_, _>) : aws.S3ControlAccessGrant.S3ControlAccessGrant =
            Unchecked.defaultof<aws.S3ControlAccessGrant.S3ControlAccessGrant>
