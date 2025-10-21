namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GuarddutyOrganizationConfigurationState<'DetectorId> = { assignments: ResizeArray<aws.GuarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration">aws_guardduty_organization_configuration</a>.
    /// </summary>
    type GuarddutyOrganizationConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : GuarddutyOrganizationConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : GuarddutyOrganizationConfigurationState<Missing>)

        member _.Zero(()) : GuarddutyOrganizationConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : GuarddutyOrganizationConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#detector_id-1">GuarddutyOrganizationConfiguration#detector_id</a>.
        /// </summary>
        [<CustomOperation "detector_id">]
        member _.DetectorId(state: GuarddutyOrganizationConfigurationState<Missing>, value: string) : GuarddutyOrganizationConfigurationState<Present> =
            state.assignments.Add(fun config -> config.DetectorId <- value)
            ({ assignments = state.assignments } : GuarddutyOrganizationConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#auto_enable-1">GuarddutyOrganizationConfiguration#auto_enable</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_enable">]
        member _.AutoEnable(state: GuarddutyOrganizationConfigurationState<'DetectorId>, value: bool) : GuarddutyOrganizationConfigurationState<'DetectorId> =
            state.assignments.Add(fun config -> config.AutoEnable <- value)
            state : GuarddutyOrganizationConfigurationState<'DetectorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#auto_enable-1">GuarddutyOrganizationConfiguration#auto_enable</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_enable">]
        member _.AutoEnable(state: GuarddutyOrganizationConfigurationState<'DetectorId>, value: HashiCorp.Cdktf.IResolvable) : GuarddutyOrganizationConfigurationState<'DetectorId> =
            state.assignments.Add(fun config -> config.AutoEnable <- value)
            state : GuarddutyOrganizationConfigurationState<'DetectorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#auto_enable_organization_members-1">GuarddutyOrganizationConfiguration#auto_enable_organization_members</a>.
        /// </summary>
        [<CustomOperation "auto_enable_organization_members">]
        member _.AutoEnableOrganizationMembers(state: GuarddutyOrganizationConfigurationState<'DetectorId>, value: string) : GuarddutyOrganizationConfigurationState<'DetectorId> =
            state.assignments.Add(fun config -> config.AutoEnableOrganizationMembers <- value)
            state : GuarddutyOrganizationConfigurationState<'DetectorId>

        /// <summary>
        /// datasources block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#datasources-1">GuarddutyOrganizationConfiguration#datasources</a>
        /// </summary>
        [<CustomOperation "datasources">]
        member _.Datasources(state: GuarddutyOrganizationConfigurationState<'DetectorId>, value: aws.GuarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasources) : GuarddutyOrganizationConfigurationState<'DetectorId> =
            state.assignments.Add(fun config -> config.Datasources <- value)
            state : GuarddutyOrganizationConfigurationState<'DetectorId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#id-1">GuarddutyOrganizationConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GuarddutyOrganizationConfigurationState<'DetectorId>, value: string) : GuarddutyOrganizationConfigurationState<'DetectorId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GuarddutyOrganizationConfigurationState<'DetectorId>

        member _.Run(state: GuarddutyOrganizationConfigurationState<Present>) : aws.GuarddutyOrganizationConfiguration.GuarddutyOrganizationConfiguration =
            let config = aws.GuarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.GuarddutyOrganizationConfiguration.GuarddutyOrganizationConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.guarddutyOrganizationConfiguration: missing required arguments. Must call: detector_id.", 9999, IsError = true)>]
        member _.Run(_: GuarddutyOrganizationConfigurationState<_>) : aws.GuarddutyOrganizationConfiguration.GuarddutyOrganizationConfiguration =
            Unchecked.defaultof<aws.GuarddutyOrganizationConfiguration.GuarddutyOrganizationConfiguration>
