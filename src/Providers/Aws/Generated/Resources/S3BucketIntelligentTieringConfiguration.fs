namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketIntelligentTieringConfigurationState<'Bucket, 'Name, 'Tiering> = { assignments: ResizeArray<aws.S3BucketIntelligentTieringConfiguration.S3BucketIntelligentTieringConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_intelligent_tiering_configuration">aws_s3_bucket_intelligent_tiering_configuration</a>.
    /// </summary>
    type S3BucketIntelligentTieringConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketIntelligentTieringConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketIntelligentTieringConfigurationState<Missing, Missing, Missing>)

        member _.Zero(()) : S3BucketIntelligentTieringConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketIntelligentTieringConfigurationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_intelligent_tiering_configuration#bucket-1">S3BucketIntelligentTieringConfiguration#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketIntelligentTieringConfigurationState<Missing, 'Name, 'Tiering>, value: string) : S3BucketIntelligentTieringConfigurationState<Present, 'Name, 'Tiering> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketIntelligentTieringConfigurationState<Present, 'Name, 'Tiering>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_intelligent_tiering_configuration#name-1">S3BucketIntelligentTieringConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: S3BucketIntelligentTieringConfigurationState<'Bucket, Missing, 'Tiering>, value: string) : S3BucketIntelligentTieringConfigurationState<'Bucket, Present, 'Tiering> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : S3BucketIntelligentTieringConfigurationState<'Bucket, Present, 'Tiering>)

        /// <summary>
        /// tiering block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_intelligent_tiering_configuration#tiering-1">S3BucketIntelligentTieringConfiguration#tiering</a> Accepts: aws.IResolvable | aws.S3BucketIntelligentTieringConfiguration.S3BucketIntelligentTieringConfigurationTiering[]
        /// </summary>
        [<CustomOperation "tiering">]
        member _.Tiering(state: S3BucketIntelligentTieringConfigurationState<'Bucket, 'Name, Missing>, value: HashiCorp.Cdktf.IResolvable) : S3BucketIntelligentTieringConfigurationState<'Bucket, 'Name, Present> =
            state.assignments.Add(fun config -> config.Tiering <- value)
            ({ assignments = state.assignments } : S3BucketIntelligentTieringConfigurationState<'Bucket, 'Name, Present>)

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_intelligent_tiering_configuration#filter-1">S3BucketIntelligentTieringConfiguration#filter</a>
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: S3BucketIntelligentTieringConfigurationState<'Bucket, 'Name, 'Tiering>, value: aws.S3BucketIntelligentTieringConfiguration.S3BucketIntelligentTieringConfigurationFilter) : S3BucketIntelligentTieringConfigurationState<'Bucket, 'Name, 'Tiering> =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : S3BucketIntelligentTieringConfigurationState<'Bucket, 'Name, 'Tiering>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_intelligent_tiering_configuration#id-1">S3BucketIntelligentTieringConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketIntelligentTieringConfigurationState<'Bucket, 'Name, 'Tiering>, value: string) : S3BucketIntelligentTieringConfigurationState<'Bucket, 'Name, 'Tiering> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketIntelligentTieringConfigurationState<'Bucket, 'Name, 'Tiering>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_intelligent_tiering_configuration#status-1">S3BucketIntelligentTieringConfiguration#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: S3BucketIntelligentTieringConfigurationState<'Bucket, 'Name, 'Tiering>, value: string) : S3BucketIntelligentTieringConfigurationState<'Bucket, 'Name, 'Tiering> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : S3BucketIntelligentTieringConfigurationState<'Bucket, 'Name, 'Tiering>

        member _.Run(state: S3BucketIntelligentTieringConfigurationState<Present, Present, Present>) : aws.S3BucketIntelligentTieringConfiguration.S3BucketIntelligentTieringConfiguration =
            let config = aws.S3BucketIntelligentTieringConfiguration.S3BucketIntelligentTieringConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketIntelligentTieringConfiguration.S3BucketIntelligentTieringConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketIntelligentTieringConfiguration: missing required arguments. Must call: bucket, name, tiering.", 9999, IsError = true)>]
        member _.Run(_: S3BucketIntelligentTieringConfigurationState<_, _, _>) : aws.S3BucketIntelligentTieringConfiguration.S3BucketIntelligentTieringConfiguration =
            Unchecked.defaultof<aws.S3BucketIntelligentTieringConfiguration.S3BucketIntelligentTieringConfiguration>
