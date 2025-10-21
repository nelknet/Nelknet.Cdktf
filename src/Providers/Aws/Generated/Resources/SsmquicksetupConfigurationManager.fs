namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsmquicksetupConfigurationManagerState<'Name> = { assignments: ResizeArray<aws.SsmquicksetupConfigurationManager.SsmquicksetupConfigurationManagerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmquicksetup_configuration_manager">aws_ssmquicksetup_configuration_manager</a>.
    /// </summary>
    type SsmquicksetupConfigurationManagerBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsmquicksetupConfigurationManagerState<Missing> =
            ({ assignments = ResizeArray() } : SsmquicksetupConfigurationManagerState<Missing>)

        member _.Zero(()) : SsmquicksetupConfigurationManagerState<Missing> =
            ({ assignments = ResizeArray() } : SsmquicksetupConfigurationManagerState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmquicksetup_configuration_manager#name-1">SsmquicksetupConfigurationManager#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SsmquicksetupConfigurationManagerState<Missing>, value: string) : SsmquicksetupConfigurationManagerState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SsmquicksetupConfigurationManagerState<Present>)

        /// <summary>
        /// configuration_definition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmquicksetup_configuration_manager#configuration_definition-1">SsmquicksetupConfigurationManager#configuration_definition</a> Accepts: aws.IResolvable | aws.SsmquicksetupConfigurationManager.SsmquicksetupConfigurationManagerConfigurationDefinition[]
        /// </summary>
        [<CustomOperation "configuration_definition">]
        member _.ConfigurationDefinition(state: SsmquicksetupConfigurationManagerState<'Name>, value: HashiCorp.Cdktf.IResolvable) : SsmquicksetupConfigurationManagerState<'Name> =
            state.assignments.Add(fun config -> config.ConfigurationDefinition <- value)
            state : SsmquicksetupConfigurationManagerState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmquicksetup_configuration_manager#description-1">SsmquicksetupConfigurationManager#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SsmquicksetupConfigurationManagerState<'Name>, value: string) : SsmquicksetupConfigurationManagerState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SsmquicksetupConfigurationManagerState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmquicksetup_configuration_manager#tags-1">SsmquicksetupConfigurationManager#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SsmquicksetupConfigurationManagerState<'Name>, value: seq<string * string>) : SsmquicksetupConfigurationManagerState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SsmquicksetupConfigurationManagerState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmquicksetup_configuration_manager#timeouts-1">SsmquicksetupConfigurationManager#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SsmquicksetupConfigurationManagerState<'Name>, value: aws.SsmquicksetupConfigurationManager.SsmquicksetupConfigurationManagerTimeouts) : SsmquicksetupConfigurationManagerState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SsmquicksetupConfigurationManagerState<'Name>

        member _.Run(state: SsmquicksetupConfigurationManagerState<Present>) : aws.SsmquicksetupConfigurationManager.SsmquicksetupConfigurationManager =
            let config = aws.SsmquicksetupConfigurationManager.SsmquicksetupConfigurationManagerConfig()
            for setter in state.assignments do
                setter config
            aws.SsmquicksetupConfigurationManager.SsmquicksetupConfigurationManager(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssmquicksetupConfigurationManager: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: SsmquicksetupConfigurationManagerState<_>) : aws.SsmquicksetupConfigurationManager.SsmquicksetupConfigurationManager =
            Unchecked.defaultof<aws.SsmquicksetupConfigurationManager.SsmquicksetupConfigurationManager>
