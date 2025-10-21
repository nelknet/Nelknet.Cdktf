namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CognitoUserState<'Username, 'UserPoolId> = { assignments: ResizeArray<aws.CognitoUser.CognitoUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user">aws_cognito_user</a>.
    /// </summary>
    type CognitoUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : CognitoUserState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitoUserState<Missing, Missing>)

        member _.Zero(()) : CognitoUserState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitoUserState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user#username-1">CognitoUser#username</a>.
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: CognitoUserState<Missing, 'UserPoolId>, value: string) : CognitoUserState<Present, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Username <- value)
            ({ assignments = state.assignments } : CognitoUserState<Present, 'UserPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user#user_pool_id-1">CognitoUser#user_pool_id</a>.
        /// </summary>
        [<CustomOperation "user_pool_id">]
        member _.UserPoolId(state: CognitoUserState<'Username, Missing>, value: string) : CognitoUserState<'Username, Present> =
            state.assignments.Add(fun config -> config.UserPoolId <- value)
            ({ assignments = state.assignments } : CognitoUserState<'Username, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user#attributes-1">CognitoUser#attributes</a>.
        /// </summary>
        [<CustomOperation "attributes">]
        member _.Attributes(state: CognitoUserState<'Username, 'UserPoolId>, value: seq<string * string>) : CognitoUserState<'Username, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Attributes <- dict value)
            state : CognitoUserState<'Username, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user#client_metadata-1">CognitoUser#client_metadata</a>.
        /// </summary>
        [<CustomOperation "client_metadata">]
        member _.ClientMetadata(state: CognitoUserState<'Username, 'UserPoolId>, value: seq<string * string>) : CognitoUserState<'Username, 'UserPoolId> =
            state.assignments.Add(fun config -> config.ClientMetadata <- dict value)
            state : CognitoUserState<'Username, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user#desired_delivery_mediums-1">CognitoUser#desired_delivery_mediums</a>.
        /// </summary>
        [<CustomOperation "desired_delivery_mediums">]
        member _.DesiredDeliveryMediums(state: CognitoUserState<'Username, 'UserPoolId>, value: seq<string>) : CognitoUserState<'Username, 'UserPoolId> =
            state.assignments.Add(fun config -> config.DesiredDeliveryMediums <- (value |> Seq.toArray))
            state : CognitoUserState<'Username, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user#enabled-1">CognitoUser#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: CognitoUserState<'Username, 'UserPoolId>, value: bool) : CognitoUserState<'Username, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : CognitoUserState<'Username, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user#enabled-1">CognitoUser#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: CognitoUserState<'Username, 'UserPoolId>, value: HashiCorp.Cdktf.IResolvable) : CognitoUserState<'Username, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : CognitoUserState<'Username, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user#force_alias_creation-1">CognitoUser#force_alias_creation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_alias_creation">]
        member _.ForceAliasCreation(state: CognitoUserState<'Username, 'UserPoolId>, value: bool) : CognitoUserState<'Username, 'UserPoolId> =
            state.assignments.Add(fun config -> config.ForceAliasCreation <- value)
            state : CognitoUserState<'Username, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user#force_alias_creation-1">CognitoUser#force_alias_creation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_alias_creation">]
        member _.ForceAliasCreation(state: CognitoUserState<'Username, 'UserPoolId>, value: HashiCorp.Cdktf.IResolvable) : CognitoUserState<'Username, 'UserPoolId> =
            state.assignments.Add(fun config -> config.ForceAliasCreation <- value)
            state : CognitoUserState<'Username, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user#id-1">CognitoUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CognitoUserState<'Username, 'UserPoolId>, value: string) : CognitoUserState<'Username, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CognitoUserState<'Username, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user#message_action-1">CognitoUser#message_action</a>.
        /// </summary>
        [<CustomOperation "message_action">]
        member _.MessageAction(state: CognitoUserState<'Username, 'UserPoolId>, value: string) : CognitoUserState<'Username, 'UserPoolId> =
            state.assignments.Add(fun config -> config.MessageAction <- value)
            state : CognitoUserState<'Username, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user#password-1">CognitoUser#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: CognitoUserState<'Username, 'UserPoolId>, value: string) : CognitoUserState<'Username, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Password <- value)
            state : CognitoUserState<'Username, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user#temporary_password-1">CognitoUser#temporary_password</a>.
        /// </summary>
        [<CustomOperation "temporary_password">]
        member _.TemporaryPassword(state: CognitoUserState<'Username, 'UserPoolId>, value: string) : CognitoUserState<'Username, 'UserPoolId> =
            state.assignments.Add(fun config -> config.TemporaryPassword <- value)
            state : CognitoUserState<'Username, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user#validation_data-1">CognitoUser#validation_data</a>.
        /// </summary>
        [<CustomOperation "validation_data">]
        member _.ValidationData(state: CognitoUserState<'Username, 'UserPoolId>, value: seq<string * string>) : CognitoUserState<'Username, 'UserPoolId> =
            state.assignments.Add(fun config -> config.ValidationData <- dict value)
            state : CognitoUserState<'Username, 'UserPoolId>

        member _.Run(state: CognitoUserState<Present, Present>) : aws.CognitoUser.CognitoUser =
            let config = aws.CognitoUser.CognitoUserConfig()
            for setter in state.assignments do
                setter config
            aws.CognitoUser.CognitoUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cognitoUser: missing required arguments. Must call: username, user_pool_id.", 9999, IsError = true)>]
        member _.Run(_: CognitoUserState<_, _>) : aws.CognitoUser.CognitoUser =
            Unchecked.defaultof<aws.CognitoUser.CognitoUser>
