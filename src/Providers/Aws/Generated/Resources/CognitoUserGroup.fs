namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CognitoUserGroupState<'Name, 'UserPoolId> = { assignments: ResizeArray<aws.CognitoUserGroup.CognitoUserGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_group">aws_cognito_user_group</a>.
    /// </summary>
    type CognitoUserGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : CognitoUserGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitoUserGroupState<Missing, Missing>)

        member _.Zero(()) : CognitoUserGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitoUserGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_group#name-1">CognitoUserGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CognitoUserGroupState<Missing, 'UserPoolId>, value: string) : CognitoUserGroupState<Present, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CognitoUserGroupState<Present, 'UserPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_group#user_pool_id-1">CognitoUserGroup#user_pool_id</a>.
        /// </summary>
        [<CustomOperation "user_pool_id">]
        member _.UserPoolId(state: CognitoUserGroupState<'Name, Missing>, value: string) : CognitoUserGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.UserPoolId <- value)
            ({ assignments = state.assignments } : CognitoUserGroupState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_group#description-1">CognitoUserGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: CognitoUserGroupState<'Name, 'UserPoolId>, value: string) : CognitoUserGroupState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : CognitoUserGroupState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_group#id-1">CognitoUserGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CognitoUserGroupState<'Name, 'UserPoolId>, value: string) : CognitoUserGroupState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CognitoUserGroupState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_group#precedence-1">CognitoUserGroup#precedence</a>.
        /// </summary>
        [<CustomOperation "precedence">]
        member _.Precedence(state: CognitoUserGroupState<'Name, 'UserPoolId>, value: double) : CognitoUserGroupState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Precedence <- value)
            state : CognitoUserGroupState<'Name, 'UserPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_group#role_arn-1">CognitoUserGroup#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: CognitoUserGroupState<'Name, 'UserPoolId>, value: string) : CognitoUserGroupState<'Name, 'UserPoolId> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            state : CognitoUserGroupState<'Name, 'UserPoolId>

        member _.Run(state: CognitoUserGroupState<Present, Present>) : aws.CognitoUserGroup.CognitoUserGroup =
            let config = aws.CognitoUserGroup.CognitoUserGroupConfig()
            for setter in state.assignments do
                setter config
            aws.CognitoUserGroup.CognitoUserGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cognitoUserGroup: missing required arguments. Must call: name, user_pool_id.", 9999, IsError = true)>]
        member _.Run(_: CognitoUserGroupState<_, _>) : aws.CognitoUserGroup.CognitoUserGroup =
            Unchecked.defaultof<aws.CognitoUserGroup.CognitoUserGroup>
