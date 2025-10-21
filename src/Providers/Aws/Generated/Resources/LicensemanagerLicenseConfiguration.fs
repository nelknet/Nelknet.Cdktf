namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name> = { assignments: ResizeArray<aws.LicensemanagerLicenseConfiguration.LicensemanagerLicenseConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_license_configuration">aws_licensemanager_license_configuration</a>.
    /// </summary>
    type LicensemanagerLicenseConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : LicensemanagerLicenseConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LicensemanagerLicenseConfigurationState<Missing, Missing>)

        member _.Zero(()) : LicensemanagerLicenseConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LicensemanagerLicenseConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_license_configuration#license_counting_type-1">LicensemanagerLicenseConfiguration#license_counting_type</a>.
        /// </summary>
        [<CustomOperation "license_counting_type">]
        member _.LicenseCountingType(state: LicensemanagerLicenseConfigurationState<Missing, 'Name>, value: string) : LicensemanagerLicenseConfigurationState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LicenseCountingType <- value)
            ({ assignments = state.assignments } : LicensemanagerLicenseConfigurationState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_license_configuration#name-1">LicensemanagerLicenseConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LicensemanagerLicenseConfigurationState<'LicenseCountingType, Missing>, value: string) : LicensemanagerLicenseConfigurationState<'LicenseCountingType, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LicensemanagerLicenseConfigurationState<'LicenseCountingType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_license_configuration#description-1">LicensemanagerLicenseConfiguration#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name>, value: string) : LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_license_configuration#id-1">LicensemanagerLicenseConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name>, value: string) : LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_license_configuration#license_count-1">LicensemanagerLicenseConfiguration#license_count</a>.
        /// </summary>
        [<CustomOperation "license_count">]
        member _.LicenseCount(state: LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name>, value: double) : LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name> =
            state.assignments.Add(fun config -> config.LicenseCount <- value)
            state : LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_license_configuration#license_count_hard_limit-1">LicensemanagerLicenseConfiguration#license_count_hard_limit</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "license_count_hard_limit">]
        member _.LicenseCountHardLimit(state: LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name>, value: bool) : LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name> =
            state.assignments.Add(fun config -> config.LicenseCountHardLimit <- value)
            state : LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_license_configuration#license_count_hard_limit-1">LicensemanagerLicenseConfiguration#license_count_hard_limit</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "license_count_hard_limit">]
        member _.LicenseCountHardLimit(state: LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name>, value: HashiCorp.Cdktf.IResolvable) : LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name> =
            state.assignments.Add(fun config -> config.LicenseCountHardLimit <- value)
            state : LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_license_configuration#license_rules-1">LicensemanagerLicenseConfiguration#license_rules</a>.
        /// </summary>
        [<CustomOperation "license_rules">]
        member _.LicenseRules(state: LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name>, value: seq<string>) : LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name> =
            state.assignments.Add(fun config -> config.LicenseRules <- (value |> Seq.toArray))
            state : LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_license_configuration#tags-1">LicensemanagerLicenseConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name>, value: seq<string * string>) : LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_license_configuration#tags_all-1">LicensemanagerLicenseConfiguration#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name>, value: seq<string * string>) : LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LicensemanagerLicenseConfigurationState<'LicenseCountingType, 'Name>

        member _.Run(state: LicensemanagerLicenseConfigurationState<Present, Present>) : aws.LicensemanagerLicenseConfiguration.LicensemanagerLicenseConfiguration =
            let config = aws.LicensemanagerLicenseConfiguration.LicensemanagerLicenseConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.LicensemanagerLicenseConfiguration.LicensemanagerLicenseConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.licensemanagerLicenseConfiguration: missing required arguments. Must call: license_counting_type, name.", 9999, IsError = true)>]
        member _.Run(_: LicensemanagerLicenseConfigurationState<_, _>) : aws.LicensemanagerLicenseConfiguration.LicensemanagerLicenseConfiguration =
            Unchecked.defaultof<aws.LicensemanagerLicenseConfiguration.LicensemanagerLicenseConfiguration>
