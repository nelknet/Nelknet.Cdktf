namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppflowConnectorProfileState<'ConnectionMode, 'ConnectorProfileConfig, 'ConnectorType, 'Name> = { assignments: ResizeArray<aws.AppflowConnectorProfile.AppflowConnectorProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile">aws_appflow_connector_profile</a>.
    /// </summary>
    type AppflowConnectorProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppflowConnectorProfileState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppflowConnectorProfileState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppflowConnectorProfileState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppflowConnectorProfileState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#connection_mode-1">AppflowConnectorProfile#connection_mode</a>.
        /// </summary>
        [<CustomOperation "connection_mode">]
        member _.ConnectionMode(state: AppflowConnectorProfileState<Missing, 'ConnectorProfileConfig, 'ConnectorType, 'Name>, value: string) : AppflowConnectorProfileState<Present, 'ConnectorProfileConfig, 'ConnectorType, 'Name> =
            state.assignments.Add(fun config -> config.ConnectionMode <- value)
            ({ assignments = state.assignments } : AppflowConnectorProfileState<Present, 'ConnectorProfileConfig, 'ConnectorType, 'Name>)

        /// <summary>
        /// connector_profile_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#connector_profile_config-1">AppflowConnectorProfile#connector_profile_config</a>
        /// </summary>
        [<CustomOperation "connector_profile_config">]
        member _.ConnectorProfileConfig(state: AppflowConnectorProfileState<'ConnectionMode, Missing, 'ConnectorType, 'Name>, value: aws.AppflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfig) : AppflowConnectorProfileState<'ConnectionMode, Present, 'ConnectorType, 'Name> =
            state.assignments.Add(fun config -> config.ConnectorProfileConfig <- value)
            ({ assignments = state.assignments } : AppflowConnectorProfileState<'ConnectionMode, Present, 'ConnectorType, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#connector_type-1">AppflowConnectorProfile#connector_type</a>.
        /// </summary>
        [<CustomOperation "connector_type">]
        member _.ConnectorType(state: AppflowConnectorProfileState<'ConnectionMode, 'ConnectorProfileConfig, Missing, 'Name>, value: string) : AppflowConnectorProfileState<'ConnectionMode, 'ConnectorProfileConfig, Present, 'Name> =
            state.assignments.Add(fun config -> config.ConnectorType <- value)
            ({ assignments = state.assignments } : AppflowConnectorProfileState<'ConnectionMode, 'ConnectorProfileConfig, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#name-1">AppflowConnectorProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppflowConnectorProfileState<'ConnectionMode, 'ConnectorProfileConfig, 'ConnectorType, Missing>, value: string) : AppflowConnectorProfileState<'ConnectionMode, 'ConnectorProfileConfig, 'ConnectorType, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppflowConnectorProfileState<'ConnectionMode, 'ConnectorProfileConfig, 'ConnectorType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#connector_label-1">AppflowConnectorProfile#connector_label</a>.
        /// </summary>
        [<CustomOperation "connector_label">]
        member _.ConnectorLabel(state: AppflowConnectorProfileState<'ConnectionMode, 'ConnectorProfileConfig, 'ConnectorType, 'Name>, value: string) : AppflowConnectorProfileState<'ConnectionMode, 'ConnectorProfileConfig, 'ConnectorType, 'Name> =
            state.assignments.Add(fun config -> config.ConnectorLabel <- value)
            state : AppflowConnectorProfileState<'ConnectionMode, 'ConnectorProfileConfig, 'ConnectorType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#id-1">AppflowConnectorProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppflowConnectorProfileState<'ConnectionMode, 'ConnectorProfileConfig, 'ConnectorType, 'Name>, value: string) : AppflowConnectorProfileState<'ConnectionMode, 'ConnectorProfileConfig, 'ConnectorType, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppflowConnectorProfileState<'ConnectionMode, 'ConnectorProfileConfig, 'ConnectorType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#kms_arn-1">AppflowConnectorProfile#kms_arn</a>.
        /// </summary>
        [<CustomOperation "kms_arn">]
        member _.KmsArn(state: AppflowConnectorProfileState<'ConnectionMode, 'ConnectorProfileConfig, 'ConnectorType, 'Name>, value: string) : AppflowConnectorProfileState<'ConnectionMode, 'ConnectorProfileConfig, 'ConnectorType, 'Name> =
            state.assignments.Add(fun config -> config.KmsArn <- value)
            state : AppflowConnectorProfileState<'ConnectionMode, 'ConnectorProfileConfig, 'ConnectorType, 'Name>

        member _.Run(state: AppflowConnectorProfileState<Present, Present, Present, Present>) : aws.AppflowConnectorProfile.AppflowConnectorProfile =
            let config = aws.AppflowConnectorProfile.AppflowConnectorProfileConfig()
            for setter in state.assignments do
                setter config
            aws.AppflowConnectorProfile.AppflowConnectorProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appflowConnectorProfile: missing required arguments. Must call: connection_mode, connector_profile_config, connector_type, name.", 9999, IsError = true)>]
        member _.Run(_: AppflowConnectorProfileState<_, _, _, _>) : aws.AppflowConnectorProfile.AppflowConnectorProfile =
            Unchecked.defaultof<aws.AppflowConnectorProfile.AppflowConnectorProfile>
