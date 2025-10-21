namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityhubOrganizationConfigurationState<'AutoEnable> = { assignments: ResizeArray<aws.SecurityhubOrganizationConfiguration.SecurityhubOrganizationConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_organization_configuration">aws_securityhub_organization_configuration</a>.
    /// </summary>
    type SecurityhubOrganizationConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityhubOrganizationConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : SecurityhubOrganizationConfigurationState<Missing>)

        member _.Zero(()) : SecurityhubOrganizationConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : SecurityhubOrganizationConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_organization_configuration#auto_enable-1">SecurityhubOrganizationConfiguration#auto_enable</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_enable">]
        member _.AutoEnable(state: SecurityhubOrganizationConfigurationState<Missing>, value: bool) : SecurityhubOrganizationConfigurationState<Present> =
            state.assignments.Add(fun config -> config.AutoEnable <- value)
            ({ assignments = state.assignments } : SecurityhubOrganizationConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_organization_configuration#auto_enable-1">SecurityhubOrganizationConfiguration#auto_enable</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_enable">]
        member _.AutoEnable(state: SecurityhubOrganizationConfigurationState<Missing>, value: HashiCorp.Cdktf.IResolvable) : SecurityhubOrganizationConfigurationState<Present> =
            state.assignments.Add(fun config -> config.AutoEnable <- value)
            ({ assignments = state.assignments } : SecurityhubOrganizationConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_organization_configuration#auto_enable_standards-1">SecurityhubOrganizationConfiguration#auto_enable_standards</a>.
        /// </summary>
        [<CustomOperation "auto_enable_standards">]
        member _.AutoEnableStandards(state: SecurityhubOrganizationConfigurationState<'AutoEnable>, value: string) : SecurityhubOrganizationConfigurationState<'AutoEnable> =
            state.assignments.Add(fun config -> config.AutoEnableStandards <- value)
            state : SecurityhubOrganizationConfigurationState<'AutoEnable>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_organization_configuration#id-1">SecurityhubOrganizationConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityhubOrganizationConfigurationState<'AutoEnable>, value: string) : SecurityhubOrganizationConfigurationState<'AutoEnable> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityhubOrganizationConfigurationState<'AutoEnable>

        /// <summary>
        /// organization_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_organization_configuration#organization_configuration-1">SecurityhubOrganizationConfiguration#organization_configuration</a>
        /// </summary>
        [<CustomOperation "organization_configuration">]
        member _.OrganizationConfiguration(state: SecurityhubOrganizationConfigurationState<'AutoEnable>, value: aws.SecurityhubOrganizationConfiguration.SecurityhubOrganizationConfigurationOrganizationConfiguration) : SecurityhubOrganizationConfigurationState<'AutoEnable> =
            state.assignments.Add(fun config -> config.OrganizationConfiguration <- value)
            state : SecurityhubOrganizationConfigurationState<'AutoEnable>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_organization_configuration#timeouts-1">SecurityhubOrganizationConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SecurityhubOrganizationConfigurationState<'AutoEnable>, value: aws.SecurityhubOrganizationConfiguration.SecurityhubOrganizationConfigurationTimeouts) : SecurityhubOrganizationConfigurationState<'AutoEnable> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SecurityhubOrganizationConfigurationState<'AutoEnable>

        member _.Run(state: SecurityhubOrganizationConfigurationState<Present>) : aws.SecurityhubOrganizationConfiguration.SecurityhubOrganizationConfiguration =
            let config = aws.SecurityhubOrganizationConfiguration.SecurityhubOrganizationConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.SecurityhubOrganizationConfiguration.SecurityhubOrganizationConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.securityhubOrganizationConfiguration: missing required arguments. Must call: auto_enable.", 9999, IsError = true)>]
        member _.Run(_: SecurityhubOrganizationConfigurationState<_>) : aws.SecurityhubOrganizationConfiguration.SecurityhubOrganizationConfiguration =
            Unchecked.defaultof<aws.SecurityhubOrganizationConfiguration.SecurityhubOrganizationConfiguration>
