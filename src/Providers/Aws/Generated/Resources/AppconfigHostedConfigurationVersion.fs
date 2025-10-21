namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppconfigHostedConfigurationVersionState<'ApplicationId, 'ConfigurationProfileId, 'Content, 'ContentType> = { assignments: ResizeArray<aws.AppconfigHostedConfigurationVersion.AppconfigHostedConfigurationVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_hosted_configuration_version">aws_appconfig_hosted_configuration_version</a>.
    /// </summary>
    type AppconfigHostedConfigurationVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppconfigHostedConfigurationVersionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppconfigHostedConfigurationVersionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppconfigHostedConfigurationVersionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppconfigHostedConfigurationVersionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_hosted_configuration_version#application_id-1">AppconfigHostedConfigurationVersion#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: AppconfigHostedConfigurationVersionState<Missing, 'ConfigurationProfileId, 'Content, 'ContentType>, value: string) : AppconfigHostedConfigurationVersionState<Present, 'ConfigurationProfileId, 'Content, 'ContentType> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : AppconfigHostedConfigurationVersionState<Present, 'ConfigurationProfileId, 'Content, 'ContentType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_hosted_configuration_version#configuration_profile_id-1">AppconfigHostedConfigurationVersion#configuration_profile_id</a>.
        /// </summary>
        [<CustomOperation "configuration_profile_id">]
        member _.ConfigurationProfileId(state: AppconfigHostedConfigurationVersionState<'ApplicationId, Missing, 'Content, 'ContentType>, value: string) : AppconfigHostedConfigurationVersionState<'ApplicationId, Present, 'Content, 'ContentType> =
            state.assignments.Add(fun config -> config.ConfigurationProfileId <- value)
            ({ assignments = state.assignments } : AppconfigHostedConfigurationVersionState<'ApplicationId, Present, 'Content, 'ContentType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_hosted_configuration_version#content-1">AppconfigHostedConfigurationVersion#content</a>.
        /// </summary>
        [<CustomOperation "content">]
        member _.Content(state: AppconfigHostedConfigurationVersionState<'ApplicationId, 'ConfigurationProfileId, Missing, 'ContentType>, value: string) : AppconfigHostedConfigurationVersionState<'ApplicationId, 'ConfigurationProfileId, Present, 'ContentType> =
            state.assignments.Add(fun config -> config.Content <- value)
            ({ assignments = state.assignments } : AppconfigHostedConfigurationVersionState<'ApplicationId, 'ConfigurationProfileId, Present, 'ContentType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_hosted_configuration_version#content_type-1">AppconfigHostedConfigurationVersion#content_type</a>.
        /// </summary>
        [<CustomOperation "content_type">]
        member _.ContentType(state: AppconfigHostedConfigurationVersionState<'ApplicationId, 'ConfigurationProfileId, 'Content, Missing>, value: string) : AppconfigHostedConfigurationVersionState<'ApplicationId, 'ConfigurationProfileId, 'Content, Present> =
            state.assignments.Add(fun config -> config.ContentType <- value)
            ({ assignments = state.assignments } : AppconfigHostedConfigurationVersionState<'ApplicationId, 'ConfigurationProfileId, 'Content, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_hosted_configuration_version#description-1">AppconfigHostedConfigurationVersion#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AppconfigHostedConfigurationVersionState<'ApplicationId, 'ConfigurationProfileId, 'Content, 'ContentType>, value: string) : AppconfigHostedConfigurationVersionState<'ApplicationId, 'ConfigurationProfileId, 'Content, 'ContentType> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AppconfigHostedConfigurationVersionState<'ApplicationId, 'ConfigurationProfileId, 'Content, 'ContentType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_hosted_configuration_version#id-1">AppconfigHostedConfigurationVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppconfigHostedConfigurationVersionState<'ApplicationId, 'ConfigurationProfileId, 'Content, 'ContentType>, value: string) : AppconfigHostedConfigurationVersionState<'ApplicationId, 'ConfigurationProfileId, 'Content, 'ContentType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppconfigHostedConfigurationVersionState<'ApplicationId, 'ConfigurationProfileId, 'Content, 'ContentType>

        member _.Run(state: AppconfigHostedConfigurationVersionState<Present, Present, Present, Present>) : aws.AppconfigHostedConfigurationVersion.AppconfigHostedConfigurationVersion =
            let config = aws.AppconfigHostedConfigurationVersion.AppconfigHostedConfigurationVersionConfig()
            for setter in state.assignments do
                setter config
            aws.AppconfigHostedConfigurationVersion.AppconfigHostedConfigurationVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appconfigHostedConfigurationVersion: missing required arguments. Must call: application_id, configuration_profile_id, content, content_type.", 9999, IsError = true)>]
        member _.Run(_: AppconfigHostedConfigurationVersionState<_, _, _, _>) : aws.AppconfigHostedConfigurationVersion.AppconfigHostedConfigurationVersion =
            Unchecked.defaultof<aws.AppconfigHostedConfigurationVersion.AppconfigHostedConfigurationVersion>
