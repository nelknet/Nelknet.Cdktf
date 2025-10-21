namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LambdaFunctionState<'FunctionName, 'Role> = { assignments: ResizeArray<aws.LambdaFunction.LambdaFunctionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function">aws_lambda_function</a>.
    /// </summary>
    type LambdaFunctionBuilder(logicalId: string) =
        member _.Yield(_: unit) : LambdaFunctionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LambdaFunctionState<Missing, Missing>)

        member _.Zero(()) : LambdaFunctionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LambdaFunctionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#function_name-1">LambdaFunction#function_name</a>.
        /// </summary>
        [<CustomOperation "function_name">]
        member _.FunctionName(state: LambdaFunctionState<Missing, 'Role>, value: string) : LambdaFunctionState<Present, 'Role> =
            state.assignments.Add(fun config -> config.FunctionName <- value)
            ({ assignments = state.assignments } : LambdaFunctionState<Present, 'Role>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#role-1">LambdaFunction#role</a>.
        /// </summary>
        [<CustomOperation "role">]
        member _.Role(state: LambdaFunctionState<'FunctionName, Missing>, value: string) : LambdaFunctionState<'FunctionName, Present> =
            state.assignments.Add(fun config -> config.Role <- value)
            ({ assignments = state.assignments } : LambdaFunctionState<'FunctionName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#architectures-1">LambdaFunction#architectures</a>.
        /// </summary>
        [<CustomOperation "architectures">]
        member _.Architectures(state: LambdaFunctionState<'FunctionName, 'Role>, value: seq<string>) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.Architectures <- (value |> Seq.toArray))
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#code_signing_config_arn-1">LambdaFunction#code_signing_config_arn</a>.
        /// </summary>
        [<CustomOperation "code_signing_config_arn">]
        member _.CodeSigningConfigArn(state: LambdaFunctionState<'FunctionName, 'Role>, value: string) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.CodeSigningConfigArn <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// dead_letter_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#dead_letter_config-1">LambdaFunction#dead_letter_config</a>
        /// </summary>
        [<CustomOperation "dead_letter_config">]
        member _.DeadLetterConfig(state: LambdaFunctionState<'FunctionName, 'Role>, value: aws.LambdaFunction.LambdaFunctionDeadLetterConfig) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.DeadLetterConfig <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#description-1">LambdaFunction#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: LambdaFunctionState<'FunctionName, 'Role>, value: string) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// environment block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#environment-1">LambdaFunction#environment</a>
        /// </summary>
        [<CustomOperation "environment">]
        member _.Environment(state: LambdaFunctionState<'FunctionName, 'Role>, value: aws.LambdaFunction.LambdaFunctionEnvironment) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.Environment <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// ephemeral_storage block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#ephemeral_storage-1">LambdaFunction#ephemeral_storage</a>
        /// </summary>
        [<CustomOperation "ephemeral_storage">]
        member _.EphemeralStorage(state: LambdaFunctionState<'FunctionName, 'Role>, value: aws.LambdaFunction.LambdaFunctionEphemeralStorage) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.EphemeralStorage <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#filename-1">LambdaFunction#filename</a>.
        /// </summary>
        [<CustomOperation "filename">]
        member _.Filename(state: LambdaFunctionState<'FunctionName, 'Role>, value: string) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.Filename <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// file_system_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#file_system_config-1">LambdaFunction#file_system_config</a>
        /// </summary>
        [<CustomOperation "file_system_config">]
        member _.FileSystemConfig(state: LambdaFunctionState<'FunctionName, 'Role>, value: aws.LambdaFunction.LambdaFunctionFileSystemConfig) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.FileSystemConfig <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#handler-1">LambdaFunction#handler</a>.
        /// </summary>
        [<CustomOperation "handler">]
        member _.Handler(state: LambdaFunctionState<'FunctionName, 'Role>, value: string) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.Handler <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#id-1">LambdaFunction#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LambdaFunctionState<'FunctionName, 'Role>, value: string) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// image_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#image_config-1">LambdaFunction#image_config</a>
        /// </summary>
        [<CustomOperation "image_config">]
        member _.ImageConfig(state: LambdaFunctionState<'FunctionName, 'Role>, value: aws.LambdaFunction.LambdaFunctionImageConfig) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.ImageConfig <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#image_uri-1">LambdaFunction#image_uri</a>.
        /// </summary>
        [<CustomOperation "image_uri">]
        member _.ImageUri(state: LambdaFunctionState<'FunctionName, 'Role>, value: string) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.ImageUri <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#kms_key_arn-1">LambdaFunction#kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "kms_key_arn">]
        member _.KmsKeyArn(state: LambdaFunctionState<'FunctionName, 'Role>, value: string) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.KmsKeyArn <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#layers-1">LambdaFunction#layers</a>.
        /// </summary>
        [<CustomOperation "layers">]
        member _.Layers(state: LambdaFunctionState<'FunctionName, 'Role>, value: seq<string>) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.Layers <- (value |> Seq.toArray))
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// logging_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#logging_config-1">LambdaFunction#logging_config</a>
        /// </summary>
        [<CustomOperation "logging_config">]
        member _.LoggingConfig(state: LambdaFunctionState<'FunctionName, 'Role>, value: aws.LambdaFunction.LambdaFunctionLoggingConfig) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.LoggingConfig <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#memory_size-1">LambdaFunction#memory_size</a>.
        /// </summary>
        [<CustomOperation "memory_size">]
        member _.MemorySize(state: LambdaFunctionState<'FunctionName, 'Role>, value: double) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.MemorySize <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#package_type-1">LambdaFunction#package_type</a>.
        /// </summary>
        [<CustomOperation "package_type">]
        member _.PackageType(state: LambdaFunctionState<'FunctionName, 'Role>, value: string) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.PackageType <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#publish-1">LambdaFunction#publish</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publish">]
        member _.Publish(state: LambdaFunctionState<'FunctionName, 'Role>, value: bool) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.Publish <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#publish-1">LambdaFunction#publish</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publish">]
        member _.Publish(state: LambdaFunctionState<'FunctionName, 'Role>, value: HashiCorp.Cdktf.IResolvable) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.Publish <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#replacement_security_group_ids-1">LambdaFunction#replacement_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "replacement_security_group_ids">]
        member _.ReplacementSecurityGroupIds(state: LambdaFunctionState<'FunctionName, 'Role>, value: seq<string>) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.ReplacementSecurityGroupIds <- (value |> Seq.toArray))
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#replace_security_groups_on_destroy-1">LambdaFunction#replace_security_groups_on_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "replace_security_groups_on_destroy">]
        member _.ReplaceSecurityGroupsOnDestroy(state: LambdaFunctionState<'FunctionName, 'Role>, value: bool) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.ReplaceSecurityGroupsOnDestroy <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#replace_security_groups_on_destroy-1">LambdaFunction#replace_security_groups_on_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "replace_security_groups_on_destroy">]
        member _.ReplaceSecurityGroupsOnDestroy(state: LambdaFunctionState<'FunctionName, 'Role>, value: HashiCorp.Cdktf.IResolvable) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.ReplaceSecurityGroupsOnDestroy <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#reserved_concurrent_executions-1">LambdaFunction#reserved_concurrent_executions</a>.
        /// </summary>
        [<CustomOperation "reserved_concurrent_executions">]
        member _.ReservedConcurrentExecutions(state: LambdaFunctionState<'FunctionName, 'Role>, value: double) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.ReservedConcurrentExecutions <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#runtime-1">LambdaFunction#runtime</a>.
        /// </summary>
        [<CustomOperation "runtime">]
        member _.Runtime(state: LambdaFunctionState<'FunctionName, 'Role>, value: string) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.Runtime <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#s3_bucket-1">LambdaFunction#s3_bucket</a>.
        /// </summary>
        [<CustomOperation "s3_bucket">]
        member _.S3Bucket(state: LambdaFunctionState<'FunctionName, 'Role>, value: string) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.S3Bucket <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#s3_key-1">LambdaFunction#s3_key</a>.
        /// </summary>
        [<CustomOperation "s3_key">]
        member _.S3Key(state: LambdaFunctionState<'FunctionName, 'Role>, value: string) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.S3Key <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#s3_object_version-1">LambdaFunction#s3_object_version</a>.
        /// </summary>
        [<CustomOperation "s3_object_version">]
        member _.S3ObjectVersion(state: LambdaFunctionState<'FunctionName, 'Role>, value: string) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.S3ObjectVersion <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#skip_destroy-1">LambdaFunction#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: LambdaFunctionState<'FunctionName, 'Role>, value: bool) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#skip_destroy-1">LambdaFunction#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: LambdaFunctionState<'FunctionName, 'Role>, value: HashiCorp.Cdktf.IResolvable) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// snap_start block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#snap_start-1">LambdaFunction#snap_start</a>
        /// </summary>
        [<CustomOperation "snap_start">]
        member _.SnapStart(state: LambdaFunctionState<'FunctionName, 'Role>, value: aws.LambdaFunction.LambdaFunctionSnapStart) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.SnapStart <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#source_code_hash-1">LambdaFunction#source_code_hash</a>.
        /// </summary>
        [<CustomOperation "source_code_hash">]
        member _.SourceCodeHash(state: LambdaFunctionState<'FunctionName, 'Role>, value: string) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.SourceCodeHash <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#tags-1">LambdaFunction#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LambdaFunctionState<'FunctionName, 'Role>, value: seq<string * string>) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#tags_all-1">LambdaFunction#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LambdaFunctionState<'FunctionName, 'Role>, value: seq<string * string>) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#timeout-1">LambdaFunction#timeout</a>.
        /// </summary>
        [<CustomOperation "timeout">]
        member _.Timeout(state: LambdaFunctionState<'FunctionName, 'Role>, value: double) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.Timeout <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#timeouts-1">LambdaFunction#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LambdaFunctionState<'FunctionName, 'Role>, value: aws.LambdaFunction.LambdaFunctionTimeouts) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// tracing_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#tracing_config-1">LambdaFunction#tracing_config</a>
        /// </summary>
        [<CustomOperation "tracing_config">]
        member _.TracingConfig(state: LambdaFunctionState<'FunctionName, 'Role>, value: aws.LambdaFunction.LambdaFunctionTracingConfig) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.TracingConfig <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        /// <summary>
        /// vpc_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#vpc_config-1">LambdaFunction#vpc_config</a>
        /// </summary>
        [<CustomOperation "vpc_config">]
        member _.VpcConfig(state: LambdaFunctionState<'FunctionName, 'Role>, value: aws.LambdaFunction.LambdaFunctionVpcConfig) : LambdaFunctionState<'FunctionName, 'Role> =
            state.assignments.Add(fun config -> config.VpcConfig <- value)
            state : LambdaFunctionState<'FunctionName, 'Role>

        member _.Run(state: LambdaFunctionState<Present, Present>) : aws.LambdaFunction.LambdaFunction =
            let config = aws.LambdaFunction.LambdaFunctionConfig()
            for setter in state.assignments do
                setter config
            aws.LambdaFunction.LambdaFunction(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lambdaFunction: missing required arguments. Must call: function_name, role.", 9999, IsError = true)>]
        member _.Run(_: LambdaFunctionState<_, _>) : aws.LambdaFunction.LambdaFunction =
            Unchecked.defaultof<aws.LambdaFunction.LambdaFunction>
