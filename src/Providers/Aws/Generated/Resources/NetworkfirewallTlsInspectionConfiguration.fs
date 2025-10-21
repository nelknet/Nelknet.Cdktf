namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkfirewallTlsInspectionConfigurationState<'Name> = { assignments: ResizeArray<aws.NetworkfirewallTlsInspectionConfiguration.NetworkfirewallTlsInspectionConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_tls_inspection_configuration">aws_networkfirewall_tls_inspection_configuration</a>.
    /// </summary>
    type NetworkfirewallTlsInspectionConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkfirewallTlsInspectionConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : NetworkfirewallTlsInspectionConfigurationState<Missing>)

        member _.Zero(()) : NetworkfirewallTlsInspectionConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : NetworkfirewallTlsInspectionConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_tls_inspection_configuration#name-1">NetworkfirewallTlsInspectionConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkfirewallTlsInspectionConfigurationState<Missing>, value: string) : NetworkfirewallTlsInspectionConfigurationState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkfirewallTlsInspectionConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_tls_inspection_configuration#description-1">NetworkfirewallTlsInspectionConfiguration#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkfirewallTlsInspectionConfigurationState<'Name>, value: string) : NetworkfirewallTlsInspectionConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkfirewallTlsInspectionConfigurationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_tls_inspection_configuration#encryption_configuration-1">NetworkfirewallTlsInspectionConfiguration#encryption_configuration</a>. Accepts: aws.IResolvable | aws.NetworkfirewallTlsInspectionConfiguration.NetworkfirewallTlsInspectionConfigurationEncryptionConfiguration[]
        /// </summary>
        [<CustomOperation "encryption_configuration">]
        member _.EncryptionConfiguration(state: NetworkfirewallTlsInspectionConfigurationState<'Name>, value: HashiCorp.Cdktf.IResolvable) : NetworkfirewallTlsInspectionConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.EncryptionConfiguration <- value)
            state : NetworkfirewallTlsInspectionConfigurationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_tls_inspection_configuration#tags-1">NetworkfirewallTlsInspectionConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkfirewallTlsInspectionConfigurationState<'Name>, value: seq<string * string>) : NetworkfirewallTlsInspectionConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkfirewallTlsInspectionConfigurationState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_tls_inspection_configuration#timeouts-1">NetworkfirewallTlsInspectionConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkfirewallTlsInspectionConfigurationState<'Name>, value: aws.NetworkfirewallTlsInspectionConfiguration.NetworkfirewallTlsInspectionConfigurationTimeouts) : NetworkfirewallTlsInspectionConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkfirewallTlsInspectionConfigurationState<'Name>

        /// <summary>
        /// tls_inspection_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_tls_inspection_configuration#tls_inspection_configuration-1">NetworkfirewallTlsInspectionConfiguration#tls_inspection_configuration</a> Accepts: aws.IResolvable | aws.NetworkfirewallTlsInspectionConfiguration.NetworkfirewallTlsInspectionConfigurationTlsInspectionConfiguration[]
        /// </summary>
        [<CustomOperation "tls_inspection_configuration">]
        member _.TlsInspectionConfiguration(state: NetworkfirewallTlsInspectionConfigurationState<'Name>, value: HashiCorp.Cdktf.IResolvable) : NetworkfirewallTlsInspectionConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.TlsInspectionConfiguration <- value)
            state : NetworkfirewallTlsInspectionConfigurationState<'Name>

        member _.Run(state: NetworkfirewallTlsInspectionConfigurationState<Present>) : aws.NetworkfirewallTlsInspectionConfiguration.NetworkfirewallTlsInspectionConfiguration =
            let config = aws.NetworkfirewallTlsInspectionConfiguration.NetworkfirewallTlsInspectionConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkfirewallTlsInspectionConfiguration.NetworkfirewallTlsInspectionConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkfirewallTlsInspectionConfiguration: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: NetworkfirewallTlsInspectionConfigurationState<_>) : aws.NetworkfirewallTlsInspectionConfiguration.NetworkfirewallTlsInspectionConfiguration =
            Unchecked.defaultof<aws.NetworkfirewallTlsInspectionConfiguration.NetworkfirewallTlsInspectionConfiguration>
