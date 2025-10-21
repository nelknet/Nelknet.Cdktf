namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CognitoUserInGroupState<'GroupName, 'Username, 'UserPoolId> = { assignments: ResizeArray<aws.CognitoUserInGroup.CognitoUserInGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_in_group">aws_cognito_user_in_group</a>.
    /// </summary>
    type CognitoUserInGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : CognitoUserInGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitoUserInGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : CognitoUserInGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitoUserInGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_in_group#group_name-1">CognitoUserInGroup#group_name</a>.
        /// </summary>
        [<CustomOperation "group_name">]
        member _.GroupName(state: CognitoUserInGroupState<Missing, 'Username, 'UserPoolId>, value: string) : CognitoUserInGroupState<Present, 'Username, 'UserPoolId> =
            state.assignments.Add(fun config -> config.GroupName <- value)
            ({ assignments = state.assignments } : CognitoUserInGroupState<Present, 'Username, 'UserPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_in_group#username-1">CognitoUserInGroup#username</a>.
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: CognitoUserInGroupState<'GroupName, Missing, 'UserPoolId>, value: string) : CognitoUserInGroupState<'GroupName, Present, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Username <- value)
            ({ assignments = state.assignments } : CognitoUserInGroupState<'GroupName, Present, 'UserPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_in_group#user_pool_id-1">CognitoUserInGroup#user_pool_id</a>.
        /// </summary>
        [<CustomOperation "user_pool_id">]
        member _.UserPoolId(state: CognitoUserInGroupState<'GroupName, 'Username, Missing>, value: string) : CognitoUserInGroupState<'GroupName, 'Username, Present> =
            state.assignments.Add(fun config -> config.UserPoolId <- value)
            ({ assignments = state.assignments } : CognitoUserInGroupState<'GroupName, 'Username, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_in_group#id-1">CognitoUserInGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CognitoUserInGroupState<'GroupName, 'Username, 'UserPoolId>, value: string) : CognitoUserInGroupState<'GroupName, 'Username, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CognitoUserInGroupState<'GroupName, 'Username, 'UserPoolId>

        member _.Run(state: CognitoUserInGroupState<Present, Present, Present>) : aws.CognitoUserInGroup.CognitoUserInGroup =
            let config = aws.CognitoUserInGroup.CognitoUserInGroupConfig()
            for setter in state.assignments do
                setter config
            aws.CognitoUserInGroup.CognitoUserInGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cognitoUserInGroup: missing required arguments. Must call: group_name, username, user_pool_id.", 9999, IsError = true)>]
        member _.Run(_: CognitoUserInGroupState<_, _, _>) : aws.CognitoUserInGroup.CognitoUserInGroup =
            Unchecked.defaultof<aws.CognitoUserInGroup.CognitoUserInGroup>
