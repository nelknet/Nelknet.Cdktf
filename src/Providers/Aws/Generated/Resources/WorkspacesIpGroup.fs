namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WorkspacesIpGroupState<'Name> = { assignments: ResizeArray<aws.WorkspacesIpGroup.WorkspacesIpGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_ip_group">aws_workspaces_ip_group</a>.
    /// </summary>
    type WorkspacesIpGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : WorkspacesIpGroupState<Missing> =
            ({ assignments = ResizeArray() } : WorkspacesIpGroupState<Missing>)

        member _.Zero(()) : WorkspacesIpGroupState<Missing> =
            ({ assignments = ResizeArray() } : WorkspacesIpGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_ip_group#name-1">WorkspacesIpGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WorkspacesIpGroupState<Missing>, value: string) : WorkspacesIpGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WorkspacesIpGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_ip_group#description-1">WorkspacesIpGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: WorkspacesIpGroupState<'Name>, value: string) : WorkspacesIpGroupState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : WorkspacesIpGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_ip_group#id-1">WorkspacesIpGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WorkspacesIpGroupState<'Name>, value: string) : WorkspacesIpGroupState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WorkspacesIpGroupState<'Name>

        /// <summary>
        /// rules block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_ip_group#rules-1">WorkspacesIpGroup#rules</a> Accepts: aws.IResolvable | aws.WorkspacesIpGroup.WorkspacesIpGroupRules[]
        /// </summary>
        [<CustomOperation "rules">]
        member _.Rules(state: WorkspacesIpGroupState<'Name>, value: HashiCorp.Cdktf.IResolvable) : WorkspacesIpGroupState<'Name> =
            state.assignments.Add(fun config -> config.Rules <- value)
            state : WorkspacesIpGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_ip_group#tags-1">WorkspacesIpGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WorkspacesIpGroupState<'Name>, value: seq<string * string>) : WorkspacesIpGroupState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WorkspacesIpGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_ip_group#tags_all-1">WorkspacesIpGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: WorkspacesIpGroupState<'Name>, value: seq<string * string>) : WorkspacesIpGroupState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : WorkspacesIpGroupState<'Name>

        member _.Run(state: WorkspacesIpGroupState<Present>) : aws.WorkspacesIpGroup.WorkspacesIpGroup =
            let config = aws.WorkspacesIpGroup.WorkspacesIpGroupConfig()
            for setter in state.assignments do
                setter config
            aws.WorkspacesIpGroup.WorkspacesIpGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.workspacesIpGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: WorkspacesIpGroupState<_>) : aws.WorkspacesIpGroup.WorkspacesIpGroup =
            Unchecked.defaultof<aws.WorkspacesIpGroup.WorkspacesIpGroup>
