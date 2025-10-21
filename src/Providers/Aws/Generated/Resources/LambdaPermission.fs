namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LambdaPermissionState<'Action, 'FunctionName, 'Principal> = { assignments: ResizeArray<aws.LambdaPermission.LambdaPermissionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_permission">aws_lambda_permission</a>.
    /// </summary>
    type LambdaPermissionBuilder(logicalId: string) =
        member _.Yield(_: unit) : LambdaPermissionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LambdaPermissionState<Missing, Missing, Missing>)

        member _.Zero(()) : LambdaPermissionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LambdaPermissionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_permission#action-1">LambdaPermission#action</a>.
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: LambdaPermissionState<Missing, 'FunctionName, 'Principal>, value: string) : LambdaPermissionState<Present, 'FunctionName, 'Principal> =
            state.assignments.Add(fun config -> config.Action <- value)
            ({ assignments = state.assignments } : LambdaPermissionState<Present, 'FunctionName, 'Principal>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_permission#function_name-1">LambdaPermission#function_name</a>.
        /// </summary>
        [<CustomOperation "function_name">]
        member _.FunctionName(state: LambdaPermissionState<'Action, Missing, 'Principal>, value: string) : LambdaPermissionState<'Action, Present, 'Principal> =
            state.assignments.Add(fun config -> config.FunctionName <- value)
            ({ assignments = state.assignments } : LambdaPermissionState<'Action, Present, 'Principal>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_permission#principal-1">LambdaPermission#principal</a>.
        /// </summary>
        [<CustomOperation "principal">]
        member _.Principal(state: LambdaPermissionState<'Action, 'FunctionName, Missing>, value: string) : LambdaPermissionState<'Action, 'FunctionName, Present> =
            state.assignments.Add(fun config -> config.Principal <- value)
            ({ assignments = state.assignments } : LambdaPermissionState<'Action, 'FunctionName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_permission#event_source_token-1">LambdaPermission#event_source_token</a>.
        /// </summary>
        [<CustomOperation "event_source_token">]
        member _.EventSourceToken(state: LambdaPermissionState<'Action, 'FunctionName, 'Principal>, value: string) : LambdaPermissionState<'Action, 'FunctionName, 'Principal> =
            state.assignments.Add(fun config -> config.EventSourceToken <- value)
            state : LambdaPermissionState<'Action, 'FunctionName, 'Principal>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_permission#function_url_auth_type-1">LambdaPermission#function_url_auth_type</a>.
        /// </summary>
        [<CustomOperation "function_url_auth_type">]
        member _.FunctionUrlAuthType(state: LambdaPermissionState<'Action, 'FunctionName, 'Principal>, value: string) : LambdaPermissionState<'Action, 'FunctionName, 'Principal> =
            state.assignments.Add(fun config -> config.FunctionUrlAuthType <- value)
            state : LambdaPermissionState<'Action, 'FunctionName, 'Principal>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_permission#id-1">LambdaPermission#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LambdaPermissionState<'Action, 'FunctionName, 'Principal>, value: string) : LambdaPermissionState<'Action, 'FunctionName, 'Principal> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LambdaPermissionState<'Action, 'FunctionName, 'Principal>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_permission#principal_org_id-1">LambdaPermission#principal_org_id</a>.
        /// </summary>
        [<CustomOperation "principal_org_id">]
        member _.PrincipalOrgId(state: LambdaPermissionState<'Action, 'FunctionName, 'Principal>, value: string) : LambdaPermissionState<'Action, 'FunctionName, 'Principal> =
            state.assignments.Add(fun config -> config.PrincipalOrgId <- value)
            state : LambdaPermissionState<'Action, 'FunctionName, 'Principal>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_permission#qualifier-1">LambdaPermission#qualifier</a>.
        /// </summary>
        [<CustomOperation "qualifier">]
        member _.Qualifier(state: LambdaPermissionState<'Action, 'FunctionName, 'Principal>, value: string) : LambdaPermissionState<'Action, 'FunctionName, 'Principal> =
            state.assignments.Add(fun config -> config.Qualifier <- value)
            state : LambdaPermissionState<'Action, 'FunctionName, 'Principal>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_permission#source_account-1">LambdaPermission#source_account</a>.
        /// </summary>
        [<CustomOperation "source_account">]
        member _.SourceAccount(state: LambdaPermissionState<'Action, 'FunctionName, 'Principal>, value: string) : LambdaPermissionState<'Action, 'FunctionName, 'Principal> =
            state.assignments.Add(fun config -> config.SourceAccount <- value)
            state : LambdaPermissionState<'Action, 'FunctionName, 'Principal>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_permission#source_arn-1">LambdaPermission#source_arn</a>.
        /// </summary>
        [<CustomOperation "source_arn">]
        member _.SourceArn(state: LambdaPermissionState<'Action, 'FunctionName, 'Principal>, value: string) : LambdaPermissionState<'Action, 'FunctionName, 'Principal> =
            state.assignments.Add(fun config -> config.SourceArn <- value)
            state : LambdaPermissionState<'Action, 'FunctionName, 'Principal>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_permission#statement_id-1">LambdaPermission#statement_id</a>.
        /// </summary>
        [<CustomOperation "statement_id">]
        member _.StatementId(state: LambdaPermissionState<'Action, 'FunctionName, 'Principal>, value: string) : LambdaPermissionState<'Action, 'FunctionName, 'Principal> =
            state.assignments.Add(fun config -> config.StatementId <- value)
            state : LambdaPermissionState<'Action, 'FunctionName, 'Principal>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_permission#statement_id_prefix-1">LambdaPermission#statement_id_prefix</a>.
        /// </summary>
        [<CustomOperation "statement_id_prefix">]
        member _.StatementIdPrefix(state: LambdaPermissionState<'Action, 'FunctionName, 'Principal>, value: string) : LambdaPermissionState<'Action, 'FunctionName, 'Principal> =
            state.assignments.Add(fun config -> config.StatementIdPrefix <- value)
            state : LambdaPermissionState<'Action, 'FunctionName, 'Principal>

        member _.Run(state: LambdaPermissionState<Present, Present, Present>) : aws.LambdaPermission.LambdaPermission =
            let config = aws.LambdaPermission.LambdaPermissionConfig()
            for setter in state.assignments do
                setter config
            aws.LambdaPermission.LambdaPermission(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lambdaPermission: missing required arguments. Must call: action, function_name, principal.", 9999, IsError = true)>]
        member _.Run(_: LambdaPermissionState<_, _, _>) : aws.LambdaPermission.LambdaPermission =
            Unchecked.defaultof<aws.LambdaPermission.LambdaPermission>
