namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLambdaLayerVersionState<'LayerName> = { assignments: ResizeArray<aws.DataAwsLambdaLayerVersion.DataAwsLambdaLayerVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_layer_version">aws_lambda_layer_version</a>.
    /// </summary>
    type DataAwsLambdaLayerVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLambdaLayerVersionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLambdaLayerVersionState<Missing>)

        member _.Zero(()) : DataAwsLambdaLayerVersionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLambdaLayerVersionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_layer_version#layer_name-1">DataAwsLambdaLayerVersion#layer_name</a>.
        /// </summary>
        [<CustomOperation "layer_name">]
        member _.LayerName(state: DataAwsLambdaLayerVersionState<Missing>, value: string) : DataAwsLambdaLayerVersionState<Present> =
            state.assignments.Add(fun config -> config.LayerName <- value)
            ({ assignments = state.assignments } : DataAwsLambdaLayerVersionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_layer_version#compatible_architecture-1">DataAwsLambdaLayerVersion#compatible_architecture</a>.
        /// </summary>
        [<CustomOperation "compatible_architecture">]
        member _.CompatibleArchitecture(state: DataAwsLambdaLayerVersionState<'LayerName>, value: string) : DataAwsLambdaLayerVersionState<'LayerName> =
            state.assignments.Add(fun config -> config.CompatibleArchitecture <- value)
            state : DataAwsLambdaLayerVersionState<'LayerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_layer_version#compatible_runtime-1">DataAwsLambdaLayerVersion#compatible_runtime</a>.
        /// </summary>
        [<CustomOperation "compatible_runtime">]
        member _.CompatibleRuntime(state: DataAwsLambdaLayerVersionState<'LayerName>, value: string) : DataAwsLambdaLayerVersionState<'LayerName> =
            state.assignments.Add(fun config -> config.CompatibleRuntime <- value)
            state : DataAwsLambdaLayerVersionState<'LayerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_layer_version#id-1">DataAwsLambdaLayerVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLambdaLayerVersionState<'LayerName>, value: string) : DataAwsLambdaLayerVersionState<'LayerName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLambdaLayerVersionState<'LayerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lambda_layer_version#version-1">DataAwsLambdaLayerVersion#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: DataAwsLambdaLayerVersionState<'LayerName>, value: double) : DataAwsLambdaLayerVersionState<'LayerName> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : DataAwsLambdaLayerVersionState<'LayerName>

        member _.Run(state: DataAwsLambdaLayerVersionState<Present>) : aws.DataAwsLambdaLayerVersion.DataAwsLambdaLayerVersion =
            let config = aws.DataAwsLambdaLayerVersion.DataAwsLambdaLayerVersionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLambdaLayerVersion.DataAwsLambdaLayerVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLambdaLayerVersion: missing required arguments. Must call: layer_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLambdaLayerVersionState<_>) : aws.DataAwsLambdaLayerVersion.DataAwsLambdaLayerVersion =
            Unchecked.defaultof<aws.DataAwsLambdaLayerVersion.DataAwsLambdaLayerVersion>
