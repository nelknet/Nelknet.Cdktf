namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GuarddutyOrganizationConfigurationFeatureState<'AutoEnable, 'DetectorId, 'Name> = { assignments: ResizeArray<aws.GuarddutyOrganizationConfigurationFeature.GuarddutyOrganizationConfigurationFeatureConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration_feature">aws_guardduty_organization_configuration_feature</a>.
    /// </summary>
    type GuarddutyOrganizationConfigurationFeatureBuilder(logicalId: string) =
        member _.Yield(_: unit) : GuarddutyOrganizationConfigurationFeatureState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GuarddutyOrganizationConfigurationFeatureState<Missing, Missing, Missing>)

        member _.Zero(()) : GuarddutyOrganizationConfigurationFeatureState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GuarddutyOrganizationConfigurationFeatureState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration_feature#auto_enable-1">GuarddutyOrganizationConfigurationFeature#auto_enable</a>.
        /// </summary>
        [<CustomOperation "auto_enable">]
        member _.AutoEnable(state: GuarddutyOrganizationConfigurationFeatureState<Missing, 'DetectorId, 'Name>, value: string) : GuarddutyOrganizationConfigurationFeatureState<Present, 'DetectorId, 'Name> =
            state.assignments.Add(fun config -> config.AutoEnable <- value)
            ({ assignments = state.assignments } : GuarddutyOrganizationConfigurationFeatureState<Present, 'DetectorId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration_feature#detector_id-1">GuarddutyOrganizationConfigurationFeature#detector_id</a>.
        /// </summary>
        [<CustomOperation "detector_id">]
        member _.DetectorId(state: GuarddutyOrganizationConfigurationFeatureState<'AutoEnable, Missing, 'Name>, value: string) : GuarddutyOrganizationConfigurationFeatureState<'AutoEnable, Present, 'Name> =
            state.assignments.Add(fun config -> config.DetectorId <- value)
            ({ assignments = state.assignments } : GuarddutyOrganizationConfigurationFeatureState<'AutoEnable, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration_feature#name-1">GuarddutyOrganizationConfigurationFeature#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GuarddutyOrganizationConfigurationFeatureState<'AutoEnable, 'DetectorId, Missing>, value: string) : GuarddutyOrganizationConfigurationFeatureState<'AutoEnable, 'DetectorId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GuarddutyOrganizationConfigurationFeatureState<'AutoEnable, 'DetectorId, Present>)

        /// <summary>
        /// additional_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration_feature#additional_configuration-1">GuarddutyOrganizationConfigurationFeature#additional_configuration</a> Accepts: aws.IResolvable | aws.GuarddutyOrganizationConfigurationFeature.GuarddutyOrganizationConfigurationFeatureAdditionalConfiguration[]
        /// </summary>
        [<CustomOperation "additional_configuration">]
        member _.AdditionalConfiguration(state: GuarddutyOrganizationConfigurationFeatureState<'AutoEnable, 'DetectorId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : GuarddutyOrganizationConfigurationFeatureState<'AutoEnable, 'DetectorId, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalConfiguration <- value)
            state : GuarddutyOrganizationConfigurationFeatureState<'AutoEnable, 'DetectorId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration_feature#id-1">GuarddutyOrganizationConfigurationFeature#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GuarddutyOrganizationConfigurationFeatureState<'AutoEnable, 'DetectorId, 'Name>, value: string) : GuarddutyOrganizationConfigurationFeatureState<'AutoEnable, 'DetectorId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GuarddutyOrganizationConfigurationFeatureState<'AutoEnable, 'DetectorId, 'Name>

        member _.Run(state: GuarddutyOrganizationConfigurationFeatureState<Present, Present, Present>) : aws.GuarddutyOrganizationConfigurationFeature.GuarddutyOrganizationConfigurationFeature =
            let config = aws.GuarddutyOrganizationConfigurationFeature.GuarddutyOrganizationConfigurationFeatureConfig()
            for setter in state.assignments do
                setter config
            aws.GuarddutyOrganizationConfigurationFeature.GuarddutyOrganizationConfigurationFeature(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.guarddutyOrganizationConfigurationFeature: missing required arguments. Must call: auto_enable, detector_id, name.", 9999, IsError = true)>]
        member _.Run(_: GuarddutyOrganizationConfigurationFeatureState<_, _, _>) : aws.GuarddutyOrganizationConfigurationFeature.GuarddutyOrganizationConfigurationFeature =
            Unchecked.defaultof<aws.GuarddutyOrganizationConfigurationFeature.GuarddutyOrganizationConfigurationFeature>
