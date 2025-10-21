namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkfirewallLoggingConfigurationState<'FirewallArn, 'LoggingConfiguration> = { assignments: ResizeArray<aws.NetworkfirewallLoggingConfiguration.NetworkfirewallLoggingConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_logging_configuration">aws_networkfirewall_logging_configuration</a>.
    /// </summary>
    type NetworkfirewallLoggingConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkfirewallLoggingConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkfirewallLoggingConfigurationState<Missing, Missing>)

        member _.Zero(()) : NetworkfirewallLoggingConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkfirewallLoggingConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_logging_configuration#firewall_arn-1">NetworkfirewallLoggingConfiguration#firewall_arn</a>.
        /// </summary>
        [<CustomOperation "firewall_arn">]
        member _.FirewallArn(state: NetworkfirewallLoggingConfigurationState<Missing, 'LoggingConfiguration>, value: string) : NetworkfirewallLoggingConfigurationState<Present, 'LoggingConfiguration> =
            state.assignments.Add(fun config -> config.FirewallArn <- value)
            ({ assignments = state.assignments } : NetworkfirewallLoggingConfigurationState<Present, 'LoggingConfiguration>)

        /// <summary>
        /// logging_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_logging_configuration#logging_configuration-1">NetworkfirewallLoggingConfiguration#logging_configuration</a>
        /// </summary>
        [<CustomOperation "logging_configuration">]
        member _.LoggingConfiguration(state: NetworkfirewallLoggingConfigurationState<'FirewallArn, Missing>, value: aws.NetworkfirewallLoggingConfiguration.NetworkfirewallLoggingConfigurationLoggingConfiguration) : NetworkfirewallLoggingConfigurationState<'FirewallArn, Present> =
            state.assignments.Add(fun config -> config.LoggingConfiguration <- value)
            ({ assignments = state.assignments } : NetworkfirewallLoggingConfigurationState<'FirewallArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_logging_configuration#id-1">NetworkfirewallLoggingConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkfirewallLoggingConfigurationState<'FirewallArn, 'LoggingConfiguration>, value: string) : NetworkfirewallLoggingConfigurationState<'FirewallArn, 'LoggingConfiguration> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkfirewallLoggingConfigurationState<'FirewallArn, 'LoggingConfiguration>

        member _.Run(state: NetworkfirewallLoggingConfigurationState<Present, Present>) : aws.NetworkfirewallLoggingConfiguration.NetworkfirewallLoggingConfiguration =
            let config = aws.NetworkfirewallLoggingConfiguration.NetworkfirewallLoggingConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkfirewallLoggingConfiguration.NetworkfirewallLoggingConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkfirewallLoggingConfiguration: missing required arguments. Must call: firewall_arn, logging_configuration.", 9999, IsError = true)>]
        member _.Run(_: NetworkfirewallLoggingConfigurationState<_, _>) : aws.NetworkfirewallLoggingConfiguration.NetworkfirewallLoggingConfiguration =
            Unchecked.defaultof<aws.NetworkfirewallLoggingConfiguration.NetworkfirewallLoggingConfiguration>
