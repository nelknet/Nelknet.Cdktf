namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule> = { assignments: ResizeArray<aws.SyntheticsCanary.SyntheticsCanaryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary">aws_synthetics_canary</a>.
    /// </summary>
    type SyntheticsCanaryBuilder(logicalId: string) =
        member _.Yield(_: unit) : SyntheticsCanaryState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SyntheticsCanaryState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SyntheticsCanaryState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SyntheticsCanaryState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#artifact_s3_location-1">SyntheticsCanary#artifact_s3_location</a>.
        /// </summary>
        [<CustomOperation "artifact_s3_location">]
        member _.ArtifactS3Location(state: SyntheticsCanaryState<Missing, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>, value: string) : SyntheticsCanaryState<Present, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.ArtifactS3Location <- value)
            ({ assignments = state.assignments } : SyntheticsCanaryState<Present, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#execution_role_arn-1">SyntheticsCanary#execution_role_arn</a>.
        /// </summary>
        [<CustomOperation "execution_role_arn">]
        member _.ExecutionRoleArn(state: SyntheticsCanaryState<'ArtifactS3Location, Missing, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>, value: string) : SyntheticsCanaryState<'ArtifactS3Location, Present, 'Handler, 'Name, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.ExecutionRoleArn <- value)
            ({ assignments = state.assignments } : SyntheticsCanaryState<'ArtifactS3Location, Present, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#handler-1">SyntheticsCanary#handler</a>.
        /// </summary>
        [<CustomOperation "handler">]
        member _.Handler(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, Missing, 'Name, 'RuntimeVersion, 'Schedule>, value: string) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, Present, 'Name, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.Handler <- value)
            ({ assignments = state.assignments } : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, Present, 'Name, 'RuntimeVersion, 'Schedule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#name-1">SyntheticsCanary#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, Missing, 'RuntimeVersion, 'Schedule>, value: string) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, Present, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, Present, 'RuntimeVersion, 'Schedule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#runtime_version-1">SyntheticsCanary#runtime_version</a>.
        /// </summary>
        [<CustomOperation "runtime_version">]
        member _.RuntimeVersion(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, Missing, 'Schedule>, value: string) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, Present, 'Schedule> =
            state.assignments.Add(fun config -> config.RuntimeVersion <- value)
            ({ assignments = state.assignments } : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, Present, 'Schedule>)

        /// <summary>
        /// schedule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#schedule-1">SyntheticsCanary#schedule</a>
        /// </summary>
        [<CustomOperation "schedule">]
        member _.Schedule(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, Missing>, value: aws.SyntheticsCanary.SyntheticsCanarySchedule) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, Present> =
            state.assignments.Add(fun config -> config.Schedule <- value)
            ({ assignments = state.assignments } : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, Present>)

        /// <summary>
        /// artifact_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#artifact_config-1">SyntheticsCanary#artifact_config</a>
        /// </summary>
        [<CustomOperation "artifact_config">]
        member _.ArtifactConfig(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>, value: aws.SyntheticsCanary.SyntheticsCanaryArtifactConfig) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.ArtifactConfig <- value)
            state : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#delete_lambda-1">SyntheticsCanary#delete_lambda</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_lambda">]
        member _.DeleteLambda(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>, value: bool) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.DeleteLambda <- value)
            state : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#delete_lambda-1">SyntheticsCanary#delete_lambda</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_lambda">]
        member _.DeleteLambda(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>, value: HashiCorp.Cdktf.IResolvable) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.DeleteLambda <- value)
            state : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#failure_retention_period-1">SyntheticsCanary#failure_retention_period</a>.
        /// </summary>
        [<CustomOperation "failure_retention_period">]
        member _.FailureRetentionPeriod(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>, value: double) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.FailureRetentionPeriod <- value)
            state : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#id-1">SyntheticsCanary#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>, value: string) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>

        /// <summary>
        /// run_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#run_config-1">SyntheticsCanary#run_config</a>
        /// </summary>
        [<CustomOperation "run_config">]
        member _.RunConfig(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>, value: aws.SyntheticsCanary.SyntheticsCanaryRunConfig) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.RunConfig <- value)
            state : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#s3_bucket-1">SyntheticsCanary#s3_bucket</a>.
        /// </summary>
        [<CustomOperation "s3_bucket">]
        member _.S3Bucket(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>, value: string) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.S3Bucket <- value)
            state : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#s3_key-1">SyntheticsCanary#s3_key</a>.
        /// </summary>
        [<CustomOperation "s3_key">]
        member _.S3Key(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>, value: string) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.S3Key <- value)
            state : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#s3_version-1">SyntheticsCanary#s3_version</a>.
        /// </summary>
        [<CustomOperation "s3_version">]
        member _.S3Version(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>, value: string) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.S3Version <- value)
            state : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#start_canary-1">SyntheticsCanary#start_canary</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "start_canary">]
        member _.StartCanary(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>, value: bool) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.StartCanary <- value)
            state : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#start_canary-1">SyntheticsCanary#start_canary</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "start_canary">]
        member _.StartCanary(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>, value: HashiCorp.Cdktf.IResolvable) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.StartCanary <- value)
            state : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#success_retention_period-1">SyntheticsCanary#success_retention_period</a>.
        /// </summary>
        [<CustomOperation "success_retention_period">]
        member _.SuccessRetentionPeriod(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>, value: double) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.SuccessRetentionPeriod <- value)
            state : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#tags-1">SyntheticsCanary#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>, value: seq<string * string>) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#tags_all-1">SyntheticsCanary#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>, value: seq<string * string>) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>

        /// <summary>
        /// vpc_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#vpc_config-1">SyntheticsCanary#vpc_config</a>
        /// </summary>
        [<CustomOperation "vpc_config">]
        member _.VpcConfig(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>, value: aws.SyntheticsCanary.SyntheticsCanaryVpcConfig) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.VpcConfig <- value)
            state : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#zip_file-1">SyntheticsCanary#zip_file</a>.
        /// </summary>
        [<CustomOperation "zip_file">]
        member _.ZipFile(state: SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>, value: string) : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule> =
            state.assignments.Add(fun config -> config.ZipFile <- value)
            state : SyntheticsCanaryState<'ArtifactS3Location, 'ExecutionRoleArn, 'Handler, 'Name, 'RuntimeVersion, 'Schedule>

        member _.Run(state: SyntheticsCanaryState<Present, Present, Present, Present, Present, Present>) : aws.SyntheticsCanary.SyntheticsCanary =
            let config = aws.SyntheticsCanary.SyntheticsCanaryConfig()
            for setter in state.assignments do
                setter config
            aws.SyntheticsCanary.SyntheticsCanary(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.syntheticsCanary: missing required arguments. Must call: artifact_s3_location, execution_role_arn, handler, name, runtime_version, schedule.", 9999, IsError = true)>]
        member _.Run(_: SyntheticsCanaryState<_, _, _, _, _, _>) : aws.SyntheticsCanary.SyntheticsCanary =
            Unchecked.defaultof<aws.SyntheticsCanary.SyntheticsCanary>
