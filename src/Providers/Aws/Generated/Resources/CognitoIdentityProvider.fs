namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CognitoIdentityProviderState<'ProviderDetails, 'ProviderName, 'ProviderType, 'UserPoolId> = { assignments: ResizeArray<aws.CognitoIdentityProvider.CognitoIdentityProviderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_provider">aws_cognito_identity_provider</a>.
    /// </summary>
    type CognitoIdentityProviderBuilder(logicalId: string) =
        member _.Yield(_: unit) : CognitoIdentityProviderState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitoIdentityProviderState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CognitoIdentityProviderState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitoIdentityProviderState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_provider#provider_details-1">CognitoIdentityProvider#provider_details</a>.
        /// </summary>
        [<CustomOperation "provider_details">]
        member _.ProviderDetails(state: CognitoIdentityProviderState<Missing, 'ProviderName, 'ProviderType, 'UserPoolId>, value: seq<string * string>) : CognitoIdentityProviderState<Present, 'ProviderName, 'ProviderType, 'UserPoolId> =
            state.assignments.Add(fun config -> config.ProviderDetails <- dict value)
            ({ assignments = state.assignments } : CognitoIdentityProviderState<Present, 'ProviderName, 'ProviderType, 'UserPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_provider#provider_name-1">CognitoIdentityProvider#provider_name</a>.
        /// </summary>
        [<CustomOperation "provider_name">]
        member _.ProviderName(state: CognitoIdentityProviderState<'ProviderDetails, Missing, 'ProviderType, 'UserPoolId>, value: string) : CognitoIdentityProviderState<'ProviderDetails, Present, 'ProviderType, 'UserPoolId> =
            state.assignments.Add(fun config -> config.ProviderName <- value)
            ({ assignments = state.assignments } : CognitoIdentityProviderState<'ProviderDetails, Present, 'ProviderType, 'UserPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_provider#provider_type-1">CognitoIdentityProvider#provider_type</a>.
        /// </summary>
        [<CustomOperation "provider_type">]
        member _.ProviderType(state: CognitoIdentityProviderState<'ProviderDetails, 'ProviderName, Missing, 'UserPoolId>, value: string) : CognitoIdentityProviderState<'ProviderDetails, 'ProviderName, Present, 'UserPoolId> =
            state.assignments.Add(fun config -> config.ProviderType <- value)
            ({ assignments = state.assignments } : CognitoIdentityProviderState<'ProviderDetails, 'ProviderName, Present, 'UserPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_provider#user_pool_id-1">CognitoIdentityProvider#user_pool_id</a>.
        /// </summary>
        [<CustomOperation "user_pool_id">]
        member _.UserPoolId(state: CognitoIdentityProviderState<'ProviderDetails, 'ProviderName, 'ProviderType, Missing>, value: string) : CognitoIdentityProviderState<'ProviderDetails, 'ProviderName, 'ProviderType, Present> =
            state.assignments.Add(fun config -> config.UserPoolId <- value)
            ({ assignments = state.assignments } : CognitoIdentityProviderState<'ProviderDetails, 'ProviderName, 'ProviderType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_provider#attribute_mapping-1">CognitoIdentityProvider#attribute_mapping</a>.
        /// </summary>
        [<CustomOperation "attribute_mapping">]
        member _.AttributeMapping(state: CognitoIdentityProviderState<'ProviderDetails, 'ProviderName, 'ProviderType, 'UserPoolId>, value: seq<string * string>) : CognitoIdentityProviderState<'ProviderDetails, 'ProviderName, 'ProviderType, 'UserPoolId> =
            state.assignments.Add(fun config -> config.AttributeMapping <- dict value)
            state : CognitoIdentityProviderState<'ProviderDetails, 'ProviderName, 'ProviderType, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_provider#id-1">CognitoIdentityProvider#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CognitoIdentityProviderState<'ProviderDetails, 'ProviderName, 'ProviderType, 'UserPoolId>, value: string) : CognitoIdentityProviderState<'ProviderDetails, 'ProviderName, 'ProviderType, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CognitoIdentityProviderState<'ProviderDetails, 'ProviderName, 'ProviderType, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_provider#idp_identifiers-1">CognitoIdentityProvider#idp_identifiers</a>.
        /// </summary>
        [<CustomOperation "idp_identifiers">]
        member _.IdpIdentifiers(state: CognitoIdentityProviderState<'ProviderDetails, 'ProviderName, 'ProviderType, 'UserPoolId>, value: seq<string>) : CognitoIdentityProviderState<'ProviderDetails, 'ProviderName, 'ProviderType, 'UserPoolId> =
            state.assignments.Add(fun config -> config.IdpIdentifiers <- (value |> Seq.toArray))
            state : CognitoIdentityProviderState<'ProviderDetails, 'ProviderName, 'ProviderType, 'UserPoolId>

        member _.Run(state: CognitoIdentityProviderState<Present, Present, Present, Present>) : aws.CognitoIdentityProvider.CognitoIdentityProvider =
            let config = aws.CognitoIdentityProvider.CognitoIdentityProviderConfig()
            for setter in state.assignments do
                setter config
            aws.CognitoIdentityProvider.CognitoIdentityProvider(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cognitoIdentityProvider: missing required arguments. Must call: provider_details, provider_name, provider_type, user_pool_id.", 9999, IsError = true)>]
        member _.Run(_: CognitoIdentityProviderState<_, _, _, _>) : aws.CognitoIdentityProvider.CognitoIdentityProvider =
            Unchecked.defaultof<aws.CognitoIdentityProvider.CognitoIdentityProvider>
