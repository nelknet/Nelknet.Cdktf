namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FinspaceKxUserState<'EnvironmentId, 'IamRole, 'Name> = { assignments: ResizeArray<aws.FinspaceKxUser.FinspaceKxUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_user">aws_finspace_kx_user</a>.
    /// </summary>
    type FinspaceKxUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : FinspaceKxUserState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FinspaceKxUserState<Missing, Missing, Missing>)

        member _.Zero(()) : FinspaceKxUserState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FinspaceKxUserState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_user#environment_id-1">FinspaceKxUser#environment_id</a>.
        /// </summary>
        [<CustomOperation "environment_id">]
        member _.EnvironmentId(state: FinspaceKxUserState<Missing, 'IamRole, 'Name>, value: string) : FinspaceKxUserState<Present, 'IamRole, 'Name> =
            state.assignments.Add(fun config -> config.EnvironmentId <- value)
            ({ assignments = state.assignments } : FinspaceKxUserState<Present, 'IamRole, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_user#iam_role-1">FinspaceKxUser#iam_role</a>.
        /// </summary>
        [<CustomOperation "iam_role">]
        member _.IamRole(state: FinspaceKxUserState<'EnvironmentId, Missing, 'Name>, value: string) : FinspaceKxUserState<'EnvironmentId, Present, 'Name> =
            state.assignments.Add(fun config -> config.IamRole <- value)
            ({ assignments = state.assignments } : FinspaceKxUserState<'EnvironmentId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_user#name-1">FinspaceKxUser#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FinspaceKxUserState<'EnvironmentId, 'IamRole, Missing>, value: string) : FinspaceKxUserState<'EnvironmentId, 'IamRole, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FinspaceKxUserState<'EnvironmentId, 'IamRole, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_user#id-1">FinspaceKxUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FinspaceKxUserState<'EnvironmentId, 'IamRole, 'Name>, value: string) : FinspaceKxUserState<'EnvironmentId, 'IamRole, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FinspaceKxUserState<'EnvironmentId, 'IamRole, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_user#tags-1">FinspaceKxUser#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FinspaceKxUserState<'EnvironmentId, 'IamRole, 'Name>, value: seq<string * string>) : FinspaceKxUserState<'EnvironmentId, 'IamRole, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FinspaceKxUserState<'EnvironmentId, 'IamRole, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_user#tags_all-1">FinspaceKxUser#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FinspaceKxUserState<'EnvironmentId, 'IamRole, 'Name>, value: seq<string * string>) : FinspaceKxUserState<'EnvironmentId, 'IamRole, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FinspaceKxUserState<'EnvironmentId, 'IamRole, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_user#timeouts-1">FinspaceKxUser#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FinspaceKxUserState<'EnvironmentId, 'IamRole, 'Name>, value: aws.FinspaceKxUser.FinspaceKxUserTimeouts) : FinspaceKxUserState<'EnvironmentId, 'IamRole, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FinspaceKxUserState<'EnvironmentId, 'IamRole, 'Name>

        member _.Run(state: FinspaceKxUserState<Present, Present, Present>) : aws.FinspaceKxUser.FinspaceKxUser =
            let config = aws.FinspaceKxUser.FinspaceKxUserConfig()
            for setter in state.assignments do
                setter config
            aws.FinspaceKxUser.FinspaceKxUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.finspaceKxUser: missing required arguments. Must call: environment_id, iam_role, name.", 9999, IsError = true)>]
        member _.Run(_: FinspaceKxUserState<_, _, _>) : aws.FinspaceKxUser.FinspaceKxUser =
            Unchecked.defaultof<aws.FinspaceKxUser.FinspaceKxUser>
