namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Macie2OrganizationConfigurationState<'AutoEnable> = { assignments: ResizeArray<aws.Macie2OrganizationConfiguration.Macie2OrganizationConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_organization_configuration">aws_macie2_organization_configuration</a>.
    /// </summary>
    type Macie2OrganizationConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Macie2OrganizationConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : Macie2OrganizationConfigurationState<Missing>)

        member _.Zero(()) : Macie2OrganizationConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : Macie2OrganizationConfigurationState<Missing>)

        /// <summary>
        /// Whether to enable Amazon Macie automatically for accounts that are added to the organization in AWS Organizations. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_organization_configuration#auto_enable-1">Macie2OrganizationConfiguration#auto_enable</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_enable">]
        member _.AutoEnable(state: Macie2OrganizationConfigurationState<Missing>, value: bool) : Macie2OrganizationConfigurationState<Present> =
            state.assignments.Add(fun config -> config.AutoEnable <- value)
            ({ assignments = state.assignments } : Macie2OrganizationConfigurationState<Present>)

        /// <summary>
        /// Whether to enable Amazon Macie automatically for accounts that are added to the organization in AWS Organizations. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_organization_configuration#auto_enable-1">Macie2OrganizationConfiguration#auto_enable</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_enable">]
        member _.AutoEnable(state: Macie2OrganizationConfigurationState<Missing>, value: HashiCorp.Cdktf.IResolvable) : Macie2OrganizationConfigurationState<Present> =
            state.assignments.Add(fun config -> config.AutoEnable <- value)
            ({ assignments = state.assignments } : Macie2OrganizationConfigurationState<Present>)

        member _.Run(state: Macie2OrganizationConfigurationState<Present>) : aws.Macie2OrganizationConfiguration.Macie2OrganizationConfiguration =
            let config = aws.Macie2OrganizationConfiguration.Macie2OrganizationConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.Macie2OrganizationConfiguration.Macie2OrganizationConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.macie2OrganizationConfiguration: missing required arguments. Must call: auto_enable.", 9999, IsError = true)>]
        member _.Run(_: Macie2OrganizationConfigurationState<_>) : aws.Macie2OrganizationConfiguration.Macie2OrganizationConfiguration =
            Unchecked.defaultof<aws.Macie2OrganizationConfiguration.Macie2OrganizationConfiguration>
