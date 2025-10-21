namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type> = { assignments: ResizeArray<aws.NetworkfirewallRuleGroup.NetworkfirewallRuleGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group">aws_networkfirewall_rule_group</a>.
    /// </summary>
    type NetworkfirewallRuleGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkfirewallRuleGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkfirewallRuleGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkfirewallRuleGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkfirewallRuleGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#capacity-1">NetworkfirewallRuleGroup#capacity</a>.
        /// </summary>
        [<CustomOperation "capacity">]
        member _.Capacity(state: NetworkfirewallRuleGroupState<Missing, 'Name, 'Type>, value: double) : NetworkfirewallRuleGroupState<Present, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Capacity <- value)
            ({ assignments = state.assignments } : NetworkfirewallRuleGroupState<Present, 'Name, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#name-1">NetworkfirewallRuleGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkfirewallRuleGroupState<'Capacity, Missing, 'Type>, value: string) : NetworkfirewallRuleGroupState<'Capacity, Present, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkfirewallRuleGroupState<'Capacity, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#type-1">NetworkfirewallRuleGroup#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: NetworkfirewallRuleGroupState<'Capacity, 'Name, Missing>, value: string) : NetworkfirewallRuleGroupState<'Capacity, 'Name, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : NetworkfirewallRuleGroupState<'Capacity, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#description-1">NetworkfirewallRuleGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type>, value: string) : NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type>

        /// <summary>
        /// encryption_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#encryption_configuration-1">NetworkfirewallRuleGroup#encryption_configuration</a>
        /// </summary>
        [<CustomOperation "encryption_configuration">]
        member _.EncryptionConfiguration(state: NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type>, value: aws.NetworkfirewallRuleGroup.NetworkfirewallRuleGroupEncryptionConfiguration) : NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.EncryptionConfiguration <- value)
            state : NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#id-1">NetworkfirewallRuleGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type>, value: string) : NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type>

        /// <summary>
        /// rule_group block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#rule_group-1">NetworkfirewallRuleGroup#rule_group</a>
        /// </summary>
        [<CustomOperation "rule_group">]
        member _.RuleGroup(state: NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type>, value: aws.NetworkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroup) : NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.RuleGroup <- value)
            state : NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#rules-1">NetworkfirewallRuleGroup#rules</a>.
        /// </summary>
        [<CustomOperation "rules">]
        member _.Rules(state: NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type>, value: string) : NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Rules <- value)
            state : NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#tags-1">NetworkfirewallRuleGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type>, value: seq<string * string>) : NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#tags_all-1">NetworkfirewallRuleGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type>, value: seq<string * string>) : NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NetworkfirewallRuleGroupState<'Capacity, 'Name, 'Type>

        member _.Run(state: NetworkfirewallRuleGroupState<Present, Present, Present>) : aws.NetworkfirewallRuleGroup.NetworkfirewallRuleGroup =
            let config = aws.NetworkfirewallRuleGroup.NetworkfirewallRuleGroupConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkfirewallRuleGroup.NetworkfirewallRuleGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkfirewallRuleGroup: missing required arguments. Must call: capacity, name, type.", 9999, IsError = true)>]
        member _.Run(_: NetworkfirewallRuleGroupState<_, _, _>) : aws.NetworkfirewallRuleGroup.NetworkfirewallRuleGroup =
            Unchecked.defaultof<aws.NetworkfirewallRuleGroup.NetworkfirewallRuleGroup>
