namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId> = { assignments: ResizeArray<aws.AppconfigDeployment.AppconfigDeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment">aws_appconfig_deployment</a>.
    /// </summary>
    type AppconfigDeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppconfigDeploymentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppconfigDeploymentState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppconfigDeploymentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppconfigDeploymentState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment#application_id-1">AppconfigDeployment#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: AppconfigDeploymentState<Missing, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId>, value: string) : AppconfigDeploymentState<Present, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : AppconfigDeploymentState<Present, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment#configuration_profile_id-1">AppconfigDeployment#configuration_profile_id</a>.
        /// </summary>
        [<CustomOperation "configuration_profile_id">]
        member _.ConfigurationProfileId(state: AppconfigDeploymentState<'ApplicationId, Missing, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId>, value: string) : AppconfigDeploymentState<'ApplicationId, Present, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId> =
            state.assignments.Add(fun config -> config.ConfigurationProfileId <- value)
            ({ assignments = state.assignments } : AppconfigDeploymentState<'ApplicationId, Present, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment#configuration_version-1">AppconfigDeployment#configuration_version</a>.
        /// </summary>
        [<CustomOperation "configuration_version">]
        member _.ConfigurationVersion(state: AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, Missing, 'DeploymentStrategyId, 'EnvironmentId>, value: string) : AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, Present, 'DeploymentStrategyId, 'EnvironmentId> =
            state.assignments.Add(fun config -> config.ConfigurationVersion <- value)
            ({ assignments = state.assignments } : AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, Present, 'DeploymentStrategyId, 'EnvironmentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment#deployment_strategy_id-1">AppconfigDeployment#deployment_strategy_id</a>.
        /// </summary>
        [<CustomOperation "deployment_strategy_id">]
        member _.DeploymentStrategyId(state: AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, Missing, 'EnvironmentId>, value: string) : AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, Present, 'EnvironmentId> =
            state.assignments.Add(fun config -> config.DeploymentStrategyId <- value)
            ({ assignments = state.assignments } : AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, Present, 'EnvironmentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment#environment_id-1">AppconfigDeployment#environment_id</a>.
        /// </summary>
        [<CustomOperation "environment_id">]
        member _.EnvironmentId(state: AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, Missing>, value: string) : AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, Present> =
            state.assignments.Add(fun config -> config.EnvironmentId <- value)
            ({ assignments = state.assignments } : AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment#description-1">AppconfigDeployment#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId>, value: string) : AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment#id-1">AppconfigDeployment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId>, value: string) : AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment#kms_key_identifier-1">AppconfigDeployment#kms_key_identifier</a>.
        /// </summary>
        [<CustomOperation "kms_key_identifier">]
        member _.KmsKeyIdentifier(state: AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId>, value: string) : AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId> =
            state.assignments.Add(fun config -> config.KmsKeyIdentifier <- value)
            state : AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment#tags-1">AppconfigDeployment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId>, value: seq<string * string>) : AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_deployment#tags_all-1">AppconfigDeployment#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId>, value: seq<string * string>) : AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppconfigDeploymentState<'ApplicationId, 'ConfigurationProfileId, 'ConfigurationVersion, 'DeploymentStrategyId, 'EnvironmentId>

        member _.Run(state: AppconfigDeploymentState<Present, Present, Present, Present, Present>) : aws.AppconfigDeployment.AppconfigDeployment =
            let config = aws.AppconfigDeployment.AppconfigDeploymentConfig()
            for setter in state.assignments do
                setter config
            aws.AppconfigDeployment.AppconfigDeployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appconfigDeployment: missing required arguments. Must call: application_id, configuration_profile_id, configuration_version, deployment_strategy_id, environment_id.", 9999, IsError = true)>]
        member _.Run(_: AppconfigDeploymentState<_, _, _, _, _>) : aws.AppconfigDeployment.AppconfigDeployment =
            Unchecked.defaultof<aws.AppconfigDeployment.AppconfigDeployment>
