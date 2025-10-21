namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MedialiveInputSecurityGroupState<'WhitelistRules> = { assignments: ResizeArray<aws.MedialiveInputSecurityGroup.MedialiveInputSecurityGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input_security_group">aws_medialive_input_security_group</a>.
    /// </summary>
    type MedialiveInputSecurityGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : MedialiveInputSecurityGroupState<Missing> =
            ({ assignments = ResizeArray() } : MedialiveInputSecurityGroupState<Missing>)

        member _.Zero(()) : MedialiveInputSecurityGroupState<Missing> =
            ({ assignments = ResizeArray() } : MedialiveInputSecurityGroupState<Missing>)

        /// <summary>
        /// whitelist_rules block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input_security_group#whitelist_rules-1">MedialiveInputSecurityGroup#whitelist_rules</a> Accepts: aws.IResolvable | aws.MedialiveInputSecurityGroup.MedialiveInputSecurityGroupWhitelistRules[]
        /// </summary>
        [<CustomOperation "whitelist_rules">]
        member _.WhitelistRules(state: MedialiveInputSecurityGroupState<Missing>, value: HashiCorp.Cdktf.IResolvable) : MedialiveInputSecurityGroupState<Present> =
            state.assignments.Add(fun config -> config.WhitelistRules <- value)
            ({ assignments = state.assignments } : MedialiveInputSecurityGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input_security_group#id-1">MedialiveInputSecurityGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MedialiveInputSecurityGroupState<'WhitelistRules>, value: string) : MedialiveInputSecurityGroupState<'WhitelistRules> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MedialiveInputSecurityGroupState<'WhitelistRules>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input_security_group#tags-1">MedialiveInputSecurityGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MedialiveInputSecurityGroupState<'WhitelistRules>, value: seq<string * string>) : MedialiveInputSecurityGroupState<'WhitelistRules> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MedialiveInputSecurityGroupState<'WhitelistRules>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input_security_group#tags_all-1">MedialiveInputSecurityGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MedialiveInputSecurityGroupState<'WhitelistRules>, value: seq<string * string>) : MedialiveInputSecurityGroupState<'WhitelistRules> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MedialiveInputSecurityGroupState<'WhitelistRules>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input_security_group#timeouts-1">MedialiveInputSecurityGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MedialiveInputSecurityGroupState<'WhitelistRules>, value: aws.MedialiveInputSecurityGroup.MedialiveInputSecurityGroupTimeouts) : MedialiveInputSecurityGroupState<'WhitelistRules> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MedialiveInputSecurityGroupState<'WhitelistRules>

        member _.Run(state: MedialiveInputSecurityGroupState<Present>) : aws.MedialiveInputSecurityGroup.MedialiveInputSecurityGroup =
            let config = aws.MedialiveInputSecurityGroup.MedialiveInputSecurityGroupConfig()
            for setter in state.assignments do
                setter config
            aws.MedialiveInputSecurityGroup.MedialiveInputSecurityGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.medialiveInputSecurityGroup: missing required arguments. Must call: whitelist_rules.", 9999, IsError = true)>]
        member _.Run(_: MedialiveInputSecurityGroupState<_>) : aws.MedialiveInputSecurityGroup.MedialiveInputSecurityGroup =
            Unchecked.defaultof<aws.MedialiveInputSecurityGroup.MedialiveInputSecurityGroup>
