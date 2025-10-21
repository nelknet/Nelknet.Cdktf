namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LambdaLayerVersionPermissionState<'Action, 'LayerName, 'Principal, 'StatementId, 'VersionNumber> = { assignments: ResizeArray<aws.LambdaLayerVersionPermission.LambdaLayerVersionPermissionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version_permission">aws_lambda_layer_version_permission</a>.
    /// </summary>
    type LambdaLayerVersionPermissionBuilder(logicalId: string) =
        member _.Yield(_: unit) : LambdaLayerVersionPermissionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LambdaLayerVersionPermissionState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LambdaLayerVersionPermissionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LambdaLayerVersionPermissionState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version_permission#action-1">LambdaLayerVersionPermission#action</a>.
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: LambdaLayerVersionPermissionState<Missing, 'LayerName, 'Principal, 'StatementId, 'VersionNumber>, value: string) : LambdaLayerVersionPermissionState<Present, 'LayerName, 'Principal, 'StatementId, 'VersionNumber> =
            state.assignments.Add(fun config -> config.Action <- value)
            ({ assignments = state.assignments } : LambdaLayerVersionPermissionState<Present, 'LayerName, 'Principal, 'StatementId, 'VersionNumber>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version_permission#layer_name-1">LambdaLayerVersionPermission#layer_name</a>.
        /// </summary>
        [<CustomOperation "layer_name">]
        member _.LayerName(state: LambdaLayerVersionPermissionState<'Action, Missing, 'Principal, 'StatementId, 'VersionNumber>, value: string) : LambdaLayerVersionPermissionState<'Action, Present, 'Principal, 'StatementId, 'VersionNumber> =
            state.assignments.Add(fun config -> config.LayerName <- value)
            ({ assignments = state.assignments } : LambdaLayerVersionPermissionState<'Action, Present, 'Principal, 'StatementId, 'VersionNumber>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version_permission#principal-1">LambdaLayerVersionPermission#principal</a>.
        /// </summary>
        [<CustomOperation "principal">]
        member _.Principal(state: LambdaLayerVersionPermissionState<'Action, 'LayerName, Missing, 'StatementId, 'VersionNumber>, value: string) : LambdaLayerVersionPermissionState<'Action, 'LayerName, Present, 'StatementId, 'VersionNumber> =
            state.assignments.Add(fun config -> config.Principal <- value)
            ({ assignments = state.assignments } : LambdaLayerVersionPermissionState<'Action, 'LayerName, Present, 'StatementId, 'VersionNumber>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version_permission#statement_id-1">LambdaLayerVersionPermission#statement_id</a>.
        /// </summary>
        [<CustomOperation "statement_id">]
        member _.StatementId(state: LambdaLayerVersionPermissionState<'Action, 'LayerName, 'Principal, Missing, 'VersionNumber>, value: string) : LambdaLayerVersionPermissionState<'Action, 'LayerName, 'Principal, Present, 'VersionNumber> =
            state.assignments.Add(fun config -> config.StatementId <- value)
            ({ assignments = state.assignments } : LambdaLayerVersionPermissionState<'Action, 'LayerName, 'Principal, Present, 'VersionNumber>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version_permission#version_number-1">LambdaLayerVersionPermission#version_number</a>.
        /// </summary>
        [<CustomOperation "version_number">]
        member _.VersionNumber(state: LambdaLayerVersionPermissionState<'Action, 'LayerName, 'Principal, 'StatementId, Missing>, value: double) : LambdaLayerVersionPermissionState<'Action, 'LayerName, 'Principal, 'StatementId, Present> =
            state.assignments.Add(fun config -> config.VersionNumber <- value)
            ({ assignments = state.assignments } : LambdaLayerVersionPermissionState<'Action, 'LayerName, 'Principal, 'StatementId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version_permission#id-1">LambdaLayerVersionPermission#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LambdaLayerVersionPermissionState<'Action, 'LayerName, 'Principal, 'StatementId, 'VersionNumber>, value: string) : LambdaLayerVersionPermissionState<'Action, 'LayerName, 'Principal, 'StatementId, 'VersionNumber> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LambdaLayerVersionPermissionState<'Action, 'LayerName, 'Principal, 'StatementId, 'VersionNumber>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version_permission#organization_id-1">LambdaLayerVersionPermission#organization_id</a>.
        /// </summary>
        [<CustomOperation "organization_id">]
        member _.OrganizationId(state: LambdaLayerVersionPermissionState<'Action, 'LayerName, 'Principal, 'StatementId, 'VersionNumber>, value: string) : LambdaLayerVersionPermissionState<'Action, 'LayerName, 'Principal, 'StatementId, 'VersionNumber> =
            state.assignments.Add(fun config -> config.OrganizationId <- value)
            state : LambdaLayerVersionPermissionState<'Action, 'LayerName, 'Principal, 'StatementId, 'VersionNumber>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version_permission#skip_destroy-1">LambdaLayerVersionPermission#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: LambdaLayerVersionPermissionState<'Action, 'LayerName, 'Principal, 'StatementId, 'VersionNumber>, value: bool) : LambdaLayerVersionPermissionState<'Action, 'LayerName, 'Principal, 'StatementId, 'VersionNumber> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : LambdaLayerVersionPermissionState<'Action, 'LayerName, 'Principal, 'StatementId, 'VersionNumber>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_layer_version_permission#skip_destroy-1">LambdaLayerVersionPermission#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: LambdaLayerVersionPermissionState<'Action, 'LayerName, 'Principal, 'StatementId, 'VersionNumber>, value: HashiCorp.Cdktf.IResolvable) : LambdaLayerVersionPermissionState<'Action, 'LayerName, 'Principal, 'StatementId, 'VersionNumber> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : LambdaLayerVersionPermissionState<'Action, 'LayerName, 'Principal, 'StatementId, 'VersionNumber>

        member _.Run(state: LambdaLayerVersionPermissionState<Present, Present, Present, Present, Present>) : aws.LambdaLayerVersionPermission.LambdaLayerVersionPermission =
            let config = aws.LambdaLayerVersionPermission.LambdaLayerVersionPermissionConfig()
            for setter in state.assignments do
                setter config
            aws.LambdaLayerVersionPermission.LambdaLayerVersionPermission(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lambdaLayerVersionPermission: missing required arguments. Must call: action, layer_name, principal, statement_id, version_number.", 9999, IsError = true)>]
        member _.Run(_: LambdaLayerVersionPermissionState<_, _, _, _, _>) : aws.LambdaLayerVersionPermission.LambdaLayerVersionPermission =
            Unchecked.defaultof<aws.LambdaLayerVersionPermission.LambdaLayerVersionPermission>
