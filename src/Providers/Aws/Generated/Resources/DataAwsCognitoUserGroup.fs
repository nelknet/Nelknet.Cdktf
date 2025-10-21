namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCognitoUserGroupState<'Name, 'UserPoolId> = { assignments: ResizeArray<aws.DataAwsCognitoUserGroup.DataAwsCognitoUserGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_group">aws_cognito_user_group</a>.
    /// </summary>
    type DataAwsCognitoUserGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCognitoUserGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsCognitoUserGroupState<Missing, Missing>)

        member _.Zero(()) : DataAwsCognitoUserGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsCognitoUserGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_group#name-1">DataAwsCognitoUserGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsCognitoUserGroupState<Missing, 'UserPoolId>, value: string) : DataAwsCognitoUserGroupState<Present, 'UserPoolId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsCognitoUserGroupState<Present, 'UserPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_group#user_pool_id-1">DataAwsCognitoUserGroup#user_pool_id</a>.
        /// </summary>
        [<CustomOperation "user_pool_id">]
        member _.UserPoolId(state: DataAwsCognitoUserGroupState<'Name, Missing>, value: string) : DataAwsCognitoUserGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.UserPoolId <- value)
            ({ assignments = state.assignments } : DataAwsCognitoUserGroupState<'Name, Present>)

        member _.Run(state: DataAwsCognitoUserGroupState<Present, Present>) : aws.DataAwsCognitoUserGroup.DataAwsCognitoUserGroup =
            let config = aws.DataAwsCognitoUserGroup.DataAwsCognitoUserGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCognitoUserGroup.DataAwsCognitoUserGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCognitoUserGroup: missing required arguments. Must call: name, user_pool_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCognitoUserGroupState<_, _>) : aws.DataAwsCognitoUserGroup.DataAwsCognitoUserGroup =
            Unchecked.defaultof<aws.DataAwsCognitoUserGroup.DataAwsCognitoUserGroup>
