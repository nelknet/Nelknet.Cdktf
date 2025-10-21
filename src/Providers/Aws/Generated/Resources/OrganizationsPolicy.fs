namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OrganizationsPolicyState<'Content, 'Name> = { assignments: ResizeArray<aws.OrganizationsPolicy.OrganizationsPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_policy">aws_organizations_policy</a>.
    /// </summary>
    type OrganizationsPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : OrganizationsPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OrganizationsPolicyState<Missing, Missing>)

        member _.Zero(()) : OrganizationsPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OrganizationsPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_policy#content-1">OrganizationsPolicy#content</a>.
        /// </summary>
        [<CustomOperation "content">]
        member _.Content(state: OrganizationsPolicyState<Missing, 'Name>, value: string) : OrganizationsPolicyState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Content <- value)
            ({ assignments = state.assignments } : OrganizationsPolicyState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_policy#name-1">OrganizationsPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OrganizationsPolicyState<'Content, Missing>, value: string) : OrganizationsPolicyState<'Content, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : OrganizationsPolicyState<'Content, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_policy#description-1">OrganizationsPolicy#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: OrganizationsPolicyState<'Content, 'Name>, value: string) : OrganizationsPolicyState<'Content, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : OrganizationsPolicyState<'Content, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_policy#id-1">OrganizationsPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OrganizationsPolicyState<'Content, 'Name>, value: string) : OrganizationsPolicyState<'Content, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OrganizationsPolicyState<'Content, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_policy#skip_destroy-1">OrganizationsPolicy#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: OrganizationsPolicyState<'Content, 'Name>, value: bool) : OrganizationsPolicyState<'Content, 'Name> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : OrganizationsPolicyState<'Content, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_policy#skip_destroy-1">OrganizationsPolicy#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: OrganizationsPolicyState<'Content, 'Name>, value: HashiCorp.Cdktf.IResolvable) : OrganizationsPolicyState<'Content, 'Name> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : OrganizationsPolicyState<'Content, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_policy#tags-1">OrganizationsPolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OrganizationsPolicyState<'Content, 'Name>, value: seq<string * string>) : OrganizationsPolicyState<'Content, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OrganizationsPolicyState<'Content, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_policy#tags_all-1">OrganizationsPolicy#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: OrganizationsPolicyState<'Content, 'Name>, value: seq<string * string>) : OrganizationsPolicyState<'Content, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : OrganizationsPolicyState<'Content, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_policy#type-1">OrganizationsPolicy#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: OrganizationsPolicyState<'Content, 'Name>, value: string) : OrganizationsPolicyState<'Content, 'Name> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : OrganizationsPolicyState<'Content, 'Name>

        member _.Run(state: OrganizationsPolicyState<Present, Present>) : aws.OrganizationsPolicy.OrganizationsPolicy =
            let config = aws.OrganizationsPolicy.OrganizationsPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.OrganizationsPolicy.OrganizationsPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.organizationsPolicy: missing required arguments. Must call: content, name.", 9999, IsError = true)>]
        member _.Run(_: OrganizationsPolicyState<_, _>) : aws.OrganizationsPolicy.OrganizationsPolicy =
            Unchecked.defaultof<aws.OrganizationsPolicy.OrganizationsPolicy>
