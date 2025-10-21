namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElastictranscoderPipelineState<'InputBucket, 'Role> = { assignments: ResizeArray<aws.ElastictranscoderPipeline.ElastictranscoderPipelineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline">aws_elastictranscoder_pipeline</a>.
    /// </summary>
    type ElastictranscoderPipelineBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElastictranscoderPipelineState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElastictranscoderPipelineState<Missing, Missing>)

        member _.Zero(()) : ElastictranscoderPipelineState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElastictranscoderPipelineState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#input_bucket-1">ElastictranscoderPipeline#input_bucket</a>.
        /// </summary>
        [<CustomOperation "input_bucket">]
        member _.InputBucket(state: ElastictranscoderPipelineState<Missing, 'Role>, value: string) : ElastictranscoderPipelineState<Present, 'Role> =
            state.assignments.Add(fun config -> config.InputBucket <- value)
            ({ assignments = state.assignments } : ElastictranscoderPipelineState<Present, 'Role>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#role-1">ElastictranscoderPipeline#role</a>.
        /// </summary>
        [<CustomOperation "role">]
        member _.Role(state: ElastictranscoderPipelineState<'InputBucket, Missing>, value: string) : ElastictranscoderPipelineState<'InputBucket, Present> =
            state.assignments.Add(fun config -> config.Role <- value)
            ({ assignments = state.assignments } : ElastictranscoderPipelineState<'InputBucket, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#aws_kms_key_arn-1">ElastictranscoderPipeline#aws_kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "aws_kms_key_arn">]
        member _.AwsKmsKeyArn(state: ElastictranscoderPipelineState<'InputBucket, 'Role>, value: string) : ElastictranscoderPipelineState<'InputBucket, 'Role> =
            state.assignments.Add(fun config -> config.AwsKmsKeyArn <- value)
            state : ElastictranscoderPipelineState<'InputBucket, 'Role>

        /// <summary>
        /// content_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#content_config-1">ElastictranscoderPipeline#content_config</a>
        /// </summary>
        [<CustomOperation "content_config">]
        member _.ContentConfig(state: ElastictranscoderPipelineState<'InputBucket, 'Role>, value: aws.ElastictranscoderPipeline.ElastictranscoderPipelineContentConfig) : ElastictranscoderPipelineState<'InputBucket, 'Role> =
            state.assignments.Add(fun config -> config.ContentConfig <- value)
            state : ElastictranscoderPipelineState<'InputBucket, 'Role>

        /// <summary>
        /// content_config_permissions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#content_config_permissions-1">ElastictranscoderPipeline#content_config_permissions</a> Accepts: aws.IResolvable | aws.ElastictranscoderPipeline.ElastictranscoderPipelineContentConfigPermissions[]
        /// </summary>
        [<CustomOperation "content_config_permissions">]
        member _.ContentConfigPermissions(state: ElastictranscoderPipelineState<'InputBucket, 'Role>, value: HashiCorp.Cdktf.IResolvable) : ElastictranscoderPipelineState<'InputBucket, 'Role> =
            state.assignments.Add(fun config -> config.ContentConfigPermissions <- value)
            state : ElastictranscoderPipelineState<'InputBucket, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#id-1">ElastictranscoderPipeline#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElastictranscoderPipelineState<'InputBucket, 'Role>, value: string) : ElastictranscoderPipelineState<'InputBucket, 'Role> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElastictranscoderPipelineState<'InputBucket, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#name-1">ElastictranscoderPipeline#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ElastictranscoderPipelineState<'InputBucket, 'Role>, value: string) : ElastictranscoderPipelineState<'InputBucket, 'Role> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : ElastictranscoderPipelineState<'InputBucket, 'Role>

        /// <summary>
        /// notifications block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#notifications-1">ElastictranscoderPipeline#notifications</a>
        /// </summary>
        [<CustomOperation "notifications">]
        member _.Notifications(state: ElastictranscoderPipelineState<'InputBucket, 'Role>, value: aws.ElastictranscoderPipeline.ElastictranscoderPipelineNotifications) : ElastictranscoderPipelineState<'InputBucket, 'Role> =
            state.assignments.Add(fun config -> config.Notifications <- value)
            state : ElastictranscoderPipelineState<'InputBucket, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#output_bucket-1">ElastictranscoderPipeline#output_bucket</a>.
        /// </summary>
        [<CustomOperation "output_bucket">]
        member _.OutputBucket(state: ElastictranscoderPipelineState<'InputBucket, 'Role>, value: string) : ElastictranscoderPipelineState<'InputBucket, 'Role> =
            state.assignments.Add(fun config -> config.OutputBucket <- value)
            state : ElastictranscoderPipelineState<'InputBucket, 'Role>

        /// <summary>
        /// thumbnail_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#thumbnail_config-1">ElastictranscoderPipeline#thumbnail_config</a>
        /// </summary>
        [<CustomOperation "thumbnail_config">]
        member _.ThumbnailConfig(state: ElastictranscoderPipelineState<'InputBucket, 'Role>, value: aws.ElastictranscoderPipeline.ElastictranscoderPipelineThumbnailConfig) : ElastictranscoderPipelineState<'InputBucket, 'Role> =
            state.assignments.Add(fun config -> config.ThumbnailConfig <- value)
            state : ElastictranscoderPipelineState<'InputBucket, 'Role>

        /// <summary>
        /// thumbnail_config_permissions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_pipeline#thumbnail_config_permissions-1">ElastictranscoderPipeline#thumbnail_config_permissions</a> Accepts: aws.IResolvable | aws.ElastictranscoderPipeline.ElastictranscoderPipelineThumbnailConfigPermissions[]
        /// </summary>
        [<CustomOperation "thumbnail_config_permissions">]
        member _.ThumbnailConfigPermissions(state: ElastictranscoderPipelineState<'InputBucket, 'Role>, value: HashiCorp.Cdktf.IResolvable) : ElastictranscoderPipelineState<'InputBucket, 'Role> =
            state.assignments.Add(fun config -> config.ThumbnailConfigPermissions <- value)
            state : ElastictranscoderPipelineState<'InputBucket, 'Role>

        member _.Run(state: ElastictranscoderPipelineState<Present, Present>) : aws.ElastictranscoderPipeline.ElastictranscoderPipeline =
            let config = aws.ElastictranscoderPipeline.ElastictranscoderPipelineConfig()
            for setter in state.assignments do
                setter config
            aws.ElastictranscoderPipeline.ElastictranscoderPipeline(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elastictranscoderPipeline: missing required arguments. Must call: input_bucket, role.", 9999, IsError = true)>]
        member _.Run(_: ElastictranscoderPipelineState<_, _>) : aws.ElastictranscoderPipeline.ElastictranscoderPipeline =
            Unchecked.defaultof<aws.ElastictranscoderPipeline.ElastictranscoderPipeline>
