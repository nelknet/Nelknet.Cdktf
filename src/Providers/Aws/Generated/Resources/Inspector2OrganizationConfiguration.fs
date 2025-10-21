namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Inspector2OrganizationConfigurationState<'AutoEnable> = { assignments: ResizeArray<aws.Inspector2OrganizationConfiguration.Inspector2OrganizationConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_organization_configuration">aws_inspector2_organization_configuration</a>.
    /// </summary>
    type Inspector2OrganizationConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Inspector2OrganizationConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : Inspector2OrganizationConfigurationState<Missing>)

        member _.Zero(()) : Inspector2OrganizationConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : Inspector2OrganizationConfigurationState<Missing>)

        /// <summary>
        /// auto_enable block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_organization_configuration#auto_enable-1">Inspector2OrganizationConfiguration#auto_enable</a>
        /// </summary>
        [<CustomOperation "auto_enable">]
        member _.AutoEnable(state: Inspector2OrganizationConfigurationState<Missing>, value: aws.Inspector2OrganizationConfiguration.Inspector2OrganizationConfigurationAutoEnable) : Inspector2OrganizationConfigurationState<Present> =
            state.assignments.Add(fun config -> config.AutoEnable <- value)
            ({ assignments = state.assignments } : Inspector2OrganizationConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_organization_configuration#id-1">Inspector2OrganizationConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Inspector2OrganizationConfigurationState<'AutoEnable>, value: string) : Inspector2OrganizationConfigurationState<'AutoEnable> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Inspector2OrganizationConfigurationState<'AutoEnable>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_organization_configuration#timeouts-1">Inspector2OrganizationConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Inspector2OrganizationConfigurationState<'AutoEnable>, value: aws.Inspector2OrganizationConfiguration.Inspector2OrganizationConfigurationTimeouts) : Inspector2OrganizationConfigurationState<'AutoEnable> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Inspector2OrganizationConfigurationState<'AutoEnable>

        member _.Run(state: Inspector2OrganizationConfigurationState<Present>) : aws.Inspector2OrganizationConfiguration.Inspector2OrganizationConfiguration =
            let config = aws.Inspector2OrganizationConfiguration.Inspector2OrganizationConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.Inspector2OrganizationConfiguration.Inspector2OrganizationConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.inspector2OrganizationConfiguration: missing required arguments. Must call: auto_enable.", 9999, IsError = true)>]
        member _.Run(_: Inspector2OrganizationConfigurationState<_>) : aws.Inspector2OrganizationConfiguration.Inspector2OrganizationConfiguration =
            Unchecked.defaultof<aws.Inspector2OrganizationConfiguration.Inspector2OrganizationConfiguration>
