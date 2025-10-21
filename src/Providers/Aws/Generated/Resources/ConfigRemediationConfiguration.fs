namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType> = { assignments: ResizeArray<aws.ConfigRemediationConfiguration.ConfigRemediationConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration">aws_config_remediation_configuration</a>.
    /// </summary>
    type ConfigRemediationConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConfigRemediationConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConfigRemediationConfigurationState<Missing, Missing, Missing>)

        member _.Zero(()) : ConfigRemediationConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConfigRemediationConfigurationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#config_rule_name-1">ConfigRemediationConfiguration#config_rule_name</a>.
        /// </summary>
        [<CustomOperation "config_rule_name">]
        member _.ConfigRuleName(state: ConfigRemediationConfigurationState<Missing, 'TargetId, 'TargetType>, value: string) : ConfigRemediationConfigurationState<Present, 'TargetId, 'TargetType> =
            state.assignments.Add(fun config -> config.ConfigRuleName <- value)
            ({ assignments = state.assignments } : ConfigRemediationConfigurationState<Present, 'TargetId, 'TargetType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#target_id-1">ConfigRemediationConfiguration#target_id</a>.
        /// </summary>
        [<CustomOperation "target_id">]
        member _.TargetId(state: ConfigRemediationConfigurationState<'ConfigRuleName, Missing, 'TargetType>, value: string) : ConfigRemediationConfigurationState<'ConfigRuleName, Present, 'TargetType> =
            state.assignments.Add(fun config -> config.TargetId <- value)
            ({ assignments = state.assignments } : ConfigRemediationConfigurationState<'ConfigRuleName, Present, 'TargetType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#target_type-1">ConfigRemediationConfiguration#target_type</a>.
        /// </summary>
        [<CustomOperation "target_type">]
        member _.TargetType(state: ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, Missing>, value: string) : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, Present> =
            state.assignments.Add(fun config -> config.TargetType <- value)
            ({ assignments = state.assignments } : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#automatic-1">ConfigRemediationConfiguration#automatic</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "automatic">]
        member _.Automatic(state: ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType>, value: bool) : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType> =
            state.assignments.Add(fun config -> config.Automatic <- value)
            state : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#automatic-1">ConfigRemediationConfiguration#automatic</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "automatic">]
        member _.Automatic(state: ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType>, value: HashiCorp.Cdktf.IResolvable) : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType> =
            state.assignments.Add(fun config -> config.Automatic <- value)
            state : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType>

        /// <summary>
        /// execution_controls block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#execution_controls-1">ConfigRemediationConfiguration#execution_controls</a>
        /// </summary>
        [<CustomOperation "execution_controls">]
        member _.ExecutionControls(state: ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType>, value: aws.ConfigRemediationConfiguration.ConfigRemediationConfigurationExecutionControls) : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType> =
            state.assignments.Add(fun config -> config.ExecutionControls <- value)
            state : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#id-1">ConfigRemediationConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType>, value: string) : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#maximum_automatic_attempts-1">ConfigRemediationConfiguration#maximum_automatic_attempts</a>.
        /// </summary>
        [<CustomOperation "maximum_automatic_attempts">]
        member _.MaximumAutomaticAttempts(state: ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType>, value: double) : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType> =
            state.assignments.Add(fun config -> config.MaximumAutomaticAttempts <- value)
            state : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType>

        /// <summary>
        /// parameter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#parameter-1">ConfigRemediationConfiguration#parameter</a> Accepts: aws.IResolvable | aws.ConfigRemediationConfiguration.ConfigRemediationConfigurationParameter[]
        /// </summary>
        [<CustomOperation "parameter">]
        member _.Parameter(state: ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType>, value: HashiCorp.Cdktf.IResolvable) : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType> =
            state.assignments.Add(fun config -> config.Parameter <- value)
            state : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#resource_type-1">ConfigRemediationConfiguration#resource_type</a>.
        /// </summary>
        [<CustomOperation "resource_type">]
        member _.ResourceType(state: ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType>, value: string) : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType> =
            state.assignments.Add(fun config -> config.ResourceType <- value)
            state : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#retry_attempt_seconds-1">ConfigRemediationConfiguration#retry_attempt_seconds</a>.
        /// </summary>
        [<CustomOperation "retry_attempt_seconds">]
        member _.RetryAttemptSeconds(state: ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType>, value: double) : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType> =
            state.assignments.Add(fun config -> config.RetryAttemptSeconds <- value)
            state : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_remediation_configuration#target_version-1">ConfigRemediationConfiguration#target_version</a>.
        /// </summary>
        [<CustomOperation "target_version">]
        member _.TargetVersion(state: ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType>, value: string) : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType> =
            state.assignments.Add(fun config -> config.TargetVersion <- value)
            state : ConfigRemediationConfigurationState<'ConfigRuleName, 'TargetId, 'TargetType>

        member _.Run(state: ConfigRemediationConfigurationState<Present, Present, Present>) : aws.ConfigRemediationConfiguration.ConfigRemediationConfiguration =
            let config = aws.ConfigRemediationConfiguration.ConfigRemediationConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.ConfigRemediationConfiguration.ConfigRemediationConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.configRemediationConfiguration: missing required arguments. Must call: config_rule_name, target_id, target_type.", 9999, IsError = true)>]
        member _.Run(_: ConfigRemediationConfigurationState<_, _, _>) : aws.ConfigRemediationConfiguration.ConfigRemediationConfiguration =
            Unchecked.defaultof<aws.ConfigRemediationConfiguration.ConfigRemediationConfiguration>
