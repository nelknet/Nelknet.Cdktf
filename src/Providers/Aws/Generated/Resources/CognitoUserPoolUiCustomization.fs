namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CognitoUserPoolUiCustomizationState<'UserPoolId> = { assignments: ResizeArray<aws.CognitoUserPoolUiCustomization.CognitoUserPoolUiCustomizationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_ui_customization">aws_cognito_user_pool_ui_customization</a>.
    /// </summary>
    type CognitoUserPoolUiCustomizationBuilder(logicalId: string) =
        member _.Yield(_: unit) : CognitoUserPoolUiCustomizationState<Missing> =
            ({ assignments = ResizeArray() } : CognitoUserPoolUiCustomizationState<Missing>)

        member _.Zero(()) : CognitoUserPoolUiCustomizationState<Missing> =
            ({ assignments = ResizeArray() } : CognitoUserPoolUiCustomizationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_ui_customization#user_pool_id-1">CognitoUserPoolUiCustomization#user_pool_id</a>.
        /// </summary>
        [<CustomOperation "user_pool_id">]
        member _.UserPoolId(state: CognitoUserPoolUiCustomizationState<Missing>, value: string) : CognitoUserPoolUiCustomizationState<Present> =
            state.assignments.Add(fun config -> config.UserPoolId <- value)
            ({ assignments = state.assignments } : CognitoUserPoolUiCustomizationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_ui_customization#client_id-1">CognitoUserPoolUiCustomization#client_id</a>.
        /// </summary>
        [<CustomOperation "client_id">]
        member _.ClientId(state: CognitoUserPoolUiCustomizationState<'UserPoolId>, value: string) : CognitoUserPoolUiCustomizationState<'UserPoolId> =
            state.assignments.Add(fun config -> config.ClientId <- value)
            state : CognitoUserPoolUiCustomizationState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_ui_customization#css-1">CognitoUserPoolUiCustomization#css</a>.
        /// </summary>
        [<CustomOperation "css">]
        member _.Css(state: CognitoUserPoolUiCustomizationState<'UserPoolId>, value: string) : CognitoUserPoolUiCustomizationState<'UserPoolId> =
            state.assignments.Add(fun config -> config.Css <- value)
            state : CognitoUserPoolUiCustomizationState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_ui_customization#id-1">CognitoUserPoolUiCustomization#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CognitoUserPoolUiCustomizationState<'UserPoolId>, value: string) : CognitoUserPoolUiCustomizationState<'UserPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CognitoUserPoolUiCustomizationState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool_ui_customization#image_file-1">CognitoUserPoolUiCustomization#image_file</a>.
        /// </summary>
        [<CustomOperation "image_file">]
        member _.ImageFile(state: CognitoUserPoolUiCustomizationState<'UserPoolId>, value: string) : CognitoUserPoolUiCustomizationState<'UserPoolId> =
            state.assignments.Add(fun config -> config.ImageFile <- value)
            state : CognitoUserPoolUiCustomizationState<'UserPoolId>

        member _.Run(state: CognitoUserPoolUiCustomizationState<Present>) : aws.CognitoUserPoolUiCustomization.CognitoUserPoolUiCustomization =
            let config = aws.CognitoUserPoolUiCustomization.CognitoUserPoolUiCustomizationConfig()
            for setter in state.assignments do
                setter config
            aws.CognitoUserPoolUiCustomization.CognitoUserPoolUiCustomization(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cognitoUserPoolUiCustomization: missing required arguments. Must call: user_pool_id.", 9999, IsError = true)>]
        member _.Run(_: CognitoUserPoolUiCustomizationState<_>) : aws.CognitoUserPoolUiCustomization.CognitoUserPoolUiCustomization =
            Unchecked.defaultof<aws.CognitoUserPoolUiCustomization.CognitoUserPoolUiCustomization>
