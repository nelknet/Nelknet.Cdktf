namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CognitoRiskConfigurationState<'UserPoolId> = { assignments: ResizeArray<aws.CognitoRiskConfiguration.CognitoRiskConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration">aws_cognito_risk_configuration</a>.
    /// </summary>
    type CognitoRiskConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : CognitoRiskConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : CognitoRiskConfigurationState<Missing>)

        member _.Zero(()) : CognitoRiskConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : CognitoRiskConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#user_pool_id-1">CognitoRiskConfiguration#user_pool_id</a>.
        /// </summary>
        [<CustomOperation "user_pool_id">]
        member _.UserPoolId(state: CognitoRiskConfigurationState<Missing>, value: string) : CognitoRiskConfigurationState<Present> =
            state.assignments.Add(fun config -> config.UserPoolId <- value)
            ({ assignments = state.assignments } : CognitoRiskConfigurationState<Present>)

        /// <summary>
        /// account_takeover_risk_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#account_takeover_risk_configuration-1">CognitoRiskConfiguration#account_takeover_risk_configuration</a>
        /// </summary>
        [<CustomOperation "account_takeover_risk_configuration">]
        member _.AccountTakeoverRiskConfiguration(state: CognitoRiskConfigurationState<'UserPoolId>, value: aws.CognitoRiskConfiguration.CognitoRiskConfigurationAccountTakeoverRiskConfiguration) : CognitoRiskConfigurationState<'UserPoolId> =
            state.assignments.Add(fun config -> config.AccountTakeoverRiskConfiguration <- value)
            state : CognitoRiskConfigurationState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#client_id-1">CognitoRiskConfiguration#client_id</a>.
        /// </summary>
        [<CustomOperation "client_id">]
        member _.ClientId(state: CognitoRiskConfigurationState<'UserPoolId>, value: string) : CognitoRiskConfigurationState<'UserPoolId> =
            state.assignments.Add(fun config -> config.ClientId <- value)
            state : CognitoRiskConfigurationState<'UserPoolId>

        /// <summary>
        /// compromised_credentials_risk_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#compromised_credentials_risk_configuration-1">CognitoRiskConfiguration#compromised_credentials_risk_configuration</a>
        /// </summary>
        [<CustomOperation "compromised_credentials_risk_configuration">]
        member _.CompromisedCredentialsRiskConfiguration(state: CognitoRiskConfigurationState<'UserPoolId>, value: aws.CognitoRiskConfiguration.CognitoRiskConfigurationCompromisedCredentialsRiskConfiguration) : CognitoRiskConfigurationState<'UserPoolId> =
            state.assignments.Add(fun config -> config.CompromisedCredentialsRiskConfiguration <- value)
            state : CognitoRiskConfigurationState<'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#id-1">CognitoRiskConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CognitoRiskConfigurationState<'UserPoolId>, value: string) : CognitoRiskConfigurationState<'UserPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CognitoRiskConfigurationState<'UserPoolId>

        /// <summary>
        /// risk_exception_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_risk_configuration#risk_exception_configuration-1">CognitoRiskConfiguration#risk_exception_configuration</a>
        /// </summary>
        [<CustomOperation "risk_exception_configuration">]
        member _.RiskExceptionConfiguration(state: CognitoRiskConfigurationState<'UserPoolId>, value: aws.CognitoRiskConfiguration.CognitoRiskConfigurationRiskExceptionConfiguration) : CognitoRiskConfigurationState<'UserPoolId> =
            state.assignments.Add(fun config -> config.RiskExceptionConfiguration <- value)
            state : CognitoRiskConfigurationState<'UserPoolId>

        member _.Run(state: CognitoRiskConfigurationState<Present>) : aws.CognitoRiskConfiguration.CognitoRiskConfiguration =
            let config = aws.CognitoRiskConfiguration.CognitoRiskConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.CognitoRiskConfiguration.CognitoRiskConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cognitoRiskConfiguration: missing required arguments. Must call: user_pool_id.", 9999, IsError = true)>]
        member _.Run(_: CognitoRiskConfigurationState<_>) : aws.CognitoRiskConfiguration.CognitoRiskConfiguration =
            Unchecked.defaultof<aws.CognitoRiskConfiguration.CognitoRiskConfiguration>
