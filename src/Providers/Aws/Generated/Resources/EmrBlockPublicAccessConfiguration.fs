namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EmrBlockPublicAccessConfigurationState<'BlockPublicSecurityGroupRules> = { assignments: ResizeArray<aws.EmrBlockPublicAccessConfiguration.EmrBlockPublicAccessConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_block_public_access_configuration">aws_emr_block_public_access_configuration</a>.
    /// </summary>
    type EmrBlockPublicAccessConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : EmrBlockPublicAccessConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : EmrBlockPublicAccessConfigurationState<Missing>)

        member _.Zero(()) : EmrBlockPublicAccessConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : EmrBlockPublicAccessConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_block_public_access_configuration#block_public_security_group_rules-1">EmrBlockPublicAccessConfiguration#block_public_security_group_rules</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "block_public_security_group_rules">]
        member _.BlockPublicSecurityGroupRules(state: EmrBlockPublicAccessConfigurationState<Missing>, value: bool) : EmrBlockPublicAccessConfigurationState<Present> =
            state.assignments.Add(fun config -> config.BlockPublicSecurityGroupRules <- value)
            ({ assignments = state.assignments } : EmrBlockPublicAccessConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_block_public_access_configuration#block_public_security_group_rules-1">EmrBlockPublicAccessConfiguration#block_public_security_group_rules</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "block_public_security_group_rules">]
        member _.BlockPublicSecurityGroupRules(state: EmrBlockPublicAccessConfigurationState<Missing>, value: HashiCorp.Cdktf.IResolvable) : EmrBlockPublicAccessConfigurationState<Present> =
            state.assignments.Add(fun config -> config.BlockPublicSecurityGroupRules <- value)
            ({ assignments = state.assignments } : EmrBlockPublicAccessConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_block_public_access_configuration#id-1">EmrBlockPublicAccessConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EmrBlockPublicAccessConfigurationState<'BlockPublicSecurityGroupRules>, value: string) : EmrBlockPublicAccessConfigurationState<'BlockPublicSecurityGroupRules> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EmrBlockPublicAccessConfigurationState<'BlockPublicSecurityGroupRules>

        /// <summary>
        /// permitted_public_security_group_rule_range block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_block_public_access_configuration#permitted_public_security_group_rule_range-1">EmrBlockPublicAccessConfiguration#permitted_public_security_group_rule_range</a> Accepts: aws.IResolvable | aws.EmrBlockPublicAccessConfiguration.EmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRange[]
        /// </summary>
        [<CustomOperation "permitted_public_security_group_rule_range">]
        member _.PermittedPublicSecurityGroupRuleRange(state: EmrBlockPublicAccessConfigurationState<'BlockPublicSecurityGroupRules>, value: HashiCorp.Cdktf.IResolvable) : EmrBlockPublicAccessConfigurationState<'BlockPublicSecurityGroupRules> =
            state.assignments.Add(fun config -> config.PermittedPublicSecurityGroupRuleRange <- value)
            state : EmrBlockPublicAccessConfigurationState<'BlockPublicSecurityGroupRules>

        member _.Run(state: EmrBlockPublicAccessConfigurationState<Present>) : aws.EmrBlockPublicAccessConfiguration.EmrBlockPublicAccessConfiguration =
            let config = aws.EmrBlockPublicAccessConfiguration.EmrBlockPublicAccessConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.EmrBlockPublicAccessConfiguration.EmrBlockPublicAccessConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.emrBlockPublicAccessConfiguration: missing required arguments. Must call: block_public_security_group_rules.", 9999, IsError = true)>]
        member _.Run(_: EmrBlockPublicAccessConfigurationState<_>) : aws.EmrBlockPublicAccessConfiguration.EmrBlockPublicAccessConfiguration =
            Unchecked.defaultof<aws.EmrBlockPublicAccessConfiguration.EmrBlockPublicAccessConfiguration>
