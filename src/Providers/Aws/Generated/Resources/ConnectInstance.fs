namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled> = { assignments: ResizeArray<aws.ConnectInstance.ConnectInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance">aws_connect_instance</a>.
    /// </summary>
    type ConnectInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConnectInstanceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectInstanceState<Missing, Missing, Missing>)

        member _.Zero(()) : ConnectInstanceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectInstanceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#identity_management_type-1">ConnectInstance#identity_management_type</a>.
        /// </summary>
        [<CustomOperation "identity_management_type">]
        member _.IdentityManagementType(state: ConnectInstanceState<Missing, 'InboundCallsEnabled, 'OutboundCallsEnabled>, value: string) : ConnectInstanceState<Present, 'InboundCallsEnabled, 'OutboundCallsEnabled> =
            state.assignments.Add(fun config -> config.IdentityManagementType <- value)
            ({ assignments = state.assignments } : ConnectInstanceState<Present, 'InboundCallsEnabled, 'OutboundCallsEnabled>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#inbound_calls_enabled-1">ConnectInstance#inbound_calls_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "inbound_calls_enabled">]
        member _.InboundCallsEnabled(state: ConnectInstanceState<'IdentityManagementType, Missing, 'OutboundCallsEnabled>, value: bool) : ConnectInstanceState<'IdentityManagementType, Present, 'OutboundCallsEnabled> =
            state.assignments.Add(fun config -> config.InboundCallsEnabled <- value)
            ({ assignments = state.assignments } : ConnectInstanceState<'IdentityManagementType, Present, 'OutboundCallsEnabled>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#inbound_calls_enabled-1">ConnectInstance#inbound_calls_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "inbound_calls_enabled">]
        member _.InboundCallsEnabled(state: ConnectInstanceState<'IdentityManagementType, Missing, 'OutboundCallsEnabled>, value: HashiCorp.Cdktf.IResolvable) : ConnectInstanceState<'IdentityManagementType, Present, 'OutboundCallsEnabled> =
            state.assignments.Add(fun config -> config.InboundCallsEnabled <- value)
            ({ assignments = state.assignments } : ConnectInstanceState<'IdentityManagementType, Present, 'OutboundCallsEnabled>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#outbound_calls_enabled-1">ConnectInstance#outbound_calls_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "outbound_calls_enabled">]
        member _.OutboundCallsEnabled(state: ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, Missing>, value: bool) : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, Present> =
            state.assignments.Add(fun config -> config.OutboundCallsEnabled <- value)
            ({ assignments = state.assignments } : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#outbound_calls_enabled-1">ConnectInstance#outbound_calls_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "outbound_calls_enabled">]
        member _.OutboundCallsEnabled(state: ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, Missing>, value: HashiCorp.Cdktf.IResolvable) : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, Present> =
            state.assignments.Add(fun config -> config.OutboundCallsEnabled <- value)
            ({ assignments = state.assignments } : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#auto_resolve_best_voices_enabled-1">ConnectInstance#auto_resolve_best_voices_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_resolve_best_voices_enabled">]
        member _.AutoResolveBestVoicesEnabled(state: ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>, value: bool) : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled> =
            state.assignments.Add(fun config -> config.AutoResolveBestVoicesEnabled <- value)
            state : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#auto_resolve_best_voices_enabled-1">ConnectInstance#auto_resolve_best_voices_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_resolve_best_voices_enabled">]
        member _.AutoResolveBestVoicesEnabled(state: ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>, value: HashiCorp.Cdktf.IResolvable) : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled> =
            state.assignments.Add(fun config -> config.AutoResolveBestVoicesEnabled <- value)
            state : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#contact_flow_logs_enabled-1">ConnectInstance#contact_flow_logs_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "contact_flow_logs_enabled">]
        member _.ContactFlowLogsEnabled(state: ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>, value: bool) : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled> =
            state.assignments.Add(fun config -> config.ContactFlowLogsEnabled <- value)
            state : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#contact_flow_logs_enabled-1">ConnectInstance#contact_flow_logs_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "contact_flow_logs_enabled">]
        member _.ContactFlowLogsEnabled(state: ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>, value: HashiCorp.Cdktf.IResolvable) : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled> =
            state.assignments.Add(fun config -> config.ContactFlowLogsEnabled <- value)
            state : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#contact_lens_enabled-1">ConnectInstance#contact_lens_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "contact_lens_enabled">]
        member _.ContactLensEnabled(state: ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>, value: bool) : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled> =
            state.assignments.Add(fun config -> config.ContactLensEnabled <- value)
            state : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#contact_lens_enabled-1">ConnectInstance#contact_lens_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "contact_lens_enabled">]
        member _.ContactLensEnabled(state: ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>, value: HashiCorp.Cdktf.IResolvable) : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled> =
            state.assignments.Add(fun config -> config.ContactLensEnabled <- value)
            state : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#directory_id-1">ConnectInstance#directory_id</a>.
        /// </summary>
        [<CustomOperation "directory_id">]
        member _.DirectoryId(state: ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>, value: string) : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled> =
            state.assignments.Add(fun config -> config.DirectoryId <- value)
            state : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#early_media_enabled-1">ConnectInstance#early_media_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "early_media_enabled">]
        member _.EarlyMediaEnabled(state: ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>, value: bool) : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled> =
            state.assignments.Add(fun config -> config.EarlyMediaEnabled <- value)
            state : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#early_media_enabled-1">ConnectInstance#early_media_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "early_media_enabled">]
        member _.EarlyMediaEnabled(state: ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>, value: HashiCorp.Cdktf.IResolvable) : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled> =
            state.assignments.Add(fun config -> config.EarlyMediaEnabled <- value)
            state : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#id-1">ConnectInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>, value: string) : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#instance_alias-1">ConnectInstance#instance_alias</a>.
        /// </summary>
        [<CustomOperation "instance_alias">]
        member _.InstanceAlias(state: ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>, value: string) : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled> =
            state.assignments.Add(fun config -> config.InstanceAlias <- value)
            state : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#multi_party_conference_enabled-1">ConnectInstance#multi_party_conference_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_party_conference_enabled">]
        member _.MultiPartyConferenceEnabled(state: ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>, value: bool) : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled> =
            state.assignments.Add(fun config -> config.MultiPartyConferenceEnabled <- value)
            state : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#multi_party_conference_enabled-1">ConnectInstance#multi_party_conference_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_party_conference_enabled">]
        member _.MultiPartyConferenceEnabled(state: ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>, value: HashiCorp.Cdktf.IResolvable) : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled> =
            state.assignments.Add(fun config -> config.MultiPartyConferenceEnabled <- value)
            state : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#tags-1">ConnectInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>, value: seq<string * string>) : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#tags_all-1">ConnectInstance#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>, value: seq<string * string>) : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance#timeouts-1">ConnectInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>, value: aws.ConnectInstance.ConnectInstanceTimeouts) : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ConnectInstanceState<'IdentityManagementType, 'InboundCallsEnabled, 'OutboundCallsEnabled>

        member _.Run(state: ConnectInstanceState<Present, Present, Present>) : aws.ConnectInstance.ConnectInstance =
            let config = aws.ConnectInstance.ConnectInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.ConnectInstance.ConnectInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.connectInstance: missing required arguments. Must call: identity_management_type, inbound_calls_enabled, outbound_calls_enabled.", 9999, IsError = true)>]
        member _.Run(_: ConnectInstanceState<_, _, _>) : aws.ConnectInstance.ConnectInstance =
            Unchecked.defaultof<aws.ConnectInstance.ConnectInstance>
