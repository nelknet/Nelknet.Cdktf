namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatazoneEnvironmentBlueprintConfigurationState<'DomainId, 'EnabledRegions, 'EnvironmentBlueprintId> = { assignments: ResizeArray<aws.DatazoneEnvironmentBlueprintConfiguration.DatazoneEnvironmentBlueprintConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment_blueprint_configuration">aws_datazone_environment_blueprint_configuration</a>.
    /// </summary>
    type DatazoneEnvironmentBlueprintConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatazoneEnvironmentBlueprintConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneEnvironmentBlueprintConfigurationState<Missing, Missing, Missing>)

        member _.Zero(()) : DatazoneEnvironmentBlueprintConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneEnvironmentBlueprintConfigurationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment_blueprint_configuration#domain_id-1">DatazoneEnvironmentBlueprintConfiguration#domain_id</a>.
        /// </summary>
        [<CustomOperation "domain_id">]
        member _.DomainId(state: DatazoneEnvironmentBlueprintConfigurationState<Missing, 'EnabledRegions, 'EnvironmentBlueprintId>, value: string) : DatazoneEnvironmentBlueprintConfigurationState<Present, 'EnabledRegions, 'EnvironmentBlueprintId> =
            state.assignments.Add(fun config -> config.DomainId <- value)
            ({ assignments = state.assignments } : DatazoneEnvironmentBlueprintConfigurationState<Present, 'EnabledRegions, 'EnvironmentBlueprintId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment_blueprint_configuration#enabled_regions-1">DatazoneEnvironmentBlueprintConfiguration#enabled_regions</a>.
        /// </summary>
        [<CustomOperation "enabled_regions">]
        member _.EnabledRegions(state: DatazoneEnvironmentBlueprintConfigurationState<'DomainId, Missing, 'EnvironmentBlueprintId>, value: seq<string>) : DatazoneEnvironmentBlueprintConfigurationState<'DomainId, Present, 'EnvironmentBlueprintId> =
            state.assignments.Add(fun config -> config.EnabledRegions <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DatazoneEnvironmentBlueprintConfigurationState<'DomainId, Present, 'EnvironmentBlueprintId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment_blueprint_configuration#environment_blueprint_id-1">DatazoneEnvironmentBlueprintConfiguration#environment_blueprint_id</a>.
        /// </summary>
        [<CustomOperation "environment_blueprint_id">]
        member _.EnvironmentBlueprintId(state: DatazoneEnvironmentBlueprintConfigurationState<'DomainId, 'EnabledRegions, Missing>, value: string) : DatazoneEnvironmentBlueprintConfigurationState<'DomainId, 'EnabledRegions, Present> =
            state.assignments.Add(fun config -> config.EnvironmentBlueprintId <- value)
            ({ assignments = state.assignments } : DatazoneEnvironmentBlueprintConfigurationState<'DomainId, 'EnabledRegions, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment_blueprint_configuration#manage_access_role_arn-1">DatazoneEnvironmentBlueprintConfiguration#manage_access_role_arn</a>.
        /// </summary>
        [<CustomOperation "manage_access_role_arn">]
        member _.ManageAccessRoleArn(state: DatazoneEnvironmentBlueprintConfigurationState<'DomainId, 'EnabledRegions, 'EnvironmentBlueprintId>, value: string) : DatazoneEnvironmentBlueprintConfigurationState<'DomainId, 'EnabledRegions, 'EnvironmentBlueprintId> =
            state.assignments.Add(fun config -> config.ManageAccessRoleArn <- value)
            state : DatazoneEnvironmentBlueprintConfigurationState<'DomainId, 'EnabledRegions, 'EnvironmentBlueprintId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment_blueprint_configuration#provisioning_role_arn-1">DatazoneEnvironmentBlueprintConfiguration#provisioning_role_arn</a>.
        /// </summary>
        [<CustomOperation "provisioning_role_arn">]
        member _.ProvisioningRoleArn(state: DatazoneEnvironmentBlueprintConfigurationState<'DomainId, 'EnabledRegions, 'EnvironmentBlueprintId>, value: string) : DatazoneEnvironmentBlueprintConfigurationState<'DomainId, 'EnabledRegions, 'EnvironmentBlueprintId> =
            state.assignments.Add(fun config -> config.ProvisioningRoleArn <- value)
            state : DatazoneEnvironmentBlueprintConfigurationState<'DomainId, 'EnabledRegions, 'EnvironmentBlueprintId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment_blueprint_configuration#regional_parameters-1">DatazoneEnvironmentBlueprintConfiguration#regional_parameters</a>. Accepts: aws.IResolvable | IDictionary<string, IDictionary<string, string>>
        /// </summary>
        [<CustomOperation "regional_parameters">]
        member _.RegionalParameters(state: DatazoneEnvironmentBlueprintConfigurationState<'DomainId, 'EnabledRegions, 'EnvironmentBlueprintId>, value: HashiCorp.Cdktf.IResolvable) : DatazoneEnvironmentBlueprintConfigurationState<'DomainId, 'EnabledRegions, 'EnvironmentBlueprintId> =
            state.assignments.Add(fun config -> config.RegionalParameters <- value)
            state : DatazoneEnvironmentBlueprintConfigurationState<'DomainId, 'EnabledRegions, 'EnvironmentBlueprintId>

        member _.Run(state: DatazoneEnvironmentBlueprintConfigurationState<Present, Present, Present>) : aws.DatazoneEnvironmentBlueprintConfiguration.DatazoneEnvironmentBlueprintConfiguration =
            let config = aws.DatazoneEnvironmentBlueprintConfiguration.DatazoneEnvironmentBlueprintConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.DatazoneEnvironmentBlueprintConfiguration.DatazoneEnvironmentBlueprintConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datazoneEnvironmentBlueprintConfiguration: missing required arguments. Must call: domain_id, enabled_regions, environment_blueprint_id.", 9999, IsError = true)>]
        member _.Run(_: DatazoneEnvironmentBlueprintConfigurationState<_, _, _>) : aws.DatazoneEnvironmentBlueprintConfiguration.DatazoneEnvironmentBlueprintConfiguration =
            Unchecked.defaultof<aws.DatazoneEnvironmentBlueprintConfiguration.DatazoneEnvironmentBlueprintConfiguration>
