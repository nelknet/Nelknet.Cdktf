namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OrganizationsResourcePolicyState<'Content> = { assignments: ResizeArray<aws.OrganizationsResourcePolicy.OrganizationsResourcePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_resource_policy">aws_organizations_resource_policy</a>.
    /// </summary>
    type OrganizationsResourcePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : OrganizationsResourcePolicyState<Missing> =
            ({ assignments = ResizeArray() } : OrganizationsResourcePolicyState<Missing>)

        member _.Zero(()) : OrganizationsResourcePolicyState<Missing> =
            ({ assignments = ResizeArray() } : OrganizationsResourcePolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_resource_policy#content-1">OrganizationsResourcePolicy#content</a>.
        /// </summary>
        [<CustomOperation "content">]
        member _.Content(state: OrganizationsResourcePolicyState<Missing>, value: string) : OrganizationsResourcePolicyState<Present> =
            state.assignments.Add(fun config -> config.Content <- value)
            ({ assignments = state.assignments } : OrganizationsResourcePolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_resource_policy#id-1">OrganizationsResourcePolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OrganizationsResourcePolicyState<'Content>, value: string) : OrganizationsResourcePolicyState<'Content> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OrganizationsResourcePolicyState<'Content>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_resource_policy#tags-1">OrganizationsResourcePolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OrganizationsResourcePolicyState<'Content>, value: seq<string * string>) : OrganizationsResourcePolicyState<'Content> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OrganizationsResourcePolicyState<'Content>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_resource_policy#tags_all-1">OrganizationsResourcePolicy#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: OrganizationsResourcePolicyState<'Content>, value: seq<string * string>) : OrganizationsResourcePolicyState<'Content> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : OrganizationsResourcePolicyState<'Content>

        member _.Run(state: OrganizationsResourcePolicyState<Present>) : aws.OrganizationsResourcePolicy.OrganizationsResourcePolicy =
            let config = aws.OrganizationsResourcePolicy.OrganizationsResourcePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.OrganizationsResourcePolicy.OrganizationsResourcePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.organizationsResourcePolicy: missing required arguments. Must call: content.", 9999, IsError = true)>]
        member _.Run(_: OrganizationsResourcePolicyState<_>) : aws.OrganizationsResourcePolicy.OrganizationsResourcePolicy =
            Unchecked.defaultof<aws.OrganizationsResourcePolicy.OrganizationsResourcePolicy>
