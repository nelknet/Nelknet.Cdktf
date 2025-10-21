namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamUserState<'Name> = { assignments: ResizeArray<aws.IamUser.IamUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user">aws_iam_user</a>.
    /// </summary>
    type IamUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamUserState<Missing> =
            ({ assignments = ResizeArray() } : IamUserState<Missing>)

        member _.Zero(()) : IamUserState<Missing> =
            ({ assignments = ResizeArray() } : IamUserState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user#name-1">IamUser#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IamUserState<Missing>, value: string) : IamUserState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IamUserState<Present>)

        /// <summary>
        /// Delete user even if it has non-Terraform-managed IAM access keys, login profile or MFA devices. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user#force_destroy-1">IamUser#force_destroy</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: IamUserState<'Name>, value: bool) : IamUserState<'Name> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : IamUserState<'Name>

        /// <summary>
        /// Delete user even if it has non-Terraform-managed IAM access keys, login profile or MFA devices. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user#force_destroy-1">IamUser#force_destroy</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: IamUserState<'Name>, value: HashiCorp.Cdktf.IResolvable) : IamUserState<'Name> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : IamUserState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user#id-1">IamUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamUserState<'Name>, value: string) : IamUserState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamUserState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user#path-1">IamUser#path</a>.
        /// </summary>
        [<CustomOperation "path">]
        member _.Path(state: IamUserState<'Name>, value: string) : IamUserState<'Name> =
            state.assignments.Add(fun config -> config.Path <- value)
            state : IamUserState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user#permissions_boundary-1">IamUser#permissions_boundary</a>.
        /// </summary>
        [<CustomOperation "permissions_boundary">]
        member _.PermissionsBoundary(state: IamUserState<'Name>, value: string) : IamUserState<'Name> =
            state.assignments.Add(fun config -> config.PermissionsBoundary <- value)
            state : IamUserState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user#tags-1">IamUser#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IamUserState<'Name>, value: seq<string * string>) : IamUserState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IamUserState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user#tags_all-1">IamUser#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IamUserState<'Name>, value: seq<string * string>) : IamUserState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IamUserState<'Name>

        member _.Run(state: IamUserState<Present>) : aws.IamUser.IamUser =
            let config = aws.IamUser.IamUserConfig()
            for setter in state.assignments do
                setter config
            aws.IamUser.IamUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamUser: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: IamUserState<_>) : aws.IamUser.IamUser =
            Unchecked.defaultof<aws.IamUser.IamUser>
