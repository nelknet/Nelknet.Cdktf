namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LambdaLayerVersionState<'LayerName> = { assignments: ResizeArray<aws.LambdaLayerVersion.LambdaLayerVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version">aws_lambda_layer_version</a>.
    /// </summary>
    type LambdaLayerVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : LambdaLayerVersionState<Missing> =
            ({ assignments = ResizeArray() } : LambdaLayerVersionState<Missing>)

        member _.Zero(()) : LambdaLayerVersionState<Missing> =
            ({ assignments = ResizeArray() } : LambdaLayerVersionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version#layer_name-1">LambdaLayerVersion#layer_name</a>.
        /// </summary>
        [<CustomOperation "layer_name">]
        member _.LayerName(state: LambdaLayerVersionState<Missing>, value: string) : LambdaLayerVersionState<Present> =
            state.assignments.Add(fun config -> config.LayerName <- value)
            ({ assignments = state.assignments } : LambdaLayerVersionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version#compatible_architectures-1">LambdaLayerVersion#compatible_architectures</a>.
        /// </summary>
        [<CustomOperation "compatible_architectures">]
        member _.CompatibleArchitectures(state: LambdaLayerVersionState<'LayerName>, value: seq<string>) : LambdaLayerVersionState<'LayerName> =
            state.assignments.Add(fun config -> config.CompatibleArchitectures <- (value |> Seq.toArray))
            state : LambdaLayerVersionState<'LayerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version#compatible_runtimes-1">LambdaLayerVersion#compatible_runtimes</a>.
        /// </summary>
        [<CustomOperation "compatible_runtimes">]
        member _.CompatibleRuntimes(state: LambdaLayerVersionState<'LayerName>, value: seq<string>) : LambdaLayerVersionState<'LayerName> =
            state.assignments.Add(fun config -> config.CompatibleRuntimes <- (value |> Seq.toArray))
            state : LambdaLayerVersionState<'LayerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version#description-1">LambdaLayerVersion#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: LambdaLayerVersionState<'LayerName>, value: string) : LambdaLayerVersionState<'LayerName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : LambdaLayerVersionState<'LayerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version#filename-1">LambdaLayerVersion#filename</a>.
        /// </summary>
        [<CustomOperation "filename">]
        member _.Filename(state: LambdaLayerVersionState<'LayerName>, value: string) : LambdaLayerVersionState<'LayerName> =
            state.assignments.Add(fun config -> config.Filename <- value)
            state : LambdaLayerVersionState<'LayerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version#id-1">LambdaLayerVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LambdaLayerVersionState<'LayerName>, value: string) : LambdaLayerVersionState<'LayerName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LambdaLayerVersionState<'LayerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version#license_info-1">LambdaLayerVersion#license_info</a>.
        /// </summary>
        [<CustomOperation "license_info">]
        member _.LicenseInfo(state: LambdaLayerVersionState<'LayerName>, value: string) : LambdaLayerVersionState<'LayerName> =
            state.assignments.Add(fun config -> config.LicenseInfo <- value)
            state : LambdaLayerVersionState<'LayerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version#s3_bucket-1">LambdaLayerVersion#s3_bucket</a>.
        /// </summary>
        [<CustomOperation "s3_bucket">]
        member _.S3Bucket(state: LambdaLayerVersionState<'LayerName>, value: string) : LambdaLayerVersionState<'LayerName> =
            state.assignments.Add(fun config -> config.S3Bucket <- value)
            state : LambdaLayerVersionState<'LayerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version#s3_key-1">LambdaLayerVersion#s3_key</a>.
        /// </summary>
        [<CustomOperation "s3_key">]
        member _.S3Key(state: LambdaLayerVersionState<'LayerName>, value: string) : LambdaLayerVersionState<'LayerName> =
            state.assignments.Add(fun config -> config.S3Key <- value)
            state : LambdaLayerVersionState<'LayerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version#s3_object_version-1">LambdaLayerVersion#s3_object_version</a>.
        /// </summary>
        [<CustomOperation "s3_object_version">]
        member _.S3ObjectVersion(state: LambdaLayerVersionState<'LayerName>, value: string) : LambdaLayerVersionState<'LayerName> =
            state.assignments.Add(fun config -> config.S3ObjectVersion <- value)
            state : LambdaLayerVersionState<'LayerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version#skip_destroy-1">LambdaLayerVersion#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: LambdaLayerVersionState<'LayerName>, value: bool) : LambdaLayerVersionState<'LayerName> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : LambdaLayerVersionState<'LayerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version#skip_destroy-1">LambdaLayerVersion#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: LambdaLayerVersionState<'LayerName>, value: HashiCorp.Cdktf.IResolvable) : LambdaLayerVersionState<'LayerName> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : LambdaLayerVersionState<'LayerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version#source_code_hash-1">LambdaLayerVersion#source_code_hash</a>.
        /// </summary>
        [<CustomOperation "source_code_hash">]
        member _.SourceCodeHash(state: LambdaLayerVersionState<'LayerName>, value: string) : LambdaLayerVersionState<'LayerName> =
            state.assignments.Add(fun config -> config.SourceCodeHash <- value)
            state : LambdaLayerVersionState<'LayerName>

        member _.Run(state: LambdaLayerVersionState<Present>) : aws.LambdaLayerVersion.LambdaLayerVersion =
            let config = aws.LambdaLayerVersion.LambdaLayerVersionConfig()
            for setter in state.assignments do
                setter config
            aws.LambdaLayerVersion.LambdaLayerVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lambdaLayerVersion: missing required arguments. Must call: layer_name.", 9999, IsError = true)>]
        member _.Run(_: LambdaLayerVersionState<_>) : aws.LambdaLayerVersion.LambdaLayerVersion =
            Unchecked.defaultof<aws.LambdaLayerVersion.LambdaLayerVersion>
