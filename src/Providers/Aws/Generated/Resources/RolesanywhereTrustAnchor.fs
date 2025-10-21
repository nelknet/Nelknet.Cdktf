namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RolesanywhereTrustAnchorState<'Name, 'Source> = { assignments: ResizeArray<aws.RolesanywhereTrustAnchor.RolesanywhereTrustAnchorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_trust_anchor">aws_rolesanywhere_trust_anchor</a>.
    /// </summary>
    type RolesanywhereTrustAnchorBuilder(logicalId: string) =
        member _.Yield(_: unit) : RolesanywhereTrustAnchorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RolesanywhereTrustAnchorState<Missing, Missing>)

        member _.Zero(()) : RolesanywhereTrustAnchorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RolesanywhereTrustAnchorState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_trust_anchor#name-1">RolesanywhereTrustAnchor#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RolesanywhereTrustAnchorState<Missing, 'Source>, value: string) : RolesanywhereTrustAnchorState<Present, 'Source> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RolesanywhereTrustAnchorState<Present, 'Source>)

        /// <summary>
        /// source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_trust_anchor#source-1">RolesanywhereTrustAnchor#source</a>
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: RolesanywhereTrustAnchorState<'Name, Missing>, value: aws.RolesanywhereTrustAnchor.RolesanywhereTrustAnchorSource) : RolesanywhereTrustAnchorState<'Name, Present> =
            state.assignments.Add(fun config -> config.Source <- value)
            ({ assignments = state.assignments } : RolesanywhereTrustAnchorState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_trust_anchor#enabled-1">RolesanywhereTrustAnchor#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: RolesanywhereTrustAnchorState<'Name, 'Source>, value: bool) : RolesanywhereTrustAnchorState<'Name, 'Source> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : RolesanywhereTrustAnchorState<'Name, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_trust_anchor#enabled-1">RolesanywhereTrustAnchor#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: RolesanywhereTrustAnchorState<'Name, 'Source>, value: HashiCorp.Cdktf.IResolvable) : RolesanywhereTrustAnchorState<'Name, 'Source> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : RolesanywhereTrustAnchorState<'Name, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_trust_anchor#id-1">RolesanywhereTrustAnchor#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RolesanywhereTrustAnchorState<'Name, 'Source>, value: string) : RolesanywhereTrustAnchorState<'Name, 'Source> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RolesanywhereTrustAnchorState<'Name, 'Source>

        /// <summary>
        /// notification_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_trust_anchor#notification_settings-1">RolesanywhereTrustAnchor#notification_settings</a> Accepts: aws.IResolvable | aws.RolesanywhereTrustAnchor.RolesanywhereTrustAnchorNotificationSettings[]
        /// </summary>
        [<CustomOperation "notification_settings">]
        member _.NotificationSettings(state: RolesanywhereTrustAnchorState<'Name, 'Source>, value: HashiCorp.Cdktf.IResolvable) : RolesanywhereTrustAnchorState<'Name, 'Source> =
            state.assignments.Add(fun config -> config.NotificationSettings <- value)
            state : RolesanywhereTrustAnchorState<'Name, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_trust_anchor#tags-1">RolesanywhereTrustAnchor#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RolesanywhereTrustAnchorState<'Name, 'Source>, value: seq<string * string>) : RolesanywhereTrustAnchorState<'Name, 'Source> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RolesanywhereTrustAnchorState<'Name, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_trust_anchor#tags_all-1">RolesanywhereTrustAnchor#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RolesanywhereTrustAnchorState<'Name, 'Source>, value: seq<string * string>) : RolesanywhereTrustAnchorState<'Name, 'Source> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RolesanywhereTrustAnchorState<'Name, 'Source>

        member _.Run(state: RolesanywhereTrustAnchorState<Present, Present>) : aws.RolesanywhereTrustAnchor.RolesanywhereTrustAnchor =
            let config = aws.RolesanywhereTrustAnchor.RolesanywhereTrustAnchorConfig()
            for setter in state.assignments do
                setter config
            aws.RolesanywhereTrustAnchor.RolesanywhereTrustAnchor(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rolesanywhereTrustAnchor: missing required arguments. Must call: name, source.", 9999, IsError = true)>]
        member _.Run(_: RolesanywhereTrustAnchorState<_, _>) : aws.RolesanywhereTrustAnchor.RolesanywhereTrustAnchor =
            Unchecked.defaultof<aws.RolesanywhereTrustAnchor.RolesanywhereTrustAnchor>
