namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketReplicationConfigurationAState<'Bucket, 'Role, 'Rule> = { assignments: ResizeArray<aws.S3BucketReplicationConfiguration.S3BucketReplicationConfigurationAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration">aws_s3_bucket_replication_configuration</a>.
    /// </summary>
    type S3BucketReplicationConfigurationABuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketReplicationConfigurationAState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketReplicationConfigurationAState<Missing, Missing, Missing>)

        member _.Zero(()) : S3BucketReplicationConfigurationAState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketReplicationConfigurationAState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#bucket-1">S3BucketReplicationConfigurationA#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketReplicationConfigurationAState<Missing, 'Role, 'Rule>, value: string) : S3BucketReplicationConfigurationAState<Present, 'Role, 'Rule> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketReplicationConfigurationAState<Present, 'Role, 'Rule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#role-1">S3BucketReplicationConfigurationA#role</a>.
        /// </summary>
        [<CustomOperation "role">]
        member _.Role(state: S3BucketReplicationConfigurationAState<'Bucket, Missing, 'Rule>, value: string) : S3BucketReplicationConfigurationAState<'Bucket, Present, 'Rule> =
            state.assignments.Add(fun config -> config.Role <- value)
            ({ assignments = state.assignments } : S3BucketReplicationConfigurationAState<'Bucket, Present, 'Rule>)

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#rule-1">S3BucketReplicationConfigurationA#rule</a> Accepts: aws.IResolvable | aws.S3BucketReplicationConfiguration.S3BucketReplicationConfigurationRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: S3BucketReplicationConfigurationAState<'Bucket, 'Role, Missing>, value: HashiCorp.Cdktf.IResolvable) : S3BucketReplicationConfigurationAState<'Bucket, 'Role, Present> =
            state.assignments.Add(fun config -> config.Rule <- value)
            ({ assignments = state.assignments } : S3BucketReplicationConfigurationAState<'Bucket, 'Role, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#id-1">S3BucketReplicationConfigurationA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketReplicationConfigurationAState<'Bucket, 'Role, 'Rule>, value: string) : S3BucketReplicationConfigurationAState<'Bucket, 'Role, 'Rule> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketReplicationConfigurationAState<'Bucket, 'Role, 'Rule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#token-1">S3BucketReplicationConfigurationA#token</a>.
        /// </summary>
        [<CustomOperation "token">]
        member _.Token(state: S3BucketReplicationConfigurationAState<'Bucket, 'Role, 'Rule>, value: string) : S3BucketReplicationConfigurationAState<'Bucket, 'Role, 'Rule> =
            state.assignments.Add(fun config -> config.Token <- value)
            state : S3BucketReplicationConfigurationAState<'Bucket, 'Role, 'Rule>

        member _.Run(state: S3BucketReplicationConfigurationAState<Present, Present, Present>) : aws.S3BucketReplicationConfiguration.S3BucketReplicationConfigurationA =
            let config = aws.S3BucketReplicationConfiguration.S3BucketReplicationConfigurationAConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketReplicationConfiguration.S3BucketReplicationConfigurationA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketReplicationConfigurationA: missing required arguments. Must call: bucket, role, rule.", 9999, IsError = true)>]
        member _.Run(_: S3BucketReplicationConfigurationAState<_, _, _>) : aws.S3BucketReplicationConfiguration.S3BucketReplicationConfigurationA =
            Unchecked.defaultof<aws.S3BucketReplicationConfiguration.S3BucketReplicationConfigurationA>
