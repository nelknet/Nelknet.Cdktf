namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCognitoUserGroupsState<'UserPoolId> = { assignments: ResizeArray<aws.DataAwsCognitoUserGroups.DataAwsCognitoUserGroupsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_groups">aws_cognito_user_groups</a>.
    /// </summary>
    type DataAwsCognitoUserGroupsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCognitoUserGroupsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCognitoUserGroupsState<Missing>)

        member _.Zero(()) : DataAwsCognitoUserGroupsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCognitoUserGroupsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_groups#user_pool_id-1">DataAwsCognitoUserGroups#user_pool_id</a>.
        /// </summary>
        [<CustomOperation "user_pool_id">]
        member _.UserPoolId(state: DataAwsCognitoUserGroupsState<Missing>, value: string) : DataAwsCognitoUserGroupsState<Present> =
            state.assignments.Add(fun config -> config.UserPoolId <- value)
            ({ assignments = state.assignments } : DataAwsCognitoUserGroupsState<Present>)

        member _.Run(state: DataAwsCognitoUserGroupsState<Present>) : aws.DataAwsCognitoUserGroups.DataAwsCognitoUserGroups =
            let config = aws.DataAwsCognitoUserGroups.DataAwsCognitoUserGroupsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCognitoUserGroups.DataAwsCognitoUserGroups(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCognitoUserGroups: missing required arguments. Must call: user_pool_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCognitoUserGroupsState<_>) : aws.DataAwsCognitoUserGroups.DataAwsCognitoUserGroups =
            Unchecked.defaultof<aws.DataAwsCognitoUserGroups.DataAwsCognitoUserGroups>
