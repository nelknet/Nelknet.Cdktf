namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAppconfigConfigurationProfileState<'ApplicationId, 'ConfigurationProfileId> = { assignments: ResizeArray<aws.DataAwsAppconfigConfigurationProfile.DataAwsAppconfigConfigurationProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appconfig_configuration_profile">aws_appconfig_configuration_profile</a>.
    /// </summary>
    type DataAwsAppconfigConfigurationProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAppconfigConfigurationProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppconfigConfigurationProfileState<Missing, Missing>)

        member _.Zero(()) : DataAwsAppconfigConfigurationProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppconfigConfigurationProfileState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appconfig_configuration_profile#application_id-1">DataAwsAppconfigConfigurationProfile#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: DataAwsAppconfigConfigurationProfileState<Missing, 'ConfigurationProfileId>, value: string) : DataAwsAppconfigConfigurationProfileState<Present, 'ConfigurationProfileId> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : DataAwsAppconfigConfigurationProfileState<Present, 'ConfigurationProfileId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appconfig_configuration_profile#configuration_profile_id-1">DataAwsAppconfigConfigurationProfile#configuration_profile_id</a>.
        /// </summary>
        [<CustomOperation "configuration_profile_id">]
        member _.ConfigurationProfileId(state: DataAwsAppconfigConfigurationProfileState<'ApplicationId, Missing>, value: string) : DataAwsAppconfigConfigurationProfileState<'ApplicationId, Present> =
            state.assignments.Add(fun config -> config.ConfigurationProfileId <- value)
            ({ assignments = state.assignments } : DataAwsAppconfigConfigurationProfileState<'ApplicationId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appconfig_configuration_profile#id-1">DataAwsAppconfigConfigurationProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAppconfigConfigurationProfileState<'ApplicationId, 'ConfigurationProfileId>, value: string) : DataAwsAppconfigConfigurationProfileState<'ApplicationId, 'ConfigurationProfileId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAppconfigConfigurationProfileState<'ApplicationId, 'ConfigurationProfileId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appconfig_configuration_profile#tags-1">DataAwsAppconfigConfigurationProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsAppconfigConfigurationProfileState<'ApplicationId, 'ConfigurationProfileId>, value: seq<string * string>) : DataAwsAppconfigConfigurationProfileState<'ApplicationId, 'ConfigurationProfileId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsAppconfigConfigurationProfileState<'ApplicationId, 'ConfigurationProfileId>

        member _.Run(state: DataAwsAppconfigConfigurationProfileState<Present, Present>) : aws.DataAwsAppconfigConfigurationProfile.DataAwsAppconfigConfigurationProfile =
            let config = aws.DataAwsAppconfigConfigurationProfile.DataAwsAppconfigConfigurationProfileConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAppconfigConfigurationProfile.DataAwsAppconfigConfigurationProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsAppconfigConfigurationProfile: missing required arguments. Must call: application_id, configuration_profile_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsAppconfigConfigurationProfileState<_, _>) : aws.DataAwsAppconfigConfigurationProfile.DataAwsAppconfigConfigurationProfile =
            Unchecked.defaultof<aws.DataAwsAppconfigConfigurationProfile.DataAwsAppconfigConfigurationProfile>
