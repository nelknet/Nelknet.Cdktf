namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAppconfigConfigurationProfilesState<'ApplicationId> = { assignments: ResizeArray<aws.DataAwsAppconfigConfigurationProfiles.DataAwsAppconfigConfigurationProfilesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appconfig_configuration_profiles">aws_appconfig_configuration_profiles</a>.
    /// </summary>
    type DataAwsAppconfigConfigurationProfilesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAppconfigConfigurationProfilesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppconfigConfigurationProfilesState<Missing>)

        member _.Zero(()) : DataAwsAppconfigConfigurationProfilesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppconfigConfigurationProfilesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appconfig_configuration_profiles#application_id-1">DataAwsAppconfigConfigurationProfiles#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: DataAwsAppconfigConfigurationProfilesState<Missing>, value: string) : DataAwsAppconfigConfigurationProfilesState<Present> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : DataAwsAppconfigConfigurationProfilesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appconfig_configuration_profiles#id-1">DataAwsAppconfigConfigurationProfiles#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAppconfigConfigurationProfilesState<'ApplicationId>, value: string) : DataAwsAppconfigConfigurationProfilesState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAppconfigConfigurationProfilesState<'ApplicationId>

        member _.Run(state: DataAwsAppconfigConfigurationProfilesState<Present>) : aws.DataAwsAppconfigConfigurationProfiles.DataAwsAppconfigConfigurationProfiles =
            let config = aws.DataAwsAppconfigConfigurationProfiles.DataAwsAppconfigConfigurationProfilesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAppconfigConfigurationProfiles.DataAwsAppconfigConfigurationProfiles(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsAppconfigConfigurationProfiles: missing required arguments. Must call: application_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsAppconfigConfigurationProfilesState<_>) : aws.DataAwsAppconfigConfigurationProfiles.DataAwsAppconfigConfigurationProfiles =
            Unchecked.defaultof<aws.DataAwsAppconfigConfigurationProfiles.DataAwsAppconfigConfigurationProfiles>
