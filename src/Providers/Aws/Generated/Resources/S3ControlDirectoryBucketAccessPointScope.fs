namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3ControlDirectoryBucketAccessPointScopeState<'AccountId, 'Name> = { assignments: ResizeArray<aws.S3ControlDirectoryBucketAccessPointScope.S3ControlDirectoryBucketAccessPointScopeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_directory_bucket_access_point_scope">aws_s3control_directory_bucket_access_point_scope</a>.
    /// </summary>
    type S3ControlDirectoryBucketAccessPointScopeBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3ControlDirectoryBucketAccessPointScopeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlDirectoryBucketAccessPointScopeState<Missing, Missing>)

        member _.Zero(()) : S3ControlDirectoryBucketAccessPointScopeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlDirectoryBucketAccessPointScopeState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_directory_bucket_access_point_scope#account_id-1">S3ControlDirectoryBucketAccessPointScope#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: S3ControlDirectoryBucketAccessPointScopeState<Missing, 'Name>, value: string) : S3ControlDirectoryBucketAccessPointScopeState<Present, 'Name> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            ({ assignments = state.assignments } : S3ControlDirectoryBucketAccessPointScopeState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_directory_bucket_access_point_scope#name-1">S3ControlDirectoryBucketAccessPointScope#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: S3ControlDirectoryBucketAccessPointScopeState<'AccountId, Missing>, value: string) : S3ControlDirectoryBucketAccessPointScopeState<'AccountId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : S3ControlDirectoryBucketAccessPointScopeState<'AccountId, Present>)

        /// <summary>
        /// scope block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_directory_bucket_access_point_scope#scope-1">S3ControlDirectoryBucketAccessPointScope#scope</a> Accepts: aws.IResolvable | aws.S3ControlDirectoryBucketAccessPointScope.S3ControlDirectoryBucketAccessPointScopeScope[]
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: S3ControlDirectoryBucketAccessPointScopeState<'AccountId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : S3ControlDirectoryBucketAccessPointScopeState<'AccountId, 'Name> =
            state.assignments.Add(fun config -> config.Scope <- value)
            state : S3ControlDirectoryBucketAccessPointScopeState<'AccountId, 'Name>

        member _.Run(state: S3ControlDirectoryBucketAccessPointScopeState<Present, Present>) : aws.S3ControlDirectoryBucketAccessPointScope.S3ControlDirectoryBucketAccessPointScope =
            let config = aws.S3ControlDirectoryBucketAccessPointScope.S3ControlDirectoryBucketAccessPointScopeConfig()
            for setter in state.assignments do
                setter config
            aws.S3ControlDirectoryBucketAccessPointScope.S3ControlDirectoryBucketAccessPointScope(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3ControlDirectoryBucketAccessPointScope: missing required arguments. Must call: account_id, name.", 9999, IsError = true)>]
        member _.Run(_: S3ControlDirectoryBucketAccessPointScopeState<_, _>) : aws.S3ControlDirectoryBucketAccessPointScope.S3ControlDirectoryBucketAccessPointScope =
            Unchecked.defaultof<aws.S3ControlDirectoryBucketAccessPointScope.S3ControlDirectoryBucketAccessPointScope>
