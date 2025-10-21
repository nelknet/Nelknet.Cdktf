namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OrganizationsAccountState<'Email, 'Name> = { assignments: ResizeArray<aws.OrganizationsAccount.OrganizationsAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_account">aws_organizations_account</a>.
    /// </summary>
    type OrganizationsAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : OrganizationsAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OrganizationsAccountState<Missing, Missing>)

        member _.Zero(()) : OrganizationsAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OrganizationsAccountState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_account#email-1">OrganizationsAccount#email</a>.
        /// </summary>
        [<CustomOperation "email">]
        member _.Email(state: OrganizationsAccountState<Missing, 'Name>, value: string) : OrganizationsAccountState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Email <- value)
            ({ assignments = state.assignments } : OrganizationsAccountState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_account#name-1">OrganizationsAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OrganizationsAccountState<'Email, Missing>, value: string) : OrganizationsAccountState<'Email, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : OrganizationsAccountState<'Email, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_account#close_on_deletion-1">OrganizationsAccount#close_on_deletion</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "close_on_deletion">]
        member _.CloseOnDeletion(state: OrganizationsAccountState<'Email, 'Name>, value: bool) : OrganizationsAccountState<'Email, 'Name> =
            state.assignments.Add(fun config -> config.CloseOnDeletion <- value)
            state : OrganizationsAccountState<'Email, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_account#close_on_deletion-1">OrganizationsAccount#close_on_deletion</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "close_on_deletion">]
        member _.CloseOnDeletion(state: OrganizationsAccountState<'Email, 'Name>, value: HashiCorp.Cdktf.IResolvable) : OrganizationsAccountState<'Email, 'Name> =
            state.assignments.Add(fun config -> config.CloseOnDeletion <- value)
            state : OrganizationsAccountState<'Email, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_account#create_govcloud-1">OrganizationsAccount#create_govcloud</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "create_govcloud">]
        member _.CreateGovcloud(state: OrganizationsAccountState<'Email, 'Name>, value: bool) : OrganizationsAccountState<'Email, 'Name> =
            state.assignments.Add(fun config -> config.CreateGovcloud <- value)
            state : OrganizationsAccountState<'Email, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_account#create_govcloud-1">OrganizationsAccount#create_govcloud</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "create_govcloud">]
        member _.CreateGovcloud(state: OrganizationsAccountState<'Email, 'Name>, value: HashiCorp.Cdktf.IResolvable) : OrganizationsAccountState<'Email, 'Name> =
            state.assignments.Add(fun config -> config.CreateGovcloud <- value)
            state : OrganizationsAccountState<'Email, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_account#iam_user_access_to_billing-1">OrganizationsAccount#iam_user_access_to_billing</a>.
        /// </summary>
        [<CustomOperation "iam_user_access_to_billing">]
        member _.IamUserAccessToBilling(state: OrganizationsAccountState<'Email, 'Name>, value: string) : OrganizationsAccountState<'Email, 'Name> =
            state.assignments.Add(fun config -> config.IamUserAccessToBilling <- value)
            state : OrganizationsAccountState<'Email, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_account#id-1">OrganizationsAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OrganizationsAccountState<'Email, 'Name>, value: string) : OrganizationsAccountState<'Email, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OrganizationsAccountState<'Email, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_account#parent_id-1">OrganizationsAccount#parent_id</a>.
        /// </summary>
        [<CustomOperation "parent_id">]
        member _.ParentId(state: OrganizationsAccountState<'Email, 'Name>, value: string) : OrganizationsAccountState<'Email, 'Name> =
            state.assignments.Add(fun config -> config.ParentId <- value)
            state : OrganizationsAccountState<'Email, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_account#role_name-1">OrganizationsAccount#role_name</a>.
        /// </summary>
        [<CustomOperation "role_name">]
        member _.RoleName(state: OrganizationsAccountState<'Email, 'Name>, value: string) : OrganizationsAccountState<'Email, 'Name> =
            state.assignments.Add(fun config -> config.RoleName <- value)
            state : OrganizationsAccountState<'Email, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_account#tags-1">OrganizationsAccount#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OrganizationsAccountState<'Email, 'Name>, value: seq<string * string>) : OrganizationsAccountState<'Email, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OrganizationsAccountState<'Email, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_account#tags_all-1">OrganizationsAccount#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: OrganizationsAccountState<'Email, 'Name>, value: seq<string * string>) : OrganizationsAccountState<'Email, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : OrganizationsAccountState<'Email, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_account#timeouts-1">OrganizationsAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OrganizationsAccountState<'Email, 'Name>, value: aws.OrganizationsAccount.OrganizationsAccountTimeouts) : OrganizationsAccountState<'Email, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OrganizationsAccountState<'Email, 'Name>

        member _.Run(state: OrganizationsAccountState<Present, Present>) : aws.OrganizationsAccount.OrganizationsAccount =
            let config = aws.OrganizationsAccount.OrganizationsAccountConfig()
            for setter in state.assignments do
                setter config
            aws.OrganizationsAccount.OrganizationsAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.organizationsAccount: missing required arguments. Must call: email, name.", 9999, IsError = true)>]
        member _.Run(_: OrganizationsAccountState<_, _>) : aws.OrganizationsAccount.OrganizationsAccount =
            Unchecked.defaultof<aws.OrganizationsAccount.OrganizationsAccount>
