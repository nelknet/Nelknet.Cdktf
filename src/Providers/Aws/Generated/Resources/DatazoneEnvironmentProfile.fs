namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatazoneEnvironmentProfileState<'AwsAccountRegion, 'DomainIdentifier, 'EnvironmentBlueprintIdentifier, 'Name, 'ProjectIdentifier> = { assignments: ResizeArray<aws.DatazoneEnvironmentProfile.DatazoneEnvironmentProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment_profile">aws_datazone_environment_profile</a>.
    /// </summary>
    type DatazoneEnvironmentProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatazoneEnvironmentProfileState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneEnvironmentProfileState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DatazoneEnvironmentProfileState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneEnvironmentProfileState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment_profile#aws_account_region-1">DatazoneEnvironmentProfile#aws_account_region</a>.
        /// </summary>
        [<CustomOperation "aws_account_region">]
        member _.AwsAccountRegion(state: DatazoneEnvironmentProfileState<Missing, 'DomainIdentifier, 'EnvironmentBlueprintIdentifier, 'Name, 'ProjectIdentifier>, value: string) : DatazoneEnvironmentProfileState<Present, 'DomainIdentifier, 'EnvironmentBlueprintIdentifier, 'Name, 'ProjectIdentifier> =
            state.assignments.Add(fun config -> config.AwsAccountRegion <- value)
            ({ assignments = state.assignments } : DatazoneEnvironmentProfileState<Present, 'DomainIdentifier, 'EnvironmentBlueprintIdentifier, 'Name, 'ProjectIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment_profile#domain_identifier-1">DatazoneEnvironmentProfile#domain_identifier</a>.
        /// </summary>
        [<CustomOperation "domain_identifier">]
        member _.DomainIdentifier(state: DatazoneEnvironmentProfileState<'AwsAccountRegion, Missing, 'EnvironmentBlueprintIdentifier, 'Name, 'ProjectIdentifier>, value: string) : DatazoneEnvironmentProfileState<'AwsAccountRegion, Present, 'EnvironmentBlueprintIdentifier, 'Name, 'ProjectIdentifier> =
            state.assignments.Add(fun config -> config.DomainIdentifier <- value)
            ({ assignments = state.assignments } : DatazoneEnvironmentProfileState<'AwsAccountRegion, Present, 'EnvironmentBlueprintIdentifier, 'Name, 'ProjectIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment_profile#environment_blueprint_identifier-1">DatazoneEnvironmentProfile#environment_blueprint_identifier</a>.
        /// </summary>
        [<CustomOperation "environment_blueprint_identifier">]
        member _.EnvironmentBlueprintIdentifier(state: DatazoneEnvironmentProfileState<'AwsAccountRegion, 'DomainIdentifier, Missing, 'Name, 'ProjectIdentifier>, value: string) : DatazoneEnvironmentProfileState<'AwsAccountRegion, 'DomainIdentifier, Present, 'Name, 'ProjectIdentifier> =
            state.assignments.Add(fun config -> config.EnvironmentBlueprintIdentifier <- value)
            ({ assignments = state.assignments } : DatazoneEnvironmentProfileState<'AwsAccountRegion, 'DomainIdentifier, Present, 'Name, 'ProjectIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment_profile#name-1">DatazoneEnvironmentProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DatazoneEnvironmentProfileState<'AwsAccountRegion, 'DomainIdentifier, 'EnvironmentBlueprintIdentifier, Missing, 'ProjectIdentifier>, value: string) : DatazoneEnvironmentProfileState<'AwsAccountRegion, 'DomainIdentifier, 'EnvironmentBlueprintIdentifier, Present, 'ProjectIdentifier> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DatazoneEnvironmentProfileState<'AwsAccountRegion, 'DomainIdentifier, 'EnvironmentBlueprintIdentifier, Present, 'ProjectIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment_profile#project_identifier-1">DatazoneEnvironmentProfile#project_identifier</a>.
        /// </summary>
        [<CustomOperation "project_identifier">]
        member _.ProjectIdentifier(state: DatazoneEnvironmentProfileState<'AwsAccountRegion, 'DomainIdentifier, 'EnvironmentBlueprintIdentifier, 'Name, Missing>, value: string) : DatazoneEnvironmentProfileState<'AwsAccountRegion, 'DomainIdentifier, 'EnvironmentBlueprintIdentifier, 'Name, Present> =
            state.assignments.Add(fun config -> config.ProjectIdentifier <- value)
            ({ assignments = state.assignments } : DatazoneEnvironmentProfileState<'AwsAccountRegion, 'DomainIdentifier, 'EnvironmentBlueprintIdentifier, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment_profile#aws_account_id-1">DatazoneEnvironmentProfile#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: DatazoneEnvironmentProfileState<'AwsAccountRegion, 'DomainIdentifier, 'EnvironmentBlueprintIdentifier, 'Name, 'ProjectIdentifier>, value: string) : DatazoneEnvironmentProfileState<'AwsAccountRegion, 'DomainIdentifier, 'EnvironmentBlueprintIdentifier, 'Name, 'ProjectIdentifier> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : DatazoneEnvironmentProfileState<'AwsAccountRegion, 'DomainIdentifier, 'EnvironmentBlueprintIdentifier, 'Name, 'ProjectIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment_profile#description-1">DatazoneEnvironmentProfile#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DatazoneEnvironmentProfileState<'AwsAccountRegion, 'DomainIdentifier, 'EnvironmentBlueprintIdentifier, 'Name, 'ProjectIdentifier>, value: string) : DatazoneEnvironmentProfileState<'AwsAccountRegion, 'DomainIdentifier, 'EnvironmentBlueprintIdentifier, 'Name, 'ProjectIdentifier> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DatazoneEnvironmentProfileState<'AwsAccountRegion, 'DomainIdentifier, 'EnvironmentBlueprintIdentifier, 'Name, 'ProjectIdentifier>

        /// <summary>
        /// user_parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_environment_profile#user_parameters-1">DatazoneEnvironmentProfile#user_parameters</a> Accepts: aws.IResolvable | aws.DatazoneEnvironmentProfile.DatazoneEnvironmentProfileUserParameters[]
        /// </summary>
        [<CustomOperation "user_parameters">]
        member _.UserParameters(state: DatazoneEnvironmentProfileState<'AwsAccountRegion, 'DomainIdentifier, 'EnvironmentBlueprintIdentifier, 'Name, 'ProjectIdentifier>, value: HashiCorp.Cdktf.IResolvable) : DatazoneEnvironmentProfileState<'AwsAccountRegion, 'DomainIdentifier, 'EnvironmentBlueprintIdentifier, 'Name, 'ProjectIdentifier> =
            state.assignments.Add(fun config -> config.UserParameters <- value)
            state : DatazoneEnvironmentProfileState<'AwsAccountRegion, 'DomainIdentifier, 'EnvironmentBlueprintIdentifier, 'Name, 'ProjectIdentifier>

        member _.Run(state: DatazoneEnvironmentProfileState<Present, Present, Present, Present, Present>) : aws.DatazoneEnvironmentProfile.DatazoneEnvironmentProfile =
            let config = aws.DatazoneEnvironmentProfile.DatazoneEnvironmentProfileConfig()
            for setter in state.assignments do
                setter config
            aws.DatazoneEnvironmentProfile.DatazoneEnvironmentProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datazoneEnvironmentProfile: missing required arguments. Must call: aws_account_region, domain_identifier, environment_blueprint_identifier, name, project_identifier.", 9999, IsError = true)>]
        member _.Run(_: DatazoneEnvironmentProfileState<_, _, _, _, _>) : aws.DatazoneEnvironmentProfile.DatazoneEnvironmentProfile =
            Unchecked.defaultof<aws.DatazoneEnvironmentProfile.DatazoneEnvironmentProfile>
